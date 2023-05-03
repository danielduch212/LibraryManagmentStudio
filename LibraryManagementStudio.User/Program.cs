using LibraryManagementStudio.Data.Seeders;
using LibraryManagementStudio.User.Views.UserAuthView;

namespace LibraryManagementStudio.User
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            //Seeder
            var seeder = new LibrarySeeder();
            seeder.SeedDatabase();
            
            //Run
            var startupView = new UserLoginView();
            Application.Run(startupView);
        }
    }
}