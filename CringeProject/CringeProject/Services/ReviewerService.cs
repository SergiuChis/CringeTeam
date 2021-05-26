using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CringeProject.Entities;
using CringeProject.Entities.BiddingInterests;
using CringeProject.Messages;
using CringeProject.Repository;

namespace CringeProject.Services {
    public class ReviewerService : PaperManagementService {
        public ReviewerService(RepositoryContext repository) :base(repository) { }

        public IEnumerable<Paper> GetAllPapersForReviewer(User user) {
            var paperIds = _repository.ReviewAssignments.Where(r=>r.UserName==user.UserName).Select(r => r.PaperId);
            
            return _repository.Papers.Where(p => paperIds.Contains(p.Id)).ToList();
        }

        public IEnumerable<Paper> GetAllPapersAvailableForBidding(int sectionId, User user) {
            var assignedPapers = GetAllPapersForReviewer(user).ToList();

            var conferenceId = _repository.Sections.Where(s => s.Id == sectionId)
                .Select(s => s.ConferenceId)
                .FirstOrDefault();
            var sectionIds = _repository.Sections.Where(s => s.ConferenceId == conferenceId).Select(s=>s.Id);

            var papersForConference = _repository.Papers.Where(p => sectionIds.Contains(p.SectionId)).ToList();
            return papersForConference.Except(assignedPapers);
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

        public async Task<Status> AddBidding(string userId, int paperId, string interest) {
            var bid = new Bid() {Interest = interest, PaperId = paperId, UserName = userId};

            try {
                _repository.Bids.Add(bid);
                await _repository.SaveChangesAsync();
            }
            catch (Exception e) {
                return new Status("Error adding new bidding.", false);
            }

            return new Status("Success!", true);
        }

        public IEnumerable<Bid> GetAllBids() {
            return _repository.Bids;
        }

        public async Task<Status> AcceptBidProposal(Bid bid) {
            if (BiddingInterest.IsPositive(bid.Interest))
                await AddReviewAssignment(bid.UserName, bid.PaperId);

            try {
                _repository.Bids.Remove(bid);
                await _repository.SaveChangesAsync();
            }
            catch (Exception e) {
                return new Status("Failed to accept bidding proposal.", false);
            }

            return new Status("Success!", true);
        }
    }
}
