using CringeProject.Entities;
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

        public static SteeringCommitteeWindow CreateSteeringCommitteeWindow(Participation participation)
        {
            var steeringCommitteeService = (SteeringCommitteeService)Program.ServiceProvider.GetService(typeof(SteeringCommitteeService));
            return new SteeringCommitteeWindow(participation, steeringCommitteeService);
        }
        
        public static MainMenuWindow CreateNewBaseUserWindow(User user)
        {
            var baseUserService = (MainMenuService)Program.ServiceProvider.GetService(typeof(MainMenuService));
            return new MainMenuWindow(user, baseUserService);
        }

        public static CreateConferenceWindow CreateNewConferenceWindow(User user)
        {
            var mainMenuService = (MainMenuService)Program.ServiceProvider.GetService(typeof(MainMenuService));
            return new CreateConferenceWindow(user, mainMenuService);
        }

        public static ListenerWindow CreateNewListenerWindow(Participation participation)
        {
            var listenerService = (ListenerService)Program.ServiceProvider.GetService(typeof(ListenerService));
            return new ListenerWindow(participation, listenerService);
        }
    }
}
