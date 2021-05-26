using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CringeProject.Entities;
using CringeProject.Messages;
using CringeProject.Repository;

namespace CringeProject.Services {
    public class ReviewerService : PaperManagementService {
        public ReviewerService(RepositoryContext repository) :base(repository) { }

        public IEnumerable<Paper> GetAllPapersForReviewer(User user) {
            var paperIds = _repository.ReviewAssignments.Where(r=>r.UserName==user.UserName).Select(r => r.PaperId);
            
            return _repository.Papers.Where(p => paperIds.Contains(p.Id)).ToList();
        }

        public async Task<Status> AddReview(string userId, int paperId, string grade) {
            if (string.IsNullOrEmpty(grade))
                return new Status("Invalid review.", false);

            var review = new Review {Grade = grade, PaperId = paperId, UserName = userId};

            try {
                _repository.Reviews.Add(review);
                await _repository.SaveChangesAsync();
            }
            catch (Exception e) {
                return new Status("Error adding new review.", false);
            }

            return new Status("Success!", true);
        }

        public async Task<Status> AddReviewAssignment(string reviewerUsername, int paperId) {
            var reviewAssignment = new ReviewAssignment() {PaperId = paperId, UserName = reviewerUsername};

            try {
                _repository.ReviewAssignments.Add(reviewAssignment);
                await _repository.SaveChangesAsync();
            }
            catch (Exception e) {
                return new Status("Error adding new review assignment.", false);
            }

            return new Status("Success!", true);
        }
    }
}
