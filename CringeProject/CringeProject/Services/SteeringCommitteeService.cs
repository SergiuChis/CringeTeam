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
        private readonly RepositoryContext _repository;
        public SteeringCommitteeService(RepositoryContext repository) {
            _repository = repository;
        }

        public async Task<Status> UpdateUserRole(Participation participation, string newRole) {
            var existingUser = _repository.Users.FirstOrDefault(u => u.UserName == participation.UserName);
            if (existingUser == null)
                return new Status("Invalid user.", false);

            participation.UserType = newRole;

            try {
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
    }
}
