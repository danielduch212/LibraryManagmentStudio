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
            if(textboxLogin.Text != "" && textboxHaslo.Text != "")
            {
                var worker = service.checkLoginData(textboxLogin.Text, textboxHaslo.Text);
                if(worker != null)
                {
                    var adminView = new Worker.Views.AdminView.Main(worker, dbContext);
                    adminView.Show();
                    this.Hide();
                }
                

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
