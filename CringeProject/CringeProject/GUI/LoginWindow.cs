using System;
using System.Windows.Forms;
using CringeProject.Services.Login;

namespace CringeProject.GUI {
    public partial class LoginWindow : Form {
        private readonly LoginService _loginService;

        public LoginWindow(LoginService loginService) {
            _loginService = loginService;

            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var user = _loginService.Authenticate(usernameTextbox.Text, passwordTextbox.Text);
            WindowCreationFactory.CreateNewBaseUserWindow(user).Show();
        }

        private async void loginButton_Click_1(object sender, EventArgs e) {
            var user = await _loginService.Authenticate(usernameTextbox.Text, passwordTextbox.Text);
            WindowCreationFactory.CreateSteeringCommitteeWindow().Show();
            //WindowCreationFactory.CreateMainMenuWindow(user);
        }
    }
}
