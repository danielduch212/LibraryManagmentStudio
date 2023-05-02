namespace LibraryManagementStudio.User.Views.UserAuthView
{
    partial class UserBankLoginView
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            autorizeButton = new Button();
            panel2 = new Panel();
            panelLeft = new Panel();
            panelRight = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(390, 321);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(207, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(390, 261);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(280, 309);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 7;
            label4.Text = "Haslo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(280, 252);
            label2.Name = "label2";
            label2.Size = new Size(89, 37);
            label2.TabIndex = 6;
            label2.Text = "Login";
            // 
            // autorizeButton
            // 
            autorizeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            autorizeButton.Location = new Point(409, 386);
            autorizeButton.Margin = new Padding(3, 4, 3, 4);
            autorizeButton.Name = "autorizeButton";
            autorizeButton.Size = new Size(141, 31);
            autorizeButton.TabIndex = 10;
            autorizeButton.Text = "Autoryzuj";
            autorizeButton.UseVisualStyleBackColor = true;
            autorizeButton.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(panelLeft);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 600);
            panel2.TabIndex = 13;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(192, 0, 0);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(167, 600);
            panelLeft.TabIndex = 14;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(192, 0, 0);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(747, 0);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(167, 600);
            panelRight.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(406, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 160);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // UserBankLoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(autorizeButton);
            Controls.Add(panelRight);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserBankLoginView";
            Text = "LogowanieBank";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label2;
        private Button autorizeButton;
        private Panel panel2;
        private Panel panelLeft;
        private Panel panelRight;
        private PictureBox pictureBox1;
    }
}