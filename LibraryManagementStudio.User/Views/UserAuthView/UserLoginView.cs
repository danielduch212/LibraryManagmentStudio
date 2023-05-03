using Autofac;
using LibraryManagementStudio.User.Services;
using LibraryManagementStudio.User.Services.Interfaces;
using LibraryManagementStudio.User.Views.UserLibraryView;

namespace LibraryManagementStudio.User.Views.UserAuthView
{
    public partial class UserLoginView : Form
    {
        private readonly IUserAuthService _userAuthService;

        public UserLoginView()
        {
            InitializeComponent();

            var diContainer = UserDIConfig.Configure();
            _userAuthService = diContainer.Resolve<IUserAuthService>();
            alertLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alertLabel.Visible = false;

            if (emailTextBox.Text != null && passwordTextBox.Text != null)
            {
                var validatedCredentials = _userAuthService.ValidateCredentials(emailTextBox.Text, passwordTextBox.Text);
                //var validatedCredentials = true;

                if (validatedCredentials != null)
                {
                    UserView userView = new UserView(validatedCredentials);
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
            var userRegistrationView = new UserRegistrationView();
            userRegistrationView.Show();
            this.Hide();
        }
    }
}
