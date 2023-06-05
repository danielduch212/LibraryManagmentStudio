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
        List<PenaltyDto> penalties;

        bool statusOfPayment;
        public Penalties(LibraryDbContext dbContext, Data.Models.Worker worker)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            service = new WorkerPenaltyService(dbContext);
            labelStatus.Text = "Aktualne";
            statusOfPayment = false;
            penalties = service.GetPenalties(statusOfPayment);
            LoadView();
            panelErasePenalty.Visible = false;
            this.worker = worker;
        }

        private void LoadView()
        {
            
            var bindingList = new BindingList<PenaltyDto>(penalties);
            var bindingSource = new BindingSource(bindingList, null);

            penaltyGridView.DataSource = bindingSource;

            penaltyGridView.Columns["PenaltyId"]!.HeaderText = "Id";
            //penaltyGridView.Columns["PenaltyId"]!.Width = 10;
            penaltyGridView.Columns["WorkerId"]!.HeaderText = "Id Pracownika";
            //penaltyGridView.Columns["WorkerId"]!.Width = 15;
            penaltyGridView.Columns["UserId"]!.HeaderText = "Id Użytkownika";
            //penaltyGridView.Columns["UserId"]!.Width = 15;
            penaltyGridView.Columns["UserFirstName"]!.HeaderText = "Imie";
            //penaltyGridView.Columns["UserFirstName"]!.Width = 25;
            penaltyGridView.Columns["UserLastName"]!.HeaderText = "Nazwisko";
            //penaltyGridView.Columns["UserLastName"]!.Width = 25;
            penaltyGridView.Columns["BookTitle"]!.HeaderText = "Ksiazka";
            //penaltyGridView.Columns["BookTitle"]!.Width = 25;
            penaltyGridView.Columns["Description"]!.HeaderText = "Opis";
            //penaltyGridView.Columns["Description"]!.Width = 25;
            penaltyGridView.Columns["Price"]!.HeaderText = "Cena";
            //penaltyGridView.Columns["Price"]!.Width = 25;
            penaltyGridView.Columns["BookBorrowId"]!.HeaderText = "Id Wypozyczenia";
            //penaltyGridView.Columns["BookBorrowId"]!.Width = 10;
            penaltyGridView.Columns["IsPaid"]!.HeaderText = "Zapłacone";
            //penaltyGridView.Columns["IsPaid"]!.Width = 10;
            penaltyGridView.BackgroundColor = Color.White;
            penaltyGridView.RowHeadersVisible = false;

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            statusOfPayment = false;
            labelStatus.Text = "Aktualne";
            LoadView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            statusOfPayment = true;
            labelStatus.Text = "Zaplacone";
            LoadView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //searchButton
            penalties = service.GetPenaltyByEmail(searchBooksTextBox.Text, statusOfPayment).ToList();
            LoadView();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(penaltyGridView.SelectedRows.Count > 0)
            {
                SetPanelLocation(panelErasePenalty);
                panelErasePenalty.Visible = true;
            }
        }

        private void eraseNo_Click(object sender, EventArgs e)
        {
            panelErasePenalty.Visible = false;
        }

        private void eraseYes_Click(object sender, EventArgs e)
        {
            if(penaltyGridView.SelectedRows.Count > 0)
            {
                if (penaltyGridView.SelectedRows.ToString() == null) { return; }
                string data = penaltyGridView.SelectedRows.ToString();
                if (data == null) { return; }
                service.ErasePenalty(service.getPenaltyFromString(data));
                panelErasePenalty.Visible = false;
                penalties = service.GetPenalties(statusOfPayment);
                LoadView();
            }
            
        }

        private void SetPanelLocation(Panel panelToSetLocation)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int panelWidth = panelToSetLocation.Width;
            int panelHeight = panelToSetLocation.Height;

            // Ustaw położenie panelu na środku formularza
            panelToSetLocation.Location = new Point((formWidth - panelWidth) / 2, (formHeight - panelHeight) / 2);

        }
    }
}
