using System.ComponentModel;
using LibraryManagementStudio.User.Dtos.Book;
using LibraryManagementStudio.User.Services;

namespace LibraryManagementStudio.User.Views.UserLibraryView
{
    public partial class UserBookListControl : UserControl
    {
        private readonly Panel _contentPanel;
        private readonly UserBookService _userBookService;
        private List<BookDto> _bookList;

        public UserBookListControl(Panel contentPanel, UserBookService userBookService)
        {
            InitializeComponent();
            searchBooksTextBox.KeyPress += CheckEnterKeyPress;
            _contentPanel = contentPanel;
            _userBookService = userBookService;

            ViewStyleHelper.MaximizeUserControl(this);
            InitializeView();
        }

        private void InitializeView()
        {
            _bookList = _userBookService.GetBooks().ToList();
            SetupGridData();
        }

        private void SearchBooks()
        {
            _bookList = _userBookService.GetBooks(searchBooksTextBox.Text).ToList();
            SetupGridData();
        }

        private void SetupGridData()
        {
            var bindingList = new BindingList<BookDto>(_bookList);
            var books = new BindingSource(bindingList, null);
            SetupGridViewStyle(books);
        }

        private void SetupGridViewStyle(BindingSource books)
        {
            bookListGridView.DataSource = books;

            bookListGridView.Columns["BookId"]!.Visible = false;
            bookListGridView.Columns["Description"]!.Visible = false;
            bookListGridView.Columns["PublishDate"]!.Visible = false;

            bookListGridView.Columns["Title"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookListGridView.Columns["Title"]!.HeaderText = "Tytuł";

            bookListGridView.Columns["AuthorName"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            bookListGridView.Columns["AuthorName"]!.HeaderText = "Autor";

            bookListGridView.Columns["PublisherName"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            bookListGridView.Columns["PublisherName"]!.HeaderText = "Wydawnictwo";

            bookListGridView.Columns["Category"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            bookListGridView.Columns["Category"]!.HeaderText = "Kategoria";

            bookListGridView.Columns["BookCopiesCount"]!.Width = 235;
            bookListGridView.Columns["BookCopiesCount"]!.HeaderText = "Ilość dostępnych egzemplarzy";

            bookListGridView.BackgroundColor = Color.White;
            bookListGridView.RowHeadersVisible = false;
        }

        private void bookInfoButton_Click(object sender, EventArgs e)
        {
            BookDto? selectedBook = null;
            
            if (bookListGridView.CurrentRow != null)
            {
                selectedBook = (BookDto)bookListGridView.CurrentRow.DataBoundItem;
            }

            if (selectedBook != null)
            {
                var control = new UserBookInfoControl(_contentPanel, _userBookService, selectedBook);
                ViewStyleHelper.AddControlToPanel(control, _contentPanel);
            }
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

        private void reserveBookButton_Click(object sender, EventArgs e)
        {
            ReserveBook();
        }

        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            BorrowBook();
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            searchBooksTextBox.Text = "";
            InitializeView();
        }

        private void ReserveBook()
        {
        }

        private void BorrowBook()
        {
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SearchBooks();
            }
        }

        private void searchBooksTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserBookListControl_Load(object sender, EventArgs e)
        {
        }

      
    }
}
