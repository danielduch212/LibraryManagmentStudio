﻿namespace LibraryManagementStudio.Worker.Views.AdminView
{
    partial class Reports
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRaport1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRaport2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSelect1 = new System.Windows.Forms.Panel();
            this.buttonGenerate1 = new System.Windows.Forms.Button();
            this.dataTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSelect2 = new System.Windows.Forms.Panel();
            this.buttonGenerate2 = new System.Windows.Forms.Button();
            this.comboBoxAvailibility = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.countTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSelect1.SuspendLayout();
            this.panelSelect2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(568, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raporty";
            // 
            // buttonRaport1
            // 
            this.buttonRaport1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRaport1.BackColor = System.Drawing.Color.White;
            this.buttonRaport1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRaport1.Location = new System.Drawing.Point(505, 70);
            this.buttonRaport1.Name = "buttonRaport1";
            this.buttonRaport1.Size = new System.Drawing.Size(129, 23);
            this.buttonRaport1.TabIndex = 2;
            this.buttonRaport1.Text = "1 - RAPORT";
            this.buttonRaport1.UseVisualStyleBackColor = false;
            this.buttonRaport1.Click += new System.EventHandler(this.buttonRaport1_Click_2);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(67, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Historia wypożyczeń danego uzytkownika";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(807, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista książek";
            // 
            // buttonRaport2
            // 
            this.buttonRaport2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRaport2.BackColor = System.Drawing.Color.White;
            this.buttonRaport2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRaport2.Location = new System.Drawing.Point(956, 70);
            this.buttonRaport2.Name = "buttonRaport2";
            this.buttonRaport2.Size = new System.Drawing.Size(129, 23);
            this.buttonRaport2.TabIndex = 4;
            this.buttonRaport2.Text = "2 - RAPORT";
            this.buttonRaport2.UseVisualStyleBackColor = false;
            this.buttonRaport2.Click += new System.EventHandler(this.buttonRaport2_Click_2);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.buttonRaport1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonRaport2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 126);
            this.panel1.TabIndex = 6;
            // 
            // panelSelect1
            // 
            this.panelSelect1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSelect1.Controls.Add(this.buttonGenerate1);
            this.panelSelect1.Controls.Add(this.dataTimePickerTo);
            this.panelSelect1.Controls.Add(this.label6);
            this.panelSelect1.Controls.Add(this.dataTimePickerFrom);
            this.panelSelect1.Controls.Add(this.label5);
            this.panelSelect1.Controls.Add(this.textBoxUserId);
            this.panelSelect1.Controls.Add(this.label4);
            this.panelSelect1.Location = new System.Drawing.Point(6, 130);
            this.panelSelect1.Name = "panelSelect1";
            this.panelSelect1.Size = new System.Drawing.Size(1244, 110);
            this.panelSelect1.TabIndex = 7;
            // 
            // buttonGenerate1
            // 
            this.buttonGenerate1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGenerate1.BackColor = System.Drawing.Color.White;
            this.buttonGenerate1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate1.Location = new System.Drawing.Point(1055, 23);
            this.buttonGenerate1.Name = "buttonGenerate1";
            this.buttonGenerate1.Size = new System.Drawing.Size(129, 23);
            this.buttonGenerate1.TabIndex = 6;
            this.buttonGenerate1.Text = "Generuj";
            this.buttonGenerate1.UseVisualStyleBackColor = false;
            this.buttonGenerate1.Click += new System.EventHandler(this.buttonGenerate1_Click_2);
            // 
            // dataTimePickerTo
            // 
            this.dataTimePickerTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataTimePickerTo.Location = new System.Drawing.Point(745, 25);
            this.dataTimePickerTo.Name = "dataTimePickerTo";
            this.dataTimePickerTo.Size = new System.Drawing.Size(257, 23);
            this.dataTimePickerTo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(659, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data Do";
            // 
            // dataTimePickerFrom
            // 
            this.dataTimePickerFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataTimePickerFrom.Location = new System.Drawing.Point(388, 24);
            this.dataTimePickerFrom.Name = "dataTimePickerFrom";
            this.dataTimePickerFrom.Size = new System.Drawing.Size(253, 23);
            this.dataTimePickerFrom.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(303, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data Od";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxUserId.Location = new System.Drawing.Point(199, 25);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(82, 23);
            this.textBoxUserId.TabIndex = 1;
            this.textBoxUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(57, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Użytkownika";
            // 
            // panelSelect2
            // 
            this.panelSelect2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSelect2.Controls.Add(this.buttonGenerate2);
            this.panelSelect2.Controls.Add(this.comboBoxAvailibility);
            this.panelSelect2.Controls.Add(this.label10);
            this.panelSelect2.Controls.Add(this.comboBoxCategory);
            this.panelSelect2.Controls.Add(this.label7);
            this.panelSelect2.Controls.Add(this.comboBoxPublisher);
            this.panelSelect2.Controls.Add(this.label9);
            this.panelSelect2.Controls.Add(this.comboBoxAuthor);
            this.panelSelect2.Controls.Add(this.label8);
            this.panelSelect2.Location = new System.Drawing.Point(0, 132);
            this.panelSelect2.Name = "panelSelect2";
            this.panelSelect2.Size = new System.Drawing.Size(1250, 110);
            this.panelSelect2.TabIndex = 8;
            // 
            // buttonGenerate2
            // 
            this.buttonGenerate2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGenerate2.BackColor = System.Drawing.Color.White;
            this.buttonGenerate2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate2.Location = new System.Drawing.Point(1002, 52);
            this.buttonGenerate2.Name = "buttonGenerate2";
            this.buttonGenerate2.Size = new System.Drawing.Size(129, 23);
            this.buttonGenerate2.TabIndex = 6;
            this.buttonGenerate2.Text = "Generuj";
            this.buttonGenerate2.UseVisualStyleBackColor = false;
            this.buttonGenerate2.Click += new System.EventHandler(this.buttonGenerate2_Click_2);
            // 
            // comboBoxAvailibility
            // 
            this.comboBoxAvailibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxAvailibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAvailibility.FormattingEnabled = true;
            this.comboBoxAvailibility.Location = new System.Drawing.Point(518, 52);
            this.comboBoxAvailibility.Name = "comboBoxAvailibility";
            this.comboBoxAvailibility.Size = new System.Drawing.Size(222, 23);
            this.comboBoxAvailibility.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(402, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "Dostępność";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(899, 18);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(232, 23);
            this.comboBoxCategory.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(802, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Kategoria";
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(533, 16);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(232, 23);
            this.comboBoxPublisher.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(400, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Wydawnictwo";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(131, 16);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(232, 23);
            this.comboBoxAuthor.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(68, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Autor";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1241, 460);
            this.dataGridView.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Location = new System.Drawing.Point(3, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1244, 469);
            this.panel2.TabIndex = 9;
            // 
            // countTB
            // 
            this.countTB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.countTB.Location = new System.Drawing.Point(141, 721);
            this.countTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countTB.Name = "countTB";
            this.countTB.Size = new System.Drawing.Size(246, 23);
            this.countTB.TabIndex = 10;
            this.countTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(5, 720);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Podsumowanie";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.countTB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSelect1);
            this.Controls.Add(this.panelSelect2);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1250, 762);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSelect1.ResumeLayout(false);
            this.panelSelect1.PerformLayout();
            this.panelSelect2.ResumeLayout(false);
            this.panelSelect2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button buttonRaport1;
        private Label label3;
        private Label label1;
        private Button buttonRaport2;
        private Panel panel1;
        private Panel panelSelect1;
        private Label label5;
        private TextBox textBoxUserId;
        private Label label4;
        private DateTimePicker dataTimePickerTo;
        private Label label6;
        private DateTimePicker dataTimePickerFrom;
        private Button buttonGenerate1;
        private DataGridView dataGridView;
        private Panel panelSelect2;
        private Button buttonGenerate2;
        private ComboBox comboBoxAvailibility;
        private Label label10;
        private ComboBox comboBoxCategory;
        private Label label7;
        private ComboBox comboBoxPublisher;
        private Label label9;
        private ComboBox comboBoxAuthor;
        private Label label8;
        private Panel panel2;
        private TextBox countTB;
        private Label label11;
    }
}
