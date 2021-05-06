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
    public partial class SteeringCommitteeWindow : Form {
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
