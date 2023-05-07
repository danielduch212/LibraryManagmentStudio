namespace LibraryManagementStudio.Worker.Views.ParcelMaintenanceView
{
    partial class ParcelMaintenanceMainView
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
            panel2 = new Panel();
            logOutButton = new Button();
            AcceptrRequest = new Button();
            AcceptReturn = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.Location = new Point(195, 2);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(603, 447);
            contentPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(logOutButton);
            panel2.Controls.Add(AcceptrRequest);
            panel2.Controls.Add(AcceptReturn);
            panel2.Location = new Point(3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 447);
            panel2.TabIndex = 1;
            // 
            // logOutButton
            // 
            logOutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logOutButton.Cursor = Cursors.Hand;
            logOutButton.Location = new Point(3, 415);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(180, 29);
            logOutButton.TabIndex = 7;
            logOutButton.Text = "Wyloguj się";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // AcceptrRequest
            // 
            AcceptrRequest.Location = new Point(3, 38);
            AcceptrRequest.Name = "AcceptrRequest";
            AcceptrRequest.Size = new Size(180, 29);
            AcceptrRequest.TabIndex = 1;
            AcceptrRequest.Text = "Zaakceptuj zwrot";
            AcceptrRequest.UseVisualStyleBackColor = true;
            AcceptrRequest.Click += AcceptrRequest_Click;
            // 
            // AcceptReturn
            // 
            AcceptReturn.Location = new Point(3, 3);
            AcceptReturn.Name = "AcceptReturn";
            AcceptReturn.Size = new Size(180, 29);
            AcceptReturn.TabIndex = 0;
            AcceptReturn.Text = "Zaakceptuj odbiór";
            AcceptReturn.UseVisualStyleBackColor = true;
            AcceptReturn.Click += AcceptReturn_Click;
            // 
            // ParcelViewBasic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(contentPanel);
            Name = "ParcelMaintenanceMainView";
            Text = "ParcelViewBasic";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private Panel panel2;
        private Button AcceptrRequest;
        private Button AcceptReturn;
        private Button logOutButton;
    }
}