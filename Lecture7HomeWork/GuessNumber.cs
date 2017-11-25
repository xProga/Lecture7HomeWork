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
    public partial class GuessNumber : Form
    {
        private int AimValue;
        private List<ValuesAndCount> liValCount;

        private class ValuesAndCount
        {
            public int Values { get; set; }
            public int IDAction { get; set; }
        }

        public GuessNumber()
        {
            InitializeComponent();
            Random rnd = new Random();
            AimValue = rnd.Next(0, 100);
            liValCount = new List<ValuesAndCount>();
        }

        private void Result(int inputValue)
        {
            if (inputValue == AimValue)
            {
                MessageBox.Show("Вы угадали число!!!", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Хотите сыграть еще раз?", "Еще раз?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Random rnd = new Random();
                    AimValue = rnd.Next(0, 100);
                    MuchOrLessValueLabel.Text = "";
                    UserValueTextBox.Text = "";
                    UserValueTextBox.Focus();
                }
            }
        }

        private void GuessNumber_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(UserValueTextBox.Text) < AimValue)
            {
                MuchOrLessValueLabel.Text = "Маловато... Нужно больше (золота)";
            }
            else if (int.Parse(UserValueTextBox.Text) > AimValue)
            {
                MuchOrLessValueLabel.Text = "Многовато...";
            }
            else if (int.Parse(UserValueTextBox.Text) == AimValue)
            {
                Result(int.Parse(UserValueTextBox.Text));
            }
            UserValueTextBox.SelectionStart = 0;
            UserValueTextBox.SelectionLength = UserValueTextBox.Text.Length;
        }
    }
}
