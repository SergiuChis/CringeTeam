using System;
using System.Windows.Forms;
using CringeProject.Entities;
using CringeProject.Services;

namespace CringeProject.GUI {
    public partial class SteeringCommitteeWindow : Form {
        private readonly Participation _participation;
        private readonly SteeringCommitteeService _steeringCommitteeService;

        public SteeringCommitteeWindow(Participation participation, SteeringCommitteeService steeringCommitteeService) {
            _participation = participation;
            _steeringCommitteeService = steeringCommitteeService;
            InitializeComponent();
        }

        private void SteeringCommitteeWindow_Load(object sender, EventArgs e) {
            confirmAddSectionButton.Hide();
            availablePlacesLabel.Hide();
            roomLabel.Hide();
            availablePlacesTextBox.Hide();
            roomTextBox.Hide();
        }

        private void updateUserRoleButton_Click(object sender, EventArgs e) {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
