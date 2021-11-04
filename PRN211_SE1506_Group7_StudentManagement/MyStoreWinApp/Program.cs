using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    static class Program
    {
        public static IConfiguration Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<UserObject>();
            string email = adminDefaultSettings.UserEmail;
            string password = adminDefaultSettings.UserPassword;
            UserRepository userRepository = new UserRepository();
            UserObject user = new UserObject
            {
                UserEmail = email,
                UserPassword = password
            };
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMark());
        }
    }
}
