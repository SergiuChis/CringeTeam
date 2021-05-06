using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
