namespace LibraryManagementStudio.Worker.Views.ParcelMaintenanceView
{
    partial class AddPenaltyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            bookCodeTB = new TextBox();
            descriptionTB = new TextBox();
            label1 = new Label();
            UserCodeTB = new TextBox();
            backButton = new Button();
            panel4 = new Panel();
            priceTB = new TextBox();
            label4 = new Label();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(274, 39);
            label9.Name = "label9";
            label9.Size = new Size(266, 25);
            label9.TabIndex = 22;
            label9.Text = "Zgłoszenie uszkodzenia książki";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 110);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 24;
            label2.Text = "Kod książki";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 282);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 25;
            label3.Text = "Opis uszkodzeń książki";
            // 
            // button1
            // 
            button1.Location = new Point(593, 527);
            button1.Name = "button1";
            button1.Size = new Size(181, 39);
            button1.TabIndex = 26;
            button1.Text = "Dodaj zgłoszenie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bookCodeTB
            // 
            bookCodeTB.Location = new Point(22, 138);
            bookCodeTB.Name = "bookCodeTB";
            bookCodeTB.ReadOnly = true;
            bookCodeTB.Size = new Size(752, 27);
            bookCodeTB.TabIndex = 27;
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(22, 310);
            descriptionTB.Multiline = true;
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(752, 94);
            descriptionTB.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 199);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 29;
            label1.Text = "Kod Wypożyczającego";
            // 
            // UserCodeTB
            // 
            UserCodeTB.Location = new Point(22, 227);
            UserCodeTB.Name = "UserCodeTB";
            UserCodeTB.ReadOnly = true;
            UserCodeTB.Size = new Size(752, 27);
            UserCodeTB.TabIndex = 30;
            // 
            // backButton
            // 
            backButton.Location = new Point(22, 527);
            backButton.Name = "backButton";
            backButton.Size = new Size(181, 39);
            backButton.TabIndex = 31;
            backButton.Text = "Powrót";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.MistyRose;
            panel4.Controls.Add(priceTB);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(backButton);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(UserCodeTB);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(descriptionTB);
            panel4.Controls.Add(bookCodeTB);
            panel4.Location = new Point(8, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(815, 694);
            panel4.TabIndex = 32;
            // 
            // priceTB
            // 
            priceTB.Location = new Point(22, 450);
            priceTB.Name = "priceTB";
            priceTB.Size = new Size(752, 27);
            priceTB.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 422);
            label4.Name = "label4";
            label4.Size = new Size(199, 25);
            label4.TabIndex = 32;
            label4.Text = "Cena do uregulowania";
            // 
            // AddPenaltyControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Name = "AddPenaltyControl";
            Size = new Size(830, 817);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label9;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox bookCodeTB;
        private TextBox descriptionTB;
        private Label label1;
        private TextBox UserCodeTB;
        private Button backButton;
        private Panel panel4;
        private TextBox priceTB;
        private Label label4;
    }
}
