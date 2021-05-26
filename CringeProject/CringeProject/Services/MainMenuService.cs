using CringeProject.Entities;
using CringeProject.Entities.UserTypes;
using CringeProject.Messages;
using CringeProject.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Services {
    public class MainMenuService {
        private readonly RepositoryContext _repository;

        public MainMenuService(RepositoryContext repositoryContext)
        {
            _repository = repositoryContext;
        }

        public List<Conference> GetAllConferences()
        {
            return _repository.Conferences.ToList();
        }

        public List<Conference> GetConferencesForUser(User user) {
            var sectionIds = _repository.Participations.Where(p => p.UserName == user.UserName)
                .Select(p => p.SectionId);
            var conferenceIds = _repository.Sections.Where(sec => sectionIds.Contains(sec.Id)).Select(sec => sec.ConferenceId);
            return _repository.Conferences.Where(c => conferenceIds.Contains(c.Id)).ToList();
        }

        public List<Section> GetAllSections() {
            return _repository.Sections.ToList();
        }

        public async Task<Status> AddConferenceAsync(User creatingUser, string conferenceName, DateTime startDate, DateTime endDate, DateTime deadlineForAbstracts, DateTime deadlineForPapers)
        {
            Conference newConference = new Conference { Name = conferenceName, StartDate = startDate, EndDate = endDate, AbstractDeadline = deadlineForAbstracts, PaperDeadline = deadlineForPapers };
            var addedConference = _repository.Conferences.Add(newConference);
            var newSection = new Section { ConferenceId = addedConference.Id, Room = "AdminRoom", AvailablePlaces = 1 };
            var addedSection = _repository.Sections.Add(newSection);

            _repository.Participations.Add(new Participation { SectionId = addedSection.Id, UserName = creatingUser.UserName, UserType = UserType.SteeringCommittee });
           
            try
            {
                await _repository.SaveChangesAsync();
                return new Status("Success", true);
            }
            catch (Exception e)
            {
                return new Status("Failed to add conference", false);
            }
        }

        public async Task<Status> UpdateConferenceAsync(int conferenceID, string conferenceName, DateTime startDate, DateTime endDate, DateTime deadlineForAbstracts, DateTime deadlineForPapers)
        {
            var conference = _repository.Conferences.SingleOrDefault(conf => conf.Id == conferenceID);
            conference.Name = conferenceName;
            conference.StartDate = startDate;
            conference.EndDate = endDate;
            conference.AbstractDeadline = deadlineForAbstracts;
            conference.PaperDeadline = deadlineForPapers;

            try
            {
                await _repository.SaveChangesAsync();
                return new Status("Success", true);
            }
            catch (Exception e)
            {
                return new Status("Failed to update conference", false);
            }
        }

        public async Task<Status> AddParticipationAsync(User user, Section section) {
            var participation = new Participation {
                UserName = user.UserName, 
                UserType = UserType.Listener, 
                SectionId = section.Id
            };

            var searchForDuplicateParticipation = _repository.Participations
                .Where(p => p.UserName == participation.UserName && p.SectionId == section.Id)
                .ToList();
            if (searchForDuplicateParticipation.Count != 0)
            {
                return new Status("Participation already exists", false);
            }

            _repository.Participations.Add(participation);

            try {
                await _repository.SaveChangesAsync();
                return new Status("Success", true);
            }
            catch (Exception e) {
                return new Status("Failed to add participation", false);
            }
        }

        public async Task<Participation> GetParticipationForConferenceAsync(string username, int conferenceId) {
            var sectionsFilteredByConferenceId = _repository.Sections.Where(s => s.ConferenceId == conferenceId).Select(s => s.Id);
            return await _repository.Participations.FirstOrDefaultAsync(p => p.UserName == username && sectionsFilteredByConferenceId.Contains(p.SectionId));
        }
    }
}
