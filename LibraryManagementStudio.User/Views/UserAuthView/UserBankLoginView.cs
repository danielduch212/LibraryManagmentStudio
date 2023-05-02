using LibraryManagementStudio.Data;
using LibraryManagementStudio.User.Dtos.User;

namespace LibraryManagementStudio.User.Views.UserAuthView
{
    public partial class UserBankLoginView : Form
    {
        private readonly LibraryDbContext _dbContext;
        private readonly CreateUserDto _userToCreateDto;

        public UserBankLoginView(LibraryDbContext dbContext, Image image, Color color, CreateUserDto userToCreateDto)
        {
            InitializeComponent();

            _userToCreateDto = userToCreateDto;
            _dbContext = dbContext;
            
            pictureBox1.BackgroundImage = image;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            panelLeft.BackColor = color;
            panelRight.BackColor = color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") 
                return;
            
            var successRegistrationView = new UserSuccessfulRegistrationView(_dbContext, _userToCreateDto);
            successRegistrationView.Show();
            this.Hide();
        }
    }
}
