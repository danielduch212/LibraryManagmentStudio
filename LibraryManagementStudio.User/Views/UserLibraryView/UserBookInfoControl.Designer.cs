namespace LibraryManagementStudio.User.Views.UserLibraryView
{
    partial class UserBookInfoControl
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
            backButton = new Button();
            descriptionTB = new RichTextBox();
            categoryTB = new TextBox();
            publishDateTB = new TextBox();
            publisherTB = new TextBox();
            authorTB = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            nameTB = new TextBox();
            Label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(descriptionTB);
            panel1.Controls.Add(categoryTB);
            panel1.Controls.Add(publishDateTB);
            panel1.Controls.Add(publisherTB);
            panel1.Controls.Add(authorTB);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nameTB);
            panel1.Controls.Add(Label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1573, 788);
            panel1.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backButton.Cursor = Cursors.Hand;
            backButton.Location = new Point(1482, -1);
            backButton.Name = "backButton";
            backButton.Size = new Size(91, 29);
            backButton.TabIndex = 28;
            backButton.Text = "Powrót";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(151, 350);
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(931, 285);
            descriptionTB.TabIndex = 27;
            descriptionTB.Text = "";
            // 
            // categoryTB
            // 
            categoryTB.Location = new Point(151, 151);
            categoryTB.Name = "categoryTB";
            categoryTB.Size = new Size(931, 27);
            categoryTB.TabIndex = 26;
            // 
            // publishDateTB
            // 
            publishDateTB.Location = new Point(151, 201);
            publishDateTB.Name = "publishDateTB";
            publishDateTB.Size = new Size(931, 27);
            publishDateTB.TabIndex = 25;
            // 
            // publisherTB
            // 
            publisherTB.Location = new Point(151, 101);
            publisherTB.Name = "publisherTB";
            publisherTB.Size = new Size(931, 27);
            publisherTB.TabIndex = 24;
            // 
            // authorTB
            // 
            authorTB.Location = new Point(151, 51);
            authorTB.Name = "authorTB";
            authorTB.Size = new Size(931, 27);
            authorTB.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 345);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 22;
            label7.Text = "Opis:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 200);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 21;
            label5.Text = "Data wydania:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 150);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 20;
            label4.Text = "Kategoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 100);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 19;
            label3.Text = "Wydawnictwo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 50);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 18;
            label2.Text = "Autor:";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(151, 1);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(931, 27);
            nameTB.TabIndex = 17;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.Location = new Point(10, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(68, 25);
            Label1.TabIndex = 16;
            Label1.Text = "Nazwa:";
            // 
            // UserBookInfoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserBookInfoControl";
            Size = new Size(1579, 794);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private TextBox creationDateTB;
        private TextBox textBox6;
        private Panel panel1;
        private Button backButton;
        private RichTextBox descriptionTB;
        private TextBox categoryTB;
        private TextBox publishDateTB;
        private TextBox publisherTB;
        private TextBox authorTB;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox nameTB;
        private Label Label1;
    }
}
