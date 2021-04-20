using CringeProject.Entities;
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
        public User User { get; private set; }

        public ListenerWindow(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void available_conference_selection(object sender, EventArgs e)
        {

        }

        private void ListenerWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
