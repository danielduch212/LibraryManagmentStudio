namespace LibraryManagementStudio.User.Views.UserAuthView
{
    partial class UserSuccessfulRegistrationView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            labelName = new Label();
            label7 = new Label();
            labelSurname = new Label();
            label9 = new Label();
            labelEmail = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(310, 122);
            label3.Name = "label3";
            label3.Size = new Size(259, 41);
            label3.TabIndex = 6;
            label3.Text = "Rejestracja konta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(295, 51);
            label1.Name = "label1";
            label1.Size = new Size(292, 62);
            label1.TabIndex = 5;
            label1.Text = "BIBLIOTEKA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(295, 189);
            label2.Name = "label2";
            label2.Size = new Size(312, 23);
            label2.TabIndex = 7;
            label2.Text = "Rejestracja Konta przebiegła pomyślnie.";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(748, 555);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(154, 32);
            button1.TabIndex = 10;
            button1.Text = "Zaloguj się";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(544, 252);
            labelName.Name = "labelName";
            labelName.Size = new Size(140, 32);
            labelName.TabIndex = 12;
            labelName.Text = "XXXXXXXXX";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(219, 252);
            label7.Name = "label7";
            label7.Size = new Size(53, 28);
            label7.TabIndex = 11;
            label7.Text = "Imie";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSurname.Location = new Point(544, 297);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(140, 32);
            labelSurname.TabIndex = 14;
            labelSurname.Text = "XXXXXXXXX";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(219, 297);
            label9.Name = "label9";
            label9.Size = new Size(103, 28);
            label9.TabIndex = 13;
            label9.Text = "Nazwisko";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(544, 343);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(140, 32);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "XXXXXXXXX";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(219, 343);
            label11.Name = "label11";
            label11.Size = new Size(64, 28);
            label11.TabIndex = 15;
            label11.Text = "Email";
            // 
            // AutoryzacjaKoniec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(labelEmail);
            Controls.Add(label11);
            Controls.Add(labelSurname);
            Controls.Add(label9);
            Controls.Add(labelName);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserSuccessfulRegistrationView";
            Text = "AutoryzacjaKoniec";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label labelName;
        private Label label7;
        private Label labelSurname;
        private Label label9;
        private Label labelEmail;
        private Label label11;
    }
}