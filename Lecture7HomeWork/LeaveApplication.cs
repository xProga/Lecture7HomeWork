using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture7HomeWork
{
    public partial class LeaveApplication : Form
    {
        private List<Control> liCtrl = new List<Control>();

        public LeaveApplication()
        {
            InitializeComponent();
            CurrentCompanyRulerFIOComboBox.SelectedIndex = 0;
            CurrentCompanyRulerPositionComboBox.SelectedIndex = 0;
        }

        private string CheckFields()
        {
            string outputStr = string.Empty;

            if (FirstNameTextBox.Text == string.Empty)
            {
                outputStr += "Фамилия\n";
            }
            if (NameTextBox.Text == string.Empty)
            {
                outputStr += "Имя\n";
            }
            if (LastNameTextBox.Text == string.Empty)
            {
                outputStr += "Отчество\n";
            }
            return outputStr;
        }

        private void InputTextLeaveApp()
        {
            LeaveApplicationText lat = new LeaveApplicationText();
            var latrtb = lat.LeaveAppRichTextBox;
            latrtb.SelectionAlignment = HorizontalAlignment.Left;
            if (CurrentCompanyRulerPositionComboBox.SelectedIndex == 0)
            { latrtb.Text += "Начальнику предприятия\r\n"; }
            if (CurrentCompanyRulerPositionComboBox.SelectedIndex == 1)
            { latrtb.Text += "И.О. Начальника предприятия\r\n"; }
            if (CurrentCompanyRulerFIOComboBox.SelectedIndex == 0)
            {
                latrtb.Text += "Полушину Е.И.\r\n";
            }
            if (CurrentCompanyRulerFIOComboBox.SelectedIndex == 1)
            {
                latrtb.Text += "Крылову В.А.\r\n";
            }

            latrtb.Text += "\r\n\r\n\r\n";
            latrtb.SelectionAlignment = HorizontalAlignment.Center;
            latrtb.Text += "Заявление\r\n\r\n";
            latrtb.SelectionAlignment = HorizontalAlignment.Left;
            int days = (EndVacationDateTimePicker.Value - StartVacationDateTimePicker.Value).Days;
            latrtb.Text += "Я, " + FirstNameTextBox.Text + " " + NameTextBox.Text + " " + LastNameTextBox.Text + ", прошу предоставить мне отпуск с " + StartVacationDateTimePicker.Value.ToShortDateString()
                + " по " + EndVacationDateTimePicker.Value.ToShortDateString() + ", в количестве " + days + " дней.\r\n\r\n";
            latrtb.Text += DateTime.Now.ToShortDateString() + "                                                                                             " + FirstNameTextBox.Text + " " + NameTextBox.Text.Substring(0, 1) + "." + LastNameTextBox.Text.Substring(0, 1) + ".";
            lat.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chkStr = CheckFields();
            if (chkStr != string.Empty)
            {
                MessageBox.Show("Не заполнены следующие поля:\n\n" + chkStr, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InputTextLeaveApp();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrentCompanyRulerFIOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)CurrentCompanyRulerFIOComboBox.SelectedItem == "Полушин В.И.")
            {
                CurrentCompanyRulerPositionComboBox.SelectedIndex = 0;
            }
            else if ((string)CurrentCompanyRulerFIOComboBox.SelectedItem == "Крылов В.А.")
            {
                CurrentCompanyRulerPositionComboBox.SelectedIndex = 1;
            }

        }
    }
}
