using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CringeProject.Services;

namespace CringeProject.GUI {
    public partial class CreateUserWindow : Form
    {
        private readonly LoginService _loginService;

        public CreateUserWindow(LoginService loginService)
        {
            _loginService = loginService;

            InitializeComponent();
        }
    }
}
