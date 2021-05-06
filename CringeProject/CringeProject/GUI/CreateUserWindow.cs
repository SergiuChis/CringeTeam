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

        private void createUserButton_Click(object sender, System.EventArgs e) {

        }
    }
}
