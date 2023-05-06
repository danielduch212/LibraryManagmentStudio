namespace LibraryManagementStudio.User.Views.UserLibraryView
{
    public partial class UserPickupAndReturnControl : UserControl
    {
        // private readonly Models.User _user;
        // private readonly BookStoreCodeService _bookStoreCodeService;
        // private List<BookStoreCode> _codes;
        // private List<BookStoreCode> _borrowedCodes;
        // private List<BookStoreCode> _returnCodes;

        public UserPickupAndReturnControl(/*Models.User user, BookStoreCodeService bookStoreCodeService*/)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            //
            // _user = user;
            // _bookStoreCodeService = bookStoreCodeService;
            // _codes = _bookStoreCodeService.GetBookStoreCodesForUser(_user.Id).ToList();

            SetupCodes();
            SetupPickupGridViewStyle();
            SetupReturnGridViewStyle();
        }

        public void SetupCodes()
        {
            // _borrowedCodes = _codes.Where(x => x.CodeType == Models.Enums.CodeType.odbior).ToList();
            //
            // var borrowedBindingList = new BindingList<BookStoreCode>(_borrowedCodes);
            // var codesBindingBorrow = new BindingSource(borrowedBindingList, null);
            //
            // getCodesDataGridView.DataSource = codesBindingBorrow;
            //
            // _returnCodes = _codes.Where(x => x.CodeType == Models.Enums.CodeType.zwrot).ToList();
            //
            // var returnBindingList = new BindingList<BookStoreCode>(_returnCodes);
            // var codesBindingReturn = new BindingSource(returnBindingList, null);
            //
            // returnCodesDataGridView.DataSource = codesBindingReturn;
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
