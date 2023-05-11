using Autofac.Core;
using LibraryManagementStudio.Data;
using LibraryManagementStudio.Worker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementStudio.Worker.Views.AdminView
{
    public partial class Workers : UserControl
    {
        WorkerService service;
        LibraryManagementStudio.Data.Models.Worker worker;
        public Workers(LibraryDbContext dbContext, Data.Models.Worker worker)
        {
            InitializeComponent();
            service = new WorkerService(dbContext);
            LoadWorkers();
            this.worker = worker;
        }

        private void LoadWorkers()
        {
            var workers = service.getWorkers();
            var bindingList = new BindingList<LibraryManagementStudio.Data.Models.Worker>(workers);
            var bindingSource = new BindingSource(bindingList, null);

            workersDataGridView.DataSource = bindingSource;

            workersDataGridView.Columns["WorkerId"]!.HeaderText = "Id";
            workersDataGridView.Columns["WorkerId"]!.Width = 10;
            workersDataGridView.Columns["Type"]!.HeaderText = "Typ";
            workersDataGridView.Columns["Type"]!.Width = 15;
            workersDataGridView.Columns["FirstName"]!.HeaderText = "Imie";
            workersDataGridView.Columns["FirstName"]!.Width = 25;
            workersDataGridView.Columns["LastName"]!.HeaderText = "Nazwisko";
            workersDataGridView.Columns["LastName"]!.Width = 25;
            workersDataGridView.Columns["EmailAddress"]!.HeaderText = "Email";
            workersDataGridView.Columns["EmailAddress"]!.Width = 30;
            workersDataGridView.Columns["Password"]!.Visible = false;
            workersDataGridView.Columns["Books"]!.Visible = false;
            workersDataGridView.Columns["BookBorrows"]!.Visible = false;
            workersDataGridView.Columns["Users"]!.Visible = false;
            workersDataGridView.Columns["Penalties"]!.Visible = false;
            workersDataGridView.BackgroundColor = Color.White;
            workersDataGridView.RowHeadersVisible = false;

        }
    }
}
