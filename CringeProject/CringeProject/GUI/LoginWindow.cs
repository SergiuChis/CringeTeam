using System;
using System.Windows.Forms;
using CringeProject.Services;

namespace CringeProject.GUI {
    public partial class LoginWindow : Form
    {
        private readonly LoginService _loginService;

        public LoginWindow(LoginService loginService)
        {
            _loginService = loginService;

            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e) {

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            _loginService.Authenticate("a", "b");
            WindowCreationFactory.CreateNewUserAccountWindow().Show();
        }
    }
}
