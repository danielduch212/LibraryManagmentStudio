namespace LibraryManagementStudio.Worker.Views.ParcelMaintenanceView
{
    public partial class ParcelMaintenanceMainView : Form
    {
        public ParcelMaintenanceMainView()
        {
            InitializeComponent();

            ViewStyleHelper.MaximizeForm(this);
            ViewStyleHelper.AddControlToPanel(new AcceptBookBorrowControl(), contentPanel);
            AcceptrRequest.BackColor = Color.White;
            AcceptReturn.BackColor = Color.Gray;
        }

        private void AcceptReturn_Click(object sender, EventArgs e)
        {
            ViewStyleHelper.AddControlToPanel(new AcceptBookBorrowControl(), contentPanel);

            AcceptrRequest.BackColor = Color.White;
            AcceptReturn.BackColor = Color.Gray;
        }

        private void AcceptrRequest_Click(object sender, EventArgs e)
        {
            ViewStyleHelper.AddControlToPanel(new AcceptBookReturnControl(contentPanel), contentPanel);

           
            AcceptrRequest.BackColor = Color.Gray;
            AcceptReturn.BackColor = Color.White;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
