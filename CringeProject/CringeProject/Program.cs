using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            services.AddScoped<LoginWindow>();

            //Structure: 
            /*services.AddLogging(configure => configure.AddConsole())
                    .AddScoped<IBusinessLayer, CBusinessLayer>()
                    .AddScoped<IBusinessLayer, CBusinessLayer>()
                    .AddSingleton<IDataAccessLayer, CDataAccessLayer>();*/
        }
    }
}
