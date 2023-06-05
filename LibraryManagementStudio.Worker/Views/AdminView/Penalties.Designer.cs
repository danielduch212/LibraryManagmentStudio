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
            this.button5 = new System.Windows.Forms.Button();
            this.searchBooksTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.penaltyGridView = new System.Windows.Forms.DataGridView();
            this.panelErasePenalty = new System.Windows.Forms.Panel();
            this.eraseYes = new System.Windows.Forms.Button();
            this.eraseNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyGridView)).BeginInit();
            this.panelErasePenalty.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.Controls.Add(this.button5);
            this.panelTop.Controls.Add(this.searchBooksTextBox);
            this.panelTop.Controls.Add(this.button4);
            this.panelTop.Controls.Add(this.labelStatus);
            this.panelTop.Controls.Add(this.button3);
            this.panelTop.Controls.Add(this.button2);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1250, 66);
            this.panelTop.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(413, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 25);
            this.button5.TabIndex = 18;
            this.button5.Text = "Znajdz";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // searchBooksTextBox
            // 
            this.searchBooksTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBooksTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBooksTextBox.Location = new System.Drawing.Point(45, 21);
            this.searchBooksTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBooksTextBox.MaximumSize = new System.Drawing.Size(376, 23);
            this.searchBooksTextBox.Name = "searchBooksTextBox";
            this.searchBooksTextBox.Size = new System.Drawing.Size(331, 23);
            this.searchBooksTextBox.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(986, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 25);
            this.button4.TabIndex = 16;
            this.button4.Text = "Pokaz Aktualne";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(835, 23);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 21);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "label1";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(1116, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 25);
            this.button3.TabIndex = 14;
            this.button3.Text = "Pokaz Historie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(570, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "Oplac Kare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataGridView.Controls.Add(this.penaltyGridView);
            this.panelDataGridView.Location = new System.Drawing.Point(0, 62);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(1250, 654);
            this.panelDataGridView.TabIndex = 3;
            // 
            // penaltyGridView
            // 
            this.penaltyGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.penaltyGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.penaltyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.penaltyGridView.Location = new System.Drawing.Point(3, 0);
            this.penaltyGridView.MultiSelect = false;
            this.penaltyGridView.Name = "penaltyGridView";
            this.penaltyGridView.ReadOnly = true;
            this.penaltyGridView.RowTemplate.Height = 25;
            this.penaltyGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.penaltyGridView.Size = new System.Drawing.Size(1244, 651);
            this.penaltyGridView.TabIndex = 0;
            // 
            // panelErasePenalty
            // 
            this.panelErasePenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelErasePenalty.Controls.Add(this.eraseYes);
            this.panelErasePenalty.Controls.Add(this.eraseNo);
            this.panelErasePenalty.Controls.Add(this.label1);
            this.panelErasePenalty.Location = new System.Drawing.Point(445, 135);
            this.panelErasePenalty.Name = "panelErasePenalty";
            this.panelErasePenalty.Size = new System.Drawing.Size(334, 203);
            this.panelErasePenalty.TabIndex = 19;
            // 
            // eraseYes
            // 
            this.eraseYes.BackColor = System.Drawing.Color.Silver;
            this.eraseYes.Location = new System.Drawing.Point(194, 114);
            this.eraseYes.Name = "eraseYes";
            this.eraseYes.Size = new System.Drawing.Size(75, 23);
            this.eraseYes.TabIndex = 2;
            this.eraseYes.Text = "TAK";
            this.eraseYes.UseVisualStyleBackColor = false;
            this.eraseYes.Click += new System.EventHandler(this.eraseYes_Click);
            // 
            // eraseNo
            // 
            this.eraseNo.BackColor = System.Drawing.Color.Lime;
            this.eraseNo.Location = new System.Drawing.Point(56, 114);
            this.eraseNo.Name = "eraseNo";
            this.eraseNo.Size = new System.Drawing.Size(75, 23);
            this.eraseNo.TabIndex = 1;
            this.eraseNo.Text = "NIE";
            this.eraseNo.UseVisualStyleBackColor = false;
            this.eraseNo.Click += new System.EventHandler(this.eraseNo_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czy usunac zaznaczona kare?";
            // 
            // Penalties
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelErasePenalty);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panelTop);
            this.Name = "Penalties";
            this.Size = new System.Drawing.Size(1250, 716);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.penaltyGridView)).EndInit();
            this.panelErasePenalty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTop;
        private Button button2;
        private Panel panelDataGridView;
        private DataGridView penaltyGridView;
        private Button button3;
        private Button button4;
        private Label labelStatus;
        private Button button5;
        private TextBox searchBooksTextBox;
        private Panel panelErasePenalty;
        private Button eraseYes;
        private Button eraseNo;
        private Label label1;
    }
}
