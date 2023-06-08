using Autofac.Core;
using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Worker.Dtos.User;
using LibraryManagementStudio.Worker.Services;
using Microsoft.VisualBasic.ApplicationServices;
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
        WorkerBookService bookService;
        AdminUserService service;
        LibraryManagementStudio.Data.Models.Worker worker;
        List<UserDto> users;
        List<Worker.Dtos.BookBorrow.BookBorrowToShow>? userBorrows;
        LibraryManagementStudio.Data.Models.User? user;
        public UsersList(LibraryDbContext dbContext, Data.Models.Worker worker)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            service = new AdminUserService(dbContext);
            bookService = new WorkerBookService(dbContext);
            usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            showUserDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            showUserPanel.Visible = false;
            users = service.getUsers();
            LoadUsers();
            this.worker = worker;
        }

        private void LoadUsers()
        {

            var bindingList = new BindingList<UserDto>(users);
            var bindingSource = new BindingSource(bindingList, null);


            usersDataGridView.DataSource = bindingSource;

            usersDataGridView.Columns["UserId"]!.HeaderText = "Id";
            usersDataGridView.Columns["UserId"].DisplayIndex = 0; // Przesuń kolumnę "BookId" na pierwszą pozycję


            usersDataGridView.Columns["FirstName"]!.HeaderText = "Imie";
            usersDataGridView.Columns["FirstName"].DisplayIndex = 1;
            usersDataGridView.Columns["LastName"]!.HeaderText = "Nazwisko";
            usersDataGridView.Columns["FirstName"].DisplayIndex = 2;

            usersDataGridView.Columns["EmailAddress"]!.HeaderText = "Email";
            usersDataGridView.Columns["EmailAddress"].DisplayIndex = 3;

            usersDataGridView.Columns["City"]!.HeaderText = "City";
            usersDataGridView.Columns["City"].DisplayIndex = 4;

            usersDataGridView.Columns["Street"]!.HeaderText = "Ulica";
            usersDataGridView.Columns["Street"].DisplayIndex = 5;

            usersDataGridView.Columns["PostalCode"]!.HeaderText = "Kod Pocztowy";
            usersDataGridView.Columns["PostalCode"].DisplayIndex = 6;

            usersDataGridView.Columns["BookBorrowsCount"]!.HeaderText = "Liczba Ksiazek";
            usersDataGridView.Columns["BookBorrowsCount"].DisplayIndex = 7;

            usersDataGridView.Columns["BookBorrows"]!.Visible = false;
            usersDataGridView.BackgroundColor = Color.White;
            usersDataGridView.RowHeadersVisible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {


            users = service.searchUser(searchBooksTextBox.Text);
            LoadUsers();
        }

        private void cancelShowDataButton_Click(object sender, EventArgs e)
        {
            showUserPanel.Visible = false;

            users = service.getUsers();
            LoadUsers();
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void ReturnBook_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = usersDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = usersDataGridView.Rows[selectedRowIndex];

                int userId = Convert.ToInt32(selectedRow.Cells["UserId"].Value);


                user = service.findUserRow(userId);
                if (user == null)
                {
                    return;
                }

                userBorrows = bookService.GetUsersBorrowedBooks(user);
                if (userBorrows == null)
                {
                    return;
                }
                labelUserName.Text = user.FirstName;
                labelSurname.Text = user.LastName;
                labelEmail.Text = user.EmailAddress;
                labelCity.Text = user.City;
                labelAllBorrows.Text = userBorrows.Count.ToString();

                SetUserDataView();
                panel1.Visible = false;
                panel2.Visible = false;
                showUserPanel.Visible = true;
            }
        }

        private void SetUserDataView()
        {

            var bindingList = new BindingList<Worker.Dtos.BookBorrow.BookBorrowToShow>(userBorrows);
            var bindingSource = new BindingSource(bindingList, null);

            showUserDataGridView.DataSource = bindingSource;

            showUserDataGridView.Columns["BookBorrowId"]!.HeaderText = "Id";
            showUserDataGridView.Columns["BookBorrowId"].DisplayIndex = 0;

            showUserDataGridView.Columns["bookTitle"]!.HeaderText = "Tytul";
            showUserDataGridView.Columns["bookTitle"].DisplayIndex = 1;


            showUserDataGridView.Columns["StartDate"]!.HeaderText = "Data wypozyczenie";
            showUserDataGridView.Columns["StartDate"].DisplayIndex = 2;


            showUserDataGridView.Columns["EndDate"]!.HeaderText = "Data konca wypozyczenia";
            showUserDataGridView.Columns["EndDate"].DisplayIndex = 3;

            showUserDataGridView.Columns["Status"]!.HeaderText = "Status";
            showUserDataGridView.Columns["Status"].DisplayIndex = 4;

            showUserDataGridView.Columns["WorkerId"]!.HeaderText = "Id pracownika";
            showUserDataGridView.Columns["WorkerId"].DisplayIndex = 4;



            showUserDataGridView.Columns["UserId"]!.HeaderText = "Id";
            showUserDataGridView.Columns["UserId"].DisplayIndex = 5;


            showUserDataGridView.Columns["BookCopyId"]!.HeaderText = "BookCopyID";
            showUserDataGridView.Columns["BookCopyId"].DisplayIndex = 6;


            showUserDataGridView.BackgroundColor = Color.White;
            showUserDataGridView.RowHeadersVisible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchBooksTextBox.Text = "";
        }

        private void ReturnBook_Click_1(object sender, EventArgs e)
        {
            if (showUserDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = showUserDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = showUserDataGridView.Rows[selectedRowIndex];

                int bookId = Convert.ToInt32(selectedRow.Cells["BookBorrowId"].Value);
                bookService.returnBookBorrow(bookId);
                userBorrows = bookService.GetUsersBorrowedBooks(user);
                SetUserDataView();
            }
        }
    }
}
