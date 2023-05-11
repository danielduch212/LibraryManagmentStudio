using System.ComponentModel;
using Autofac;
using LibraryManagementStudio.User.Dtos.Penalty;
using LibraryManagementStudio.User.Dtos.User;
using LibraryManagementStudio.User.Services.Interfaces;

namespace LibraryManagementStudio.User.Views.UserLibraryView
{
    public partial class UserPenaltiesControl : UserControl
    {
        private readonly UserDto _userDto;
        private readonly IUserPenaltyService _userPenaltyService;

        private List<PenaltyDto> _paidPenalties;
        private List<PenaltyDto> _unPaidPenalties;

        public UserPenaltiesControl(UserDto userDto)
        {
            InitializeComponent();
            
            _userDto = userDto;

            var diContainer = UserDIConfig.Configure();
            _userPenaltyService = diContainer.Resolve<IUserPenaltyService>();
            
            ViewStyleHelper.MaximizeUserControl(this);

            SetupPenalties();
            SetupPickupGridViewStyle();
            SetupReturnGridViewStyle();
        }

        private void SetupPenalties()
        {
            _paidPenalties = _userPenaltyService.GetPenalties(_userDto.UserId, true).ToList();
            var paidBindingList = new BindingList<PenaltyDto>(_paidPenalties);
            var paidBindingSource = new BindingSource(paidBindingList, null);
            getCodesDataGridView.DataSource = paidBindingSource;
            
            _unPaidPenalties = _userPenaltyService.GetPenalties(_userDto.UserId, false).ToList();
            var unPaidBindingList = new BindingList<PenaltyDto>(_unPaidPenalties);
            var unPaidBindingSource = new BindingSource(unPaidBindingList, null);
            returnCodesDataGridView.DataSource = unPaidBindingSource;
        }

        private void SetupPickupGridViewStyle()
        {
            // getCodesDataGridView.Columns["Id"].Visible = false;
            // getCodesDataGridView.Columns["UserId"].Visible = false;
            // getCodesDataGridView.Columns["CodeType"].Visible = false;
            // getCodesDataGridView.Columns["BorrowedBookId"].Visible = false;
            //
            // getCodesDataGridView.Columns["Code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // getCodesDataGridView.Columns["Code"].HeaderText = "Kod";
            //
            // getCodesDataGridView.Columns["BookName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // getCodesDataGridView.Columns["BookName"].HeaderText = "Tytuł książki";
            //
            // getCodesDataGridView.RowHeadersVisible = false;
        }

        private void SetupReturnGridViewStyle()
        {

            // returnCodesDataGridView.Columns["Id"].Visible = false;
            // returnCodesDataGridView.Columns["UserId"].Visible = false;
            // returnCodesDataGridView.Columns["CodeType"].Visible = false;
            // returnCodesDataGridView.Columns["BorrowedBookId"].Visible = false;
            //
            // returnCodesDataGridView.Columns["Code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // returnCodesDataGridView.Columns["Code"].HeaderText = "Kod";
            //
            // returnCodesDataGridView.Columns["BookName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // returnCodesDataGridView.Columns["BookName"].HeaderText = "Tytuł książki";
            //
            // returnCodesDataGridView.RowHeadersVisible = false;
        }
    }
}
