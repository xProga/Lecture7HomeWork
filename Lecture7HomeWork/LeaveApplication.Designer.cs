namespace Lecture7HomeWork
{
    partial class LeaveApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentCompanyRulerFIOComboBox = new System.Windows.Forms.ComboBox();
            this.CurrentCompanyRulerPositionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TabelNumberTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartVacationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EndVacationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заполните все поля.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Руководитель предпоиятия:";
            // 
            // CurrentCompanyRulerFIOComboBox
            // 
            this.CurrentCompanyRulerFIOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentCompanyRulerFIOComboBox.FormattingEnabled = true;
            this.CurrentCompanyRulerFIOComboBox.Items.AddRange(new object[] {
            "Полушин В.И.",
            "Крылов В.А."});
            this.CurrentCompanyRulerFIOComboBox.Location = new System.Drawing.Point(187, 45);
            this.CurrentCompanyRulerFIOComboBox.Name = "CurrentCompanyRulerFIOComboBox";
            this.CurrentCompanyRulerFIOComboBox.Size = new System.Drawing.Size(191, 21);
            this.CurrentCompanyRulerFIOComboBox.TabIndex = 2;
            this.CurrentCompanyRulerFIOComboBox.SelectedIndexChanged += new System.EventHandler(this.CurrentCompanyRulerFIOComboBox_SelectedIndexChanged);
            // 
            // CurrentCompanyRulerPositionComboBox
            // 
            this.CurrentCompanyRulerPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentCompanyRulerPositionComboBox.Enabled = false;
            this.CurrentCompanyRulerPositionComboBox.FormattingEnabled = true;
            this.CurrentCompanyRulerPositionComboBox.Items.AddRange(new object[] {
            "Начальник предприятия",
            "И.О. начальника предприятия"});
            this.CurrentCompanyRulerPositionComboBox.Location = new System.Drawing.Point(187, 72);
            this.CurrentCompanyRulerPositionComboBox.Name = "CurrentCompanyRulerPositionComboBox";
            this.CurrentCompanyRulerPositionComboBox.Size = new System.Drawing.Size(191, 21);
            this.CurrentCompanyRulerPositionComboBox.TabIndex = 4;
            this.CurrentCompanyRulerPositionComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Должность рук. предпиятия:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Фамилия:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(175, 13);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.FirstNameTextBox.TabIndex = 6;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(175, 39);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(151, 20);
            this.NameTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Имя:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(175, 65);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.LastNameTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Отчество:";
            // 
            // TabelNumberTextBox
            // 
            this.TabelNumberTextBox.Location = new System.Drawing.Point(175, 91);
            this.TabelNumberTextBox.Name = "TabelNumberTextBox";
            this.TabelNumberTextBox.Size = new System.Drawing.Size(151, 20);
            this.TabelNumberTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Табельный номер:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.EndVacationDateTimePicker);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.StartVacationDateTimePicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TabelNumberTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.FirstNameTextBox);
            this.groupBox1.Controls.Add(this.LastNameTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 182);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ваши личные данные";
            // 
            // StartVacationDateTimePicker
            // 
            this.StartVacationDateTimePicker.Location = new System.Drawing.Point(175, 117);
            this.StartVacationDateTimePicker.Name = "StartVacationDateTimePicker";
            this.StartVacationDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.StartVacationDateTimePicker.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Дата начала отпуска:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Дата окончания отпуска:";
            // 
            // EndVacationDateTimePicker
            // 
            this.EndVacationDateTimePicker.Location = new System.Drawing.Point(175, 143);
            this.EndVacationDateTimePicker.Name = "EndVacationDateTimePicker";
            this.EndVacationDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.EndVacationDateTimePicker.TabIndex = 15;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(148, 309);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 14;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LeaveApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 344);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CurrentCompanyRulerPositionComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CurrentCompanyRulerFIOComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LeaveApplication";
            this.Text = "Создание заявления на отпуск";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CurrentCompanyRulerFIOComboBox;
        private System.Windows.Forms.ComboBox CurrentCompanyRulerPositionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TabelNumberTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker EndVacationDateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker StartVacationDateTimePicker;
        private System.Windows.Forms.Button CreateButton;
    }
}