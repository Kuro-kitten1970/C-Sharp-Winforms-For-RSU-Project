using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Lab_Sheet_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int result, interval;
        private int dice1, dice2, dice3;

        private void btnRoll_MouseDown(object sender, MouseEventArgs e)
        {
            bool checkErr = int.TryParse(txtInterval.Text, out interval);

            if (!checkErr)
            {
                MessageBox.Show("Interval Box must be only Integer.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInterval.Focus();
                return;
            }

            if (interval <= 0)
            {
                MessageBox.Show("Number must higher than 0.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInterval.Focus();
                return;
            }

            timer.Interval = interval;
            timer.Start();
            txtResult.Clear();
        }

        private void btnRoll_MouseUp(object sender, MouseEventArgs e)
        {
            timer.Stop();
            txtResult.Text = result.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);
            dice3 = rnd.Next(1, 7);

            result = dice1 + dice2 + dice3;
            diceRoll(dice1, dice2, dice3);
        }

        private void diceRoll(int dice1, int dice2, int dice3)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            //string defPath = "YourNamespace.YourFolder.YourImage.png";
            string defPath = "Lab_Sheet_03.IMG.";

            using (Stream stream = assembly.GetManifestResourceStream(defPath + dice1 + ".png"))
            {
                picDice1.Image = new Bitmap(stream);
            }

            using (Stream stream = assembly.GetManifestResourceStream(defPath + dice2 + ".png"))
            {
                picDice2.Image = new Bitmap(stream);
            }

            using (Stream stream = assembly.GetManifestResourceStream(defPath + dice3 + ".png"))
            {
                picDice3.Image = new Bitmap(stream);
            }
        }
    }
}