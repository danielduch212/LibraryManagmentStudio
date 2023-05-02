using LibraryManagementStudio.Data;
using LibraryManagementStudio.User.Dtos.User;
using LibraryManagementStudio.User.Services;

namespace LibraryManagementStudio.User.Views.UserAuthView
{
    public partial class UserSuccessfulRegistrationView : Form
    {
        private readonly LibraryDbContext _dbContext;

        public UserSuccessfulRegistrationView(LibraryDbContext dbContext, CreateUserDto userToCreateDto)
        {
            InitializeComponent();
            
            var userAuthService = new UserAuthService(dbContext);
            _dbContext = dbContext;
            
            labelName.Text = userToCreateDto.FirstName;
            labelSurname.Text = userToCreateDto.LastName;
            labelEmail.Text = userToCreateDto.EmailAddress;

            userAuthService.CreateUser(userToCreateDto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLoginView userLoginView = new UserLoginView(_dbContext);
            userLoginView.Show();
            this.Hide();
        }
    }
}
