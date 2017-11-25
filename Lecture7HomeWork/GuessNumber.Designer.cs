namespace Lecture7HomeWork
{
    partial class GuessNumber
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
            this.MuchOrLessValueLabel = new System.Windows.Forms.Label();
            this.UserValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputUserValueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игра \"Угадай-ка!\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Угадайте загаданное компьютером число за минимальное количество попыток.";
            // 
            // MuchOrLessValueLabel
            // 
            this.MuchOrLessValueLabel.AutoSize = true;
            this.MuchOrLessValueLabel.Location = new System.Drawing.Point(138, 82);
            this.MuchOrLessValueLabel.Name = "MuchOrLessValueLabel";
            this.MuchOrLessValueLabel.Size = new System.Drawing.Size(0, 13);
            this.MuchOrLessValueLabel.TabIndex = 3;
            // 
            // UserValueTextBox
            // 
            this.UserValueTextBox.Location = new System.Drawing.Point(198, 117);
            this.UserValueTextBox.Name = "UserValueTextBox";
            this.UserValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserValueTextBox.TabIndex = 4;
            this.UserValueTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите предполагаемое число:";
            // 
            // InputUserValueButton
            // 
            this.InputUserValueButton.Location = new System.Drawing.Point(304, 115);
            this.InputUserValueButton.Name = "InputUserValueButton";
            this.InputUserValueButton.Size = new System.Drawing.Size(75, 23);
            this.InputUserValueButton.TabIndex = 6;
            this.InputUserValueButton.Text = "Ввести";
            this.InputUserValueButton.UseVisualStyleBackColor = true;
            this.InputUserValueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 192);
            this.Controls.Add(this.InputUserValueButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserValueTextBox);
            this.Controls.Add(this.MuchOrLessValueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GuessNumber";
            this.Text = "Угайдай-ка!";
            this.Load += new System.EventHandler(this.GuessNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MuchOrLessValueLabel;
        private System.Windows.Forms.TextBox UserValueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InputUserValueButton;
    }
}