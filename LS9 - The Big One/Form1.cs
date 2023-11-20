using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab_Sheet_09
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        private int playerResult, index, playerScore = 0, pcScore = 0;

        List<int> pcResults;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pcResults = Enumerable.Range(1, 15).OrderBy(i => rnd.Next()).Take(15).ToList();

            index = 0;
            playerScore = 0;
            pcScore = 0;
            label2.Text = "0";
            label4.Text = "0";
            label5.Text = "New Game";

            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.Enabled = true;
                }
            }
        }

        private void btnNumber(object sender, EventArgs e) 
        {
            Button btn = (Button)sender;
            playerResult = Convert.ToInt32(btn.Tag);

            btn.Enabled = false;

            label5.Text = CheckResult(playerResult, pcResults[index]);
            index++;
            label2.Text = playerScore.ToString();
            label4.Text = pcScore.ToString();
        }

        private string CheckResult(int x, int y)
        {
            string returnResult = "Player : " + x + " | PC : " + y + " | ";

            if (x == 1 && y == 15)
            {
                returnResult += "Player Win!";
                playerScore++;
            }
            else if (x == 15 && y == 1)
            {
                returnResult += "Computer Win!";
                pcScore++;
            }
            else if (x == y)
            {
                returnResult += "Draw!";
            }
            else if (x > y)
            {
                returnResult += "Player Win!";
                playerScore++;
            }
            else if (x < y)
            {
                returnResult += "Computer Win!";
                pcScore++;
            }
            else { MessageBox.Show("Error!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            return returnResult;
        }
    }
}