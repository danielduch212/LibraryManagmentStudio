namespace LibraryManagementStudio.Parcel.Views
{
    partial class BookParcelView
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
            panel4 = new Panel();
            returnButton = new Button();
            acceptButton = new Button();
            label8 = new Label();
            label9 = new Label();
            codeTextBox = new TextBox();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.Controls.Add(returnButton);
            panel4.Controls.Add(acceptButton);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(codeTextBox);
            panel4.Location = new Point(145, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(815, 399);
            panel4.TabIndex = 1;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.Coral;
            returnButton.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            returnButton.ForeColor = SystemColors.Control;
            returnButton.Location = new Point(414, 293);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(261, 92);
            returnButton.TabIndex = 16;
            returnButton.Text = "ZWROT";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = Color.Lime;
            acceptButton.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            acceptButton.ForeColor = SystemColors.Control;
            acceptButton.Location = new Point(148, 293);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(260, 92);
            acceptButton.TabIndex = 2;
            acceptButton.Text = "ODBIÓR";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(205, 47);
            label8.Name = "label8";
            label8.Size = new Size(418, 69);
            label8.TabIndex = 14;
            label8.Text = "KSIĄŻKOMAT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(369, 221);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 15;
            label9.Text = "Podaj kod";
            // 
            // codeTextBox
            // 
            codeTextBox.Location = new Point(28, 260);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(773, 27);
            codeTextBox.TabIndex = 8;
            // 
            // BookParcel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 664);
            Controls.Add(panel4);
            Name = "BookParcelView";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label label8;
        private Label label9;
        private TextBox codeTextBox;
        private Button acceptButton;
        private Button returnButton;
    }
}
