namespace LibraryManagementStudio.Worker.Views.AdminView
{
    partial class CreateAcc
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
            panelMain = new Panel();
            textBoxPassword = new TextBox();
            label10 = new Label();
            alertLabel = new Label();
            button1 = new Button();
            textBoxLocation = new TextBox();
            textBoxCode = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBoxCity = new TextBox();
            label6 = new Label();
            dateTimePicker = new DateTimePicker();
            label5 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            textBoxSurname = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.Controls.Add(textBoxPassword);
            panelMain.Controls.Add(label10);
            panelMain.Controls.Add(alertLabel);
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(textBoxLocation);
            panelMain.Controls.Add(textBoxCode);
            panelMain.Controls.Add(label8);
            panelMain.Controls.Add(label7);
            panelMain.Controls.Add(textBoxCity);
            panelMain.Controls.Add(label6);
            panelMain.Controls.Add(dateTimePicker);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(textBoxEmail);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(textBoxSurname);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(textBoxName);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label1);
            panelMain.Location = new Point(3, 0);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(978, 705);
            panelMain.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(485, 563);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(228, 27);
            textBoxPassword.TabIndex = 34;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(265, 556);
            label10.Name = "label10";
            label10.Size = new Size(147, 33);
            label10.TabIndex = 33;
            label10.Text = "Hasło:";
            // 
            // alertLabel
            // 
            alertLabel.BackColor = Color.Red;
            alertLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            alertLabel.ForeColor = Color.Black;
            alertLabel.Location = new Point(293, 115);
            alertLabel.Name = "alertLabel";
            alertLabel.Size = new Size(393, 33);
            alertLabel.TabIndex = 32;
            alertLabel.Text = "Sprawdź poprawność danych klienta!";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(417, 612);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(122, 52);
            button1.TabIndex = 31;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxLocation
            // 
            textBoxLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLocation.Location = new Point(485, 511);
            textBoxLocation.Margin = new Padding(3, 4, 3, 4);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(228, 27);
            textBoxLocation.TabIndex = 30;
            // 
            // textBoxCode
            // 
            textBoxCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCode.Location = new Point(485, 456);
            textBoxCode.Margin = new Padding(3, 4, 3, 4);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(228, 27);
            textBoxCode.TabIndex = 29;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(265, 449);
            label8.Name = "label8";
            label8.Size = new Size(214, 33);
            label8.TabIndex = 28;
            label8.Text = "Kod Pocztowy:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(265, 504);
            label7.Name = "label7";
            label7.Size = new Size(177, 33);
            label7.TabIndex = 27;
            label7.Text = "Adres:";
            // 
            // textBoxCity
            // 
            textBoxCity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCity.Location = new Point(485, 403);
            textBoxCity.Margin = new Padding(3, 4, 3, 4);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(228, 27);
            textBoxCity.TabIndex = 26;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(265, 396);
            label6.Name = "label6";
            label6.Size = new Size(147, 33);
            label6.TabIndex = 25;
            label6.Text = "Miasto:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.Location = new Point(485, 345);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(228, 27);
            dateTimePicker.TabIndex = 24;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(265, 343);
            label5.Name = "label5";
            label5.Size = new Size(214, 33);
            label5.TabIndex = 23;
            label5.Text = "Data Urodzenia:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.Location = new Point(485, 287);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(228, 27);
            textBoxEmail.TabIndex = 22;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(265, 284);
            label4.Name = "label4";
            label4.Size = new Size(177, 33);
            label4.TabIndex = 21;
            label4.Text = "Adres Email:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSurname.Location = new Point(485, 227);
            textBoxSurname.Margin = new Padding(3, 4, 3, 4);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(228, 27);
            textBoxSurname.TabIndex = 20;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(265, 224);
            label3.Name = "label3";
            label3.Size = new Size(177, 33);
            label3.TabIndex = 19;
            label3.Text = "Nazwisko:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(485, 165);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(228, 27);
            textBoxName.TabIndex = 18;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(265, 165);
            label2.Name = "label2";
            label2.Size = new Size(117, 33);
            label2.TabIndex = 17;
            label2.Text = "Imie:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(333, 60);
            label1.Name = "label1";
            label1.Size = new Size(269, 43);
            label1.TabIndex = 16;
            label1.Text = "Dodaj Użytkownika";
            // 
            // CreateAcc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateAcc";
            Size = new Size(982, 705);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Button button1;
        private TextBox textBoxLocation;
        private TextBox textBoxCode;
        private Label label8;
        private Label label7;
        private TextBox textBoxCity;
        private Label label6;
        private DateTimePicker dateTimePicker;
        private Label label5;
        private TextBox textBoxEmail;
        private Label label4;
        private TextBox textBoxSurname;
        private Label label3;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private Label alertLabel;
        private TextBox textBoxPassword;
        private Label label10;
    }
}
