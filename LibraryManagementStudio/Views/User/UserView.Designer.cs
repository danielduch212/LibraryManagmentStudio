namespace LibraryManagement.App.Views.User
{
    partial class UserView
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.reservedBooksButton = new System.Windows.Forms.Button();
            this.userInfoButton = new System.Windows.Forms.Button();
            this.pickupAndReturnButton = new System.Windows.Forms.Button();
            this.borrowedBookButton = new System.Windows.Forms.Button();
            this.bookListButton = new System.Windows.Forms.Button();
            this.bookParcelButton = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contentPanel.Location = new System.Drawing.Point(209, 12);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(579, 427);
            this.contentPanel.TabIndex = 7;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonsPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonsPanel.Controls.Add(this.bookParcelButton);
            this.buttonsPanel.Controls.Add(this.reservedBooksButton);
            this.buttonsPanel.Controls.Add(this.userInfoButton);
            this.buttonsPanel.Controls.Add(this.pickupAndReturnButton);
            this.buttonsPanel.Controls.Add(this.borrowedBookButton);
            this.buttonsPanel.Controls.Add(this.bookListButton);
            this.buttonsPanel.Location = new System.Drawing.Point(11, 12);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(191, 427);
            this.buttonsPanel.TabIndex = 6;
            this.buttonsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonsPanel_Paint);
            // 
            // reservedBooksButton
            // 
            this.reservedBooksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservedBooksButton.Location = new System.Drawing.Point(0, 73);
            this.reservedBooksButton.Name = "reservedBooksButton";
            this.reservedBooksButton.Size = new System.Drawing.Size(191, 29);
            this.reservedBooksButton.TabIndex = 4;
            this.reservedBooksButton.Text = "Moje rezerwacje";
            this.reservedBooksButton.UseVisualStyleBackColor = true;
            this.reservedBooksButton.Click += new System.EventHandler(this.reservedBooksButton_Click);
            // 
            // userInfoButton
            // 
            this.userInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userInfoButton.Location = new System.Drawing.Point(0, 143);
            this.userInfoButton.Name = "userInfoButton";
            this.userInfoButton.Size = new System.Drawing.Size(191, 29);
            this.userInfoButton.TabIndex = 3;
            this.userInfoButton.Text = "Konto";
            this.userInfoButton.UseVisualStyleBackColor = true;
            this.userInfoButton.Click += new System.EventHandler(this.userInfoButton_Click);
            // 
            // pickupAndReturnButton
            // 
            this.pickupAndReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pickupAndReturnButton.Location = new System.Drawing.Point(0, 108);
            this.pickupAndReturnButton.Name = "pickupAndReturnButton";
            this.pickupAndReturnButton.Size = new System.Drawing.Size(191, 29);
            this.pickupAndReturnButton.TabIndex = 2;
            this.pickupAndReturnButton.Text = "Odbiór i zwrot";
            this.pickupAndReturnButton.UseVisualStyleBackColor = true;
            this.pickupAndReturnButton.Click += new System.EventHandler(this.pickupAndReturnButton_Click);
            // 
            // borrowedBookButton
            // 
            this.borrowedBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowedBookButton.Location = new System.Drawing.Point(0, 37);
            this.borrowedBookButton.Name = "borrowedBookButton";
            this.borrowedBookButton.Size = new System.Drawing.Size(191, 29);
            this.borrowedBookButton.TabIndex = 1;
            this.borrowedBookButton.Text = "Moje książki";
            this.borrowedBookButton.UseVisualStyleBackColor = true;
            this.borrowedBookButton.Click += new System.EventHandler(this.borrowedBookButton_Click);
            // 
            // bookListButton
            // 
            this.bookListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookListButton.Location = new System.Drawing.Point(0, 3);
            this.bookListButton.Name = "bookListButton";
            this.bookListButton.Size = new System.Drawing.Size(191, 29);
            this.bookListButton.TabIndex = 0;
            this.bookListButton.Text = "Lista książek";
            this.bookListButton.UseVisualStyleBackColor = true;
            this.bookListButton.Click += new System.EventHandler(this.bookListButton_Click);
            // 
            // bookParcelButton
            // 
            this.bookParcelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookParcelButton.Location = new System.Drawing.Point(0, 178);
            this.bookParcelButton.Name = "bookParcelButton";
            this.bookParcelButton.Size = new System.Drawing.Size(191, 29);
            this.bookParcelButton.TabIndex = 5;
            this.bookParcelButton.Text = "Paczkomat";
            this.bookParcelButton.UseVisualStyleBackColor = true;
            this.bookParcelButton.Click += new System.EventHandler(this.bookParcelButton_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "UserView";
            this.Text = "Biblioteka";
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel contentPanel;
        private Panel buttonsPanel;
        private Button pickupAndReturnButton;
        private Button borrowedBookButton;
        private Button bookListButton;
        private Button userInfoButton;
        private Button reservedBooksButton;
        private Button bookParcelButton;
    }
}