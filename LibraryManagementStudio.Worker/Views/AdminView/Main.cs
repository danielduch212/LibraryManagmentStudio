using LibraryManagementStudio.Data;
using System;
using System.Timers;

namespace LibraryManagementStudio.Worker.Views.AdminView
{
    public partial class Main : Form
    {
        LibraryDbContext dbContext;
        LibraryManagementStudio.Data.Models.Worker worker;

        public Main(LibraryManagementStudio.Data.Models.Worker worker, LibraryDbContext dbContext)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeForm(this);
            this.dbContext = dbContext;
            this.worker = worker;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var control = new UsersList(dbContext, worker);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);

        }

        private void bookStorageButton_Click(object sender, EventArgs e)
        {
            var control = new BookStorage(dbContext, worker);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var control = new CreateAcc(worker, dbContext);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);
            
        }

        private void PenaltiesButton_Click(object sender, EventArgs e)
        {
            var control = new Penalties(dbContext, worker);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);
        }

        private void AddPenaltyButton_Click(object sender, EventArgs e)
        {
            var control = new AddPenalty(worker, dbContext);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            var control = new Reports(worker, dbContext);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            var control = new AddBook(dbContext, worker);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var control = new Workers(dbContext, worker);
            ViewStyleHelper.AddControlToPanel(control, contentPanel);

        }
    }
}
