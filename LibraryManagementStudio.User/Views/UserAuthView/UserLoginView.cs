using LibraryManagementStudio.Data;
using LibraryManagementStudio.User.Services;
using LibraryManagementStudio.User.Views.UserLibraryView;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.User.Views.UserAuthView
{
    public partial class UserLoginView : Form
    {
        private readonly LibraryDbContext _dbContext;
        private readonly UserAuthService _userAuthService;

        public UserLoginView(LibraryDbContext dbContext)
        {
            InitializeComponent();

            _dbContext = dbContext;
            _userAuthService = new UserAuthService(dbContext);

            alertLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alertLabel.Visible = false;

            if (emailTextBox.Text != null && passwordTextBox.Text != null)
            {
                var validatedCredentials = _userAuthService.ValidateCredentials(emailTextBox.Text, passwordTextBox.Text);
                //var validatedCredentials = true;

                if (validatedCredentials)
                {
                    UserView userView = new UserView();
                    userView.Show();
                    this.Hide();
                }
                else
                {
                    alertLabel.Visible = true;
                }
            }
            else
            {
                alertLabel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var registrationView = new UserRegistrationView(_dbContext);
            registrationView.Show();
            this.Hide();
        }
    }
}
