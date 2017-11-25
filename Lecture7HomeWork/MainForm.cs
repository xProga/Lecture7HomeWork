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

    public partial class MainForm : Form
    {
        private class ActionsAndCount
        {
            public string Action { get; set; }
            public int IDAction { get; set; }
        }

        private List<ActionsAndCount> liAcCount;
        private int AimValue;

        private void Result(object sender, EventArgs e)
        {
            if (int.Parse(OutputValueLabel.Text) == AimValue)
            {
                MessageBox.Show("Цель достигнута!!! Сделано " + liAcCount.Last().IDAction + " ходов", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetButton_Click(sender, e);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            liAcCount = new List<ActionsAndCount>();
        }

        private void Add1Button_Click(object sender, EventArgs e)
        {
            OutputValueLabel.Text = (int.Parse(OutputValueLabel.Text) + 1).ToString();
            liAcCount.Add(new ActionsAndCount { Action = "+1", IDAction = liAcCount.Count + 1 });
            Result(sender, e);
        }

        private void Multiply2Button_Click(object sender, EventArgs e)
        {
            OutputValueLabel.Text = (int.Parse(OutputValueLabel.Text) * 2).ToString();
            liAcCount.Add(new ActionsAndCount { Action = "*2", IDAction = liAcCount.Count + 1 });
            Result(sender, e);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            OutputValueLabel.Text = "1";
            liAcCount.Clear();
        }

        private void OutputValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (liAcCount.Count > 0)
            {
                switch (liAcCount.Last().Action)
                {
                    case "+1":
                        OutputValueLabel.Text = (int.Parse(OutputValueLabel.Text) - 1).ToString();
                        liAcCount.Remove(liAcCount.Last());
                        break;
                    case "*2":
                        OutputValueLabel.Text = (int.Parse(OutputValueLabel.Text) / 2).ToString();
                        liAcCount.Remove(liAcCount.Last());
                        break;
                }
            }
            else
            {
                MessageBox.Show("Нет действий для отмены!", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StartPlayButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            AimValue = rnd.Next(0, 100);
            AimLabel.Text = "Цель: получить зачение " + AimValue;
        }

        private void угадайкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuessNumber gnForm = new GuessNumber();
            gnForm.Show();
        }

        private void хочуВОтпускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeaveApplication la = new LeaveApplication();
            la.Show();
        }
    }
}
