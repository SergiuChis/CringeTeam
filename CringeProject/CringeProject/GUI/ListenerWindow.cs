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
    public partial class ListenerWindow : Form
    {
        private User _user;
        private ListenerService _service;
        private Participation _participation;

        public ListenerWindow(User user, Participation participation, ListenerService listenerService)
        {
            _user = user;
            _participation = participation;
            _service = listenerService;
            InitializeComponent();
        }

        private async void ListenerWindow_Load(object sender, EventArgs e)
        {
            roomNameLabel.Text = _service.GetRoomName(_participation);
            availablePlacesNumberLabel.Text = _service.GetAvailablePlaces(_participation).ToString();

            var papers = await _service.GetPapersForUser(_user);
            myPapersListBox.DataSource = papers.ToList();
        }

        private void addPaperButton_Click(object sender, EventArgs e) {
            var selectedPaper = (Paper) myPapersListBox.SelectedItem;
            WindowCreationFactory.CreateAddPaperWindow(selectedPaper).Show();
        }

        private void submitAbstractButton_Click(object sender, EventArgs e) {
            WindowCreationFactory.CreateSubmitAbstractWindow(_user, _participation).Show();
        }
    }
}
