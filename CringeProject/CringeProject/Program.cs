using CringeProject.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CringeProject
{
    static class Program
    {
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
            using (var serviceProvider = services.BuildServiceProvider()) {
                var mainForm = serviceProvider.GetRequiredService<LoginWindow>();
                Application.Run(mainForm);
            }

        }

        private static void ConfigureServices(ServiceCollection services) {
            services
                .AddScoped<LoginWindow>()
                .AddScoped<RepositoryContext>();

            //Structure: 
            /*services.AddLogging(configure => configure.AddConsole())
                    .AddScoped<IBusinessLayer, CBusinessLayer>()
                    .AddScoped<IBusinessLayer, CBusinessLayer>()
                    .AddSingleton<IDataAccessLayer, CDataAccessLayer>();*/
        }
    }
}
