using System;
using System.Windows.Forms;
using CringeProject.Entities;
using CringeProject.Services;

namespace CringeProject.GUI {
    public partial class SteeringCommitteeWindow : Form {
        //TODO: for steering committee window, create a "Create sections for this conference" button.
        private readonly Participation _participation;
        private readonly SteeringCommitteeService _steeringCommitteeService;

        public SteeringCommitteeWindow(Participation participation, SteeringCommitteeService steeringCommitteeService) {
            _participation = participation;
            _steeringCommitteeService = steeringCommitteeService;
            InitializeComponent();
        }

        private void updateUserRoleButton_Click(object sender, EventArgs e) {

        }

        private void updateConferenceButton_Click(object sender, EventArgs e) {

        }
    }
}
