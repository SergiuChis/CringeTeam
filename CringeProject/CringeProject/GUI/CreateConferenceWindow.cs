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

namespace CringeProject.GUI
{
    public partial class CreateConferenceWindow : Form
    {
        private MainMenuService _service;
        private User _user;

        public CreateConferenceWindow(User user, MainMenuService service)
        {
            _service = service;
            _user = user;
            InitializeComponent();
        }

        private async void addConference_Click(object sender, EventArgs e)
        {
            string conferenceName = conferenceNameBox.Text;
            DateTime startDate = startDateBox.Value;
            DateTime endDate = endDateBox.Value;
            DateTime deadlineForAbstracts = deadlineForAbstractsBox.Value;
            DateTime deadlineForPapers = deadlineForPapersBox.Value;
            // int numberOfSections = int.Parse(numberOfSectionsBox.Text);

            await _service.AddConference(_user, conferenceName, startDate, endDate, deadlineForAbstracts, deadlineForPapers);
        }

        private void CreateConferenceWindow_Load(object sender, EventArgs e)
        {
            
        }
    }
}
