using LibraryManagementStudio.User.Dtos.User;

namespace LibraryManagementStudio.User.Views.UserAuthView
{
    public partial class UserBankLoginView : Form
    {
        private readonly CreateUserDto _userToCreateDto;

        public UserBankLoginView(Image image, Color color, CreateUserDto userToCreateDto)
        {
            InitializeComponent();

            _userToCreateDto = userToCreateDto;
            
            pictureBox1.BackgroundImage = image;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            panelLeft.BackColor = color;
            panelRight.BackColor = color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") 
                return;
            
            var successRegistrationView = new UserSuccessfulRegistrationView(_userToCreateDto);
            successRegistrationView.Show();
            this.Hide();
        }
    }
}
