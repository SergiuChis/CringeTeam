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
    public partial class MainMenuWindow : Form
    {
        private BaseUserService _service;
        private User _user;

        public MainMenuWindow(User user, BaseUserService service)
        {
            _service = service;
            _user = user;
            InitializeComponent();
        }

        private void BaseUserWindow_Load(object sender, EventArgs e)
        {
            var conferences = _service.GetAllConferences();

        }
    }
}
