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
            panel2 = new Panel();
            usersDataGridView = new DataGridView();
            showUserPanel = new Panel();
            ReturnBook = new Button();
            cancelShowDataButton = new Button();
            panel3 = new Panel();
            labelAllBorrows = new Label();
            label11 = new Label();
            labelCUrrentBorrwedBooks = new Label();
            labelCity = new Label();
            labelEmail = new Label();
            labelSurname = new Label();
            labelUserName = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            showUserDataGridView = new DataGridView();
            panel1 = new Panel();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            clearSearchButton = new Button();
            searchBooksTextBox = new TextBox();
            searchBooksButton = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            showUserPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showUserDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(usersDataGridView);
            panel2.Location = new Point(0, 96);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1618, 828);
            panel2.TabIndex = 6;
            // 
            // usersDataGridView
            // 
            usersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGridView.Location = new Point(3, 0);
            usersDataGridView.Margin = new Padding(3, 4, 3, 4);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.ReadOnly = true;
            usersDataGridView.RowHeadersWidth = 51;
            usersDataGridView.RowTemplate.Height = 25;
            usersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersDataGridView.Size = new Size(1613, 660);
            usersDataGridView.TabIndex = 0;
            // 
            // showUserPanel
            // 
            showUserPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showUserPanel.Controls.Add(ReturnBook);
            showUserPanel.Controls.Add(cancelShowDataButton);
            showUserPanel.Controls.Add(panel3);
            showUserPanel.Controls.Add(showUserDataGridView);
            showUserPanel.Location = new Point(0, 0);
            showUserPanel.Name = "showUserPanel";
            showUserPanel.Size = new Size(1619, 949);
            showUserPanel.TabIndex = 17;
            // 
            // ReturnBook
            // 
            ReturnBook.Anchor = AnchorStyles.Bottom;
            ReturnBook.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnBook.Location = new Point(952, 900);
            ReturnBook.Name = "ReturnBook";
            ReturnBook.Size = new Size(93, 41);
            ReturnBook.TabIndex = 12;
            ReturnBook.Text = "Zwroc Ksiazke";
            ReturnBook.UseVisualStyleBackColor = true;
            ReturnBook.Click += ReturnBook_Click_2;
            // 
            // cancelShowDataButton
            // 
            cancelShowDataButton.Anchor = AnchorStyles.Bottom;
            cancelShowDataButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cancelShowDataButton.Location = new Point(544, 900);
            cancelShowDataButton.Name = "cancelShowDataButton";
            cancelShowDataButton.Size = new Size(101, 41);
            cancelShowDataButton.TabIndex = 7;
            cancelShowDataButton.Text = "Cofnij";
            cancelShowDataButton.UseVisualStyleBackColor = true;
            cancelShowDataButton.Click += cancelShowDataButton_Click_1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(labelAllBorrows);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(labelCUrrentBorrwedBooks);
            panel3.Controls.Add(labelCity);
            panel3.Controls.Add(labelEmail);
            panel3.Controls.Add(labelSurname);
            panel3.Controls.Add(labelUserName);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(167, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(1333, 397);
            panel3.TabIndex = 21;
            // 
            // labelAllBorrows
            // 
            labelAllBorrows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelAllBorrows.AutoSize = true;
            labelAllBorrows.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAllBorrows.Location = new Point(782, 336);
            labelAllBorrows.Name = "labelAllBorrows";
            labelAllBorrows.Size = new Size(112, 37);
            labelAllBorrows.TabIndex = 11;
            labelAllBorrows.Text = "label12";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(362, 336);
            label11.Name = "label11";
            label11.Size = new Size(331, 37);
            label11.TabIndex = 10;
            label11.Text = "Wszystkie wypożyczenia";
            // 
            // labelCUrrentBorrwedBooks
            // 
            labelCUrrentBorrwedBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelCUrrentBorrwedBooks.AutoSize = true;
            labelCUrrentBorrwedBooks.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCUrrentBorrwedBooks.Location = new Point(782, 276);
            labelCUrrentBorrwedBooks.Name = "labelCUrrentBorrwedBooks";
            labelCUrrentBorrwedBooks.Size = new Size(112, 37);
            labelCUrrentBorrwedBooks.TabIndex = 9;
            labelCUrrentBorrwedBooks.Text = "label10";
            // 
            // labelCity
            // 
            labelCity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCity.Location = new Point(782, 221);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(96, 37);
            labelCity.TabIndex = 8;
            labelCity.Text = "label9";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(782, 164);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(96, 37);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "label8";
            // 
            // labelSurname
            // 
            labelSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSurname.Location = new Point(782, 105);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(96, 37);
            labelSurname.TabIndex = 6;
            labelSurname.Text = "label7";
            // 
            // labelUserName
            // 
            labelUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.Location = new Point(782, 45);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(96, 37);
            labelUserName.TabIndex = 5;
            labelUserName.Text = "label6";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(362, 276);
            label5.Name = "label5";
            label5.Size = new Size(318, 37);
            label5.TabIndex = 4;
            label5.Text = "Aktualne wypożyczenia";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(362, 221);
            label4.Name = "label4";
            label4.Size = new Size(106, 37);
            label4.TabIndex = 3;
            label4.Text = "Miasto";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(362, 164);
            label3.Name = "label3";
            label3.Size = new Size(87, 37);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(362, 105);
            label2.Name = "label2";
            label2.Size = new Size(140, 37);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(362, 45);
            label1.Name = "label1";
            label1.Size = new Size(74, 37);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // showUserDataGridView
            // 
            showUserDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showUserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            showUserDataGridView.Location = new Point(160, 447);
            showUserDataGridView.MultiSelect = false;
            showUserDataGridView.Name = "showUserDataGridView";
            showUserDataGridView.RowHeadersWidth = 51;
            showUserDataGridView.RowTemplate.Height = 29;
            showUserDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            showUserDataGridView.Size = new Size(1346, 372);
            showUserDataGridView.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(clearSearchButton);
            panel1.Controls.Add(searchBooksTextBox);
            panel1.Controls.Add(searchBooksButton);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1618, 88);
            panel1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1201, 31);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(177, 31);
            button4.TabIndex = 16;
            button4.Text = "Pokaz";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_2;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(475, 24);
            button2.Name = "button2";
            button2.Size = new Size(32, 49);
            button2.TabIndex = 15;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(544, 29);
            button3.Name = "button3";
            button3.Size = new Size(134, 32);
            button3.TabIndex = 14;
            button3.Text = "Szukaj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // clearSearchButton
            // 
            clearSearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearSearchButton.BackColor = Color.Red;
            clearSearchButton.Cursor = Cursors.Hand;
            clearSearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearSearchButton.ForeColor = Color.White;
            clearSearchButton.Location = new Point(1983, 33);
            clearSearchButton.Name = "clearSearchButton";
            clearSearchButton.Size = new Size(29, 29);
            clearSearchButton.TabIndex = 10;
            clearSearchButton.Text = "x";
            clearSearchButton.UseVisualStyleBackColor = false;
            // 
            // searchBooksTextBox
            // 
            searchBooksTextBox.Anchor = AnchorStyles.Top;
            searchBooksTextBox.Cursor = Cursors.IBeam;
            searchBooksTextBox.Location = new Point(23, 32);
            searchBooksTextBox.MaximumSize = new Size(429, 23);
            searchBooksTextBox.Name = "searchBooksTextBox";
            searchBooksTextBox.Size = new Size(429, 27);
            searchBooksTextBox.TabIndex = 8;
            // 
            // searchBooksButton
            // 
            searchBooksButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBooksButton.Cursor = Cursors.Hand;
            searchBooksButton.Location = new Point(1883, 33);
            searchBooksButton.Name = "searchBooksButton";
            searchBooksButton.Size = new Size(94, 29);
            searchBooksButton.TabIndex = 9;
            searchBooksButton.Text = "Szukaj";
            searchBooksButton.UseVisualStyleBackColor = true;
            // 
            // UsersList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(showUserPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsersList";
            Size = new Size(1618, 949);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            showUserPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showUserDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Button ReturnBook;
        private Button cancelShowDataButton;
        private DataGridView showUserDataGridView;
        private Panel panel3;
        private Label labelAllBorrows;
        private Label label11;
        private Label labelCUrrentBorrwedBooks;
        private Label labelCity;
        private Label labelEmail;
        private Label labelSurname;
        private Label labelUserName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
