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
        private ListenerService _service;
        private Participation _participation;

        public ListenerWindow(Participation participation, ListenerService listenerService)
        {
            _participation = participation;
            _service = listenerService;
            InitializeComponent();
        }

        private void ListenerWindow_Load(object sender, EventArgs e)
        {
            roomNameLabel.Text = _service.GetRoomName(_participation);
            availablePlacesNumberLabel.Text = _service.GetAvailablePlaces(_participation).ToString();
        }
    }
}
