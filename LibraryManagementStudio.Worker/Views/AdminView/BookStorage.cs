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
        LibraryManagementStudio.Data.Models.Book? book;
        public BookStorage(LibraryDbContext dbContext, Data.Models.Worker worker)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            service = new WorkerBookService(dbContext);
            userService = new AdminUserService(dbContext);
            panelBorrowBook.Visible = false;
            panelAddCopies.Visible = false;
            panelEraseCopy.Visible = false;
            books = service.GetBooks();
            SetupBooksView();
            this.worker = worker;
        }

        private void SetupBooksView()
        {
            var bindingList = new BindingList<BookDto>(books);
            var bindingSource = new BindingSource(bindingList, null);

            bookDataGridView.DataSource = bindingSource;



            bookDataGridView.Columns["AvailibleBookCopiesCount"]!.HeaderText = "Dostepne kopie";
            bookDataGridView.Columns["BookCopiesCount"].DisplayIndex = 8;

            bookDataGridView.Columns["BookCopiesCount"]!.HeaderText = "Liczba kopii";
            bookDataGridView.Columns["BookCopiesCount"].DisplayIndex =7;

            bookDataGridView.Columns["PublishDate"]!.HeaderText = "Data wydania";
            bookDataGridView.Columns["PublishDate"].DisplayIndex = 6;


            bookDataGridView.Columns["Category"]!.HeaderText = "Kategoria";
            bookDataGridView.Columns["Category"].DisplayIndex = 5;


            bookDataGridView.Columns["Description"]!.HeaderText = "Opis";
            bookDataGridView.Columns["Description"].DisplayIndex = 4;


            bookDataGridView.Columns["PublisherName"]!.HeaderText = "Wydawnictwo";
            bookDataGridView.Columns["PublisherName"].DisplayIndex = 3;


            bookDataGridView.Columns["AuthorName"]!.HeaderText = "Autor";
            bookDataGridView.Columns["AuthorName"].DisplayIndex = 2;

            bookDataGridView.Columns["Title"]!.HeaderText = "Tytul";
            bookDataGridView.Columns["Title"].DisplayIndex = 1;

            bookDataGridView.Columns["BookId"]!.HeaderText = "Id";
            bookDataGridView.Columns["BookId"].DisplayIndex = 0; 
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
            panelAddCopies.Visible = false;
            panelEraseCopy.Visible = false;

            if (bookDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = bookDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = bookDataGridView.Rows[selectedRowIndex];

                int bookId = Convert.ToInt32(selectedRow.Cells["BookId"].Value);
                
                book = service.getBookFromId(bookId);
                if (book == null) { return; }
                labelBookTitle.Text = book.Title;
                SetPanelLocation(panelBorrowBook);
                panelBorrowBook.Visible = true;

            }
            
        }

        private void buttonCancelBorrow_Click(object sender, EventArgs e)
        {
            panelBorrowBook.Visible = false;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(textBoxUserEmail.Text == "" || textBoxUserEmail.Text == null)
            {
                MessageBox.Show("Podaj Email", "Ostrzezenie");
                return;
            }
            if(userService.getUserByEmail(textBoxUserEmail.Text) == null)
            {
                MessageBox.Show("Zly email", "Ostrzezenie");
                return;

            }
            if (service.getAvailibleCopy(book.Title) == null)
            {
                MessageBox.Show("Brak dostepnych kopii do wypozyczenia!", "Ostrzezenie");
                return;
            }
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
            MessageBox.Show("Wypozyczono ksiazke", "Informacja");
            textBoxUserEmail.Text = "";
            service.CreateNewBookBorrow(bookBorrow, service.getAvailibleCopy(book.Title));
            books = service.GetBooks();
            SetupBooksView();
            panelBorrowBook.Visible = false;

        }

        private void AddBookCopies_Click(object sender, EventArgs e)
        {
            panelBorrowBook.Visible = false;
            panelEraseCopy.Visible = false;
            if (bookDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = bookDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = bookDataGridView.Rows[selectedRowIndex];

                int bookId = Convert.ToInt32(selectedRow.Cells["BookId"].Value);

                book = service.getBookFromId(bookId);
                if (book == null) { return; }
                AddCopiesBookTitle.Text = book.Title;
                SetPanelLocation(panelAddCopies);
                panelAddCopies.Visible = true;
            }
            
            
        }

        private void cancelButtonCopies_Click(object sender, EventArgs e)
        {
            panelAddCopies.Visible = false;

        }

        private void okButtonCopies_Click(object sender, EventArgs e)
        {
            var howManyCopies = Int32.Parse(textBoxCopiesAdd.Text);
            service.AddBookCopies(book,howManyCopies);
            books = service.GetBooks();
            SetupBooksView();
            panelAddCopies.Visible = false;
        }

        private void EraseCopy_Click(object sender, EventArgs e)
        {
            panelBorrowBook.Visible = false;
            panelAddCopies.Visible = false;
            SetPanelLocation(panelEraseCopy);

            panelEraseCopy.Visible = true;

        }

        private void cancelEraseCopyButton_Click(object sender, EventArgs e)
        {
            panelEraseCopy.Visible = false;
        }

        private void eraseCopyButton_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(textBoxCopyIDToErase.Text);
            service.EraseCopy(id);
            books = service.GetBooks();
            SetupBooksView();

            panelEraseCopy.Visible = false;


        }

        private void EraseBook_Click(object sender, EventArgs e)
        {
            if (bookDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = bookDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = bookDataGridView.Rows[selectedRowIndex];

                int bookId = Convert.ToInt32(selectedRow.Cells["BookId"].Value);

                book = service.getBookFromId(bookId);
                if (book == null) { return; }
                service.EraseBook(book);
                MessageBox.Show("Usunieto ksiazke", "Informacja");
                books = service.GetBooks();
                SetupBooksView();

            }

        }
        private void SetPanelLocation(Panel panelToSetLocation)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int panelWidth = panelToSetLocation.Width;
            int panelHeight = panelToSetLocation.Height;

            // Ustaw położenie panelu na środku formularza
            panelToSetLocation.Location = new Point((formWidth - panelWidth) / 2, (formHeight - panelHeight) / 2);

        }

        private void bookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
