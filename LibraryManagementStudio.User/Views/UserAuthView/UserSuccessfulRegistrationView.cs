using Autofac;
using LibraryManagementStudio.Data;
using LibraryManagementStudio.User.Dtos.User;
using LibraryManagementStudio.User.Services;
using LibraryManagementStudio.User.Services.Interfaces;

namespace LibraryManagementStudio.User.Views.UserAuthView
{
    public partial class UserSuccessfulRegistrationView : Form
    {
        public UserSuccessfulRegistrationView(CreateUserDto userToCreateDto)
        {
            InitializeComponent();
            
            var diContainer = UserDIConfig.Configure();
            var userAuthService = diContainer.Resolve<IUserAuthService>();

            labelName.Text = userToCreateDto.FirstName;
            labelSurname.Text = userToCreateDto.LastName;
            labelEmail.Text = userToCreateDto.EmailAddress;

            userAuthService.CreateUser(userToCreateDto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLoginView userLoginView = new UserLoginView();
            userLoginView.Show();
            this.Hide();
        }
    }
}
