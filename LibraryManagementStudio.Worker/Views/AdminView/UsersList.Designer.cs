namespace LibraryManagementStudio.Worker.Views.AdminView
{
    partial class UsersList
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.showUserPanel = new System.Windows.Forms.Panel();
            this.labelAllBorrows = new System.Windows.Forms.Label();
            this.labelCUrrentBorrwedBooks = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.ReturnBook = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelShowDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showUserDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchBooksTextBox = new System.Windows.Forms.TextBox();
            this.searchBooksButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.showUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showUserDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.usersDataGridView);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1410, 581);
            this.panel2.TabIndex = 6;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(3, 0);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 25;
            this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGridView.Size = new System.Drawing.Size(1405, 581);
            this.usersDataGridView.TabIndex = 0;
            // 
            // showUserPanel
            // 
            this.showUserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showUserPanel.Controls.Add(this.labelAllBorrows);
            this.showUserPanel.Controls.Add(this.labelCUrrentBorrwedBooks);
            this.showUserPanel.Controls.Add(this.label11);
            this.showUserPanel.Controls.Add(this.label10);
            this.showUserPanel.Controls.Add(this.labelCity);
            this.showUserPanel.Controls.Add(this.labelEmail);
            this.showUserPanel.Controls.Add(this.labelSurname);
            this.showUserPanel.Controls.Add(this.labelUserName);
            this.showUserPanel.Controls.Add(this.ReturnBook);
            this.showUserPanel.Controls.Add(this.label5);
            this.showUserPanel.Controls.Add(this.label4);
            this.showUserPanel.Controls.Add(this.label3);
            this.showUserPanel.Controls.Add(this.label2);
            this.showUserPanel.Controls.Add(this.cancelShowDataButton);
            this.showUserPanel.Controls.Add(this.label1);
            this.showUserPanel.Controls.Add(this.showUserDataGridView);
            this.showUserPanel.Location = new System.Drawing.Point(0, 0);
            this.showUserPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showUserPanel.Name = "showUserPanel";
            this.showUserPanel.Size = new System.Drawing.Size(1408, 670);
            this.showUserPanel.TabIndex = 17;
            // 
            // labelAllBorrows
            // 
            this.labelAllBorrows.AutoSize = true;
            this.labelAllBorrows.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAllBorrows.Location = new System.Drawing.Point(757, 238);
            this.labelAllBorrows.Name = "labelAllBorrows";
            this.labelAllBorrows.Size = new System.Drawing.Size(177, 25);
            this.labelAllBorrows.TabIndex = 20;
            this.labelAllBorrows.Text = "Dane uzytkownika";
            // 
            // labelCUrrentBorrwedBooks
            // 
            this.labelCUrrentBorrwedBooks.AutoSize = true;
            this.labelCUrrentBorrwedBooks.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCUrrentBorrwedBooks.Location = new System.Drawing.Point(757, 208);
            this.labelCUrrentBorrwedBooks.Name = "labelCUrrentBorrwedBooks";
            this.labelCUrrentBorrwedBooks.Size = new System.Drawing.Size(177, 25);
            this.labelCUrrentBorrwedBooks.TabIndex = 19;
            this.labelCUrrentBorrwedBooks.Text = "Dane uzytkownika";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(395, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Lacznie wypozyczonych ksiazek:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(395, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Aktualnie wypozyczone ksiazki:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCity.Location = new System.Drawing.Point(757, 178);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(177, 25);
            this.labelCity.TabIndex = 16;
            this.labelCity.Text = "Dane uzytkownika";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(757, 146);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(177, 25);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Dane uzytkownika";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSurname.Location = new System.Drawing.Point(757, 110);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(177, 25);
            this.labelSurname.TabIndex = 14;
            this.labelSurname.Text = "Dane uzytkownika";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserName.Location = new System.Drawing.Point(757, 75);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(177, 25);
            this.labelUserName.TabIndex = 13;
            this.labelUserName.Text = "Dane uzytkownika";
            // 
            // ReturnBook
            // 
            this.ReturnBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReturnBook.Location = new System.Drawing.Point(838, 593);
            this.ReturnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnBook.Name = "ReturnBook";
            this.ReturnBook.Size = new System.Drawing.Size(81, 31);
            this.ReturnBook.TabIndex = 12;
            this.ReturnBook.Text = "Zwroc Ksiazke";
            this.ReturnBook.UseVisualStyleBackColor = true;
            this.ReturnBook.Click += new System.EventHandler(this.ReturnBook_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(395, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Miasto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(395, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(395, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(395, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Imie:";
            // 
            // cancelShowDataButton
            // 
            this.cancelShowDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelShowDataButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelShowDataButton.Location = new System.Drawing.Point(468, 593);
            this.cancelShowDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelShowDataButton.Name = "cancelShowDataButton";
            this.cancelShowDataButton.Size = new System.Drawing.Size(88, 31);
            this.cancelShowDataButton.TabIndex = 7;
            this.cancelShowDataButton.Text = "Cofnij";
            this.cancelShowDataButton.UseVisualStyleBackColor = true;
            this.cancelShowDataButton.Click += new System.EventHandler(this.cancelShowDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(634, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dane uzytkownika";
            // 
            // showUserDataGridView
            // 
            this.showUserDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showUserDataGridView.Location = new System.Drawing.Point(0, 276);
            this.showUserDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showUserDataGridView.MultiSelect = false;
            this.showUserDataGridView.Name = "showUserDataGridView";
            this.showUserDataGridView.RowHeadersWidth = 51;
            this.showUserDataGridView.RowTemplate.Height = 29;
            this.showUserDataGridView.Size = new System.Drawing.Size(1408, 304);
            this.showUserDataGridView.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.clearSearchButton);
            this.panel1.Controls.Add(this.searchBooksTextBox);
            this.panel1.Controls.Add(this.searchBooksButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 66);
            this.panel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1042, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Pokaz";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(880, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(757, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 24);
            this.button3.TabIndex = 14;
            this.button3.Text = "Szukaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSearchButton.BackColor = System.Drawing.Color.Red;
            this.clearSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearSearchButton.ForeColor = System.Drawing.Color.White;
            this.clearSearchButton.Location = new System.Drawing.Point(1726, 25);
            this.clearSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(25, 22);
            this.clearSearchButton.TabIndex = 10;
            this.clearSearchButton.Text = "x";
            this.clearSearchButton.UseVisualStyleBackColor = false;
            // 
            // searchBooksTextBox
            // 
            this.searchBooksTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBooksTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBooksTextBox.Location = new System.Drawing.Point(17, 24);
            this.searchBooksTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBooksTextBox.MaximumSize = new System.Drawing.Size(376, 23);
            this.searchBooksTextBox.Name = "searchBooksTextBox";
            this.searchBooksTextBox.Size = new System.Drawing.Size(376, 23);
            this.searchBooksTextBox.TabIndex = 8;
            // 
            // searchBooksButton
            // 
            this.searchBooksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBooksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBooksButton.Location = new System.Drawing.Point(1639, 25);
            this.searchBooksButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBooksButton.Name = "searchBooksButton";
            this.searchBooksButton.Size = new System.Drawing.Size(82, 22);
            this.searchBooksButton.TabIndex = 9;
            this.searchBooksButton.Text = "Szukaj";
            this.searchBooksButton.UseVisualStyleBackColor = true;
            // 
            // UsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showUserPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UsersList";
            this.Size = new System.Drawing.Size(1410, 672);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.showUserPanel.ResumeLayout(false);
            this.showUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showUserDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button clearSearchButton;
        private TextBox searchBooksTextBox;
        private Button searchBooksButton;
        private DataGridView usersDataGridView;
        private Button button4;
        private Panel showUserPanel;
        private Label labelAllBorrows;
        private Label labelCUrrentBorrwedBooks;
        private Label label11;
        private Label label10;
        private Label labelCity;
        private Label labelEmail;
        private Label labelSurname;
        private Label labelUserName;
        private Button ReturnBook;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button cancelShowDataButton;
        private Label label1;
        private DataGridView showUserDataGridView;
    }
}
