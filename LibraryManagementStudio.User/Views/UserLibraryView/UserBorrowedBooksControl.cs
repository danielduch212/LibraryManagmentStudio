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

        private List<BookBorrowDto>? _bookBorrowsList = null;

        public UserBorrowedBooksControl(UserDto userDto)
        {
            InitializeComponent();
            searchBooksTextBox.KeyPress += CheckEnterKeyPress;
            
            _userDto = userDto;
            
            var diContainer = UserDIConfig.Configure();
            _userBookBorrowService = diContainer.Resolve<IUserBookBorrowService>();

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
            
            bookListGridView.Columns["Status"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

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
            if (bookListGridView.CurrentRow == null) 
                return;
            
            var selectedBook = (BookBorrowDto)bookListGridView.CurrentRow.DataBoundItem;
            
            if (selectedBook != null && selectedBook.Status == "Odebrana")
            {
                _userBookBorrowService.ReturnBook(selectedBook.BookBorrowId);
                InitializeView();
                MessageBox.Show("Zwrot został zaakceptowany. Na twojego maila została wysłana wiadomość z kodami zwrotu.");
            }
            else if (selectedBook != null && selectedBook.Status != "Odebrana")
            {
                MessageBox.Show("Nie można zwrócić nieodebranej książki.");
            }
        }
        
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SearchBooks();
            }
        }
    }
}
