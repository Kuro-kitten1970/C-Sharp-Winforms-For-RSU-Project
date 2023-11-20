using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_Sheet_06
{
    public partial class Form1 : Form
    {
        private Bitmap[] pcIMG = { Properties.Resources.rR, Properties.Resources.rS, Properties.Resources.rP };
        private Bitmap[] playerIMG = { Properties.Resources.pR, Properties.Resources.pS, Properties.Resources.pP };

        private int pcResult, playerResult;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void tmrPlay_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            pcResult = rnd.Next(3);

            Bitmap bitmap = pcIMG[pcResult];
            pcPicture.Image = bitmap;
        }

        private void btnRSP_Click(object sender, EventArgs e) 
        {
            tmrPlay.Enabled = false;

            Button btnRSP = (Button)sender;
            playerResult = Convert.ToInt32(btnRSP.Tag);

            playerPicture.Image = playerIMG[playerResult];

            if ((playerResult + 1) % 3 == pcResult)
            {
                MessageBox.Show("You Win!");
            }
            else if (playerResult == pcResult)
            {
                MessageBox.Show("Draw!");
            }
            else
            {
                MessageBox.Show("You Lose!");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrPlay.Enabled = true;
        }
    }
}
