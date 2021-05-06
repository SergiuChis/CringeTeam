using CringeProject.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using CringeProject.GUI;
using CringeProject.Services.Login;
using CringeProject.Services;

namespace CringeProject
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            var mainForm = WindowCreationFactory.CreateLoginWindow();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(ServiceCollection services) {
            services
                .AddScoped<LoginWindow>()
                .AddScoped<LoginService>()
                .AddScoped<RepositoryContext>()
                .AddScoped<BaseUserService>();

            ServiceProvider = services.BuildServiceProvider();
            //Structure: 
            /*services.AddLogging(configure => configure.AddConsole())
                    .AddScoped<IBusinessLayer, CBusinessLayer>()
                    .AddScoped<IBusinessLayer, CBusinessLayer>()
                    .AddSingleton<IDataAccessLayer, CDataAccessLayer>();*/
        }
    }
}
