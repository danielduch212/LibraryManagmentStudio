using LibraryManagementStudio.User.Dtos.Book;
using LibraryManagementStudio.User.Dtos.User;

namespace LibraryManagementStudio.User.Views.UserLibraryView
{
    public partial class UserBookInfoControl : UserControl
    {
        private Panel _contentPanel;
        private UserDto _userDto;

        public UserBookInfoControl(Panel contentPanel, BookDto bookDto, UserDto userDto)
        {
            InitializeComponent();

            _contentPanel = contentPanel;
            _userDto = userDto;

            SetupView(bookDto);
            ViewStyleHelper.MaximizeUserControl(this);
        }

        private void SetupView(BookDto bookDto)
        {
            nameTB.Text = bookDto.Title;
            authorTB.Text = bookDto.AuthorName;
            descriptionTB.Text = bookDto.Description;
            categoryTB.Text = EnumDescriptor.GetEnumDescription(bookDto.Category);
            publishDateTB.Text = bookDto.PublishDate.ToString("dd-MM-yyyy");
            publisherTB.Text = bookDto.PublisherName;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var control = new UserBookListControl(_contentPanel, _userDto);
            ViewStyleHelper.AddControlToPanel(control, _contentPanel);
        }
    }
}
