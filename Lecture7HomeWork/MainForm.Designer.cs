namespace Lecture7HomeWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add1Button = new System.Windows.Forms.Button();
            this.Multiply2Button = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.OutputValueLabel = new System.Windows.Forms.Label();
            this.UndoButton = new System.Windows.Forms.Button();
            this.StartPlayButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AimLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.угадайкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хочуВОтпускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add1Button
            // 
            this.Add1Button.Location = new System.Drawing.Point(264, 116);
            this.Add1Button.Name = "Add1Button";
            this.Add1Button.Size = new System.Drawing.Size(75, 23);
            this.Add1Button.TabIndex = 0;
            this.Add1Button.Text = "+1";
            this.Add1Button.UseVisualStyleBackColor = true;
            this.Add1Button.Click += new System.EventHandler(this.Add1Button_Click);
            // 
            // Multiply2Button
            // 
            this.Multiply2Button.Location = new System.Drawing.Point(264, 162);
            this.Multiply2Button.Name = "Multiply2Button";
            this.Multiply2Button.Size = new System.Drawing.Size(75, 23);
            this.Multiply2Button.TabIndex = 1;
            this.Multiply2Button.Text = "*2";
            this.Multiply2Button.UseVisualStyleBackColor = true;
            this.Multiply2Button.Click += new System.EventHandler(this.Multiply2Button_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(264, 258);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Сброс";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // OutputValueLabel
            // 
            this.OutputValueLabel.AutoSize = true;
            this.OutputValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputValueLabel.Location = new System.Drawing.Point(91, 167);
            this.OutputValueLabel.Name = "OutputValueLabel";
            this.OutputValueLabel.Size = new System.Drawing.Size(24, 25);
            this.OutputValueLabel.TabIndex = 3;
            this.OutputValueLabel.Text = "1";
            this.OutputValueLabel.Click += new System.EventHandler(this.OutputValueLabel_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(264, 210);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(75, 23);
            this.UndoButton.TabIndex = 4;
            this.UndoButton.Text = "Назад";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // StartPlayButton
            // 
            this.StartPlayButton.Location = new System.Drawing.Point(9, 11);
            this.StartPlayButton.Name = "StartPlayButton";
            this.StartPlayButton.Size = new System.Drawing.Size(128, 45);
            this.StartPlayButton.TabIndex = 5;
            this.StartPlayButton.Text = "Играть!";
            this.StartPlayButton.UseVisualStyleBackColor = true;
            this.StartPlayButton.Click += new System.EventHandler(this.StartPlayButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AimLabel);
            this.panel1.Controls.Add(this.StartPlayButton);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 66);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AimLabel
            // 
            this.AimLabel.AutoSize = true;
            this.AimLabel.Location = new System.Drawing.Point(143, 27);
            this.AimLabel.Name = "AimLabel";
            this.AimLabel.Size = new System.Drawing.Size(229, 13);
            this.AimLabel.TabIndex = 6;
            this.AimLabel.Text = "Для начала игры нажимте кнопку \"Играть\"";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.угадайкаToolStripMenuItem,
            this.хочуВОтпускToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // угадайкаToolStripMenuItem
            // 
            this.угадайкаToolStripMenuItem.Name = "угадайкаToolStripMenuItem";
            this.угадайкаToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.угадайкаToolStripMenuItem.Text = "Угадай-ка!";
            this.угадайкаToolStripMenuItem.Click += new System.EventHandler(this.угадайкаToolStripMenuItem_Click);
            // 
            // хочуВОтпускToolStripMenuItem
            // 
            this.хочуВОтпускToolStripMenuItem.Name = "хочуВОтпускToolStripMenuItem";
            this.хочуВОтпускToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.хочуВОтпускToolStripMenuItem.Text = "Хочу в отпуск";
            this.хочуВОтпускToolStripMenuItem.Click += new System.EventHandler(this.хочуВОтпускToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 305);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.OutputValueLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Multiply2Button);
            this.Controls.Add(this.Add1Button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Умножитель";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add1Button;
        private System.Windows.Forms.Button Multiply2Button;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label OutputValueLabel;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button StartPlayButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AimLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem угадайкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хочуВОтпускToolStripMenuItem;
    }
}

