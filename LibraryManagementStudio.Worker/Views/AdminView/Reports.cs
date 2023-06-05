using LibraryManagementStudio.Data;
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
        LibraryManagementStudio.Data.Models.Worker worker;
        LibraryDbContext dbContext;
        public Reports(Data.Models.Worker worker, LibraryDbContext dbContext)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            this.dbContext = dbContext;
            this.worker = worker;
            panelSelect1.Visible = false;
            panelSelect2.Visible = false;
            dataGridView.Visible = false;
        }

        private void buttonRaport1_Click(object sender, EventArgs e)
        {
            panelSelect1.Visible = true;
            panelSelect2.Visible = false;
            dataGridView.Visible = false;

        }

        private void buttonRaport2_Click(object sender, EventArgs e)
        {
            panelSelect2.Visible = true;
            panelSelect1.Visible = false;
            dataGridView.Visible = false;
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
    }
}
