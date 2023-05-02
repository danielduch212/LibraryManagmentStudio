namespace LibraryManagementStudio.User.Views.UserAuthView
{
    partial class UserLoginView
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
            button1 = new Button();
            button2 = new Button();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            alertLabel = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(744, 556);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(158, 31);
            button1.TabIndex = 0;
            button1.Text = "Dalej";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 556);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(157, 31);
            button2.TabIndex = 1;
            button2.Text = "Zarejestruj się";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(405, 255);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(216, 27);
            emailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(405, 308);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(216, 27);
            passwordTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 45);
            label1.Name = "label1";
            label1.Size = new Size(272, 60);
            label1.TabIndex = 4;
            label1.Text = "BIBLIOTEKA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(304, 251);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(304, 304);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 6;
            label3.Text = "Hasło:";
            // 
            // alertLabel
            // 
            alertLabel.AutoSize = true;
            alertLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            alertLabel.ForeColor = Color.Red;
            alertLabel.Location = new Point(321, 208);
            alertLabel.Name = "alertLabel";
            alertLabel.Size = new Size(284, 25);
            alertLabel.TabIndex = 8;
            alertLabel.Text = "Nieprawidłowy login lub hasło";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(321, 105);
            label4.Name = "label4";
            label4.Size = new Size(276, 41);
            label4.TabIndex = 16;
            label4.Text = "Witamy ponownie";
            // 
            // UserLoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label4);
            Controls.Add(alertLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserLoginView";
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label alertLabel;
        private Label label4;
    }
}