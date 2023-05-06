using Autofac;
using LibraryManagementStudio.User.Dtos.User;
using LibraryManagementStudio.User.Services.Interfaces;

namespace LibraryManagementStudio.User.Views.UserLibraryView
{
    public partial class UserInfoControl : UserControl
    {
        private readonly UserDto _userDto;
        private readonly IUserBookBorrowService _userBookBorrowService;

        public UserInfoControl(UserDto userDto)
        {
            InitializeComponent();
            
            _userDto = userDto;
            
            var diContainer = UserDIConfig.Configure();
            _userBookBorrowService = diContainer.Resolve<IUserBookBorrowService>();

            ViewStyleHelper.MaximizeUserControl(this);
            SetupView();
        }

        void SetupView()
        {
            nameTextBox.Text = _userDto.FirstName;
            surnameTextBox.Text = _userDto.LastName;
            birthdateTextBox.Text = _userDto.DateOfBirth.ToString("dd/MM/yyyy");
            emailTextBox.Text = _userDto.EmailAddress;
            cityTextBox.Text = _userDto.City;
            streetTextBox.Text = _userDto.Street;
            CountryTextBox.Text = _userDto.Country;
            postalCodeTextBox.Text = _userDto.PostalCode;
            accountCreationDateTextBox.Text = _userDto.CreationDate.ToString("dd/MM/yyyy");
            
            var borrowsCount = _userBookBorrowService.GetBorrowedBooksCount(_userDto.UserId);
            currentBorrowsTextBox.Text = borrowsCount.ToString();
        }
    }
}
