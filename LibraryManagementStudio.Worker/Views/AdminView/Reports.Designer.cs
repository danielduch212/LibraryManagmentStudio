namespace LibraryManagementStudio.Worker.Views.AdminView
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
            label2 = new Label();
            buttonRaport1 = new Button();
            label3 = new Label();
            label1 = new Label();
            buttonRaport2 = new Button();
            panel1 = new Panel();
            panelSelect1 = new Panel();
            buttonGenerate1 = new Button();
            dataTimePickerTo = new DateTimePicker();
            label6 = new Label();
            dataTimePickerFrom = new DateTimePicker();
            label5 = new Label();
            textBoxUserId = new TextBox();
            label4 = new Label();
            panelSelect2 = new Panel();
            comboBoxAvailibility = new ComboBox();
            label10 = new Label();
            comboBoxCategory = new ComboBox();
            label7 = new Label();
            comboBoxPublisher = new ComboBox();
            label9 = new Label();
            comboBoxAuthor = new ComboBox();
            label8 = new Label();
            buttonGenerate2 = new Button();
            dataGridView = new DataGridView();
            panel2 = new Panel();
            countTB = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            panelSelect1.SuspendLayout();
            panelSelect2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(643, 25);
            label2.Name = "label2";
            label2.Size = new Size(132, 41);
            label2.TabIndex = 1;
            label2.Text = "Raporty";
            // 
            // buttonRaport1
            // 
            buttonRaport1.BackColor = Color.White;
            buttonRaport1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRaport1.Location = new Point(505, 107);
            buttonRaport1.Margin = new Padding(3, 4, 3, 4);
            buttonRaport1.Name = "buttonRaport1";
            buttonRaport1.Size = new Size(147, 31);
            buttonRaport1.TabIndex = 2;
            buttonRaport1.Text = "1 - RAPORT";
            buttonRaport1.UseVisualStyleBackColor = false;
            buttonRaport1.Click += buttonRaport1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(38, 104);
            label3.Name = "label3";
            label3.Size = new Size(501, 32);
            label3.TabIndex = 3;
            label3.Text = "Historia wypożyczeń danego uzytkownika:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(749, 101);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 5;
            label1.Text = "Lista książek:";
            // 
            // buttonRaport2
            // 
            buttonRaport2.BackColor = Color.White;
            buttonRaport2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRaport2.Location = new Point(919, 107);
            buttonRaport2.Margin = new Padding(3, 4, 3, 4);
            buttonRaport2.Name = "buttonRaport2";
            buttonRaport2.Size = new Size(147, 31);
            buttonRaport2.TabIndex = 4;
            buttonRaport2.Text = "2 - RAPORT";
            buttonRaport2.UseVisualStyleBackColor = false;
            buttonRaport2.Click += buttonRaport2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(buttonRaport1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonRaport2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1429, 168);
            panel1.TabIndex = 6;
            // 
            // panelSelect1
            // 
            panelSelect1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelSelect1.Controls.Add(buttonGenerate1);
            panelSelect1.Controls.Add(dataTimePickerTo);
            panelSelect1.Controls.Add(label6);
            panelSelect1.Controls.Add(dataTimePickerFrom);
            panelSelect1.Controls.Add(label5);
            panelSelect1.Controls.Add(textBoxUserId);
            panelSelect1.Controls.Add(label4);
            panelSelect1.Location = new Point(3, 207);
            panelSelect1.Margin = new Padding(3, 4, 3, 4);
            panelSelect1.Name = "panelSelect1";
            panelSelect1.Size = new Size(1422, 171);
            panelSelect1.TabIndex = 7;
            // 
            // buttonGenerate1
            // 
            buttonGenerate1.BackColor = Color.White;
            buttonGenerate1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGenerate1.Location = new Point(625, 99);
            buttonGenerate1.Margin = new Padding(3, 4, 3, 4);
            buttonGenerate1.Name = "buttonGenerate1";
            buttonGenerate1.Size = new Size(147, 31);
            buttonGenerate1.TabIndex = 6;
            buttonGenerate1.Text = "Generuj";
            buttonGenerate1.UseVisualStyleBackColor = false;
            buttonGenerate1.Click += buttonGenerate1_Click;
            // 
            // dataTimePickerTo
            // 
            dataTimePickerTo.Location = new Point(992, 63);
            dataTimePickerTo.Margin = new Padding(3, 4, 3, 4);
            dataTimePickerTo.Name = "dataTimePickerTo";
            dataTimePickerTo.Size = new Size(228, 27);
            dataTimePickerTo.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(894, 61);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 4;
            label6.Text = "Data Do:";
            // 
            // dataTimePickerFrom
            // 
            dataTimePickerFrom.Location = new Point(619, 63);
            dataTimePickerFrom.Margin = new Padding(3, 4, 3, 4);
            dataTimePickerFrom.Name = "dataTimePickerFrom";
            dataTimePickerFrom.Size = new Size(228, 27);
            dataTimePickerFrom.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(521, 61);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 2;
            label5.Text = "Data Od:";
            // 
            // textBoxUserId
            // 
            textBoxUserId.Location = new Point(381, 63);
            textBoxUserId.Margin = new Padding(3, 4, 3, 4);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(93, 27);
            textBoxUserId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(219, 63);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 0;
            label4.Text = "ID Użytkownika:";
            // 
            // panelSelect2
            // 
            panelSelect2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelSelect2.Controls.Add(comboBoxAvailibility);
            panelSelect2.Controls.Add(label10);
            panelSelect2.Controls.Add(comboBoxCategory);
            panelSelect2.Controls.Add(label7);
            panelSelect2.Controls.Add(comboBoxPublisher);
            panelSelect2.Controls.Add(label9);
            panelSelect2.Controls.Add(comboBoxAuthor);
            panelSelect2.Controls.Add(label8);
            panelSelect2.Controls.Add(buttonGenerate2);
            panelSelect2.Location = new Point(0, 203);
            panelSelect2.Margin = new Padding(3, 4, 3, 4);
            panelSelect2.Name = "panelSelect2";
            panelSelect2.Size = new Size(1429, 171);
            panelSelect2.TabIndex = 8;
            // 
            // comboBoxAvailibility
            // 
            comboBoxAvailibility.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAvailibility.FormattingEnabled = true;
            comboBoxAvailibility.Location = new Point(613, 67);
            comboBoxAvailibility.Margin = new Padding(3, 4, 3, 4);
            comboBoxAvailibility.Name = "comboBoxAvailibility";
            comboBoxAvailibility.Size = new Size(194, 28);
            comboBoxAvailibility.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(481, 67);
            label10.Name = "label10";
            label10.Size = new Size(127, 28);
            label10.TabIndex = 25;
            label10.Text = "Dostępność:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(1027, 24);
            comboBoxCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(265, 28);
            comboBoxCategory.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(909, 27);
            label7.Name = "label7";
            label7.Size = new Size(109, 28);
            label7.TabIndex = 23;
            label7.Text = "Kategoria:";
            // 
            // comboBoxPublisher
            // 
            comboBoxPublisher.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPublisher.FormattingEnabled = true;
            comboBoxPublisher.Location = new Point(613, 27);
            comboBoxPublisher.Margin = new Padding(3, 4, 3, 4);
            comboBoxPublisher.Name = "comboBoxPublisher";
            comboBoxPublisher.Size = new Size(265, 28);
            comboBoxPublisher.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(464, 29);
            label9.Name = "label9";
            label9.Size = new Size(151, 28);
            label9.TabIndex = 21;
            label9.Text = "Wydawnictwo:";
            // 
            // comboBoxAuthor
            // 
            comboBoxAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAuthor.FormattingEnabled = true;
            comboBoxAuthor.Location = new Point(176, 27);
            comboBoxAuthor.Margin = new Padding(3, 4, 3, 4);
            comboBoxAuthor.Name = "comboBoxAuthor";
            comboBoxAuthor.Size = new Size(265, 28);
            comboBoxAuthor.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(103, 24);
            label8.Name = "label8";
            label8.Size = new Size(72, 28);
            label8.TabIndex = 19;
            label8.Text = "Autor:";
            // 
            // buttonGenerate2
            // 
            buttonGenerate2.BackColor = Color.White;
            buttonGenerate2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGenerate2.Location = new Point(619, 120);
            buttonGenerate2.Margin = new Padding(3, 4, 3, 4);
            buttonGenerate2.Name = "buttonGenerate2";
            buttonGenerate2.Size = new Size(147, 31);
            buttonGenerate2.TabIndex = 6;
            buttonGenerate2.Text = "Generuj";
            buttonGenerate2.UseVisualStyleBackColor = false;
            buttonGenerate2.Click += buttonGenerate2_Click;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(3, 0);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1418, 592);
            dataGridView.TabIndex = 8;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Location = new Point(3, 351);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1422, 600);
            panel2.TabIndex = 9;
            // 
            // countTB
            // 
            countTB.Location = new Point(161, 961);
            countTB.Name = "countTB";
            countTB.Size = new Size(280, 27);
            countTB.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(6, 960);
            label11.Name = "label11";
            label11.Size = new Size(153, 25);
            label11.TabIndex = 11;
            label11.Text = "Podsumowanie:";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label11);
            Controls.Add(countTB);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelSelect1);
            Controls.Add(panelSelect2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reports";
            Size = new Size(1429, 1016);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelSelect1.ResumeLayout(false);
            panelSelect1.PerformLayout();
            panelSelect2.ResumeLayout(false);
            panelSelect2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
