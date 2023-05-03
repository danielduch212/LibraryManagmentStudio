using Autofac;
using LibraryManagementStudio.User.Dtos.User;
using LibraryManagementStudio.User.Services.Interfaces;

namespace LibraryManagementStudio.User.Views.UserAuthView
{
    public partial class UserRegistrationView : Form
    {
        private readonly IUserAuthService _userAuthService;

        public UserRegistrationView()
        {
            var diContainer = UserDIConfig.Configure();
            _userAuthService = diContainer.Resolve<IUserAuthService>();
            InitializeComponent();

            alertLabel.Visible = false;
        }

        private void backToLoginScreenButton_Click(object sender, EventArgs e)
        {
            var diContainer = UserDIConfig.Configure();
            var loginView = diContainer.Resolve<UserLoginView>();
            loginView.Show();
            this.Hide();
        }

        private void autorizeButton_Click(object sender, EventArgs e)
        {
            alertLabel.Visible = false;

            if (!CheckUserData())
                return;

            if (_userAuthService.FindUser(emailBox.Text) == false)
            {
                var userToCreate = new CreateUserDto()
                {
                    FirstName = nameBox.Text,
                    LastName = surnameBox.Text,
                    Password = passwordBox.Text,
                    EmailAddress = emailBox.Text,
                    DateOfBirth = dateOfBirthPicker.Value,
                    Street = streetBox.Text,
                    PostalCode = postalCodeBox.Text,
                    City = cityBox.Text,
                    Country = countryBox.Text,

                };
                
                var userBankChoiceView = new UserBankChoiceView(userToCreate);
                userBankChoiceView.Show();
                this.Hide();
            }
            else
            {
                alertLabel.Location = new Point(273, 180);
                alertLabel.Text = "Konto o podanym adresie email już istnieje";
                alertLabel.Visible = true;
            }
        }

        private bool CheckUserData()
        {
            if (nameBox.Text == "" || surnameBox.Text == "" || passwordBox.Text == "" || rePasswordBox.Text == "" || emailBox.Text == ""
                || reEmailBox.Text == "" || streetBox.Text == "" || postalCodeBox.Text == "" || cityBox.Text == "" || countryBox.Text == "")
            {
                alertLabel.Location = new Point(360, 180);
                alertLabel.Text = "Podaj wszystkie dane";
                alertLabel.Visible = true;

                return false;
            }

            if (passwordBox.Text != rePasswordBox.Text)
            {
                alertLabel.Location = new Point(319, 180);
                alertLabel.Text = "Podane hasła nie są takie same";
                alertLabel.Visible = true;

                return false;
            }

            if (emailBox.Text != reEmailBox.Text)
            {
                alertLabel.Location = new Point(287, 180);
                alertLabel.Text = "Podane adresy Email nie są takie same";
                alertLabel.Visible = true;

                return false;
            }

            return true;
        }
    }
}
