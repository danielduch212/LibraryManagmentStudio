using LibraryManagementStudio.Data;
using System;
using System.Timers;

namespace LibraryManagementStudio.Worker.Views.AdminView
{
    public partial class Main : Form
    {
        LibraryDbContext dbContext = new LibraryDbContext();
        public Main()
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeForm(this);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var control = new UsersList();
            ViewStyleHelper.AddControlToPanel(control, contentPanel);

        }

        private void bookStorageButton_Click(object sender, EventArgs e)
        {
            var control = new BookStorage();
            ViewStyleHelper.AddControlToPanel(control, contentPanel);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var control = new CreateAcc();
            ViewStyleHelper.AddControlToPanel(control, contentPanel);
            
        }

        private void PenaltiesButton_Click(object sender, EventArgs e)
        {
            var control = new Penalties(dbContext);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);
        }

        private void AddPenaltyButton_Click(object sender, EventArgs e)
        {
            var control = new AddPenalty();
            ViewStyleHelper.AddControlToPanel(control, contentPanel);
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            var control = new Reports();
            ViewStyleHelper.AddControlToPanel(control, contentPanel);
        }
    }
}
