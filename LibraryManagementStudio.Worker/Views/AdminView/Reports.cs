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
            countTB.Visible = false;
            label11.Visible = false;
            panel2.Visible = false;
            SetData();
        }

        private void buttonRaport1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label11.Visible = false;
            countTB.Visible = false;
            panelSelect2.Visible = false;
            dataGridView.Visible = false;
            panelSelect1.Visible = true;
        }

        private void buttonRaport2_Click(object sender, EventArgs e)
        {

            panel2.Visible = false;
            panelSelect1.Visible = false;
            dataGridView.Visible = false;
            panelSelect2.Visible = true;
        }

        private void buttonGenerate1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerate2_Click(object sender, EventArgs e)
        {


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

        private void buttonRaport1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label11.Visible = false;
            countTB.Visible = false;
            panelSelect2.Visible = false;
            dataGridView.Visible = false;
            panelSelect1.Visible = true;
        }

        private void buttonRaport2_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panelSelect1.Visible = false;
            dataGridView.Visible = false;
            panelSelect2.Visible = true;
            countTB.Visible = false;
            label11.Visible = false;
        }

        private void textBoxUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGenerate1_Click_1(object sender, EventArgs e)
        {
            if (textBoxUserId.Text != "")
            {

                if (!int.TryParse(textBoxUserId.Text, out int number))
                {
                    MessageBox.Show("Podaj sensowne dane (liczba)", "Ostrzezenie");
                    return;

                }
                reportData1 = reportService.returnData(Int32.Parse(textBoxUserId.Text), dataTimePickerFrom.Value, dataTimePickerTo.Value);
                if (reportData1 == null)
                {
                    MessageBox.Show("Podaj sensowne dane", "Ostrzezenie");
                    return;
                }
                var bindingList = new BindingList<ReportData1>(reportData1);
                var bindingSource = new BindingSource(bindingList, null);

                dataGridView.DataSource = bindingSource;

                dataGridView.Columns["BookBorrowId"].HeaderText = "Id wypożyczenia";
                dataGridView.Columns["Title"].HeaderText = "Tytuł";
                dataGridView.Columns["Status"].HeaderText = "Status";
                dataGridView.Columns["UserId"].HeaderText = "Id Użytkownika";

                countTB.Visible = true;
                label11.Visible = true;
                countTB.Text = reportData1.Count.ToString();





                dataGridView.BackgroundColor = Color.White;
                dataGridView.RowHeadersVisible = false;
                panel2.Visible = true;
                dataGridView.Visible = true;
            }
            else
            {
                MessageBox.Show("Podaj sensowne dane (liczba)", "Ostrzezenie");

            }
        }

        private void buttonGenerate2_Click_1(object sender, EventArgs e)
        {
            if (comboBoxAvailibility.SelectedIndex != -1 || comboBoxCategory.SelectedIndex != -1 || comboBoxAuthor.SelectedIndex != -1 || comboBoxPublisher.SelectedIndex != -1)
            {
                categoryType = comboBoxCategory.Text switch
                {
                    "Romance" => CategoryType.Romance,
                    "Fantasy" => CategoryType.Fantasy,
                    "Bibliography" => CategoryType.Bibliography,
                    "History" => CategoryType.History,
                    "Thriller" => CategoryType.Thriller,
                    _ => categoryType
                };

                availibility = comboBoxAvailibility.Text switch
                {
                    "aktywne" => true,
                    "nieaktywne" => false,
                    _ => availibility
                };

                var author = reportService.findAuthor(comboBoxAuthor.Text);

                if (author == null)
                    return;

                var publisher = reportService.findPublisher(comboBoxPublisher.Text);

                if (publisher == null)
                    return;

                reportData2 = reportService.returnData(author, publisher, availibility, categoryType);
                reportData2 = reportService.returnData2(reportData2);
                var list = reportService.returnData3();
                reportData2 = reportService.returnData4(list, reportData2);

                if (reportData2 == null)
                    return;

                var bindingList = new BindingList<ReportData2>(reportData2);
                var bindingSource = new BindingSource(bindingList, null);
                dataGridView.DataSource = bindingSource;

                dataGridView.Columns["BookId"]!.HeaderText = "Id Ksiazki";
                dataGridView.Columns["Title"]!.HeaderText = "Tytul";
                dataGridView.Columns["Description"]!.HeaderText = "Opis";
                dataGridView.Columns["AllTimeBookBorrowsCount"]!.HeaderText = "Wszystkie wypozyczenia";

                dataGridView.BackgroundColor = Color.White;
                dataGridView.RowHeadersVisible = false;
                panel2.Visible = true;
                dataGridView.Visible = true;
            }
            else
            {
                MessageBox.Show("Podaj dokladnie dane", "Informacja");
            }

        }

        private void comboBoxPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRaport1_Click_2(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label11.Visible = false;
            countTB.Visible = false;
            panelSelect2.Visible = false;
            dataGridView.Visible = false;
            panelSelect1.Visible = true;
        }

        private void buttonRaport2_Click_2(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panelSelect1.Visible = false;
            dataGridView.Visible = false;
            panelSelect2.Visible = true;
        }

        private void buttonGenerate2_Click_2(object sender, EventArgs e)
        {
            if (comboBoxAvailibility.SelectedIndex != -1 || comboBoxCategory.SelectedIndex != -1 || comboBoxAuthor.SelectedIndex != -1 || comboBoxPublisher.SelectedIndex != -1)
            {
                categoryType = comboBoxCategory.Text switch
                {
                    "Romance" => CategoryType.Romance,
                    "Fantasy" => CategoryType.Fantasy,
                    "Bibliography" => CategoryType.Bibliography,
                    "History" => CategoryType.History,
                    "Thriller" => CategoryType.Thriller,
                    _ => categoryType
                };

                availibility = comboBoxAvailibility.Text switch
                {
                    "aktywne" => true,
                    "nieaktywne" => false,
                    _ => availibility
                };

                var author = reportService.findAuthor(comboBoxAuthor.Text);

                if (author == null)
                    return;

                var publisher = reportService.findPublisher(comboBoxPublisher.Text);

                if (publisher == null)
                    return;

                reportData2 = reportService.returnData(author, publisher, availibility, categoryType);
                reportData2 = reportService.returnData2(reportData2);
                var list = reportService.returnData3();
                reportData2 = reportService.returnData4(list, reportData2);

                if (reportData2 == null)
                    return;

                var bindingList = new BindingList<ReportData2>(reportData2);
                var bindingSource = new BindingSource(bindingList, null);
                dataGridView.DataSource = bindingSource;

                dataGridView.Columns["BookId"]!.HeaderText = "Id Ksiazki";
                dataGridView.Columns["Title"]!.HeaderText = "Tytul";
                dataGridView.Columns["Description"]!.HeaderText = "Opis";
                dataGridView.Columns["AllTimeBookBorrowsCount"]!.HeaderText = "Wszystkie wypozyczenia";

                dataGridView.BackgroundColor = Color.White;
                dataGridView.RowHeadersVisible = false;
                panel2.Visible = true;
                dataGridView.Visible = true;
            }
            else
            {
                MessageBox.Show("Podaj dokladnie dane", "Informacja");
            }
        }

        private void buttonGenerate1_Click_2(object sender, EventArgs e)
        {
            if (textBoxUserId.Text != "")
            {

                if (!int.TryParse(textBoxUserId.Text, out int number))
                {
                    MessageBox.Show("Podaj sensowne dane (liczba)", "Ostrzezenie");
                    return;

                }
                reportData1 = reportService.returnData(Int32.Parse(textBoxUserId.Text), dataTimePickerFrom.Value, dataTimePickerTo.Value);
                if (reportData1 == null)
                {
                    MessageBox.Show("Podaj sensowne dane", "Ostrzezenie");
                    return;
                }
                var bindingList = new BindingList<ReportData1>(reportData1);
                var bindingSource = new BindingSource(bindingList, null);

                dataGridView.DataSource = bindingSource;

                dataGridView.Columns["BookBorrowId"].HeaderText = "Id wypożyczenia";
                dataGridView.Columns["Title"].HeaderText = "Tytuł";
                dataGridView.Columns["Status"].HeaderText = "Status";
                dataGridView.Columns["UserId"].HeaderText = "Id Użytkownika";

                countTB.Visible = true;
                label11.Visible = true;
                countTB.Text = reportData1.Count.ToString();





                dataGridView.BackgroundColor = Color.White;
                dataGridView.RowHeadersVisible = false;
                panel2.Visible = true;
                dataGridView.Visible = true;
            }
            else
            {
                MessageBox.Show("Podaj sensowne dane (liczba)", "Ostrzezenie");

            }
        }
    }
}
