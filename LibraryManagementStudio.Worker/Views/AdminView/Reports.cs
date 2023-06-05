using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Data.Models.Enums;
using LibraryManagementStudio.Worker.Dtos.ReportData;
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
    public partial class Reports : UserControl
    {
        PublisherAuthorService publisherAuthorService;
        LibraryManagementStudio.Data.Models.Worker worker;
        ReportService reportService;
        LibraryDbContext dbContext;
        List<ReportData1>? reportData1;
        List<ReportData2>? reportData2;
        LibraryManagementStudio.Data.Models.Enums.CategoryType categoryType;
        bool availibility;
        public Reports(Data.Models.Worker worker, LibraryDbContext dbContext)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            this.publisherAuthorService = new PublisherAuthorService(dbContext);
            reportService = new ReportService(dbContext);
            
            this.dbContext = dbContext;
            this.worker = worker;
            panelSelect1.Visible = false;
            panelSelect2.Visible = false;
            dataGridView.Visible = false;
            SetData();
        }

        private void buttonRaport1_Click(object sender, EventArgs e)
        {
            
            panelSelect2.Visible = false;
            dataGridView.Visible = false;
            panelSelect1.Visible = true;
        }

        private void buttonRaport2_Click(object sender, EventArgs e)
        {
            
            panelSelect1.Visible = false;
            dataGridView.Visible = false;
            panelSelect2.Visible = true;
        }

        private void buttonGenerate1_Click(object sender, EventArgs e)
        {
            if(textBoxUserId.Text = "" )
            reportData1 = reportService.returnData(Int32.Parse(textBoxUserId.Text), dataTimePickerFrom.Value, dataTimePickerTo.Value);
            if(reportData1 == null)
            {
                return;
            }
            var bindingList = new BindingList<ReportData1>(reportData1);
            var bindingSource = new BindingSource(bindingList, null);

            dataGridView.DataSource = bindingSource;

            dataGridView.Columns["BookBorrowId"]!.HeaderText = "Id wypozyczenia";
            dataGridView.Columns["Title"]!.HeaderText = "Tytul";
            dataGridView.Columns["Status"]!.HeaderText = "Status";
            dataGridView.Columns["UserId"]!.HeaderText = "Id Uzytkownika";
            DataGridViewRow summaryRow = new DataGridViewRow();
            summaryRow.CreateCells(dataGridView);
            summaryRow.Cells[0].Value = "Ilosc wszystkich wypozyczonych ksiazek w podanym okresie: ";
            summaryRow.Cells[1].Value = reportData1.Count.ToString();

            dataGridView.Rows.Add(summaryRow);

            dataGridView.BackgroundColor = Color.White;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Visible = true;
        }

        private void buttonGenerate2_Click(object sender, EventArgs e)
        {
            if(comboBoxAvailibility.SelectedIndex != -1 || comboBoxCategory.SelectedIndex != -1 || comboBoxAuthor.SelectedIndex!= -1 || comboBoxPublisher.SelectedIndex != -1)
            {
                
                Author author;
                Publisher publisher;
                if (comboBoxCategory.Text == "Romance")
                    categoryType = LibraryManagementStudio.Data.Models.Enums.CategoryType.Romance;
                if (comboBoxCategory.Text == "Fantasy")
                    categoryType = LibraryManagementStudio.Data.Models.Enums.CategoryType.Fantasy;
                if (comboBoxCategory.Text == "Bibliography")
                    categoryType = LibraryManagementStudio.Data.Models.Enums.CategoryType.Bibliography;
                if (comboBoxCategory.Text == "History")
                    categoryType = LibraryManagementStudio.Data.Models.Enums.CategoryType.History;
                if (comboBoxCategory.Text == "Thriller")
                    categoryType = LibraryManagementStudio.Data.Models.Enums.CategoryType.Thriller;
                if (comboBoxAvailibility.Text == "aktywne")
                {
                    availibility = true;
                }
                if (comboBoxAvailibility.Text == "nieaktywne")
                {
                    availibility = false;
                }
                
                author = reportService.findAuthor(comboBoxAuthor.Text);
                if (author == null)
                {
                    return;
                }

                publisher = reportService.findPublisher(comboBoxPublisher.Text);
                if (publisher == null) { return; }
                reportData2 = reportService.returnData(author, publisher, availibility, categoryType);
                if(reportData2 == null) { return; }
                var bindingList = new BindingList<ReportData2>(reportData2);
                var bindingSource = new BindingSource(bindingList, null);

                dataGridView.DataSource = bindingSource;

                dataGridView.Columns["BookId"]!.HeaderText = "Id Ksiazki";
                dataGridView.Columns["Title"]!.HeaderText = "Tytul";
                dataGridView.Columns["Description"]!.HeaderText = "Opis";
                dataGridView.Columns["AllTimeBookBorrowsCount"]!.HeaderText = "Wszystkie wypozyczenia";

                dataGridView.BackgroundColor = Color.White;
                dataGridView.RowHeadersVisible = false;
                dataGridView.Visible = true;
            }
            

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SetData()
        {
            var queryAuthors = publisherAuthorService.getAuthorsNames();
            var queryPublishers = publisherAuthorService.getPublishersNames();
            foreach (string author in queryAuthors)
            {
                comboBoxAuthor.Items.Add(author);
            }
            foreach (string publisher in queryPublishers)
            {
                comboBoxPublisher.Items.Add(publisher);
            }
            comboBoxAvailibility.Items.Add("aktywne");
            comboBoxAvailibility.Items.Add("nieaktywne");

            comboBoxCategory.Items.Add(LibraryManagementStudio.Data.Models.Enums.CategoryType.Romance);
            comboBoxCategory.Items.Add(LibraryManagementStudio.Data.Models.Enums.CategoryType.Fantasy);
            comboBoxCategory.Items.Add(LibraryManagementStudio.Data.Models.Enums.CategoryType.Bibliography);
            comboBoxCategory.Items.Add(LibraryManagementStudio.Data.Models.Enums.CategoryType.History);
            comboBoxCategory.Items.Add(LibraryManagementStudio.Data.Models.Enums.CategoryType.Thriller);

        }
    }
}
