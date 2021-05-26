using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CringeProject.Entities;
using CringeProject.Entities.UserTypes;
using CringeProject.Services;

namespace CringeProject.GUI {
    public partial class SteeringCommitteeWindow : Form {
        private readonly Conference _conference;
        private readonly Participation _participation;
        private readonly SteeringCommitteeService _steeringCommitteeService;

        public SteeringCommitteeWindow(Participation participation, Conference conference, SteeringCommitteeService steeringCommitteeService) {
            _participation = participation;
            _conference = conference;
            _steeringCommitteeService = steeringCommitteeService;
            InitializeComponent();
        }

        private void SteeringCommitteeWindow_Load(object sender, EventArgs e) {
            confirmAddSectionButton.Hide();
            availablePlacesLabel.Hide();
            roomLabel.Hide();
            availablePlacesTextBox.Hide();
            roomTextBox.Hide();

            confirmChangeRoleButton.Hide();
            newRoleLabel.Hide();
            newRoleComboBox.Hide();

            newRoleComboBox.DataSource = new List<string>(new []{UserType.Listener, UserType.Reviewer, UserType.SessionChair});

            usersListbox.DataSource = _steeringCommitteeService.GetUsersForConference(_conference.Id).ToList();
        }

        private void updateUserRoleButton_Click(object sender, EventArgs e) {
            updateUserRoleButton.Hide();
            confirmChangeRoleButton.Show();
            newRoleComboBox.Show();
            newRoleLabel.Show();
        }

        private async void confirmChangeRoleButton_Click(object sender, EventArgs e) {
            updateUserRoleButton.Show();
            confirmChangeRoleButton.Hide();
            newRoleComboBox.Hide();
            newRoleLabel.Hide();

            var newRole = (string)newRoleComboBox.SelectedItem;

            await _steeringCommitteeService.UpdateUserRole(_participation.SectionId, _conference, (User)usersListbox.SelectedItem, newRole); // TODO
        }

        private void updateConferenceButton_Click(object sender, EventArgs e) {

        }

        private void addSectionButton_Click(object sender, EventArgs e) {
            confirmAddSectionButton.Show();
            addSectionButton.Hide();

            availablePlacesLabel.Show();
            roomLabel.Show();
            availablePlacesTextBox.Show();
            roomTextBox.Show();
        }

        private void confirmAddSectionButton_Click(object sender, EventArgs e) {
            _steeringCommitteeService.AddSection(this._participation, roomTextBox.Text,Int32.Parse(availablePlacesTextBox.Text));

            confirmAddSectionButton.Hide();
            addSectionButton.Show();

            availablePlacesLabel.Hide();
            roomLabel.Hide();
            availablePlacesTextBox.Text = "";
            availablePlacesTextBox.Hide();
            roomTextBox.Text = "";
            roomTextBox.Hide();
        }

        private void assignPaperToReviewerButton_Click(object sender, EventArgs e) {
            WindowCreationFactory.CreatePaperAssignationWindow(_participation).Show();
        }
    }
}
