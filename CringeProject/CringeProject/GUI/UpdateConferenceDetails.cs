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
    public partial class UpdateConferenceDetails : Form
    {
        private int _conferenceID;
        private MainMenuService _service;
        private User _user;
        private MainMenuWindow _parent;

        public UpdateConferenceDetails(int conferenceID, User user, MainMenuService service, MainMenuWindow parent)
        {
            _service = service;
            _user = user;
            _parent = parent;
            _conferenceID = conferenceID;
            InitializeComponent();
        }

        private async void updateConference_Click(object sender, EventArgs e)
        {
            string conferenceName = conferenceNameBox.Text;
            DateTime startDate = startDateBox.Value;
            DateTime endDate = endDateBox.Value;
            DateTime deadlineForAbstracts = deadlineForAbstractsBox.Value;
            DateTime deadlineForPapers = deadlineForPapersBox.Value;

            await _service.UpdateConferenceAsync(_conferenceID, conferenceName, startDate, endDate, deadlineForAbstracts, deadlineForPapers);

            _parent.RefreshLists();
        }
    }
}
