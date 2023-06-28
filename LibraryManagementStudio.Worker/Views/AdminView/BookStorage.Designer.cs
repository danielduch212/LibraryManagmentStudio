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
            panel2 = new Panel();
            bookDataGridView = new DataGridView();
            panelBorrowBook = new Panel();
            buttonCancelBorrow = new Button();
            buttonOk = new Button();
            textBoxUserID = new TextBox();
            label2 = new Label();
            labelBookTitle = new Label();
            label1 = new Label();
            panelEraseCopy = new Panel();
            cancelEraseCopyButton = new Button();
            eraseCopyButton = new Button();
            textBoxCopyIDToErase = new TextBox();
            label5 = new Label();
            panelAddCopies = new Panel();
            cancelButtonCopies = new Button();
            okButtonCopies = new Button();
            textBoxCopiesAdd = new TextBox();
            label4 = new Label();
            AddCopiesBookTitle = new Label();
            label3 = new Label();
            panel1 = new Panel();
            SearchButton = new Button();
            EraseCopy = new Button();
            EraseBook = new Button();
            AddBookCopies = new Button();
            borrowBook = new Button();
            clearSearchButton = new Button();
            searchBooksTextBox = new TextBox();
            searchBooksButton = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).BeginInit();
            panelBorrowBook.SuspendLayout();
            panelEraseCopy.SuspendLayout();
            panelAddCopies.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(bookDataGridView);
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1255, 617);
            panel2.TabIndex = 2;
            // 
            // bookDataGridView
            // 
            bookDataGridView.AllowUserToAddRows = false;
            bookDataGridView.AllowUserToDeleteRows = false;
            bookDataGridView.AllowUserToResizeColumns = false;
            bookDataGridView.AllowUserToResizeRows = false;
            bookDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bookDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGridView.Location = new Point(5, 4);
            bookDataGridView.Margin = new Padding(3, 4, 3, 4);
            bookDataGridView.MultiSelect = false;
            bookDataGridView.Name = "bookDataGridView";
            bookDataGridView.ReadOnly = true;
            bookDataGridView.RowHeadersWidth = 51;
            bookDataGridView.RowTemplate.Height = 25;
            bookDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookDataGridView.Size = new Size(1247, 609);
            bookDataGridView.TabIndex = 0;
            bookDataGridView.CellContentClick += bookDataGridView_CellContentClick;
            // 
            // panelBorrowBook
            // 
            panelBorrowBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelBorrowBook.Controls.Add(buttonCancelBorrow);
            panelBorrowBook.Controls.Add(buttonOk);
            panelBorrowBook.Controls.Add(textBoxUserID);
            panelBorrowBook.Controls.Add(label2);
            panelBorrowBook.Controls.Add(labelBookTitle);
            panelBorrowBook.Controls.Add(label1);
            panelBorrowBook.Location = new Point(399, 161);
            panelBorrowBook.Margin = new Padding(3, 4, 3, 4);
            panelBorrowBook.Name = "panelBorrowBook";
            panelBorrowBook.Size = new Size(447, 261);
            panelBorrowBook.TabIndex = 18;
            // 
            // buttonCancelBorrow
            // 
            buttonCancelBorrow.Location = new Point(57, 220);
            buttonCancelBorrow.Margin = new Padding(3, 4, 3, 4);
            buttonCancelBorrow.Name = "buttonCancelBorrow";
            buttonCancelBorrow.Size = new Size(86, 31);
            buttonCancelBorrow.TabIndex = 5;
            buttonCancelBorrow.Text = "Cancel";
            buttonCancelBorrow.UseVisualStyleBackColor = true;
            buttonCancelBorrow.Click += buttonCancelBorrow_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(203, 220);
            buttonOk.Margin = new Padding(3, 4, 3, 4);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(86, 31);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // textBoxUserID
            // 
            textBoxUserID.Location = new Point(57, 181);
            textBoxUserID.Margin = new Padding(3, 4, 3, 4);
            textBoxUserID.Name = "textBoxUserID";
            textBoxUserID.Size = new Size(353, 27);
            textBoxUserID.TabIndex = 3;
            textBoxUserID.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 119);
            label2.Name = "label2";
            label2.Size = new Size(215, 27);
            label2.TabIndex = 2;
            label2.Text = "Podaj ID Użytkownika";
            // 
            // labelBookTitle
            // 
            labelBookTitle.AutoSize = true;
            labelBookTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBookTitle.Location = new Point(167, 24);
            labelBookTitle.Name = "labelBookTitle";
            labelBookTitle.Size = new Size(88, 28);
            labelBookTitle.TabIndex = 1;
            labelBookTitle.Text = "Ksiazka:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 33);
            label1.TabIndex = 0;
            label1.Text = "Książka";
            // 
            // panelEraseCopy
            // 
            panelEraseCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelEraseCopy.Controls.Add(cancelEraseCopyButton);
            panelEraseCopy.Controls.Add(eraseCopyButton);
            panelEraseCopy.Controls.Add(textBoxCopyIDToErase);
            panelEraseCopy.Controls.Add(label5);
            panelEraseCopy.Location = new Point(402, 107);
            panelEraseCopy.Margin = new Padding(3, 4, 3, 4);
            panelEraseCopy.Name = "panelEraseCopy";
            panelEraseCopy.Size = new Size(447, 261);
            panelEraseCopy.TabIndex = 6;
            // 
            // cancelEraseCopyButton
            // 
            cancelEraseCopyButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelEraseCopyButton.Location = new Point(102, 196);
            cancelEraseCopyButton.Margin = new Padding(3, 4, 3, 4);
            cancelEraseCopyButton.Name = "cancelEraseCopyButton";
            cancelEraseCopyButton.Size = new Size(86, 31);
            cancelEraseCopyButton.TabIndex = 3;
            cancelEraseCopyButton.Text = "Cancel";
            cancelEraseCopyButton.UseVisualStyleBackColor = true;
            cancelEraseCopyButton.Click += cancelEraseCopyButton_Click;
            // 
            // eraseCopyButton
            // 
            eraseCopyButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            eraseCopyButton.Location = new Point(223, 196);
            eraseCopyButton.Margin = new Padding(3, 4, 3, 4);
            eraseCopyButton.Name = "eraseCopyButton";
            eraseCopyButton.Size = new Size(86, 31);
            eraseCopyButton.TabIndex = 2;
            eraseCopyButton.Text = "Usun";
            eraseCopyButton.UseVisualStyleBackColor = true;
            eraseCopyButton.Click += eraseCopyButton_Click;
            // 
            // textBoxCopyIDToErase
            // 
            textBoxCopyIDToErase.Location = new Point(167, 115);
            textBoxCopyIDToErase.Margin = new Padding(3, 4, 3, 4);
            textBoxCopyIDToErase.Name = "textBoxCopyIDToErase";
            textBoxCopyIDToErase.Size = new Size(114, 27);
            textBoxCopyIDToErase.TabIndex = 1;
            textBoxCopyIDToErase.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(102, 28);
            label5.Name = "label5";
            label5.Size = new Size(268, 28);
            label5.TabIndex = 0;
            label5.Text = "Podaj Id Kopii do usunięcia";
            // 
            // panelAddCopies
            // 
            panelAddCopies.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelAddCopies.Controls.Add(cancelButtonCopies);
            panelAddCopies.Controls.Add(okButtonCopies);
            panelAddCopies.Controls.Add(textBoxCopiesAdd);
            panelAddCopies.Controls.Add(label4);
            panelAddCopies.Controls.Add(AddCopiesBookTitle);
            panelAddCopies.Controls.Add(label3);
            panelAddCopies.Location = new Point(0, 0);
            panelAddCopies.Margin = new Padding(3, 4, 3, 4);
            panelAddCopies.Name = "panelAddCopies";
            panelAddCopies.Size = new Size(395, 261);
            panelAddCopies.TabIndex = 6;
            // 
            // cancelButtonCopies
            // 
            cancelButtonCopies.Location = new Point(45, 196);
            cancelButtonCopies.Margin = new Padding(3, 4, 3, 4);
            cancelButtonCopies.Name = "cancelButtonCopies";
            cancelButtonCopies.Size = new Size(86, 31);
            cancelButtonCopies.TabIndex = 5;
            cancelButtonCopies.Text = "Anuluj";
            cancelButtonCopies.UseVisualStyleBackColor = true;
            cancelButtonCopies.Click += cancelButtonCopies_Click;
            // 
            // okButtonCopies
            // 
            okButtonCopies.Location = new Point(175, 196);
            okButtonCopies.Margin = new Padding(3, 4, 3, 4);
            okButtonCopies.Name = "okButtonCopies";
            okButtonCopies.Size = new Size(86, 31);
            okButtonCopies.TabIndex = 4;
            okButtonCopies.Text = "Ok";
            okButtonCopies.UseVisualStyleBackColor = true;
            okButtonCopies.Click += okButtonCopies_Click;
            // 
            // textBoxCopiesAdd
            // 
            textBoxCopiesAdd.Location = new Point(242, 120);
            textBoxCopiesAdd.Margin = new Padding(3, 4, 3, 4);
            textBoxCopiesAdd.Name = "textBoxCopiesAdd";
            textBoxCopiesAdd.Size = new Size(114, 27);
            textBoxCopiesAdd.TabIndex = 3;
            textBoxCopiesAdd.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 119);
            label4.Name = "label4";
            label4.Size = new Size(184, 28);
            label4.TabIndex = 2;
            label4.Text = "Podaj Liczbe Kopii";
            // 
            // AddCopiesBookTitle
            // 
            AddCopiesBookTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddCopiesBookTitle.Location = new Point(167, 37);
            AddCopiesBookTitle.Name = "AddCopiesBookTitle";
            AddCopiesBookTitle.Size = new Size(81, 28);
            AddCopiesBookTitle.TabIndex = 1;
            AddCopiesBookTitle.Text = "Ksiazka:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 37);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 0;
            label3.Text = "Ksiazka";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(EraseCopy);
            panel1.Controls.Add(EraseBook);
            panel1.Controls.Add(AddBookCopies);
            panel1.Controls.Add(borrowBook);
            panel1.Controls.Add(clearSearchButton);
            panel1.Controls.Add(searchBooksTextBox);
            panel1.Controls.Add(searchBooksButton);
            panel1.Location = new Point(3, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 99);
            panel1.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top;
            SearchButton.Location = new Point(340, 35);
            SearchButton.Margin = new Padding(3, 4, 3, 4);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(151, 31);
            SearchButton.TabIndex = 17;
            SearchButton.Text = "Znajdz";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // EraseCopy
            // 
            EraseCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EraseCopy.Location = new Point(928, 56);
            EraseCopy.Margin = new Padding(3, 4, 3, 4);
            EraseCopy.Name = "EraseCopy";
            EraseCopy.Size = new Size(151, 31);
            EraseCopy.TabIndex = 16;
            EraseCopy.Text = "Usuń kopie";
            EraseCopy.UseVisualStyleBackColor = true;
            EraseCopy.Click += EraseCopy_Click;
            // 
            // EraseBook
            // 
            EraseBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EraseBook.Location = new Point(1102, 29);
            EraseBook.Margin = new Padding(3, 4, 3, 4);
            EraseBook.Name = "EraseBook";
            EraseBook.Size = new Size(151, 31);
            EraseBook.TabIndex = 15;
            EraseBook.Text = "Usuń książkę";
            EraseBook.UseVisualStyleBackColor = true;
            EraseBook.Click += EraseBook_Click;
            // 
            // AddBookCopies
            // 
            AddBookCopies.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddBookCopies.Location = new Point(928, 4);
            AddBookCopies.Margin = new Padding(3, 4, 3, 4);
            AddBookCopies.Name = "AddBookCopies";
            AddBookCopies.Size = new Size(151, 31);
            AddBookCopies.TabIndex = 14;
            AddBookCopies.Text = "Dodaj liczbe kopii";
            AddBookCopies.UseVisualStyleBackColor = true;
            AddBookCopies.Click += AddBookCopies_Click;
            // 
            // borrowBook
            // 
            borrowBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borrowBook.Location = new Point(755, 35);
            borrowBook.Margin = new Padding(3, 4, 3, 4);
            borrowBook.Name = "borrowBook";
            borrowBook.Size = new Size(151, 31);
            borrowBook.TabIndex = 13;
            borrowBook.Text = "Wypożycz Książkę";
            borrowBook.UseVisualStyleBackColor = true;
            borrowBook.Click += borrowBook_Click;
            // 
            // clearSearchButton
            // 
            clearSearchButton.Anchor = AnchorStyles.Top;
            clearSearchButton.BackColor = Color.Red;
            clearSearchButton.Cursor = Cursors.Hand;
            clearSearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearSearchButton.ForeColor = Color.White;
            clearSearchButton.Location = new Point(526, 37);
            clearSearchButton.Name = "clearSearchButton";
            clearSearchButton.Size = new Size(29, 29);
            clearSearchButton.TabIndex = 7;
            clearSearchButton.Text = "x";
            clearSearchButton.UseVisualStyleBackColor = false;
            clearSearchButton.Click += clearSearchButton_Click;
            // 
            // searchBooksTextBox
            // 
            searchBooksTextBox.Anchor = AnchorStyles.Top;
            searchBooksTextBox.Cursor = Cursors.IBeam;
            searchBooksTextBox.Location = new Point(9, 37);
            searchBooksTextBox.MaximumSize = new Size(429, 23);
            searchBooksTextBox.Name = "searchBooksTextBox";
            searchBooksTextBox.Size = new Size(325, 23);
            searchBooksTextBox.TabIndex = 5;
            searchBooksTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // searchBooksButton
            // 
            searchBooksButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBooksButton.Cursor = Cursors.Hand;
            searchBooksButton.Location = new Point(2409, 28);
            searchBooksButton.Name = "searchBooksButton";
            searchBooksButton.Size = new Size(94, 29);
            searchBooksButton.TabIndex = 6;
            searchBooksButton.Text = "Szukaj";
            searchBooksButton.UseVisualStyleBackColor = true;
            // 
            // BookStorage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAddCopies);
            Controls.Add(panelEraseCopy);
            Controls.Add(panelBorrowBook);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookStorage";
            Size = new Size(1259, 716);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).EndInit();
            panelBorrowBook.ResumeLayout(false);
            panelBorrowBook.PerformLayout();
            panelEraseCopy.ResumeLayout(false);
            panelEraseCopy.PerformLayout();
            panelAddCopies.ResumeLayout(false);
            panelAddCopies.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
