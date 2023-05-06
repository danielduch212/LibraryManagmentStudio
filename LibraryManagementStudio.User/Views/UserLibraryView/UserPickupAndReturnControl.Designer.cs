namespace LibraryManagementStudio.User.Views.UserLibraryView
{
    partial class UserPickupAndReturnControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.getCodesDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.returnCodesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getCodesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnCodesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.getCodesDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.returnCodesDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 737);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Kody odbioru";
            // 
            // getCodesDataGridView
            // 
            this.getCodesDataGridView.AllowUserToAddRows = false;
            this.getCodesDataGridView.AllowUserToDeleteRows = false;
            this.getCodesDataGridView.AllowUserToResizeColumns = false;
            this.getCodesDataGridView.AllowUserToResizeRows = false;
            this.getCodesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getCodesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.getCodesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getCodesDataGridView.Location = new System.Drawing.Point(3, 41);
            this.getCodesDataGridView.Name = "getCodesDataGridView";
            this.getCodesDataGridView.RowHeadersWidth = 51;
            this.getCodesDataGridView.RowTemplate.Height = 29;
            this.getCodesDataGridView.Size = new System.Drawing.Size(480, 693);
            this.getCodesDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kody zwrotu";
            // 
            // returnCodesDataGridView
            // 
            this.returnCodesDataGridView.AllowUserToAddRows = false;
            this.returnCodesDataGridView.AllowUserToDeleteRows = false;
            this.returnCodesDataGridView.AllowUserToResizeColumns = false;
            this.returnCodesDataGridView.AllowUserToResizeRows = false;
            this.returnCodesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnCodesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.returnCodesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnCodesDataGridView.Location = new System.Drawing.Point(13, 41);
            this.returnCodesDataGridView.Name = "returnCodesDataGridView";
            this.returnCodesDataGridView.RowHeadersWidth = 51;
            this.returnCodesDataGridView.RowTemplate.Height = 29;
            this.returnCodesDataGridView.Size = new System.Drawing.Size(480, 693);
            this.returnCodesDataGridView.TabIndex = 1;
            // 
            // UserPickupAndReturnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserPickupAndReturnControl";
            this.Size = new System.Drawing.Size(1000, 737);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getCodesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnCodesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView getCodesDataGridView;
        private DataGridView returnCodesDataGridView;
        private Label label9;
        private Label label1;
    }
}
