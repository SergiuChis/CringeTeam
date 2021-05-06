using System;
using System.Windows.Forms;
using CringeProject.Services.Login;

namespace CringeProject.GUI {
    public partial class LoginWindow : Form
    {
        private readonly LoginService _loginService;

        public LoginWindow(LoginService loginService)
        {
            _loginService = loginService;

            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var user = _loginService.Authenticate(usernameTextbox.Text, passwordTextbox.Text);
            WindowCreationFactory.CreateNewBaseUserWindow(user).Show();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            WindowCreationFactory.CreateNewUserAccountWindow().Show();
        }
    }
}
