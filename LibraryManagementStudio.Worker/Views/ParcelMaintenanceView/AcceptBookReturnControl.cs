using System.ComponentModel;
using Autofac;
using LibraryManagementStudio.Worker.Dtos.BookBorrow;
using LibraryManagementStudio.Worker.Services.Intrefaces;

namespace LibraryManagementStudio.Worker.Views.ParcelMaintenanceView
{
    public partial class AcceptBookReturnControl : UserControl
    {
        private readonly IWorkerBookBorrowService _workerBookBorrowService;
        private readonly Panel _contentPanel;

        public AcceptBookReturnControl(Panel contentPanel)
        {
            InitializeComponent();

            var diContainer = WorkerDIConfig.Configure();
            _workerBookBorrowService = diContainer.Resolve<IWorkerBookBorrowService>();

            _contentPanel = contentPanel;

            ViewStyleHelper.MaximizeUserControl(this);
            LoadBookReturnRequests();
        }

        private void LoadBookReturnRequests()
        {
            var books = _workerBookBorrowService.GetReturnedBooks();
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

        private void acceptReturnBook_Click(object sender, EventArgs e)
        {
            if (bookListGridView.CurrentRow == null)
                return;

            var selectedBook = (BookBorrowDto)bookListGridView.CurrentRow.DataBoundItem;

            _workerBookBorrowService.AcceptBookReturn(selectedBook.BookBorrowId);
            LoadBookReturnRequests();
        }

        private void addPenaltyButton_Click(object sender, EventArgs e)
        {
            ViewStyleHelper.AddControlToPanel(new AddPenaltyControl(_contentPanel), _contentPanel);
        }
    }
}
