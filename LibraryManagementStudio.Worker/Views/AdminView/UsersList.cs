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
        WorkerBookService bookService;
        AdminUserService service;
        LibraryManagementStudio.Data.Models.Worker worker;
        List<UserDto> users;
        List<Worker.Dtos.BookBorrow.BookBorrowToShow> userBorrows;
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
            
            usersDataGridView.Columns["FirstName"]!.HeaderText = "Imie";
            usersDataGridView.Columns["LastName"]!.HeaderText = "Nazwisko";
            usersDataGridView.Columns["EmailAddress"]!.HeaderText = "Email";
            usersDataGridView.Columns["City"]!.HeaderText = "20";
            usersDataGridView.Columns["Street"]!.HeaderText = "Ulica";
            usersDataGridView.Columns["PostalCode"]!.HeaderText = "Kod Pocztowy";
            usersDataGridView.Columns["BookBorrowsCount"]!.HeaderText = "Liczba Ksiazek";
            usersDataGridView.Columns["BookBorrows"]!.Visible = false;
            usersDataGridView.BackgroundColor = Color.White;
            usersDataGridView.RowHeadersVisible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //search
            users = service.searchUser(searchBooksTextBox.Text);
            LoadUsers();
        }

        private void cancelShowDataButton_Click(object sender, EventArgs e)
        {
            showUserPanel.Visible = false;
            users = service.getUsers();
            LoadUsers();
        }

        private void ReturnBook_Click(object sender, EventArgs e)
        {
            if(showUserDataGridView.SelectedRows.Count > 0)
            {
                var bookData = showUserDataGridView.SelectedRows.ToString();
                bookService.returnBookBorrow(bookData);

                SetUserDataView();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(usersDataGridView.SelectedRows.Count > 0)
            {
                var stringData = usersDataGridView.SelectedRows.ToString();
                var user = service.findUserRow(stringData);
                userBorrows = bookService.GetUsersBorrowedBooks(user);
                labelUserName.Text = user.FirstName;
                labelSurname.Text = user.LastName;
                labelEmail.Text = user.EmailAddress;
                labelCity.Text = user.City;
                //var query = userBorrows
                //    .Where(x => x.) sprawdzanie czy sa aktualne
                labelAllBorrows.Text = userBorrows.Count.ToString();

                //zrobic tutaj formatowanie tego tj. wyswietlanie wypozyczen uzytkownika
                showUserPanel.Visible = true;
            }
        }

        private void SetUserDataView()
        {

            var bindingList = new BindingList<Worker.Dtos.BookBorrow.BookBorrowToShow>(userBorrows);
            var bindingSource = new BindingSource(bindingList, null);

            showUserDataGridView.DataSource = bindingSource;

            showUserDataGridView.Columns["BookBorrowId"]!.HeaderText = "Id";
            showUserDataGridView.Columns["bookTitle"]!.HeaderText = "Tytul";
            showUserDataGridView.Columns["StartDate"]!.HeaderText = "Data wypozyczenie";

            showUserDataGridView.Columns["EndDate"]!.HeaderText = "Data konca wypozyczenia";
            showUserDataGridView.Columns["Status"]!.HeaderText = "Status";
            showUserDataGridView.Columns["WorkerId"]!.HeaderText = "Id pracownika";
            

            showUserDataGridView.Columns["UserId"]!.HeaderText = "Id";
            
            showUserDataGridView.Columns["BookCopyId"]!.HeaderText = "BookCopyID";
            showUserDataGridView.Columns["PostalCode"]!.HeaderText = "Kod Pocztowy";
            showUserDataGridView.BackgroundColor = Color.White;
            showUserDataGridView.RowHeadersVisible = false;

        }
    }
}
