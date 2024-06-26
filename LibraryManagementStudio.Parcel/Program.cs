using LibraryManagementStudio.Parcel.Views;

namespace LibraryManagementStudio.Parcel
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

            var parcelService = new ParcelService();
            Application.Run(new BookParcelView(parcelService));
        }
    }
}