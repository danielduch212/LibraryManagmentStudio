using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Seeders;
using LibraryManagementStudio.User.Views.UserAuthView;

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
            var seeder = new LibrarySeeder();
            seeder.SeedDatabase();
            
            var dbContext = new LibraryDbContext();
            Application.Run(new UserLoginView(dbContext));
        }
    }
}