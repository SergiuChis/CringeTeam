using System.Threading.Tasks;
using System.Windows.Forms;
using CringeProject.Services.Login;

namespace CringeProject.GUI {
    public partial class CreateUserWindow : Form
    {
        private readonly LoginService _loginService;

        public CreateUserWindow(LoginService loginService)
        {
            _loginService = loginService;

            InitializeComponent();
        }

        private async void createUserButton_Click(object sender, System.EventArgs e) {
            creationStatusLabel.Text = "Creating User";
            var status = await _loginService.CreateUser(usernameTextbox.Text, passwordTexbox.Text, confirmedPasswordTextbox.Text, fullNameTextBox.Text, birthdayPicker.Value);
            creationStatusLabel.Text = status.Message;
        }
    }
}
