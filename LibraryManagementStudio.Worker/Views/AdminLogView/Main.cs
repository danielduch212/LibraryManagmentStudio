﻿namespace LibraryManagementStudio.Worker.Views.AdminLogView
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
            Worker.Views.AdminView.Main adminView = new Worker.Views.AdminView.Main();
            adminView.Show();
            this.Hide();

        }
    }
}