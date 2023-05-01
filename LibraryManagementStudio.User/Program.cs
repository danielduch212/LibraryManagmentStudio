using LibraryManagementStudio.Data.Seeders;
using LibraryManagementStudio.User.Views.UserAuthView;
using LibraryManagementStudio.User.Views.UserView;

namespace LibraryManagementStudio.User
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            //Seeder
            LibrarySeeder seeder = new LibrarySeeder();
            seeder.SeedDatabase();
            
            Application.Run(new UserRegistrationView());
        }
    }
}