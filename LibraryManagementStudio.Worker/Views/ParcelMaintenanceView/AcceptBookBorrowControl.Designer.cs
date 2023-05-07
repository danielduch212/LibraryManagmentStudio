namespace LibraryManagementStudio.Worker.Views.ParcelMaintenanceView
{
    partial class AcceptBookBorrowControl
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
            panel3 = new Panel();
            AcceptBookButton = new Button();
            panel2 = new Panel();
            bookListGridView = new DataGridView();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookListGridView).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(AcceptBookButton);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1165, 33);
            panel3.TabIndex = 6;
            // 
            // AcceptBookButton
            // 
            AcceptBookButton.Cursor = Cursors.Hand;
            AcceptBookButton.Location = new Point(3, 0);
            AcceptBookButton.Name = "AcceptBookButton";
            AcceptBookButton.Size = new Size(200, 29);
            AcceptBookButton.TabIndex = 2;
            AcceptBookButton.Text = "Akceptuj wypożyczenie";
            AcceptBookButton.UseVisualStyleBackColor = true;
            AcceptBookButton.Click += AcceptBookButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(bookListGridView);
            panel2.Location = new Point(3, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(1165, 666);
            panel2.TabIndex = 7;
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
            bookListGridView.Size = new Size(1159, 663);
            bookListGridView.TabIndex = 0;
            // 
            // AcceptBookBorrowControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "AcceptBookBorrowControl";
            Size = new Size(1171, 711);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookListGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button AcceptBookButton;
        private Panel panel2;
        private DataGridView bookListGridView;
    }
}
