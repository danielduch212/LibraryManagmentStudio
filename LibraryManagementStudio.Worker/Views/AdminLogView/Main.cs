﻿using LibraryManagementStudio.Worker.Views.ParcelMaintenanceView;

namespace LibraryManagementStudio.Worker.Views.AdminLogView
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textboxLogin.Text == "admin" && textboxHaslo.Text == "admin")
            {
                Worker.Views.AdminView.Main adminView = new Worker.Views.AdminView.Main();
                adminView.Show();
                this.Hide();

            }
            if (textboxLogin.Text == "parcel" && textboxHaslo.Text == "parcel")
            {

                Worker.Views.ParcelMaintenanceView.ParcelMaintenanceMainView parcelView = new Worker.Views.ParcelMaintenanceView.ParcelMaintenanceMainView();
                parcelView.Show();
                this.Hide();
            }
            

        }
    }
}
