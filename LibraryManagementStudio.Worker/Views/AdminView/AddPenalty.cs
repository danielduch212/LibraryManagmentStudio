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

namespace LibraryManagementStudio.Worker.Views.AdminView
{
    public partial class AddPenalty : UserControl
    {
        LibraryDbContext dbContext;
        LibraryManagementStudio.Data.Models.Worker worker;
        WorkerBookService service;

        public AddPenalty(Data.Models.Worker worker, LibraryDbContext dbContext)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            this.service = new WorkerBookService(dbContext);
            this.dbContext = dbContext;
            this.worker = worker;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxBookBorrowId.Text.Length >0 && textBoxPrice.Text.Length >0 && textBoxDescription.Text.Length > 0)
            {

                var bookBorrow = service.getBookBorrow(Int32.Parse(textBoxBookBorrowId.Text));

                Penalty newPenalty = new Penalty()
                {



                };
            }
        }

        private void bookCodeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            textBoxDescription.Text = "";
            textBoxPrice.Text = "";
            textBoxBookBorrowId.Text = "";
        }
    }
}
