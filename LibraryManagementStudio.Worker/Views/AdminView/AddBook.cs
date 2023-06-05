using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementStudio.Worker.Views.AdminView
{
    public partial class AddBook : UserControl
    {
        WorkerBookService bookService;
        PublisherAuthorService publisherAuthorService;
        LibraryManagementStudio.Data.Models.Worker worker;
        LibraryManagementStudio.Data.Models.Enums.CategoryType categoryType;
        public AddBook(LibraryDbContext dbContext, LibraryManagementStudio.Data.Models.Worker worker)
        {
            InitializeComponent();
            bookService = new WorkerBookService(dbContext);
            publisherAuthorService = new PublisherAuthorService(dbContext);
            this.worker= worker;
            panelNewPublisher.Visible = false;
            panelAuthor.Visible = false;
            SetData();
            panelContent.Visible = true;


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


            comboBoxCategory.Items.Add(LibraryManagementStudio.Data.Models.Enums.CategoryType.Romance);
            comboBoxCategory.Items.Add(LibraryManagementStudio.Data.Models.Enums.CategoryType.Fantasy);
            comboBoxCategory.Items.Add(LibraryManagementStudio.Data.Models.Enums.CategoryType.Bibliography);
            comboBoxCategory.Items.Add(LibraryManagementStudio.Data.Models.Enums.CategoryType.History);
            comboBoxCategory.Items.Add(LibraryManagementStudio.Data.Models.Enums.CategoryType.Thriller);

        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (textTitle.Text != "" && (comboBoxAuthor.SelectedIndex != -1) && (comboBoxAuthor.SelectedIndex != -1) && (comboBoxPublisher.SelectedIndex != -1))
            {
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
                
                int copyCounts = Int32.Parse(textBoxCopies.Text);
                ICollection<BookCopy> bookCopies= new List<BookCopy>();
                
                Book book = new Book()
                {
                    IsActive = true,
                    Title = textTitle.Text,
                    Description = descriptionTextBox.Text,
                    PublishDate = dataTimePicker.Value,
                    Category = categoryType,
                    Author = publisherAuthorService.GetAuthor(comboBoxAuthor.Text),
                    Publisher = publisherAuthorService.GetPublisher(comboBoxPublisher.Text),
                    Worker = worker,
                    WorkerId = worker.WorkerId,
                    BookCopies = bookCopies,
                };
                bookService.AddBook(book);

                for (int i = 0; i < copyCounts; i++)
                {
                    BookCopy bookCopy = new BookCopy()
                    {
                        IsAvailable = true,
                        IsActive = true,
                        Status = Data.Models.Enums.BookCopyStatus.dobry,
                        BookBorrows = new List<BookBorrow>(),
                        Book = book,
                        BookId = book.BookId,
                    };
                    bookService.AddBookCopy(bookCopy);
                }

                comboBoxAuthor.SelectedIndex = -1;
                comboBoxPublisher.SelectedIndex = -1;
                textTitle.Text = "";

                MessageBox.Show("Dodano ksiazke", "Informacja");
            }
            else
            {
                MessageBox.Show("Brakuje danych!", "Ostrzezenie");

            }
        }

        private void anotherAuthorButton_Click(object sender, EventArgs e)
        {
            SetPanelLocation(panelAuthor);
            panelNewPublisher.Visible= false;
            panelAuthor.Visible = true;
            
        }

        private void anotherPublisherButton_Click(object sender, EventArgs e)
        {
            comboBoxPublisher.Items.Clear();
            SetPanelLocation(panelNewPublisher);
            panelAuthor.Visible = false;
            panelNewPublisher.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBoxNewAuthor.Text != "")
            {
                comboBoxAuthor.Items.Clear();
                publisherAuthorService.AddAuthor(textBoxNewAuthor.Text);
                panelAuthor.Visible = false;
                SetData();
            }
        }

        private void buttonNewPublisher_Click(object sender, EventArgs e)
        {
            if (textBoxNewPublisher.Text != "")
            {
                publisherAuthorService.AddPublisher(textBoxNewPublisher.Text);
                panelNewPublisher.Visible = false;
                SetData();
            }

        }

        private void cancelNewPublisher_Click(object sender, EventArgs e)
        {
            panelNewPublisher.Visible=false;
        }

        private void cancelNewAuthor_Click(object sender, EventArgs e)
        {
            panelAuthor.Visible = false;
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
