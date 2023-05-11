namespace LibraryManagementStudio.User.Views.UserLibraryView
{
    partial class UserPenaltiesControl
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
            splitContainer1 = new SplitContainer();
            label9 = new Label();
            getCodesDataGridView = new DataGridView();
            label1 = new Label();
            returnCodesDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)getCodesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnCodesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(getCodesDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(returnCodesDataGridView);
            splitContainer1.Size = new Size(1000, 737);
            splitContainer1.SplitterDistance = 500;
            splitContainer1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(157, 25);
            label9.TabIndex = 16;
            label9.Text = "Nieopłacone kary";
            // 
            // getCodesDataGridView
            // 
            getCodesDataGridView.AllowUserToAddRows = false;
            getCodesDataGridView.AllowUserToDeleteRows = false;
            getCodesDataGridView.AllowUserToResizeColumns = false;
            getCodesDataGridView.AllowUserToResizeRows = false;
            getCodesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            getCodesDataGridView.BackgroundColor = Color.White;
            getCodesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            getCodesDataGridView.Location = new Point(3, 41);
            getCodesDataGridView.Name = "getCodesDataGridView";
            getCodesDataGridView.RowHeadersWidth = 51;
            getCodesDataGridView.RowTemplate.Height = 29;
            getCodesDataGridView.Size = new Size(480, 693);
            getCodesDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 17;
            label1.Text = "Opłacone kary";
            // 
            // returnCodesDataGridView
            // 
            returnCodesDataGridView.AllowUserToAddRows = false;
            returnCodesDataGridView.AllowUserToDeleteRows = false;
            returnCodesDataGridView.AllowUserToResizeColumns = false;
            returnCodesDataGridView.AllowUserToResizeRows = false;
            returnCodesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            returnCodesDataGridView.BackgroundColor = Color.White;
            returnCodesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            returnCodesDataGridView.Location = new Point(13, 41);
            returnCodesDataGridView.Name = "returnCodesDataGridView";
            returnCodesDataGridView.RowHeadersWidth = 51;
            returnCodesDataGridView.RowTemplate.Height = 29;
            returnCodesDataGridView.Size = new Size(480, 693);
            returnCodesDataGridView.TabIndex = 1;
            // 
            // UserPickupAndReturnControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(splitContainer1);
            Name = "UserPenaltiesControl";
            Size = new Size(1000, 737);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)getCodesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnCodesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView getCodesDataGridView;
        private Label label9;
        private Label label1;
        private DataGridView returnCodesDataGridView;
    }
}
