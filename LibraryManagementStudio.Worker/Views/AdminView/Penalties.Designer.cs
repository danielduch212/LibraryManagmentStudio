namespace LibraryManagementStudio.Worker.Views.AdminView
{
    partial class Penalties
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.penaltyGridView = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.Controls.Add(this.button2);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1250, 66);
            this.panelTop.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(574, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "Usuń karę";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(388, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj karę";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataGridView.Controls.Add(this.penaltyGridView);
            this.panelDataGridView.Location = new System.Drawing.Point(0, 62);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(1250, 654);
            this.panelDataGridView.TabIndex = 3;
            // 
            // penaltyGridView
            // 
            this.penaltyGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.penaltyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.penaltyGridView.Location = new System.Drawing.Point(0, 0);
            this.penaltyGridView.Name = "penaltyGridView";
            this.penaltyGridView.RowTemplate.Height = 25;
            this.penaltyGridView.Size = new System.Drawing.Size(1250, 654);
            this.penaltyGridView.TabIndex = 0;
            // 
            // Penalties
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panelTop);
            this.Name = "Penalties";
            this.Size = new System.Drawing.Size(1250, 716);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.penaltyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTop;
        private Button button2;
        private Button button1;
        private Panel panelDataGridView;
        private DataGridView penaltyGridView;
    }
}
