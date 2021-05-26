using System;
using System.Linq;
using System.Windows.Forms;
using CringeProject.Entities;
using CringeProject.Entities.BiddingInterests;
using CringeProject.Entities.Grades;
using CringeProject.Services;

namespace CringeProject.GUI {
    public partial class ReviewerWindow : Form {
        private readonly User _user;
        private readonly Participation _participation;
        private readonly ReviewerService _service;

        public ReviewerWindow(User user, Participation participation, ReviewerService service) {
            _user = user;
            _participation = participation;
            _service = service;
            InitializeComponent();
        }

        private void ReviewerWindow_Load(object sender, EventArgs e) {
            papersListBox.DataSource = _service.GetAllPapersForReviewer(_user).ToList();
            biddingPapersListBox.DataSource = _service.GetAllPapersAvailableForBidding(_participation.SectionId, _user).ToList();
        }

        private void strongAcceptButton_Click(object sender, EventArgs e) {
            AddReview(Grades.StrongAccept);
        }

        private void acceptButton_Click(object sender, EventArgs e) {
            AddReview(Grades.Accept);
        }

        private void weakAcceptButton_Click(object sender, EventArgs e) {
            AddReview(Grades.WeakAccept);
        }

        private void borderlinePaperButton_Click(object sender, EventArgs e) {
            AddReview(Grades.Neutral);
        }

        private void weakRejectButton_Click(object sender, EventArgs e) {
            AddReview(Grades.WeakDecline);
        }

        private void rejectButton_Click(object sender, EventArgs e) {
            AddReview(Grades.Decline);
        }

        private void strongRejectButton_Click(object sender, EventArgs e) {
            AddReview(Grades.StrongDecline);
        }

        private async void AddReview(string grade) {
            var selectedPaper = (Paper) papersListBox.SelectedItem;
            await _service.AddReview(_participation.UserName, selectedPaper.Id, grade, recommendationTextBox.Text);
        }

        private void bidStrongInterestButton_Click(object sender, EventArgs e) {
            AddBidding(BiddingInterest.StrongAccept);
        }

        private void bidInterestButton_Click(object sender, EventArgs e) {
            AddBidding(BiddingInterest.Accept);
        }

        private void bidStrongRejectionButton_Click(object sender, EventArgs e) {
            AddBidding(BiddingInterest.StrongDecline);
        }

        private void bidRejectionButton_Click(object sender, EventArgs e) {
            AddBidding(BiddingInterest.Decline);
        }

        private async void AddBidding(string interest) {
            var selectedPaper = (Paper)biddingPapersListBox.SelectedItem;
            await _service.AddBidding(_participation.UserName, selectedPaper.Id, interest);
        }
    }
}
