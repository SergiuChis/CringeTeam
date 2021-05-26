using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CringeProject.Entities;
using CringeProject.Entities.UserTypes;
using CringeProject.Repository;

namespace CringeProject.Services {
    public class PaperManagementService : BaseUserService {
        public PaperManagementService(RepositoryContext repository) : base(repository) { }

        public IEnumerable<User> GetAllReviewers(int sectionId) {
            var userIds = _repository.Participations
                .Where(p => p.SectionId == sectionId && p.UserType == UserType.Reviewer)
                .Select(p => p.UserName);

            return _repository.Users.Where(u => userIds.Contains(u.UserName));
        }

        public IEnumerable<Paper> GetAllPapers(int sectionId) {
            return _repository.Papers.Where(p => p.SectionId == sectionId);
        }
    }
}
