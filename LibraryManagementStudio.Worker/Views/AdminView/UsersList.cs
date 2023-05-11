using Autofac.Core;
using LibraryManagementStudio.Data;
using LibraryManagementStudio.Worker.Dtos.User;
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
    public partial class UsersList : UserControl
    {
        AdminUserService service;
        LibraryManagementStudio.Data.Models.Worker worker;
        public UsersList(LibraryDbContext dbContext, Data.Models.Worker worker)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            service = new AdminUserService(dbContext);
            LoadUsers();
            this.worker = worker;
        }

        private void LoadUsers()
        {
            var users = service.getUsers();
            var bindingList = new BindingList<UserDto>(users);
            var bindingSource = new BindingSource(bindingList, null);

            usersDataGridView.DataSource = bindingSource;

            usersDataGridView.Columns["UserId"]!.HeaderText = "Id";
            usersDataGridView.Columns["UserId"]!.Width = 10;
            usersDataGridView.Columns["FirstName"]!.HeaderText = "Imie";
            usersDataGridView.Columns["FirstName"]!.Width = 25;
            usersDataGridView.Columns["LastName"]!.HeaderText = "Nazwisko";
            usersDataGridView.Columns["LastName"]!.Width = 25;
            usersDataGridView.Columns["EmailAddress"]!.HeaderText = "Email";
            usersDataGridView.Columns["EmailAddress"]!.Width = 25;
            usersDataGridView.Columns["City"]!.HeaderText = "20";
            usersDataGridView.Columns["City"]!.Width = 30;
            usersDataGridView.Columns["Street"]!.HeaderText = "Ulica";
            usersDataGridView.Columns["Street"]!.Width = 15;
            usersDataGridView.Columns["PostalCode"]!.HeaderText = "Kod Pocztowy";
            usersDataGridView.Columns["PostalCode"]!.Width = 10;
            usersDataGridView.Columns["BookBorrowsCount"]!.HeaderText = "Liczba Ksiazek";
            usersDataGridView.Columns["BookBorrowsCount"]!.Width = 10;
            usersDataGridView.Columns["BookBorrows"]!.Visible = false;
            usersDataGridView.BackgroundColor = Color.White;
            usersDataGridView.RowHeadersVisible = false;

        }
    }
}
