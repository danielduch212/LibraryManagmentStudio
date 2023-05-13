using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Worker.Dtos.Book;
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
    public partial class BookStorage : UserControl
    {
        List<BookDto> books;
        private WorkerBookService service;
        private AdminUserService userService;
        LibraryManagementStudio.Data.Models.Worker worker;
        LibraryManagementStudio.Data.Models.Book book;
        public BookStorage(LibraryDbContext dbContext, Data.Models.Worker worker)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            service = new WorkerBookService(dbContext);
            userService = new AdminUserService(dbContext);
            panelBorrowBook.Visible = false;
            books = service.GetBooks();
            SetupBooksView();
            this.worker = worker;
        }

        private void SetupBooksView()
        {
            var bindingList = new BindingList<BookDto>(books);
            var bindingSource = new BindingSource(bindingList, null);

            bookDataGridView.DataSource = bindingSource;

            bookDataGridView.Columns["BookId"]!.HeaderText = "Id";
            bookDataGridView.Columns["BookId"]!.Width = 10;
            bookDataGridView.Columns["Title"]!.HeaderText = "Tytul";
            bookDataGridView.Columns["Title"]!.Width = 25;
            bookDataGridView.Columns["AuthorName"]!.HeaderText = "Autor";
            bookDataGridView.Columns["AuthorName"]!.Width = 20;
            bookDataGridView.Columns["PublisherName"]!.HeaderText = "Wydawnictwo";
            bookDataGridView.Columns["PublisherName"]!.Width = 25;
            bookDataGridView.Columns["Description"]!.HeaderText = "Opis";
            bookDataGridView.Columns["Description"]!.Width = 30;
            bookDataGridView.Columns["Category"]!.HeaderText = "Kategoria";
            bookDataGridView.Columns["Category"]!.Width = 15;
            bookDataGridView.Columns["PublishDate"]!.HeaderText = "Data wydania";
            bookDataGridView.Columns["PublishDate"]!.Width = 10;
            bookDataGridView.Columns["BookCopiesCount"]!.HeaderText = "Liczba kopii";
            bookDataGridView.Columns["BookCopiesCount"]!.Width = 10;
            bookDataGridView.Columns["AvailibleBookCopiesCount"]!.HeaderText = "Dostepne kopie";
            bookDataGridView.Columns["AvailibleBookCopiesCount"]!.Width = 10;
            bookDataGridView.BackgroundColor = Color.White;
            bookDataGridView.RowHeadersVisible = false;

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            books = service.GetBookByTitle(searchBooksTextBox.Text).ToList();
            SetupBooksView();
        }

        private void borrowBook_Click(object sender, EventArgs e)
        {
            if(bookDataGridView.SelectedRows.Count > 0)
            {
                book = service.getBookFromString(bookDataGridView.SelectedRows.ToString());
                labelBookTitle.Text = book.Title;
                panelBorrowBook.Visible = true;

            }
            
        }

        private void buttonCancelBorrow_Click(object sender, EventArgs e)
        {
            panelBorrowBook.Visible = false;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            BookBorrow bookBorrow = new BookBorrow()
            {
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7), //wypozycza na 7 dni
                IsActive = true,
                Status = Data.Models.Enums.BorrowedBookStatus.Received,
                Worker = worker,
                User = userService.getUserByEmail(textBoxUserEmail.Text),
                BookCopy = service.getAvailibleCopy(book.Title),

            };
            service.CreateNewBookBorrow(bookBorrow);
            books = service.GetBooks();
            SetupBooksView();
            panelBorrowBook.Visible = false;

        }
    }
}
