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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchBooksTextBox = new System.Windows.Forms.TextBox();
            this.searchBooksButton = new System.Windows.Forms.Button();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.bookDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1098, 527);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.clearSearchButton);
            this.panel1.Controls.Add(this.searchBooksTextBox);
            this.panel1.Controls.Add(this.searchBooksButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 66);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(874, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Usuń książkę";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(736, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Dodaj liczbe kopii";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Wypożycz Książkę";
            this.button1.UseVisualStyleBackColor = true;
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
            this.searchBooksTextBox.Location = new System.Drawing.Point(12, 20);
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
            this.bookDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bookDataGridView.Location = new System.Drawing.Point(0, 66);
            this.bookDataGridView.MultiSelect = false;
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.ReadOnly = true;
            this.bookDataGridView.RowTemplate.Height = 25;
            this.bookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookDataGridView.Size = new System.Drawing.Size(1098, 461);
            this.bookDataGridView.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(736, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Usuń kopie";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BookStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "BookStorage";
            this.Size = new System.Drawing.Size(1098, 527);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button clearSearchButton;
        private TextBox searchBooksTextBox;
        private Button searchBooksButton;
        private DataGridView bookDataGridView;
        private Button button4;
    }
}
