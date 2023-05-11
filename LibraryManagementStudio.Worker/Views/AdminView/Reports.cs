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
        }
    }
}
