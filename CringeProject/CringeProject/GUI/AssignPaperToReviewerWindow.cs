using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CringeProject.Entities;
using CringeProject.Services;

namespace CringeProject.GUI {
    public partial class AssignPaperToReviewerWindow : Form {

        private readonly ReviewerService _service;
        private readonly Participation _participation;

        public AssignPaperToReviewerWindow(Participation participation, ReviewerService service) {
            _service = service;
            _participation = participation;
            InitializeComponent();
        }

        private void AssignPaperToReviewerWindow_Load(object sender, EventArgs e) {
            reviewersListBox.DataSource = _service.GetAllReviewers(_participation.SectionId).ToList();
            papersListBox.DataSource = _service.GetAllPapers(_participation.SectionId).ToList();
            bidsListBox.DataSource = _service.GetAllBids().ToList();
        }

        private void assignPaperButton_Click(object sender, EventArgs e) {
            var selectedPaper = (Paper) papersListBox.SelectedItem;
            var selectedReviewer = (User)reviewersListBox.SelectedItem;
            _service.AddReviewAssignment(selectedReviewer.UserName, selectedPaper.Id);
        }

        private async void acceptBidProposalButton_Click(object sender, EventArgs e) {
            var selectedBid = (Bid) bidsListBox.SelectedItem;
            await _service.AcceptBidProposal(selectedBid);
        }
    }
}
