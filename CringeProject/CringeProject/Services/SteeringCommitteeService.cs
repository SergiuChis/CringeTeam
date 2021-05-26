using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CringeProject.Entities;
using CringeProject.Messages;
using CringeProject.Repository;

namespace CringeProject.Services {
    public class SteeringCommitteeService : BaseUserService {
        public SteeringCommitteeService(RepositoryContext repository) : base(repository) { }

        public async Task<Status> UpdateUserRole(int sectionId, Conference conference, User user, string newRole) {
            try {
                var sections = _repository.Sections.Where(s => s.ConferenceId == conference.Id).Select(s=>s.Id);
                var oldParticipations =
                    _repository.Participations.Where(p => sections.Contains(p.SectionId) && p.UserName == user.UserName);
                _repository.Participations.RemoveRange(oldParticipations);

                var newParticipation = new Participation()
                    {SectionId = sectionId, UserName = user.UserName, UserType = newRole};
                _repository.Participations.Add(newParticipation);
                await _repository.SaveChangesAsync();
            }
            catch (Exception) {
                return new Status("Failed to update user role.", false);
            }

            return new Status("Success!", true);
        }

        public async Task<Status> AddSection(Participation participation, string room, int availablePlaces) {
            if (string.IsNullOrWhiteSpace(room) || availablePlaces < 1) {
                return new Status("Error validating section parameters.", false);
            }

            var newSection = new Section {
                AvailablePlaces = availablePlaces, ConferenceId = GetConferenceForSection(participation.SectionId).Id,
                Room = room
            };

            _repository.Sections.Add(newSection);

            try {
                await _repository.SaveChangesAsync();
            }
            catch (Exception) {
                return new Status("Failed to update user role.", false);
            }

            return new Status("Success!", true);
        }

        public Conference GetConferenceForSection(int sectionId) {
            var conferenceId = _repository.Sections.Where(s => s.Id == sectionId).Select(s => s.ConferenceId).FirstOrDefault();
            return _repository.Conferences.FirstOrDefault(c => c.Id == conferenceId);
        }

        public IEnumerable<User> GetUsersForConference(int conferenceId) {
            var conference = _repository.Conferences.FirstOrDefault(c => c.Id == conferenceId);
            var sections = _repository.Sections.Where(s=>s.ConferenceId == conference.Id).Select(s=>s.Id);
            var usernamesForSections = _repository.Participations
                .Where(p => sections.Contains(p.SectionId))
                .Select(p => p.UserName);
            return _repository.Users.Where(u => usernamesForSections.Contains(u.UserName));
        }
    }
}
