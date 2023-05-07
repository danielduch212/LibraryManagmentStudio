namespace LibraryManagementStudio.User.Views.UserLibraryView
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
            contentPanel = new Panel();
            buttonsPanel = new Panel();
            logOutButton = new Button();
            userInfoButton = new Button();
            pickupAndReturnButton = new Button();
            borrowedBookButton = new Button();
            bookListButton = new Button();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.BackColor = SystemColors.Control;
            contentPanel.Location = new Point(209, 12);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(579, 427);
            contentPanel.TabIndex = 7;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonsPanel.BackColor = SystemColors.ButtonFace;
            buttonsPanel.Controls.Add(logOutButton);
            buttonsPanel.Controls.Add(userInfoButton);
            buttonsPanel.Controls.Add(pickupAndReturnButton);
            buttonsPanel.Controls.Add(borrowedBookButton);
            buttonsPanel.Controls.Add(bookListButton);
            buttonsPanel.Location = new Point(11, 12);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(191, 427);
            buttonsPanel.TabIndex = 6;
            buttonsPanel.Paint += buttonsPanel_Paint;
            // 
            // logOutButton
            // 
            logOutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logOutButton.Cursor = Cursors.Hand;
            logOutButton.Location = new Point(0, 394);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(191, 29);
            logOutButton.TabIndex = 6;
            logOutButton.Text = "Wyloguj się";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // userInfoButton
            // 
            userInfoButton.Cursor = Cursors.Hand;
            userInfoButton.Location = new Point(0, 107);
            userInfoButton.Name = "userInfoButton";
            userInfoButton.Size = new Size(191, 29);
            userInfoButton.TabIndex = 3;
            userInfoButton.Text = "Moje Konto";
            userInfoButton.UseVisualStyleBackColor = true;
            userInfoButton.Click += userInfoButton_Click;
            // 
            // pickupAndReturnButton
            // 
            pickupAndReturnButton.Cursor = Cursors.Hand;
            pickupAndReturnButton.Location = new Point(0, 72);
            pickupAndReturnButton.Name = "pickupAndReturnButton";
            pickupAndReturnButton.Size = new Size(191, 29);
            pickupAndReturnButton.TabIndex = 2;
            pickupAndReturnButton.Text = "Moje kary";
            pickupAndReturnButton.UseVisualStyleBackColor = true;
            pickupAndReturnButton.Click += pickupAndReturnButton_Click;
            // 
            // borrowedBookButton
            // 
            borrowedBookButton.Cursor = Cursors.Hand;
            borrowedBookButton.Location = new Point(0, 37);
            borrowedBookButton.Name = "borrowedBookButton";
            borrowedBookButton.Size = new Size(191, 29);
            borrowedBookButton.TabIndex = 1;
            borrowedBookButton.Text = "Moje książki";
            borrowedBookButton.UseVisualStyleBackColor = true;
            borrowedBookButton.Click += borrowedBookButton_Click;
            // 
            // bookListButton
            // 
            bookListButton.Cursor = Cursors.Hand;
            bookListButton.Location = new Point(0, 3);
            bookListButton.Name = "bookListButton";
            bookListButton.Size = new Size(191, 29);
            bookListButton.TabIndex = 0;
            bookListButton.Text = "Lista książek";
            bookListButton.UseVisualStyleBackColor = true;
            bookListButton.Click += bookListButton_Click;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 451);
            Controls.Add(contentPanel);
            Controls.Add(buttonsPanel);
            Name = "UserView";
            Text = "Biblioteka";
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private Panel buttonsPanel;
        private Button pickupAndReturnButton;
        private Button borrowedBookButton;
        private Button bookListButton;
        private Button userInfoButton;
        private Button logOutButton;
    }
}