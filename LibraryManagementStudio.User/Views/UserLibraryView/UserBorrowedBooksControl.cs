using System.ComponentModel;
using Autofac;
using LibraryManagementStudio.User.Dtos.BookBorrow;
using LibraryManagementStudio.User.Dtos.User;
using LibraryManagementStudio.User.Services.Interfaces;

namespace LibraryManagementStudio.User.Views.UserLibraryView
{
    public partial class UserBorrowedBooksControl : UserControl
    {
        private readonly UserDto _userDto;
        private readonly IUserBookBorrowService _userBookBorrowService;

        private List<BookBorrowDto> _bookBorrowsList = null;

        public UserBorrowedBooksControl(UserDto userDto)
        {
            InitializeComponent();
            searchBooksTextBox.KeyPress += CheckEnterKeyPress;
            
            _userDto = userDto;
            
            var diContainer = UserDIConfig.Configure();
            _userBookBorrowService = diContainer.Resolve<IUserBookBorrowService>();

            // _bookService = bookService;
            // _borrowedBookService = borrowedBookService;
            // _user = user;
            //RefreshBooks();

            ViewStyleHelper.MaximizeUserControl(this);
            InitializeView();
        }
        
        private void InitializeView()
        {
            searchBooksTextBox.Text = "";
            _bookBorrowsList = _userBookBorrowService.GetBorrowedBooks(_userDto.UserId).ToList();
            SetupGridData();
        }

        private void SearchBooks()
        {
            _bookBorrowsList = _userBookBorrowService.GetBorrowedBooks(_userDto.UserId, searchBooksTextBox.Text).ToList();
            SetupGridData();
        }

        private void SetupGridData()
        {
            var bindingList = new BindingList<BookBorrowDto>(_bookBorrowsList);
            var books = new BindingSource(bindingList, null);
            SetupGridViewStyle(books);
        }
        
        private void SetupGridViewStyle(BindingSource books)
        {
            bookListGridView.DataSource = books;
        
            bookListGridView.Columns["BookBorrowId"]!.Visible = false;

            bookListGridView.Columns["Title"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookListGridView.Columns["Title"]!.HeaderText = "Tytuł";
        
            bookListGridView.Columns["AuthorName"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            bookListGridView.Columns["AuthorName"]!.HeaderText = "Autor";
            
            bookListGridView.Columns["Category"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            bookListGridView.Columns["Category"]!.HeaderText = "Kategoria";
            
            bookListGridView.Columns["StartDate"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            bookListGridView.Columns["StartDate"]!.HeaderText = "Od";
            
            bookListGridView.Columns["EndDate"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            bookListGridView.Columns["EndDate"]!.HeaderText = "Do";

            bookListGridView.BackgroundColor = Color.White;
            bookListGridView.RowHeadersVisible = false;
        }

        private void searchBooksButton_Click(object sender, EventArgs e)
        {
            if (searchBooksTextBox.Text != "")
            {
                SearchBooks();
            }
            else
            {
                InitializeView();
            }
        }
        
        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            searchBooksTextBox.Text = "";
            InitializeView();
        }
        
        private void returnBookButton_Click(object sender, EventArgs e)
        {
            // Book selectedBook = (Book)bookListGridView.CurrentRow.DataBoundItem;
            //
            // if (selectedBook != null && selectedBook.Status == BookStatus.odebrana)
            // {
            //     _borrowedBookService.ReturnBook(selectedBook, _user.Id);
            //     RefreshBooks();
            //     SetupView();
            //     MessageBox.Show("Zwrot został zaakceptowany.");
            // }
            // else if (selectedBook != null && selectedBook.Status == BookStatus.nieodebrana)
            // {
            //     MessageBox.Show("Nie można zwrócić nie odebranej książki.");
            // }
        }
        
        // private void SearchBooks()
        // {
        //     List<Book> booksList = _bookList.Where(b => b.Title.ToLower().Contains(searchBooksTextBox.Text.ToLower())).ToList();
        //     var bindingList = new BindingList<Book>(booksList);
        //     var books = new BindingSource(bindingList, null);
        //     SetupGridViewStyle(books);
        // }
        //
        // private void SetupView()
        // {
        //     var bindingList = new BindingList<Book>(_bookList);
        //     var books = new BindingSource(bindingList, null);
        //     SetupGridViewStyle(books);
        // }
        //
        //
        //
        // private void RefreshBooks()
        // {
        //     var books = _bookService.GetBooks().ToList();
        //     _bookList = books.Where(x => x.RentierId == _user.Id).ToList();
        // }
        //
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SearchBooks();
            }
        }
    }
}
