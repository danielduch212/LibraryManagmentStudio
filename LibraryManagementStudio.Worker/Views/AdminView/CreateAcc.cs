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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementStudio.Worker.Views.AdminView
{
    public partial class CreateAcc : UserControl
    {
        LibraryManagementStudio.Data.Models.Worker worker;
        LibraryDbContext dbContext;
        LibraryManagementStudio.Data.Models.User? user;
        AdminUserService service;
        public CreateAcc(Data.Models.Worker worker, LibraryDbContext dbContext)
        {
            InitializeComponent();
            ViewStyleHelper.MaximizeUserControl(this);
            this.dbContext = dbContext;
            this.worker = worker;
            this.service = new AdminUserService(dbContext);
            
            alertLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alertLabel.Visible = false;
            if (textBoxName.Text != "" || textBoxSurname.Text != "" || textBoxEmail.Text != "" || textBoxCode.Text != "" || textBoxLocation.Text != "")
            {
                DateTime today = DateTime.Today;

                user = new User()
                {
                    FirstName = textBoxName.Text,
                    LastName = textBoxSurname.Text,
                    EmailAddress = textBoxEmail.Text,
                    Password = textBoxPassword.Text,
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
                MessageBox.Show("Dodano nowego uzytkownika", "Informacja");
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxEmail.Text = "";
                textBoxCity.Text = "";
                textBoxPassword.Text = "";
                textBoxCode.Text = "";
                textBoxLocation.Text = "";
            }
                
            else
            {
                alertLabel.Text = "Podane dane sa bledne!";
                alertLabel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void panelAutorize_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            alertLabel.Visible = false;
            if (textBoxName.Text != "" || textBoxSurname.Text != "" || textBoxEmail.Text != "" || textBoxCode.Text != "" || textBoxLocation.Text != "")
            {
                if(IsPostalCode(textBoxCode.Text) == false)
                {
                    MessageBox.Show("Nieprawidlowy kod pocztowy", "Ostrzezenie");
                    return;
                }
                if(IsEmail(textBoxEmail.Text) == false)
                {
                    MessageBox.Show("Nieprawidlowy email", "Ostrzezenie");
                    return;
                }

                var emailToCheck = service.getUserByEmail(textBoxEmail.Text);

                if(emailToCheck != null)
                {
                    MessageBox.Show("Uzytkownik o podanym adresie email juz istnieje", "Ostrzezenie");
                    return;
                }
                DateTime today = DateTime.Today;

                DialogResult result = MessageBox.Show("Autoryzuj Dane Użytkownika", "Sprawdź Dane", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    user = new User()
                    {
                        FirstName = textBoxName.Text,
                        LastName = textBoxSurname.Text,
                        EmailAddress = textBoxEmail.Text,
                        Password = textBoxPassword.Text,
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
                    MessageBox.Show("Dodano nowego uzytkownika", "Informacja");
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxEmail.Text = "";
                    textBoxCity.Text = "";
                    textBoxPassword.Text = "";
                    textBoxCode.Text = "";
                    textBoxLocation.Text = "";
                }
                else
                {
                    return;
                }

            }

                

            else
            {
                MessageBox.Show("Podane dane sa bledne", "Ostrzezenie");
            }
        }

        private bool IsEmail(string input)
        {
            // Wzorzec wyrażenia regularnego dla sprawdzania adresu e-mail
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Użycie klasy Regex do dopasowania wzorca
            Regex regex = new Regex(pattern);

            // Sprawdzenie, czy podany ciąg znaków pasuje do wzorca
            return regex.IsMatch(input);
        }

        static bool IsPostalCode(string input)
        {
            // Wzorzec wyrażenia regularnego dla sprawdzania adresu pocztowego
            string pattern = @"^\d{2}-\d{3}$";

            // Użycie klasy Regex do dopasowania wzorca
            Regex regex = new Regex(pattern);

            // Sprawdzenie, czy podany ciąg znaków pasuje do wzorca
            return regex.IsMatch(input);
        }
    }
}
