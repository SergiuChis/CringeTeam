using CringeProject.GUI;
using CringeProject.Services;
using CringeProject.Services.Login;

namespace CringeProject {
    public static class WindowCreationFactory
    {
        public static LoginWindow CreateLoginWindow()
        {
            var loginService = (LoginService)Program.ServiceProvider.GetService(typeof(LoginService));
            return new LoginWindow(loginService);
        }

        public static CreateUserWindow CreateNewUserAccountWindow()
        {
            var loginService = (LoginService)Program.ServiceProvider.GetService(typeof(LoginService));
            return new CreateUserWindow(loginService);
        }

        public static SteeringCommitteeWindow CreateSteeringCommitteeWindow()
        {
            var steeringCommitteeService = (SteeringCommitteeService)Program.ServiceProvider.GetService(typeof(SteeringCommitteeService));
            return new SteeringCommitteeWindow(steeringCommitteeService);
        }
    }
}
