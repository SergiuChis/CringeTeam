using CringeProject.Entities;
using CringeProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CringeProject.Entities.UserTypes;

namespace CringeProject.GUI
{
    public partial class MainMenuWindow : Form
    {
        private MainMenuService _service;
        private User _user;

        public MainMenuWindow(User user, MainMenuService service)
        {
            _service = service;
            _user = user;
            InitializeComponent();
        }

        private void BaseUserWindow_Load(object sender, EventArgs e)
        {
            var conferences = _service.GetAllConferences();
            availableConferencesList.DataSource = conferences;
        }

        private void createConference_Click(object sender, EventArgs e)
        {
            WindowCreationFactory.CreateNewConferenceWindow(_user).Show();
        }

        private async void viewSelectedConference_Click(object sender, EventArgs e) {
            var selected = (Conference)availableConferencesList.SelectedItem;
            var participation = await _service.GetParticipationForConferenceAsync(_user.UserName, selected.Id);

            switch (participation.UserType) {
                case UserType.SteeringCommittee:
                    WindowCreationFactory.CreateSteeringCommitteeWindow(participation).Show();
                    return;
                default:
                    return;
            }
        }
    }
}
