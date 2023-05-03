using LibraryManagementStudio.Data;
using LibraryManagementStudio.User.Dtos.User;

namespace LibraryManagementStudio.User.Views.UserAuthView
{
    public partial class UserBankChoiceView : Form
    {
        private readonly CreateUserDto _userToCreateDto;
        private Image? _image;
        private Color? _color;

        public UserBankChoiceView(CreateUserDto userToCreateDto)
        {
            InitializeComponent();
            
            _userToCreateDto = userToCreateDto;

            ClearPanels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearPanels();
            panelPko.Visible = true;
            _image = buttonPko.BackgroundImage;
            _color = Color.Blue;

        }

        private void buttonAlior_Click(object sender, EventArgs e)
        {
            ClearPanels();
            panelAlior.Visible = true;
            _image = buttonAlior.BackgroundImage;
            _color = Color.DeepPink;
        }

        private void buttonAgricole_Click(object sender, EventArgs e)
        {
            ClearPanels();
            panelAgricole.Visible = true;
            _image = buttonAgricole.BackgroundImage;
            _color = Color.ForestGreen;
        }

        private void buttonIng_Click(object sender, EventArgs e)
        {
            ClearPanels();
            panelIng.Visible = true;
            _image = buttonIng.BackgroundImage;
            _color = Color.Orange;
        }

        private void buttonMbank_Click(object sender, EventArgs e)
        {
            ClearPanels();
            panelMbank.Visible = true;
            _image = buttonMbank.BackgroundImage;
            _color = Color.White;

        }

        private void buttonMillenium_Click(object sender, EventArgs e)
        {
            ClearPanels();
            panelMillenium.Visible = true;
            _image = buttonMillenium.BackgroundImage;
            _color = Color.Pink;
        }

        private void buttonPekao_Click(object sender, EventArgs e)
        {
            ClearPanels();
            panelPekao.Visible = true;
            _image = buttonPekao.BackgroundImage;
            _color = Color.Red;
        }

        private void buttonReiffeisen_Click(object sender, EventArgs e)
        {
            ClearPanels();
            panelRaiffeisen.Visible = true;
            _image = buttonReiffeisen.BackgroundImage;
            _color = Color.Yellow;
        }

        private void buttonSantander_Click(object sender, EventArgs e)
        {
            ClearPanels();
            panelSantander.Visible = true;
            _image = buttonSantander.BackgroundImage;
            _color = Color.Red;
        }

        private void buttonTmobile_Click(object sender, EventArgs e)
        {
            ClearPanels();
            panelTmobile.Visible = true;
            _image = buttonTmobile.BackgroundImage;
            _color = Color.Pink;
        }


        private void buttonDalej_Click(object sender, EventArgs e)
        {
            if (_image != null && _color != null)
            {
                var bankLoginView = new UserBankLoginView(_image, _color.Value, _userToCreateDto);
                bankLoginView.Show();
                this.Hide();
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            var loginView = new UserLoginView();
            loginView.Show();
            this.Hide();
        }

        private void ClearPanels()
        {
            panelPko.Visible = false;
            panelAgricole.Visible = false;
            panelAlior.Visible = false;
            panelIng.Visible = false;
            panelMbank.Visible = false;
            panelMillenium.Visible = false;
            panelPekao.Visible = false;
            panelRaiffeisen.Visible = false;
            panelSantander.Visible = false;
            panelTmobile.Visible = false;
        }
    }
}
