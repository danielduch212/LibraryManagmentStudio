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
            this.button3 = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.Controls.Add(this.button4);
            this.panelTop.Controls.Add(this.labelStatus);
            this.panelTop.Controls.Add(this.button3);
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
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(1116, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 25);
            this.button3.TabIndex = 14;
            this.button3.Text = "Pokaz Historie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(835, 23);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 21);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "label1";
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(986, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 25);
            this.button4.TabIndex = 16;
            this.button4.Text = "Pokaz Aktualne";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
        private Button button3;
        private Button button4;
        private Label labelStatus;
    }
}
