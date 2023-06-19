namespace LibraryManagementStudio.Worker.Views.AdminView
{
    partial class AddBook
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
            System.Windows.Forms.Button anotherAuthorButton;
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAuthor = new System.Windows.Forms.Panel();
            this.cancelNewAuthor = new System.Windows.Forms.Button();
            this.buttonNewAuthor = new System.Windows.Forms.Button();
            this.textBoxNewAuthor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelNewPublisher = new System.Windows.Forms.Panel();
            this.cancelNewPublisher = new System.Windows.Forms.Button();
            this.buttonNewPublisher = new System.Windows.Forms.Button();
            this.textBoxNewPublisher = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCopies = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.anotherPublisherButton = new System.Windows.Forms.Button();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            anotherAuthorButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelAuthor.SuspendLayout();
            this.panelNewPublisher.SuspendLayout();
            this.SuspendLayout();
            // 
            // anotherAuthorButton
            // 
            anotherAuthorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            anotherAuthorButton.Location = new System.Drawing.Point(768, 283);
            anotherAuthorButton.Name = "anotherAuthorButton";
            anotherAuthorButton.Size = new System.Drawing.Size(143, 40);
            anotherAuthorButton.TabIndex = 6;
            anotherAuthorButton.Text = "Inne";
            anotherAuthorButton.UseVisualStyleBackColor = true;
            anotherAuthorButton.Click += new System.EventHandler(this.anotherAuthorButton_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(439, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj ksiazke";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 92);
            this.panel1.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.panelAuthor);
            this.panelContent.Controls.Add(this.panelNewPublisher);
            this.panelContent.Controls.Add(this.textBoxCopies);
            this.panelContent.Controls.Add(this.label12);
            this.panelContent.Controls.Add(this.btnAddBook);
            this.panelContent.Controls.Add(this.anotherPublisherButton);
            this.panelContent.Controls.Add(this.comboBoxPublisher);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(anotherAuthorButton);
            this.panelContent.Controls.Add(this.comboBoxAuthor);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.comboBoxCategory);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.dataTimePicker);
            this.panelContent.Controls.Add(this.descriptionTextBox);
            this.panelContent.Controls.Add(this.textTitle);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Location = new System.Drawing.Point(3, 98);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1053, 625);
            this.panelContent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(240, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data Wydania";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(240, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Opis";
            // 
            // panelAuthor
            // 
            this.panelAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAuthor.Controls.Add(this.cancelNewAuthor);
            this.panelAuthor.Controls.Add(this.buttonNewAuthor);
            this.panelAuthor.Controls.Add(this.textBoxNewAuthor);
            this.panelAuthor.Controls.Add(this.label11);
            this.panelAuthor.Controls.Add(this.label10);
            this.panelAuthor.Location = new System.Drawing.Point(667, 389);
            this.panelAuthor.Name = "panelAuthor";
            this.panelAuthor.Size = new System.Drawing.Size(341, 214);
            this.panelAuthor.TabIndex = 21;
            // 
            // cancelNewAuthor
            // 
            this.cancelNewAuthor.Location = new System.Drawing.Point(89, 130);
            this.cancelNewAuthor.Name = "cancelNewAuthor";
            this.cancelNewAuthor.Size = new System.Drawing.Size(75, 23);
            this.cancelNewAuthor.TabIndex = 23;
            this.cancelNewAuthor.Text = "Anuluj";
            this.cancelNewAuthor.UseVisualStyleBackColor = true;
            this.cancelNewAuthor.Click += new System.EventHandler(this.cancelNewAuthor_Click_1);
            // 
            // buttonNewAuthor
            // 
            this.buttonNewAuthor.Location = new System.Drawing.Point(185, 130);
            this.buttonNewAuthor.Name = "buttonNewAuthor";
            this.buttonNewAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonNewAuthor.TabIndex = 3;
            this.buttonNewAuthor.Text = "Zatwierdz";
            this.buttonNewAuthor.UseVisualStyleBackColor = true;
            this.buttonNewAuthor.Click += new System.EventHandler(this.buttonNewAuthor_Click);
            // 
            // textBoxNewAuthor
            // 
            this.textBoxNewAuthor.Location = new System.Drawing.Point(67, 79);
            this.textBoxNewAuthor.Name = "textBoxNewAuthor";
            this.textBoxNewAuthor.Size = new System.Drawing.Size(251, 23);
            this.textBoxNewAuthor.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(9, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nazwa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(94, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Dodaj nowego autora";
            // 
            // panelNewPublisher
            // 
            this.panelNewPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNewPublisher.Controls.Add(this.cancelNewPublisher);
            this.panelNewPublisher.Controls.Add(this.buttonNewPublisher);
            this.panelNewPublisher.Controls.Add(this.textBoxNewPublisher);
            this.panelNewPublisher.Controls.Add(this.label13);
            this.panelNewPublisher.Controls.Add(this.label14);
            this.panelNewPublisher.Location = new System.Drawing.Point(10, 394);
            this.panelNewPublisher.Name = "panelNewPublisher";
            this.panelNewPublisher.Size = new System.Drawing.Size(349, 223);
            this.panelNewPublisher.TabIndex = 22;
            // 
            // cancelNewPublisher
            // 
            this.cancelNewPublisher.Location = new System.Drawing.Point(69, 130);
            this.cancelNewPublisher.Name = "cancelNewPublisher";
            this.cancelNewPublisher.Size = new System.Drawing.Size(75, 23);
            this.cancelNewPublisher.TabIndex = 5;
            this.cancelNewPublisher.Text = "Anuluj";
            this.cancelNewPublisher.UseVisualStyleBackColor = true;
            // 
            // buttonNewPublisher
            // 
            this.buttonNewPublisher.Location = new System.Drawing.Point(182, 130);
            this.buttonNewPublisher.Name = "buttonNewPublisher";
            this.buttonNewPublisher.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPublisher.TabIndex = 3;
            this.buttonNewPublisher.Text = "Zatwierdz";
            this.buttonNewPublisher.UseVisualStyleBackColor = true;
            this.buttonNewPublisher.Click += new System.EventHandler(this.buttonNewPublisher_Click_1);
            // 
            // textBoxNewPublisher
            // 
            this.textBoxNewPublisher.Location = new System.Drawing.Point(67, 79);
            this.textBoxNewPublisher.Name = "textBoxNewPublisher";
            this.textBoxNewPublisher.Size = new System.Drawing.Size(251, 23);
            this.textBoxNewPublisher.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(9, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nazwa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(76, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Dodaj nowego Wydawce";
            // 
            // textBoxCopies
            // 
            this.textBoxCopies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxCopies.Location = new System.Drawing.Point(467, 370);
            this.textBoxCopies.Name = "textBoxCopies";
            this.textBoxCopies.Size = new System.Drawing.Size(39, 23);
            this.textBoxCopies.TabIndex = 23;
            this.textBoxCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(240, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Liczba kopii";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.Location = new System.Drawing.Point(365, 418);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(260, 36);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Dodaj ksiazke";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click_1);
            // 
            // anotherPublisherButton
            // 
            this.anotherPublisherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.anotherPublisherButton.Location = new System.Drawing.Point(768, 329);
            this.anotherPublisherButton.Name = "anotherPublisherButton";
            this.anotherPublisherButton.Size = new System.Drawing.Size(143, 41);
            this.anotherPublisherButton.TabIndex = 19;
            this.anotherPublisherButton.Text = "Inne";
            this.anotherPublisherButton.UseVisualStyleBackColor = true;
            this.anotherPublisherButton.Click += new System.EventHandler(this.anotherPublisherButton_Click_1);
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(467, 327);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(272, 23);
            this.comboBoxPublisher.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(240, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Wydawnictwo";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(467, 283);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(272, 23);
            this.comboBoxAuthor.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(240, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Autor";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(467, 237);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(272, 23);
            this.comboBoxCategory.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(240, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kategoria";
            // 
            // dataTimePicker
            // 
            this.dataTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataTimePicker.Location = new System.Drawing.Point(467, 187);
            this.dataTimePicker.Name = "dataTimePicker";
            this.dataTimePicker.Size = new System.Drawing.Size(272, 23);
            this.dataTimePicker.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.descriptionTextBox.Location = new System.Drawing.Point(472, 73);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descriptionTextBox.Size = new System.Drawing.Size(267, 96);
            this.descriptionTextBox.TabIndex = 10;
            this.descriptionTextBox.Text = "";
            // 
            // textTitle
            // 
            this.textTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textTitle.Location = new System.Drawing.Point(472, 39);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(267, 23);
            this.textTitle.TabIndex = 7;
            this.textTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(240, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tytuł";
            // 
            // AddBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Name = "AddBook";
            this.Size = new System.Drawing.Size(1059, 726);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelAuthor.ResumeLayout(false);
            this.panelAuthor.PerformLayout();
            this.panelNewPublisher.ResumeLayout(false);
            this.panelNewPublisher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panelContent;
        private Label label4;
        private TextBox textTitle;
        private RichTextBox descriptionTextBox;
        private DateTimePicker dataTimePicker;
        private ComboBox comboBoxCategory;
        private Label label7;
        private Label label9;
        private Button anotherAuthorButton;
        private ComboBox comboBoxAuthor;
        private Label label8;
        private Button anotherPublisherButton;
        private ComboBox comboBoxPublisher;
        private Button btnAddBook;
        private Panel panelAuthor;
        private Button buttonNewAuthor;
        private TextBox textBoxNewAuthor;
        private Label label11;
        private Label label10;
        private Panel panelNewPublisher;
        private Button buttonNewPublisher;
        private TextBox textBoxNewPublisher;
        private Label label13;
        private Label label14;
        private Button cancelNewPublisher;
        private Button cancelNewAuthor;
        private TextBox textBoxCopies;
        private Label label12;
        private Label label2;
        private Label label3;
    }
}
