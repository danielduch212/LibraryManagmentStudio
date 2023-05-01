﻿using LibraryManagementStudio.User.Dtos.Book;
using LibraryManagementStudio.User.Services;

namespace LibraryManagementStudio.User.Views.UserView
{
    public partial class UserBookInfoControl : UserControl
    {
        private Panel _contentPanel;
        private UserBookService _userBookService;

        public UserBookInfoControl(Panel contentPanel, UserBookService userBookService, BookDto bookDto)
        {
            InitializeComponent();

            _contentPanel = contentPanel;
            _userBookService = userBookService;

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
            var control = new UserBookListControl(_contentPanel, _userBookService);
            ViewStyleHelper.AddControlToPanel(control, _contentPanel);
        }
    }
}
