namespace LibraryManagementStudio.Worker.Views.ParcelMaintenanceView
{
    partial class AcceptBookReturnControl
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
            bookListGridView = new DataGridView();
            panel3 = new Panel();
            addPenaltyButton = new Button();
            acceptReturnBook = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookListGridView).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(bookListGridView);
            panel2.Location = new Point(3, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(1237, 661);
            panel2.TabIndex = 4;
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
            bookListGridView.Size = new Size(1231, 658);
            bookListGridView.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(addPenaltyButton);
            panel3.Controls.Add(acceptReturnBook);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1234, 33);
            panel3.TabIndex = 5;
            // 
            // addPenaltyButton
            // 
            addPenaltyButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addPenaltyButton.Cursor = Cursors.Hand;
            addPenaltyButton.Location = new Point(1031, 0);
            addPenaltyButton.Name = "addPenaltyButton";
            addPenaltyButton.Size = new Size(200, 29);
            addPenaltyButton.TabIndex = 3;
            addPenaltyButton.Text = "Nałóż karę";
            addPenaltyButton.UseVisualStyleBackColor = true;
            addPenaltyButton.Click += addPenaltyButton_Click;
            // 
            // acceptReturnBook
            // 
            acceptReturnBook.Cursor = Cursors.Hand;
            acceptReturnBook.Location = new Point(0, 0);
            acceptReturnBook.Name = "acceptReturnBook";
            acceptReturnBook.Size = new Size(200, 29);
            acceptReturnBook.TabIndex = 2;
            acceptReturnBook.Text = "Akceptuj zwrot";
            acceptReturnBook.UseVisualStyleBackColor = true;
            acceptReturnBook.Click += acceptReturnBook_Click;
            // 
            // AcceptBookReturnControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "AcceptBookReturnControl";
            Size = new Size(1243, 706);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookListGridView).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button acceptButton;
        private Panel panel2;
        private DataGridView bookListGridView;
        private Panel panel1;
        private Button clearSearchButton;
        private Button borrowBookButton;
        private Button searchBooksButton;
        private Button acceptReturnBook;
        private Panel panel3;
        private Button addPenaltyButton;
    }
}
