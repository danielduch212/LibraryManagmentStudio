using LibraryManagementStudio.User.Dtos.User;
using LibraryManagementStudio.User.Views.UserAuthView;

namespace LibraryManagementStudio.User.Views.UserLibraryView
{
    public partial class UserView : Form
    {
        private readonly UserDto _userDto;

        public UserView(UserDto userDto)
        {
            InitializeComponent();

            _userDto = userDto;

            //Maximize current form
            ViewStyleHelper.MaximizeForm(this);

            //Show book list control at first
            var control = new UserBookListControl(contentPanel, userDto);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);

            bookListButton.BackColor = Color.Gray;
            borrowedBookButton.BackColor = Color.White;
            pickupAndReturnButton.BackColor = Color.White;
            userInfoButton.BackColor = Color.White;
        }

        private void bookListButton_Click(object sender, EventArgs e)
        {
            var control = new UserBookListControl(contentPanel, _userDto);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);

            bookListButton.BackColor = Color.Gray;
            borrowedBookButton.BackColor = Color.White;
            pickupAndReturnButton.BackColor = Color.White;
            userInfoButton.BackColor = Color.White;
        }

        private void borrowedBookButton_Click(object sender, EventArgs e)
        {
            var control = new UserBorrowedBooksControl(_userDto);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);

            bookListButton.BackColor = Color.White;
            borrowedBookButton.BackColor = Color.Gray;
            pickupAndReturnButton.BackColor = Color.White;
            userInfoButton.BackColor = Color.White;
        }

        private void pickupAndReturnButton_Click(object sender, EventArgs e)
        {
            var control = new UserPickupAndReturnControl();
            ViewStyleHelper.AddControlToPanel(control, contentPanel);

            bookListButton.BackColor = Color.White;
            borrowedBookButton.BackColor = Color.White;
            pickupAndReturnButton.BackColor = Color.Gray;
            userInfoButton.BackColor = Color.White;
        }

        private void userInfoButton_Click(object sender, EventArgs e)
        {
            var control = new UserInfoControl(_userDto);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);

            bookListButton.BackColor = Color.White;
            borrowedBookButton.BackColor = Color.White;
            pickupAndReturnButton.BackColor = Color.White;
            userInfoButton.BackColor = Color.Gray;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            var startupView = new UserLoginView();
            startupView.Show();
            this.Hide();
        }

        private void buttonsPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}