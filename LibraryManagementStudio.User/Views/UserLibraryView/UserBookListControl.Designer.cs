namespace LibraryManagementStudio.User.Views.UserLibraryView
{
    partial class UserBookListControl
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
            panel1 = new Panel();
            bookInfoButton = new Button();
            clearSearchButton = new Button();
            borrowBookButton = new Button();
            searchBooksButton = new Button();
            searchBooksTextBox = new TextBox();
            panel2 = new Panel();
            bookListGridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookListGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(bookInfoButton);
            panel1.Controls.Add(clearSearchButton);
            panel1.Controls.Add(borrowBookButton);
            panel1.Controls.Add(searchBooksButton);
            panel1.Controls.Add(searchBooksTextBox);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1838, 44);
            panel1.TabIndex = 0;
            // 
            // bookInfoButton
            // 
            bookInfoButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bookInfoButton.Cursor = Cursors.Hand;
            bookInfoButton.Location = new Point(1641, 0);
            bookInfoButton.Name = "bookInfoButton";
            bookInfoButton.Size = new Size(94, 29);
            bookInfoButton.TabIndex = 5;
            bookInfoButton.Text = "Informacje";
            bookInfoButton.UseVisualStyleBackColor = true;
            bookInfoButton.Click += bookInfoButton_Click;
            // 
            // clearSearchButton
            // 
            clearSearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearSearchButton.BackColor = Color.Red;
            clearSearchButton.Cursor = Cursors.Hand;
            clearSearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearSearchButton.ForeColor = Color.White;
            clearSearchButton.Location = new Point(1261, 3);
            clearSearchButton.Name = "clearSearchButton";
            clearSearchButton.Size = new Size(29, 29);
            clearSearchButton.TabIndex = 4;
            clearSearchButton.Text = "x";
            clearSearchButton.UseVisualStyleBackColor = false;
            clearSearchButton.Click += clearSearchButton_Click;
            // 
            // borrowBookButton
            // 
            borrowBookButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borrowBookButton.Cursor = Cursors.Hand;
            borrowBookButton.Location = new Point(1741, 0);
            borrowBookButton.Name = "borrowBookButton";
            borrowBookButton.Size = new Size(94, 29);
            borrowBookButton.TabIndex = 3;
            borrowBookButton.Text = "Wypożycz";
            borrowBookButton.UseVisualStyleBackColor = true;
            borrowBookButton.Click += borrowBookButton_Click;
            // 
            // searchBooksButton
            // 
            searchBooksButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBooksButton.Cursor = Cursors.Hand;
            searchBooksButton.Location = new Point(1161, 3);
            searchBooksButton.Name = "searchBooksButton";
            searchBooksButton.Size = new Size(94, 29);
            searchBooksButton.TabIndex = 2;
            searchBooksButton.Text = "Szukaj";
            searchBooksButton.UseVisualStyleBackColor = true;
            searchBooksButton.Click += searchBooksButton_Click;
            // 
            // searchBooksTextBox
            // 
            searchBooksTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBooksTextBox.Cursor = Cursors.IBeam;
            searchBooksTextBox.Location = new Point(3, 3);
            searchBooksTextBox.Name = "searchBooksTextBox";
            searchBooksTextBox.Size = new Size(1152, 27);
            searchBooksTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(bookListGridView);
            panel2.Location = new Point(3, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(1838, 884);
            panel2.TabIndex = 1;
            // 
            // bookListGridView
            // 
            bookListGridView.AllowUserToAddRows = false;
            bookListGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bookListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookListGridView.Cursor = Cursors.Hand;
            bookListGridView.Location = new Point(3, 0);
            bookListGridView.Name = "bookListGridView";
            bookListGridView.RowHeadersWidth = 51;
            bookListGridView.RowTemplate.Height = 29;
            bookListGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookListGridView.Size = new Size(1832, 879);
            bookListGridView.TabIndex = 0;
            // 
            // UserBookListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserBookListControl";
            Size = new Size(1845, 936);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookListGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button searchBooksButton;
        private TextBox searchBooksTextBox;
        private Panel panel2;
        private DataGridView bookListGridView;
        private Button borrowBookButton;
        private Button clearSearchButton;
        private Button bookInfoButton;
    }
}
