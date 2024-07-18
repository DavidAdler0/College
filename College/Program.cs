using College.Forms;
using Microsoft.Extensions.Configuration;

namespace College
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string conn = "Data Source = DAVID-ADLER; User ID = sa;initial catalog=College;Password = 1234; Connect Timeout = 30; Encrypt = False";
            DBcontext dbContext = new DBcontext(conn);
            FormHandler handler = new FormHandler(dbContext);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(dbContext, handler));
        }
    }
}