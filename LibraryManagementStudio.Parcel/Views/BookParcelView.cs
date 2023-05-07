namespace LibraryManagementStudio.Parcel.Views
{
    public partial class BookParcelView : Form
    {
        private readonly ParcelService _parcelService;

        public BookParcelView(ParcelService parcelService)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeForm(this);

            _parcelService = parcelService;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            var code = codeTextBox.Text;

            //TODO: code validation
            MessageBox.Show("Wyciągnij książkę z otwartej skrytki i naciśnij OK", "Odbiór", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var bookName = _parcelService.AcceptBookBorrow(code);
            
            if (bookName != null)
            {
                MessageBox.Show($"Książka {bookName} została odebrana", "Odbiór", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie udało się odebrać książki", "Odbiór", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            var code = codeTextBox.Text;

            //TODO: code validation
            MessageBox.Show("Umieść książkę w otwartej skrytce i naciśnij OK", "Zwrot", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var bookName = _parcelService.AcceptBookReturn(code);

            if (bookName != null)
            {
                MessageBox.Show($"Książka {bookName} została zwrócona", "Odbiór", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie udało się zwrócić książki", "Odbiór", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
