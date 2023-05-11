using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Worker.Services;

namespace LibraryManagementStudio.Worker.Views.AdminLogView
{
    public partial class Main : Form
    {
        LibraryDbContext dbContext = new LibraryDbContext();
        WorkerService service;
        public Main()
        {
            
            InitializeComponent();
            service = new WorkerService(dbContext);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textboxLogin.Text == "admin" && textboxHaslo.Text == "admin")
            {
                var worker = service.getWorker("admin");
                var adminView = new Worker.Views.AdminView.Main(worker, dbContext);
                adminView.Show();
                this.Hide();

            }
            if (textboxLogin.Text == "parcel" && textboxHaslo.Text == "parcel")
            {

                var parcelView = new ParcelMaintenanceView.ParcelMaintenanceMainView();
                parcelView.Show();
                this.Hide();
            }
            

        }
    }
}
