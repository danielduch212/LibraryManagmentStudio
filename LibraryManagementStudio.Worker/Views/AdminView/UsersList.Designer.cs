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
            showUserDataGridView = new DataGridView();
            panel1 = new Panel();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            clearSearchButton = new Button();
            searchBooksTextBox = new TextBox();
            searchBooksButton = new Button();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelUserName = new Label();
            labelSurname = new Label();
            labelEmail = new Label();
            labelCity = new Label();
            labelCUrrentBorrwedBooks = new Label();
            label11 = new Label();
            labelAllBorrows = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            showUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showUserDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(usersDataGridView);
            panel2.Location = new Point(0, 96);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1611, 775);
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
            usersDataGridView.Size = new Size(1606, 775);
            usersDataGridView.TabIndex = 0;
            // 
            // showUserPanel
            // 
            showUserPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showUserPanel.Controls.Add(panel3);
            showUserPanel.Controls.Add(ReturnBook);
            showUserPanel.Controls.Add(cancelShowDataButton);
            showUserPanel.Controls.Add(showUserDataGridView);
            showUserPanel.Location = new Point(0, 0);
            showUserPanel.Name = "showUserPanel";
            showUserPanel.Size = new Size(1609, 893);
            showUserPanel.TabIndex = 17;
            // 
            // ReturnBook
            // 
            ReturnBook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ReturnBook.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnBook.Location = new Point(926, 799);
            ReturnBook.Name = "ReturnBook";
            ReturnBook.Size = new Size(93, 41);
            ReturnBook.TabIndex = 12;
            ReturnBook.Text = "Zwroc Ksiazke";
            ReturnBook.UseVisualStyleBackColor = true;
            ReturnBook.Click += ReturnBook_Click;
            // 
            // cancelShowDataButton
            // 
            cancelShowDataButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cancelShowDataButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cancelShowDataButton.Location = new Point(503, 799);
            cancelShowDataButton.Name = "cancelShowDataButton";
            cancelShowDataButton.Size = new Size(101, 41);
            cancelShowDataButton.TabIndex = 7;
            cancelShowDataButton.Text = "Cofnij";
            cancelShowDataButton.UseVisualStyleBackColor = true;
            cancelShowDataButton.Click += cancelShowDataButton_Click;
            // 
            // showUserDataGridView
            // 
            showUserDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            showUserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            showUserDataGridView.Location = new Point(160, 503);
            showUserDataGridView.MultiSelect = false;
            showUserDataGridView.Name = "showUserDataGridView";
            showUserDataGridView.RowHeadersWidth = 51;
            showUserDataGridView.RowTemplate.Height = 29;
            showUserDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            showUserDataGridView.Size = new Size(1333, 243);
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
            panel1.Size = new Size(1611, 88);
            panel1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1191, 31);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(177, 31);
            button4.TabIndex = 16;
            button4.Text = "Pokaz";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1006, 23);
            button2.Name = "button2";
            button2.Size = new Size(32, 49);
            button2.TabIndex = 15;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(865, 31);
            button3.Name = "button3";
            button3.Size = new Size(134, 32);
            button3.TabIndex = 14;
            button3.Text = "Szukaj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // clearSearchButton
            // 
            clearSearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearSearchButton.BackColor = Color.Red;
            clearSearchButton.Cursor = Cursors.Hand;
            clearSearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearSearchButton.ForeColor = Color.White;
            clearSearchButton.Location = new Point(1973, 33);
            clearSearchButton.Name = "clearSearchButton";
            clearSearchButton.Size = new Size(29, 29);
            clearSearchButton.TabIndex = 10;
            clearSearchButton.Text = "x";
            clearSearchButton.UseVisualStyleBackColor = false;
            // 
            // searchBooksTextBox
            // 
            searchBooksTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBooksTextBox.Cursor = Cursors.IBeam;
            searchBooksTextBox.Location = new Point(19, 32);
            searchBooksTextBox.MaximumSize = new Size(429, 23);
            searchBooksTextBox.Name = "searchBooksTextBox";
            searchBooksTextBox.Size = new Size(429, 23);
            searchBooksTextBox.TabIndex = 8;
            // 
            // searchBooksButton
            // 
            searchBooksButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBooksButton.Cursor = Cursors.Hand;
            searchBooksButton.Location = new Point(1873, 33);
            searchBooksButton.Name = "searchBooksButton";
            searchBooksButton.Size = new Size(94, 29);
            searchBooksButton.TabIndex = 9;
            searchBooksButton.Text = "Szukaj";
            searchBooksButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
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
            panel3.Location = new Point(160, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(629, 408);
            panel3.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 103);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 135);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Miasto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 164);
            label5.Name = "label5";
            label5.Size = new Size(163, 20);
            label5.TabIndex = 4;
            label5.Text = "Aktualne wypożyczenia";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(269, 36);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(50, 20);
            labelUserName.TabIndex = 5;
            labelUserName.Text = "label6";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(269, 69);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(50, 20);
            labelSurname.TabIndex = 6;
            labelSurname.Text = "label7";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(269, 103);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(50, 20);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "label8";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(269, 135);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(50, 20);
            labelCity.TabIndex = 8;
            labelCity.Text = "label9";
            // 
            // labelCUrrentBorrwedBooks
            // 
            labelCUrrentBorrwedBooks.AutoSize = true;
            labelCUrrentBorrwedBooks.Location = new Point(269, 164);
            labelCUrrentBorrwedBooks.Name = "labelCUrrentBorrwedBooks";
            labelCUrrentBorrwedBooks.Size = new Size(58, 20);
            labelCUrrentBorrwedBooks.TabIndex = 9;
            labelCUrrentBorrwedBooks.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 193);
            label11.Name = "label11";
            label11.Size = new Size(169, 20);
            label11.TabIndex = 10;
            label11.Text = "Wszystkie wypożyczenia";
            // 
            // labelAllBorrows
            // 
            labelAllBorrows.AutoSize = true;
            labelAllBorrows.Location = new Point(269, 193);
            labelAllBorrows.Name = "labelAllBorrows";
            labelAllBorrows.Size = new Size(58, 20);
            labelAllBorrows.TabIndex = 11;
            labelAllBorrows.Text = "label12";
            // 
            // UsersList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(showUserPanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsersList";
            Size = new Size(1611, 896);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            showUserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)showUserDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
