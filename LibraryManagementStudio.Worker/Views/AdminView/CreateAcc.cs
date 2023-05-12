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
    public partial class CreateAcc : UserControl
    {
        LibraryManagementStudio.Data.Models.Worker worker;
        LibraryDbContext dbContext;
        LibraryManagementStudio.Data.Models.User user;
        AdminUserService service;
        public CreateAcc(Data.Models.Worker worker, LibraryDbContext dbContext)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            this.dbContext = dbContext;
            this.worker = worker;
            this.service = new AdminUserService(dbContext);
            panelAutorize.Visible = false;
            alertLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alertLabel.Visible = false;
            if (textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxEmail.Text != "" && textBoxCode.Text != "" && textBoxLocation.Text != "")
                panelAutorize.Visible = true;
            else
            {
                alertLabel.Text = "Podane dane sa bledne!";
                alertLabel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelAutorize.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxEmail.Text != "" && textBoxCode.Text !="" && textBoxLocation.Text != "" )
            {
                DateTime today = DateTime.Today;
                user = new User()
                {
                    FirstName = textBoxName.Text,
                    LastName = textBoxSurname.Text,
                    EmailAddress= textBoxEmail.Text,
                    Password= textBoxPassword.Text,
                    DateOfBirth = dateTimePicker.Value,
                    Street = textBoxLocation.Text,
                    City = textBoxCity.Text,
                    PostalCode = textBoxCode.Text,
                    Country = "Polska",
                    CreationDate = today,
                    WorkerId = worker.WorkerId,
                    Worker = worker,



                };
                service.CreateUser(user);
                panelAutorize.Visible = false;
            }
            
        }
    }
}
