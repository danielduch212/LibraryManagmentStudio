using LibraryManagementStudio.Data;
using LibraryManagementStudio.Worker.Dtos.Penalty;
using LibraryManagementStudio.Worker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementStudio.Worker.Views.AdminView
{
    public partial class Penalties : UserControl
    {
        WorkerPenaltyService service;
        LibraryManagementStudio.Data.Models.Worker worker;
        public Penalties(LibraryDbContext dbContext, Data.Models.Worker worker)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            service = new WorkerPenaltyService(dbContext);
            LoadNotPaidPenalties();
            this.worker = worker;
        }

        private void LoadNotPaidPenalties()
        {
            var penalties = service.GetNotPaidPenalties();
            var bindingList = new BindingList<PenaltyDto>(penalties);
            var bindingSource = new BindingSource(bindingList, null);

            penaltyGridView.DataSource = bindingSource;

            penaltyGridView.Columns["PenaltyId"]!.HeaderText = "Id";
            penaltyGridView.Columns["PenaltyId"]!.Width = 10;
            penaltyGridView.Columns["WorkerId"]!.HeaderText = "Id Pracownika";
            penaltyGridView.Columns["WorkerId"]!.Width = 15;
            penaltyGridView.Columns["UserId"]!.HeaderText = "Id Użytkownika";
            penaltyGridView.Columns["UserId"]!.Width = 15;
            penaltyGridView.Columns["UserFirstName"]!.HeaderText = "Imie";
            penaltyGridView.Columns["UserFirstName"]!.Width = 25;
            penaltyGridView.Columns["UserLastName"]!.HeaderText = "Nazwisko";
            penaltyGridView.Columns["UserLastName"]!.Width = 25;
            penaltyGridView.Columns["BookTitle"]!.HeaderText = "Ksiazka";
            penaltyGridView.Columns["BookTitle"]!.Width = 25;
            penaltyGridView.Columns["Description"]!.HeaderText = "Opis";
            penaltyGridView.Columns["Description"]!.Width = 25;
            penaltyGridView.Columns["Price"]!.HeaderText = "Cena";
            penaltyGridView.Columns["Price"]!.Width = 25;
            penaltyGridView.Columns["BookBorrowId"]!.HeaderText = "Id Wypozyczenia";
            penaltyGridView.Columns["BookBorrowId"]!.Width = 10;
            penaltyGridView.Columns["IsPaid"]!.HeaderText = "Zapłacone";
            penaltyGridView.Columns["IsPaid"]!.Width = 10;
            penaltyGridView.BackgroundColor = Color.White;
            penaltyGridView.RowHeadersVisible = false;

        }

        private void LoadPaidPenalties()
        {
            var penalties = service.GetPaidPenalties();
            var bindingList = new BindingList<PenaltyDto>(penalties);
            var bindingSource = new BindingSource(bindingList, null);

            penaltyGridView.DataSource = bindingSource;

            penaltyGridView.Columns["PenaltyId"]!.HeaderText = "Id";
            penaltyGridView.Columns["PenaltyId"]!.Width = 10;
            penaltyGridView.Columns["WorkerId"]!.HeaderText = "Id Pracownika";
            penaltyGridView.Columns["WorkerId"]!.Width = 15;
            penaltyGridView.Columns["UserId"]!.HeaderText = "Id Użytkownika";
            penaltyGridView.Columns["UserId"]!.Width = 15;
            penaltyGridView.Columns["UserFirstName"]!.HeaderText = "Imie";
            penaltyGridView.Columns["UserFirstName"]!.Width = 25;
            penaltyGridView.Columns["UserLastName"]!.HeaderText = "Nazwisko";
            penaltyGridView.Columns["UserLastName"]!.Width = 25;
            penaltyGridView.Columns["BookTitle"]!.HeaderText = "Ksiazka";
            penaltyGridView.Columns["BookTitle"]!.Width = 25;
            penaltyGridView.Columns["Description"]!.HeaderText = "Opis";
            penaltyGridView.Columns["Description"]!.Width = 25;
            penaltyGridView.Columns["Price"]!.HeaderText = "Cena";
            penaltyGridView.Columns["Price"]!.Width = 25;
            penaltyGridView.Columns["BookBorrowId"]!.HeaderText = "Id Wypozyczenia";
            penaltyGridView.Columns["BookBorrowId"]!.Width = 10;
            penaltyGridView.Columns["IsPaid"]!.HeaderText = "Zapłacone";
            penaltyGridView.Columns["IsPaid"]!.Width = 10;
            penaltyGridView.BackgroundColor = Color.White;
            penaltyGridView.RowHeadersVisible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Aktualne";
            LoadNotPaidPenalties();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Zaplacone";
            LoadPaidPenalties();
        }
    }
}
