namespace Lecture7HomeWork
{
    partial class LeaveApplicationText
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
            this.LeaveAppRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeaveAppRichTextBox
            // 
            this.LeaveAppRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.LeaveAppRichTextBox.Name = "LeaveAppRichTextBox";
            this.LeaveAppRichTextBox.Size = new System.Drawing.Size(444, 346);
            this.LeaveAppRichTextBox.TabIndex = 0;
            this.LeaveAppRichTextBox.Text = "";
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(462, 10);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // LeaveApplicationText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 370);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.LeaveAppRichTextBox);
            this.Name = "LeaveApplicationText";
            this.Text = "Текст заявления об отпуске";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox LeaveAppRichTextBox;
        private System.Windows.Forms.Button PrintButton;
    }
}