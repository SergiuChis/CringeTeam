using CringeProject.Entities;
using CringeProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CringeProject.Entities.UserTypes;

namespace CringeProject.GUI
{
    public partial class MainMenuWindow : Form
    {
        private readonly MainMenuService _service;
        private readonly User _user;

        public MainMenuWindow(User user, MainMenuService service)
        {
            _service = service;
            _user = user;
            InitializeComponent();
        }

        public void RefreshLists()
        {
            conferencesWithParticipationsList.DataSource = null;
            var conferences = _service.GetConferencesForUser(_user);
            conferencesWithParticipationsList.DataSource = conferences;

            conferencesWithParticipationsList.Refresh();

            availableConferencesList.DataSource = null;
            var all_sections = _service.GetAllSections().Where(s => s.Room != "AdminRoom").ToList();
            availableConferencesList.DataSource = all_sections;

            availableConferencesList.Refresh();
        }

        private void BaseUserWindow_Load(object sender, EventArgs e)
        {
            var sections = _service.GetAllSections().Where(s => s.Room != "AdminRoom").ToList();
            var conferences = _service.GetConferencesForUser(_user);
            availableConferencesList.DataSource = sections;
            conferencesWithParticipationsList.DataSource = conferences;
        }

        private void createConference_Click(object sender, EventArgs e)
        {
            WindowCreationFactory.CreateNewConferenceWindow(_user, this).Show();
            conferencesWithParticipationsList.Refresh();
        }

        private async void viewSelectedConference_Click(object sender, EventArgs e) {
            var selected = (Conference)conferencesWithParticipationsList.SelectedItem;
            var participation = await _service.GetParticipationForConferenceAsync(_user.UserName, selected.Id);

            switch (participation.UserType) {
                case UserType.SteeringCommittee:
                    WindowCreationFactory.CreateSteeringCommitteeWindow(participation, selected).Show();
                    return;
                case UserType.Listener:
                    WindowCreationFactory.CreateNewListenerWindow(_user, participation).Show();
                    return;
                case UserType.Reviewer:
                    WindowCreationFactory.CreateReviewerWindow(_user, participation).Show();
                    return;
                default:
                    return;
            }
        }

        private async void participateInConferenceButton_Click(object sender, EventArgs e) {
            var selected = (Section) availableConferencesList.SelectedItem;

            var status = await _service.AddParticipationAsync(_user, selected);

            conferencesWithParticipationsList.DataSource = null;
            var conferences = _service.GetConferencesForUser(_user);
            conferencesWithParticipationsList.DataSource = conferences;

            conferencesWithParticipationsList.Refresh();

            errorsLabel.Text = status.Message;
        }

        private void updateSelectedConference_Click(object sender, EventArgs e)
        {
            var selected = (Conference)conferencesWithParticipationsList.SelectedItem;
            WindowCreationFactory.CreateUpdateConferenceDetailsWindow(selected.Id, _user, this).Show();
        }
    }
}
