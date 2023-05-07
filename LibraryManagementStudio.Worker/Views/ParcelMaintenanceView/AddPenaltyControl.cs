namespace LibraryManagementStudio.Worker.Views.ParcelMaintenanceView
{
    public partial class AddPenaltyControl : UserControl
    {

        // private LibraryDbContext Dodaniezgloszenia;
        // private BorrowedBookService BookService ;
        // private UserService NewService;
        // private LibraryManagement.App.Models.User user;


        private readonly Panel _contentPanel;

        public AddPenaltyControl(Panel contentPanel)
        {
            InitializeComponent();

            _contentPanel = contentPanel;

            ViewStyleHelper.MaximizeUserControl(this);

            // Dodaniezgloszenia = new LibraryDbContext();
            // BookService = new BorrowedBookService(Dodaniezgloszenia);
            // NewService = new UserService(Dodaniezgloszenia);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Old penalty logic

            // if (OpisUszkodzenia.Text != "" && KodKsiazki.Text != "" && RentierCode.Text != "")
            // {
            //
            //
            //     var zgloszenie = new LibraryManagement.App.Models.BrokenBookRegistration();
            //     zgloszenie.Description = OpisUszkodzenia.Text;
            //     zgloszenie.Code = KodKsiazki.Text;
            //     user = NewService.FindUser(Int32.Parse(RentierCode.Text));
            //     zgloszenie.UserId = user.Id;
            //     zgloszenie.userName = user.Name;
            //     zgloszenie.userSurname = user.Surname;
            //     Dodaniezgloszenia.RegistrationOfbrokenBooks.Add(zgloszenie);
            //     Dodaniezgloszenia.SaveChanges();
            //     MessageBox.Show("Zgłoszenie zostało dodane");
            //     KodKsiazki.Text = "";
            //     OpisUszkodzenia.Text = "";
            //     RentierCode.Text = "";
            // }
            // else {
            //
            //     MessageBox.Show("Pole nie może być puste");
            // }


            ViewStyleHelper.AddControlToPanel(new AcceptBookReturnControl(_contentPanel), _contentPanel);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ViewStyleHelper.AddControlToPanel(new AcceptBookReturnControl(_contentPanel), _contentPanel);
        }
    }
}
