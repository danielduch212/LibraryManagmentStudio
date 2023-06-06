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
            Button anotherAuthorButton;
            label1 = new Label();
            panel1 = new Panel();
            panelContent = new Panel();
            panelAuthor = new Panel();
            cancelNewAuthor = new Button();
            alertLabelAuthor = new Label();
            buttonNewAuthor = new Button();
            textBoxNewAuthor = new TextBox();
            label11 = new Label();
            label10 = new Label();
            panelNewPublisher = new Panel();
            cancelNewPublisher = new Button();
            alertLabelPublisher = new Label();
            buttonNewPublisher = new Button();
            textBoxNewPublisher = new TextBox();
            label13 = new Label();
            label14 = new Label();
            textBoxCopies = new TextBox();
            label12 = new Label();
            btnAddBook = new Button();
            anotherPublisherButton = new Button();
            comboBoxPublisher = new ComboBox();
            label9 = new Label();
            comboBoxAuthor = new ComboBox();
            label8 = new Label();
            comboBoxCategory = new ComboBox();
            label7 = new Label();
            dataTimePicker = new DateTimePicker();
            label6 = new Label();
            descriptionTextBox = new RichTextBox();
            label5 = new Label();
            textTitle = new TextBox();
            label4 = new Label();
            anotherAuthorButton = new Button();
            panel1.SuspendLayout();
            panelContent.SuspendLayout();
            panelAuthor.SuspendLayout();
            panelNewPublisher.SuspendLayout();
            SuspendLayout();
            // 
            // anotherAuthorButton
            // 
            anotherAuthorButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anotherAuthorButton.Location = new Point(768, 283);
            anotherAuthorButton.Name = "anotherAuthorButton";
            anotherAuthorButton.Size = new Size(143, 40);
            anotherAuthorButton.TabIndex = 6;
            anotherAuthorButton.Text = "Inne";
            anotherAuthorButton.UseVisualStyleBackColor = true;
            anotherAuthorButton.Click += anotherAuthorButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(439, 30);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 0;
            label1.Text = "Dodaj ksiazke";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 92);
            panel1.TabIndex = 1;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.Controls.Add(panelAuthor);
            panelContent.Controls.Add(panelNewPublisher);
            panelContent.Controls.Add(textBoxCopies);
            panelContent.Controls.Add(label12);
            panelContent.Controls.Add(btnAddBook);
            panelContent.Controls.Add(anotherPublisherButton);
            panelContent.Controls.Add(comboBoxPublisher);
            panelContent.Controls.Add(label9);
            panelContent.Controls.Add(anotherAuthorButton);
            panelContent.Controls.Add(comboBoxAuthor);
            panelContent.Controls.Add(label8);
            panelContent.Controls.Add(comboBoxCategory);
            panelContent.Controls.Add(label7);
            panelContent.Controls.Add(dataTimePicker);
            panelContent.Controls.Add(label6);
            panelContent.Controls.Add(descriptionTextBox);
            panelContent.Controls.Add(label5);
            panelContent.Controls.Add(textTitle);
            panelContent.Controls.Add(label4);
            panelContent.Location = new Point(3, 98);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1053, 625);
            panelContent.TabIndex = 2;
            // 
            // panelAuthor
            // 
            panelAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelAuthor.Controls.Add(cancelNewAuthor);
            panelAuthor.Controls.Add(alertLabelAuthor);
            panelAuthor.Controls.Add(buttonNewAuthor);
            panelAuthor.Controls.Add(textBoxNewAuthor);
            panelAuthor.Controls.Add(label11);
            panelAuthor.Controls.Add(label10);
            panelAuthor.Location = new Point(667, 389);
            panelAuthor.Name = "panelAuthor";
            panelAuthor.Size = new Size(341, 214);
            panelAuthor.TabIndex = 21;
            // 
            // cancelNewAuthor
            // 
            cancelNewAuthor.Location = new Point(89, 130);
            cancelNewAuthor.Name = "cancelNewAuthor";
            cancelNewAuthor.Size = new Size(75, 23);
            cancelNewAuthor.TabIndex = 23;
            cancelNewAuthor.Text = "Anuluj";
            cancelNewAuthor.UseVisualStyleBackColor = true;
            cancelNewAuthor.Click += cancelNewAuthor_Click;
            // 
            // alertLabelAuthor
            // 
            alertLabelAuthor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            alertLabelAuthor.Location = new Point(148, 52);
            alertLabelAuthor.Name = "alertLabelAuthor";
            alertLabelAuthor.Size = new Size(52, 17);
            alertLabelAuthor.TabIndex = 4;
            alertLabelAuthor.Text = "Nazwa:";
            // 
            // buttonNewAuthor
            // 
            buttonNewAuthor.Location = new Point(185, 130);
            buttonNewAuthor.Name = "buttonNewAuthor";
            buttonNewAuthor.Size = new Size(75, 23);
            buttonNewAuthor.TabIndex = 3;
            buttonNewAuthor.Text = "Zatwierdz";
            buttonNewAuthor.UseVisualStyleBackColor = true;
            buttonNewAuthor.Click += button2_Click;
            // 
            // textBoxNewAuthor
            // 
            textBoxNewAuthor.Location = new Point(67, 79);
            textBoxNewAuthor.Name = "textBoxNewAuthor";
            textBoxNewAuthor.Size = new Size(251, 27);
            textBoxNewAuthor.TabIndex = 2;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(9, 78);
            label11.Name = "label11";
            label11.Size = new Size(52, 17);
            label11.TabIndex = 1;
            label11.Text = "Nazwa:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(94, 25);
            label10.Name = "label10";
            label10.Size = new Size(207, 25);
            label10.TabIndex = 0;
            label10.Text = "Dodaj nowego autora";
            // 
            // panelNewPublisher
            // 
            panelNewPublisher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelNewPublisher.Controls.Add(cancelNewPublisher);
            panelNewPublisher.Controls.Add(alertLabelPublisher);
            panelNewPublisher.Controls.Add(buttonNewPublisher);
            panelNewPublisher.Controls.Add(textBoxNewPublisher);
            panelNewPublisher.Controls.Add(label13);
            panelNewPublisher.Controls.Add(label14);
            panelNewPublisher.Location = new Point(10, 394);
            panelNewPublisher.Name = "panelNewPublisher";
            panelNewPublisher.Size = new Size(349, 223);
            panelNewPublisher.TabIndex = 22;
            // 
            // cancelNewPublisher
            // 
            cancelNewPublisher.Location = new Point(69, 130);
            cancelNewPublisher.Name = "cancelNewPublisher";
            cancelNewPublisher.Size = new Size(75, 23);
            cancelNewPublisher.TabIndex = 5;
            cancelNewPublisher.Text = "Anuluj";
            cancelNewPublisher.UseVisualStyleBackColor = true;
            cancelNewPublisher.Click += cancelNewPublisher_Click;
            // 
            // alertLabelPublisher
            // 
            alertLabelPublisher.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            alertLabelPublisher.Location = new Point(148, 49);
            alertLabelPublisher.Name = "alertLabelPublisher";
            alertLabelPublisher.Size = new Size(52, 17);
            alertLabelPublisher.TabIndex = 4;
            alertLabelPublisher.Text = "Nazwa:";
            // 
            // buttonNewPublisher
            // 
            buttonNewPublisher.Location = new Point(182, 130);
            buttonNewPublisher.Name = "buttonNewPublisher";
            buttonNewPublisher.Size = new Size(75, 23);
            buttonNewPublisher.TabIndex = 3;
            buttonNewPublisher.Text = "Zatwierdz";
            buttonNewPublisher.UseVisualStyleBackColor = true;
            buttonNewPublisher.Click += buttonNewPublisher_Click;
            // 
            // textBoxNewPublisher
            // 
            textBoxNewPublisher.Location = new Point(67, 79);
            textBoxNewPublisher.Name = "textBoxNewPublisher";
            textBoxNewPublisher.Size = new Size(251, 27);
            textBoxNewPublisher.TabIndex = 2;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(9, 78);
            label13.Name = "label13";
            label13.Size = new Size(52, 17);
            label13.TabIndex = 1;
            label13.Text = "Nazwa:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(97, 18);
            label14.Name = "label14";
            label14.Size = new Size(233, 25);
            label14.TabIndex = 0;
            label14.Text = "Dodaj nowego Wydawce";
            // 
            // textBoxCopies
            // 
            textBoxCopies.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxCopies.Location = new Point(467, 370);
            textBoxCopies.Name = "textBoxCopies";
            textBoxCopies.Size = new Size(39, 27);
            textBoxCopies.TabIndex = 23;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(240, 370);
            label12.Name = "label12";
            label12.Size = new Size(136, 42);
            label12.TabIndex = 22;
            label12.Text = "Liczba kopii:";
            // 
            // btnAddBook
            // 
            btnAddBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddBook.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBook.Location = new Point(365, 418);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(260, 36);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Dodaj ksiazke";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // anotherPublisherButton
            // 
            anotherPublisherButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anotherPublisherButton.Location = new Point(768, 329);
            anotherPublisherButton.Name = "anotherPublisherButton";
            anotherPublisherButton.Size = new Size(143, 41);
            anotherPublisherButton.TabIndex = 19;
            anotherPublisherButton.Text = "Inne";
            anotherPublisherButton.UseVisualStyleBackColor = true;
            anotherPublisherButton.Click += anotherPublisherButton_Click;
            // 
            // comboBoxPublisher
            // 
            comboBoxPublisher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxPublisher.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPublisher.FormattingEnabled = true;
            comboBoxPublisher.Location = new Point(467, 327);
            comboBoxPublisher.Name = "comboBoxPublisher";
            comboBoxPublisher.Size = new Size(272, 28);
            comboBoxPublisher.TabIndex = 18;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(240, 331);
            label9.Name = "label9";
            label9.Size = new Size(162, 39);
            label9.TabIndex = 17;
            label9.Text = "Wydawnictwo:";
            // 
            // comboBoxAuthor
            // 
            comboBoxAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAuthor.FormattingEnabled = true;
            comboBoxAuthor.Location = new Point(467, 283);
            comboBoxAuthor.Name = "comboBoxAuthor";
            comboBoxAuthor.Size = new Size(272, 28);
            comboBoxAuthor.TabIndex = 16;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(240, 285);
            label8.Name = "label8";
            label8.Size = new Size(115, 46);
            label8.TabIndex = 15;
            label8.Text = "Autor:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(467, 237);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(272, 28);
            comboBoxCategory.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(240, 237);
            label7.Name = "label7";
            label7.Size = new Size(146, 46);
            label7.TabIndex = 13;
            label7.Text = "Kategoria:";
            // 
            // dataTimePicker
            // 
            dataTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataTimePicker.Location = new Point(467, 187);
            dataTimePicker.Name = "dataTimePicker";
            dataTimePicker.Size = new Size(272, 27);
            dataTimePicker.TabIndex = 12;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(237, 193);
            label6.Name = "label6";
            label6.Size = new Size(165, 33);
            label6.TabIndex = 11;
            label6.Text = "Data Wydania:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(472, 73);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(267, 96);
            descriptionTextBox.TabIndex = 10;
            descriptionTextBox.Text = "";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(233, 73);
            label5.Name = "label5";
            label5.Size = new Size(95, 38);
            label5.TabIndex = 8;
            label5.Text = "Opis:";
            // 
            // textTitle
            // 
            textTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textTitle.Location = new Point(472, 39);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(267, 27);
            textTitle.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(233, 45);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 6;
            label4.Text = "Tytul:";
            // 
            // AddBook
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Name = "AddBook";
            Size = new Size(1059, 726);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panelAuthor.ResumeLayout(false);
            panelAuthor.PerformLayout();
            panelNewPublisher.ResumeLayout(false);
            panelNewPublisher.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panelContent;
        private Label label4;
        private TextBox textTitle;
        private RichTextBox descriptionTextBox;
        private Label label5;
        private DateTimePicker dataTimePicker;
        private Label label6;
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
        private Label alertLabelAuthor;
        private Button buttonNewAuthor;
        private TextBox textBoxNewAuthor;
        private Label label11;
        private Label label10;
        private Panel panelNewPublisher;
        private Label alertLabelPublisher;
        private Button buttonNewPublisher;
        private TextBox textBoxNewPublisher;
        private Label label13;
        private Label label14;
        private Button cancelNewPublisher;
        private Button cancelNewAuthor;
        private TextBox textBoxCopies;
        private Label label12;
    }
}
