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

        public async Task<Participation> GetParticipationForConferenceAsync(string username, int conferenceId) {
            var sectionsFilteredByConferenceId = _repository.Sections.Where(s => s.ConferenceId == conferenceId).Select(s => s.Id);
            return _repository.Participations.FirstOrDefault(p => p.UserName == username && sectionsFilteredByConferenceId.Contains(p.SectionId));
        }

        public async Task<Participation> GetParticipationForSectionAsync(string username, int sectionId) {
            return await _repository.Participations.FirstOrDefaultAsync(s => s.SectionId == sectionId && s.UserName == username);
        }
    }
}
