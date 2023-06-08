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
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.panelBorrowBook = new System.Windows.Forms.Panel();
            this.buttonCancelBorrow = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEraseCopy = new System.Windows.Forms.Panel();
            this.cancelEraseCopyButton = new System.Windows.Forms.Button();
            this.eraseCopyButton = new System.Windows.Forms.Button();
            this.textBoxCopyIDToErase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelAddCopies = new System.Windows.Forms.Panel();
            this.cancelButtonCopies = new System.Windows.Forms.Button();
            this.okButtonCopies = new System.Windows.Forms.Button();
            this.textBoxCopiesAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddCopiesBookTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EraseCopy = new System.Windows.Forms.Button();
            this.EraseBook = new System.Windows.Forms.Button();
            this.AddBookCopies = new System.Windows.Forms.Button();
            this.borrowBook = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchBooksTextBox = new System.Windows.Forms.TextBox();
            this.searchBooksButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.panelBorrowBook.SuspendLayout();
            this.panelEraseCopy.SuspendLayout();
            this.panelAddCopies.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.bookDataGridView);
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1098, 463);
            this.panel2.TabIndex = 2;
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AllowUserToAddRows = false;
            this.bookDataGridView.AllowUserToDeleteRows = false;
            this.bookDataGridView.AllowUserToResizeColumns = false;
            this.bookDataGridView.AllowUserToResizeRows = false;
            this.bookDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Location = new System.Drawing.Point(4, 3);
            this.bookDataGridView.MultiSelect = false;
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.ReadOnly = true;
            this.bookDataGridView.RowTemplate.Height = 25;
            this.bookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookDataGridView.Size = new System.Drawing.Size(1091, 457);
            this.bookDataGridView.TabIndex = 0;
            this.bookDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDataGridView_CellContentClick);
            // 
            // panelBorrowBook
            // 
            this.panelBorrowBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorrowBook.Controls.Add(this.buttonCancelBorrow);
            this.panelBorrowBook.Controls.Add(this.buttonOk);
            this.panelBorrowBook.Controls.Add(this.textBoxUserID);
            this.panelBorrowBook.Controls.Add(this.label2);
            this.panelBorrowBook.Controls.Add(this.labelBookTitle);
            this.panelBorrowBook.Controls.Add(this.label1);
            this.panelBorrowBook.Location = new System.Drawing.Point(349, 121);
            this.panelBorrowBook.Name = "panelBorrowBook";
            this.panelBorrowBook.Size = new System.Drawing.Size(391, 196);
            this.panelBorrowBook.TabIndex = 18;
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
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(50, 136);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(309, 23);
            this.textBoxUserID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj ID Użytkownika";
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBookTitle.Location = new System.Drawing.Point(146, 18);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(82, 25);
            this.labelBookTitle.TabIndex = 1;
            this.labelBookTitle.Text = "Ksiazka:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Książka";
            // 
            // panelEraseCopy
            // 
            this.panelEraseCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEraseCopy.Controls.Add(this.cancelEraseCopyButton);
            this.panelEraseCopy.Controls.Add(this.eraseCopyButton);
            this.panelEraseCopy.Controls.Add(this.textBoxCopyIDToErase);
            this.panelEraseCopy.Controls.Add(this.label5);
            this.panelEraseCopy.Location = new System.Drawing.Point(352, 80);
            this.panelEraseCopy.Name = "panelEraseCopy";
            this.panelEraseCopy.Size = new System.Drawing.Size(391, 196);
            this.panelEraseCopy.TabIndex = 6;
            // 
            // cancelEraseCopyButton
            // 
            this.cancelEraseCopyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelEraseCopyButton.Location = new System.Drawing.Point(89, 147);
            this.cancelEraseCopyButton.Name = "cancelEraseCopyButton";
            this.cancelEraseCopyButton.Size = new System.Drawing.Size(75, 23);
            this.cancelEraseCopyButton.TabIndex = 3;
            this.cancelEraseCopyButton.Text = "Cancel";
            this.cancelEraseCopyButton.UseVisualStyleBackColor = true;
            this.cancelEraseCopyButton.Click += new System.EventHandler(this.cancelEraseCopyButton_Click);
            // 
            // eraseCopyButton
            // 
            this.eraseCopyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eraseCopyButton.Location = new System.Drawing.Point(195, 147);
            this.eraseCopyButton.Name = "eraseCopyButton";
            this.eraseCopyButton.Size = new System.Drawing.Size(75, 23);
            this.eraseCopyButton.TabIndex = 2;
            this.eraseCopyButton.Text = "Usun";
            this.eraseCopyButton.UseVisualStyleBackColor = true;
            this.eraseCopyButton.Click += new System.EventHandler(this.eraseCopyButton_Click);
            // 
            // textBoxCopyIDToErase
            // 
            this.textBoxCopyIDToErase.Location = new System.Drawing.Point(146, 86);
            this.textBoxCopyIDToErase.Name = "textBoxCopyIDToErase";
            this.textBoxCopyIDToErase.Size = new System.Drawing.Size(100, 23);
            this.textBoxCopyIDToErase.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(89, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Podaj Id Kopii do usunięcia";
            // 
            // panelAddCopies
            // 
            this.panelAddCopies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddCopies.Controls.Add(this.cancelButtonCopies);
            this.panelAddCopies.Controls.Add(this.okButtonCopies);
            this.panelAddCopies.Controls.Add(this.textBoxCopiesAdd);
            this.panelAddCopies.Controls.Add(this.label4);
            this.panelAddCopies.Controls.Add(this.AddCopiesBookTitle);
            this.panelAddCopies.Controls.Add(this.label3);
            this.panelAddCopies.Location = new System.Drawing.Point(0, 0);
            this.panelAddCopies.Name = "panelAddCopies";
            this.panelAddCopies.Size = new System.Drawing.Size(346, 196);
            this.panelAddCopies.TabIndex = 6;
            // 
            // cancelButtonCopies
            // 
            this.cancelButtonCopies.Location = new System.Drawing.Point(39, 147);
            this.cancelButtonCopies.Name = "cancelButtonCopies";
            this.cancelButtonCopies.Size = new System.Drawing.Size(75, 23);
            this.cancelButtonCopies.TabIndex = 5;
            this.cancelButtonCopies.Text = "Anuluj";
            this.cancelButtonCopies.UseVisualStyleBackColor = true;
            this.cancelButtonCopies.Click += new System.EventHandler(this.cancelButtonCopies_Click);
            // 
            // okButtonCopies
            // 
            this.okButtonCopies.Location = new System.Drawing.Point(153, 147);
            this.okButtonCopies.Name = "okButtonCopies";
            this.okButtonCopies.Size = new System.Drawing.Size(75, 23);
            this.okButtonCopies.TabIndex = 4;
            this.okButtonCopies.Text = "Ok";
            this.okButtonCopies.UseVisualStyleBackColor = true;
            this.okButtonCopies.Click += new System.EventHandler(this.okButtonCopies_Click);
            // 
            // textBoxCopiesAdd
            // 
            this.textBoxCopiesAdd.Location = new System.Drawing.Point(212, 90);
            this.textBoxCopiesAdd.Name = "textBoxCopiesAdd";
            this.textBoxCopiesAdd.Size = new System.Drawing.Size(100, 23);
            this.textBoxCopiesAdd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Podaj Liczbe Kopii";
            // 
            // AddCopiesBookTitle
            // 
            this.AddCopiesBookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddCopiesBookTitle.Location = new System.Drawing.Point(146, 28);
            this.AddCopiesBookTitle.Name = "AddCopiesBookTitle";
            this.AddCopiesBookTitle.Size = new System.Drawing.Size(71, 21);
            this.AddCopiesBookTitle.TabIndex = 1;
            this.AddCopiesBookTitle.Text = "Ksiazka:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ksiazka";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.EraseCopy);
            this.panel1.Controls.Add(this.EraseBook);
            this.panel1.Controls.Add(this.AddBookCopies);
            this.panel1.Controls.Add(this.borrowBook);
            this.panel1.Controls.Add(this.clearSearchButton);
            this.panel1.Controls.Add(this.searchBooksTextBox);
            this.panel1.Controls.Add(this.searchBooksButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 68);
            this.panel1.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchButton.Location = new System.Drawing.Point(498, 21);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(132, 23);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Znajdz";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EraseCopy
            // 
            this.EraseCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EraseCopy.Location = new System.Drawing.Point(811, 42);
            this.EraseCopy.Name = "EraseCopy";
            this.EraseCopy.Size = new System.Drawing.Size(132, 23);
            this.EraseCopy.TabIndex = 16;
            this.EraseCopy.Text = "Usuń kopie";
            this.EraseCopy.UseVisualStyleBackColor = true;
            this.EraseCopy.Click += new System.EventHandler(this.EraseCopy_Click);
            // 
            // EraseBook
            // 
            this.EraseBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EraseBook.Location = new System.Drawing.Point(963, 22);
            this.EraseBook.Name = "EraseBook";
            this.EraseBook.Size = new System.Drawing.Size(132, 23);
            this.EraseBook.TabIndex = 15;
            this.EraseBook.Text = "Usuń książkę";
            this.EraseBook.UseVisualStyleBackColor = true;
            this.EraseBook.Click += new System.EventHandler(this.EraseBook_Click);
            // 
            // AddBookCopies
            // 
            this.AddBookCopies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBookCopies.Location = new System.Drawing.Point(811, 3);
            this.AddBookCopies.Name = "AddBookCopies";
            this.AddBookCopies.Size = new System.Drawing.Size(132, 23);
            this.AddBookCopies.TabIndex = 14;
            this.AddBookCopies.Text = "Dodaj liczbe kopii";
            this.AddBookCopies.UseVisualStyleBackColor = true;
            this.AddBookCopies.Click += new System.EventHandler(this.AddBookCopies_Click);
            // 
            // borrowBook
            // 
            this.borrowBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowBook.Location = new System.Drawing.Point(661, 21);
            this.borrowBook.Name = "borrowBook";
            this.borrowBook.Size = new System.Drawing.Size(132, 23);
            this.borrowBook.TabIndex = 13;
            this.borrowBook.Text = "Wypożycz Książkę";
            this.borrowBook.UseVisualStyleBackColor = true;
            this.borrowBook.Click += new System.EventHandler(this.borrowBook_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearSearchButton.BackColor = System.Drawing.Color.Red;
            this.clearSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearSearchButton.ForeColor = System.Drawing.Color.White;
            this.clearSearchButton.Location = new System.Drawing.Point(467, 20);
            this.clearSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(25, 22);
            this.clearSearchButton.TabIndex = 7;
            this.clearSearchButton.Text = "x";
            this.clearSearchButton.UseVisualStyleBackColor = false;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
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
            this.searchBooksTextBox.Size = new System.Drawing.Size(361, 23);
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
            // BookStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEraseCopy);
            this.Controls.Add(this.panelBorrowBook);
            this.Controls.Add(this.panelAddCopies);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "BookStorage";
            this.Size = new System.Drawing.Size(1102, 537);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.panelBorrowBook.ResumeLayout(false);
            this.panelBorrowBook.PerformLayout();
            this.panelEraseCopy.ResumeLayout(false);
            this.panelEraseCopy.PerformLayout();
            this.panelAddCopies.ResumeLayout(false);
            this.panelAddCopies.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private TextBox textBoxUserID;
        private Label label2;
        private Label labelBookTitle;
        private Label label1;
        private Button buttonCancelBorrow;
        private Button buttonOk;
        private Panel panelAddCopies;
        private Label AddCopiesBookTitle;
        private Label label3;
        private Button cancelButtonCopies;
        private Button okButtonCopies;
        private TextBox textBoxCopiesAdd;
        private Label label4;
        private Panel panelEraseCopy;
        private Button cancelEraseCopyButton;
        private Button eraseCopyButton;
        private TextBox textBoxCopyIDToErase;
        private Label label5;
    }
}
