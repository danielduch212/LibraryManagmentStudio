using Autofac;
using LibraryManagementStudio.Worker.Dtos.BookBorrow;
using LibraryManagementStudio.Worker.Dtos.Penalty;
using LibraryManagementStudio.Worker.Services.Intrefaces;

namespace LibraryManagementStudio.Worker.Views.ParcelMaintenanceView
{
    public partial class AddPenaltyControl : UserControl
    {
        private readonly IWorkerPenaltyService _workerPenaltyService;
        private readonly Panel _contentPanel;
        private readonly BookBorrowDto _bookBorrowDto;

        public AddPenaltyControl(Panel contentPanel, BookBorrowDto bookBorrowDto)
        {
            InitializeComponent();

            _contentPanel = contentPanel;
            _bookBorrowDto = bookBorrowDto;
            
            UserCodeTB.Text = _bookBorrowDto.UserEmailAddress;
            bookCodeTB.Text = $@"#{_bookBorrowDto.BookCopyId} - {_bookBorrowDto.BookTitle}";

            var diContainer = WorkerDIConfig.Configure();
            _workerPenaltyService = diContainer.Resolve<IWorkerPenaltyService>();

            ViewStyleHelper.MaximizeUserControl(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var createPenaltyDto = new CreatePenaltyDto()
            {
                BookBorrowId = _bookBorrowDto.BookBorrowId,
                IsPaid = false,
                Description = descriptionTB.Text,
                Price = double.Parse(priceTB.Text),
                WorkerId = 1
            };

            _workerPenaltyService.CreatePenalty(createPenaltyDto);

            ViewStyleHelper.AddControlToPanel(new AcceptBookReturnControl(_contentPanel), _contentPanel);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ViewStyleHelper.AddControlToPanel(new AcceptBookReturnControl(_contentPanel), _contentPanel);
        }
    }
}
