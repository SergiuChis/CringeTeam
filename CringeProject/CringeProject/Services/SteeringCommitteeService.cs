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
    }
}
