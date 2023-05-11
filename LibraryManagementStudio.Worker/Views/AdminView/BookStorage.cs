using LibraryManagementStudio.Data;
using LibraryManagementStudio.Worker.Dtos.Book;
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
    public partial class BookStorage : UserControl
    {
        private WorkerBookService service;
        LibraryManagementStudio.Data.Models.Worker worker;
        public BookStorage(LibraryDbContext dbContext, Data.Models.Worker worker)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            service = new WorkerBookService(dbContext);
            LoadBooks();
            this.worker = worker;
        }

        private void LoadBooks()
        {
            var books = service.GetBooks();
            var bindingList = new BindingList<BookDto>(books);
            var bindingSource = new BindingSource(bindingList, null);

            bookDataGridView.DataSource = bindingSource;

            bookDataGridView.Columns["BookId"]!.HeaderText = "Id";
            bookDataGridView.Columns["BookId"]!.Width = 10;
            bookDataGridView.Columns["Title"]!.HeaderText = "Tytul";
            bookDataGridView.Columns["Title"]!.Width = 25;
            bookDataGridView.Columns["AuthorName"]!.HeaderText = "Autor";
            bookDataGridView.Columns["AuthorName"]!.Width = 20;
            bookDataGridView.Columns["PublisherName"]!.HeaderText = "Wydawnictwo";
            bookDataGridView.Columns["PublisherName"]!.Width = 25;
            bookDataGridView.Columns["Description"]!.HeaderText = "Opis";
            bookDataGridView.Columns["Description"]!.Width = 30;
            bookDataGridView.Columns["Category"]!.HeaderText = "Kategoria";
            bookDataGridView.Columns["Category"]!.Width = 15;
            bookDataGridView.Columns["PublishDate"]!.HeaderText = "Data wydania";
            bookDataGridView.Columns["PublishDate"]!.Width = 10;
            bookDataGridView.Columns["BookCopiesCount"]!.HeaderText = "Liczba kopii";
            bookDataGridView.Columns["BookCopiesCount"]!.Width = 10;
            bookDataGridView.Columns["AvailibleBookCopiesCount"]!.HeaderText = "Dostepne kopie";
            bookDataGridView.Columns["AvailibleBookCopiesCount"]!.Width = 10;
            bookDataGridView.BackgroundColor = Color.White;
            bookDataGridView.RowHeadersVisible = false;

        }



    }
}
