using LibraryManagementStudio.Data;
using LibraryManagementStudio.User.Services;

namespace LibraryManagementStudio.User.Views.UserLibraryView
{
    public partial class UserView : Form
    {
        private readonly UserBookService _userBookService;

        public UserView()
        {
            InitializeComponent();

            //Maximize current form
            ViewStyleHelper.MaximizeForm(this);

            //Load books from databases
            var dbContext = new LibraryDbContext();
            _userBookService = new UserBookService(dbContext);

            //Show book list control at first
            var control = new UserBookListControl(contentPanel, _userBookService);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);

            bookListButton.BackColor = Color.Gray;
            borrowedBookButton.BackColor = Color.White;
            pickupAndReturnButton.BackColor = Color.White;
            userInfoButton.BackColor = Color.White;
            reservedBooksButton.BackColor = Color.White;
        }

        private void bookListButton_Click(object sender, EventArgs e)
        {
            var control = new UserBookListControl(contentPanel, _userBookService);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);

            bookListButton.BackColor = Color.Gray;
            borrowedBookButton.BackColor = Color.White;
            pickupAndReturnButton.BackColor = Color.White;
            userInfoButton.BackColor = Color.White;
            reservedBooksButton.BackColor = Color.White;
        }

        private void borrowedBookButton_Click(object sender, EventArgs e)
        {
            bookListButton.BackColor = Color.White;
            borrowedBookButton.BackColor = Color.Gray;
            pickupAndReturnButton.BackColor = Color.White;
            userInfoButton.BackColor = Color.White;
            reservedBooksButton.BackColor = Color.White;
        }

        private void pickupAndReturnButton_Click(object sender, EventArgs e)
        {
            bookListButton.BackColor = Color.White;
            borrowedBookButton.BackColor = Color.White;
            pickupAndReturnButton.BackColor = Color.Gray;
            userInfoButton.BackColor = Color.White;
            reservedBooksButton.BackColor = Color.White;
        }

        private void userInfoButton_Click(object sender, EventArgs e)
        {
            bookListButton.BackColor = Color.White;
            borrowedBookButton.BackColor = Color.White;
            pickupAndReturnButton.BackColor = Color.White;
            userInfoButton.BackColor = Color.Gray;
            reservedBooksButton.BackColor = Color.White;
        }

        private void reservedBooksButton_Click(object sender, EventArgs e)
        {
            bookListButton.BackColor = Color.White;
            borrowedBookButton.BackColor = Color.White;
            pickupAndReturnButton.BackColor = Color.White;
            userInfoButton.BackColor = Color.White;
            reservedBooksButton.BackColor = Color.Gray;
        }

        private void buttonsPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bookParcelButton_Click(object sender, EventArgs e)
        {
        }
    }
}