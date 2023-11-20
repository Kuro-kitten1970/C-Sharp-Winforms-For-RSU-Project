using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lab_Sheet_08
{
    public partial class MainForm : Form
    {
        private Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            txtNumResult.Text = "???";
            txtHint.Text = "Hint";

            int numResult = rnd.Next(100);
            int x = 0;

            bool loop = true;

            while (loop)
            {
                string getInput = Interaction.InputBox("Please guess number between 0-99.", "Guess Number");

                if (getInput == "") { return; }

                try
                {
                    x = Convert.ToInt32(getInput);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please Input only Integer number.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (x == numResult) { loop = false; txtNumResult.Text = x.ToString(); txtHint.Text = "That's correct!"; }
                else if (x > numResult) { txtHint.Text = "Too much!"; }
                else if (x < numResult) { txtHint.Text = "Too low!"; }
                else { return; }
            }
        }
    }
}
