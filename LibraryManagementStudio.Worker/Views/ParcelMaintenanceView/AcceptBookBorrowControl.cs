using System.ComponentModel;
using Autofac;
using LibraryManagementStudio.Worker.Dtos.BookBorrow;
using LibraryManagementStudio.Worker.Services.Intrefaces;

namespace LibraryManagementStudio.Worker.Views.ParcelMaintenanceView
{
    public partial class AcceptBookBorrowControl : UserControl
    {
        private readonly IWorkerBookBorrowService _workerBookBorrowService;

        public AcceptBookBorrowControl()
        {
            InitializeComponent();

            var diContainer = WorkerDIConfig.Configure();
            _workerBookBorrowService = diContainer.Resolve<IWorkerBookBorrowService>();

            ViewStyleHelper.MaximizeUserControl(this);
            LoadBookBorrowRequests();
        }

        private void LoadBookBorrowRequests()
        {
            var books = _workerBookBorrowService.GetBorrowedBooks();
            var bindingList = new BindingList<BookBorrowDto>(books);
            var bindingSource = new BindingSource(bindingList, null);

            bookListGridView.DataSource = bindingSource;

            bookListGridView.Columns["BookBorrowId"]!.Visible = false;

            bookListGridView.Columns["BookCopyId"]!.HeaderText = "Numer egzemplarza";
            bookListGridView.Columns["BookCopyId"]!.Width = 200;

            bookListGridView.Columns["BookTitle"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookListGridView.Columns["BookTitle"]!.HeaderText = "Tytuł książki";

            bookListGridView.Columns["UserEmailAddress"]!.Width = 250;
            bookListGridView.Columns["UserEmailAddress"]!.HeaderText = "Adres email użytkownika";

            bookListGridView.BackgroundColor = Color.White;
            bookListGridView.RowHeadersVisible = false;
        }

        private void AcceptBookButton_Click(object sender, EventArgs e)
        {
            if (bookListGridView.CurrentRow == null)
                return;

            var selectedBook = (BookBorrowDto)bookListGridView.CurrentRow.DataBoundItem;

            _workerBookBorrowService.AcceptBookBorrow(selectedBook.BookBorrowId);
            LoadBookBorrowRequests();
        }
    }
}
