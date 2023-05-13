namespace LibraryManagementStudio.Worker.Views.AdminView
{
    partial class BookStorage
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
            this.panelBorrowBook = new System.Windows.Forms.Panel();
            this.textBoxUserEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EraseCopy = new System.Windows.Forms.Button();
            this.EraseBook = new System.Windows.Forms.Button();
            this.AddBookCopies = new System.Windows.Forms.Button();
            this.borrowBook = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchBooksTextBox = new System.Windows.Forms.TextBox();
            this.searchBooksButton = new System.Windows.Forms.Button();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancelBorrow = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelBorrowBook.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelBorrowBook);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.bookDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1098, 527);
            this.panel2.TabIndex = 2;
            // 
            // panelBorrowBook
            // 
            this.panelBorrowBook.Controls.Add(this.buttonCancelBorrow);
            this.panelBorrowBook.Controls.Add(this.buttonOk);
            this.panelBorrowBook.Controls.Add(this.textBoxUserEmail);
            this.panelBorrowBook.Controls.Add(this.label2);
            this.panelBorrowBook.Controls.Add(this.labelBookTitle);
            this.panelBorrowBook.Controls.Add(this.label1);
            this.panelBorrowBook.Location = new System.Drawing.Point(355, 157);
            this.panelBorrowBook.Name = "panelBorrowBook";
            this.panelBorrowBook.Size = new System.Drawing.Size(391, 196);
            this.panelBorrowBook.TabIndex = 18;
            // 
            // textBoxUserEmail
            // 
            this.textBoxUserEmail.Location = new System.Drawing.Point(50, 136);
            this.textBoxUserEmail.Name = "textBoxUserEmail";
            this.textBoxUserEmail.Size = new System.Drawing.Size(309, 23);
            this.textBoxUserEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj email Uzytkownika:";
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBookTitle.Location = new System.Drawing.Point(146, 18);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(82, 25);
            this.labelBookTitle.TabIndex = 1;
            this.labelBookTitle.Text = "Ksiazka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ksiazka:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.EraseCopy);
            this.panel1.Controls.Add(this.EraseBook);
            this.panel1.Controls.Add(this.AddBookCopies);
            this.panel1.Controls.Add(this.borrowBook);
            this.panel1.Controls.Add(this.clearSearchButton);
            this.panel1.Controls.Add(this.searchBooksTextBox);
            this.panel1.Controls.Add(this.searchBooksButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 66);
            this.panel1.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(405, 22);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(132, 23);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Znajdz";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EraseCopy
            // 
            this.EraseCopy.Location = new System.Drawing.Point(736, 37);
            this.EraseCopy.Name = "EraseCopy";
            this.EraseCopy.Size = new System.Drawing.Size(132, 23);
            this.EraseCopy.TabIndex = 16;
            this.EraseCopy.Text = "Usuń kopie";
            this.EraseCopy.UseVisualStyleBackColor = true;
            // 
            // EraseBook
            // 
            this.EraseBook.Location = new System.Drawing.Point(886, 19);
            this.EraseBook.Name = "EraseBook";
            this.EraseBook.Size = new System.Drawing.Size(132, 23);
            this.EraseBook.TabIndex = 15;
            this.EraseBook.Text = "Usuń książkę";
            this.EraseBook.UseVisualStyleBackColor = true;
            // 
            // AddBookCopies
            // 
            this.AddBookCopies.Location = new System.Drawing.Point(736, 8);
            this.AddBookCopies.Name = "AddBookCopies";
            this.AddBookCopies.Size = new System.Drawing.Size(132, 23);
            this.AddBookCopies.TabIndex = 14;
            this.AddBookCopies.Text = "Dodaj liczbe kopii";
            this.AddBookCopies.UseVisualStyleBackColor = true;
            // 
            // borrowBook
            // 
            this.borrowBook.Location = new System.Drawing.Point(582, 22);
            this.borrowBook.Name = "borrowBook";
            this.borrowBook.Size = new System.Drawing.Size(132, 23);
            this.borrowBook.TabIndex = 13;
            this.borrowBook.Text = "Wypożycz Książkę";
            this.borrowBook.UseVisualStyleBackColor = true;
            this.borrowBook.Click += new System.EventHandler(this.borrowBook_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSearchButton.BackColor = System.Drawing.Color.Red;
            this.clearSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearSearchButton.ForeColor = System.Drawing.Color.White;
            this.clearSearchButton.Location = new System.Drawing.Point(1438, 21);
            this.clearSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(25, 22);
            this.clearSearchButton.TabIndex = 7;
            this.clearSearchButton.Text = "x";
            this.clearSearchButton.UseVisualStyleBackColor = false;
            // 
            // searchBooksTextBox
            // 
            this.searchBooksTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBooksTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBooksTextBox.Location = new System.Drawing.Point(13, 22);
            this.searchBooksTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBooksTextBox.MaximumSize = new System.Drawing.Size(376, 23);
            this.searchBooksTextBox.Name = "searchBooksTextBox";
            this.searchBooksTextBox.Size = new System.Drawing.Size(376, 23);
            this.searchBooksTextBox.TabIndex = 5;
            // 
            // searchBooksButton
            // 
            this.searchBooksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBooksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBooksButton.Location = new System.Drawing.Point(1351, 21);
            this.searchBooksButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBooksButton.Name = "searchBooksButton";
            this.searchBooksButton.Size = new System.Drawing.Size(82, 22);
            this.searchBooksButton.TabIndex = 6;
            this.searchBooksButton.Text = "Szukaj";
            this.searchBooksButton.UseVisualStyleBackColor = true;
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AllowUserToAddRows = false;
            this.bookDataGridView.AllowUserToDeleteRows = false;
            this.bookDataGridView.AllowUserToResizeColumns = false;
            this.bookDataGridView.AllowUserToResizeRows = false;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Location = new System.Drawing.Point(0, 66);
            this.bookDataGridView.MultiSelect = false;
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.ReadOnly = true;
            this.bookDataGridView.RowTemplate.Height = 25;
            this.bookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookDataGridView.Size = new System.Drawing.Size(1098, 461);
            this.bookDataGridView.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(178, 165);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancelBorrow
            // 
            this.buttonCancelBorrow.Location = new System.Drawing.Point(50, 165);
            this.buttonCancelBorrow.Name = "buttonCancelBorrow";
            this.buttonCancelBorrow.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelBorrow.TabIndex = 5;
            this.buttonCancelBorrow.Text = "Cancel";
            this.buttonCancelBorrow.UseVisualStyleBackColor = true;
            this.buttonCancelBorrow.Click += new System.EventHandler(this.buttonCancelBorrow_Click);
            // 
            // BookStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "BookStorage";
            this.Size = new System.Drawing.Size(1098, 527);
            this.panel2.ResumeLayout(false);
            this.panelBorrowBook.ResumeLayout(false);
            this.panelBorrowBook.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button EraseBook;
        private Button AddBookCopies;
        private Button borrowBook;
        private Button clearSearchButton;
        private TextBox searchBooksTextBox;
        private Button searchBooksButton;
        private DataGridView bookDataGridView;
        private Button EraseCopy;
        private Button SearchButton;
        private Panel panelBorrowBook;
        private TextBox textBoxUserEmail;
        private Label label2;
        private Label labelBookTitle;
        private Label label1;
        private Button buttonCancelBorrow;
        private Button buttonOk;
    }
}
