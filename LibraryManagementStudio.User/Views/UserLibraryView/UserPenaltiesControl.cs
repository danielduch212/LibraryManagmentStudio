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
            returnCodesDataGridView.DataSource = paidBindingSource;
    
            _unPaidPenalties = _userPenaltyService.GetPenalties(_userDto.UserId, false).ToList();
            var unPaidBindingList = new BindingList<PenaltyDto>(_unPaidPenalties);
            var unPaidBindingSource = new BindingSource(unPaidBindingList, null);
            getCodesDataGridView.DataSource = unPaidBindingSource;
        }

        private void SetupPickupGridViewStyle()
        {
            getCodesDataGridView.Columns["ImpositionDate"].Visible = false;

            getCodesDataGridView.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            getCodesDataGridView.Columns["Description"].HeaderText = "Opis";
            
            getCodesDataGridView.Columns["PenaltyId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            getCodesDataGridView.Columns["PenaltyId"].HeaderText = "Id";
            
            getCodesDataGridView.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            getCodesDataGridView.Columns["Price"].HeaderText = "Koszt";      
            
            getCodesDataGridView.Columns["BookTitle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            getCodesDataGridView.Columns["BookTitle"].HeaderText = "Tytuł książki";
            
            getCodesDataGridView.RowHeadersVisible = false;
        }

        private void SetupReturnGridViewStyle()
        {
            returnCodesDataGridView.Columns["ImpositionDate"].Visible = false;

            returnCodesDataGridView.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            returnCodesDataGridView.Columns["Description"].HeaderText = "Opis";
            
            returnCodesDataGridView.Columns["PenaltyId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            returnCodesDataGridView.Columns["PenaltyId"].HeaderText = "Id";
            
            returnCodesDataGridView.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            returnCodesDataGridView.Columns["Price"].HeaderText = "Koszt";      
            
            returnCodesDataGridView.Columns["BookTitle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            returnCodesDataGridView.Columns["BookTitle"].HeaderText = "Tytuł książki";
            
            returnCodesDataGridView.RowHeadersVisible = false;
        }
    }
}
