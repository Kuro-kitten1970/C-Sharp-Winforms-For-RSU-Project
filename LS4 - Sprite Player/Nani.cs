using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_Sheet_04
{
    public partial class Nani : Form
    {
        public Nani()
        {
            InitializeComponent();
        }

        int currentFrame = 0;
        int numberOfFrames = 3;
        int num = 0;

        byte walkSide;

        ImportImages importImages = new ImportImages();

        private void tmrWalk_Tick(object sender, EventArgs e)
        {
            currentFrame = (currentFrame + 1) % numberOfFrames;

            int x = picFrame.Location.X;
            int y = picFrame.Location.Y;

            switch (walkSide)
            {
                case 0:
                    picFrame.Image = new Bitmap(importImages.upIMG[currentFrame]);
                    y -= 2;
                    break;
                case 1:
                    picFrame.Image = new Bitmap(importImages.downIMG[currentFrame]);
                    y += 2;
                    break;
                case 2:
                    picFrame.Image = new Bitmap(importImages.rightIMG[currentFrame]);
                    x += 2;
                    break;
                case 3:
                    picFrame.Image = new Bitmap(importImages.leftIMG[currentFrame]);
                    x -= 2;
                    break;
                default:
                    return;
            }

            picFrame.Location = new Point(x, y);
        }

        private void btnMouseDown(object sender, MouseEventArgs e)
        {
            if (importImages.downIMG.Count == 0 || importImages.upIMG.Count == 0 || importImages.rightIMG.Count == 0 || importImages.leftIMG.Count == 0)
            {
                MessageBox.Show("You must import content first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnPlayStop.Enabled = false;

            if (btnUp.Focused)
            {
                walkSide = 0;
            }
            else if (btnDown.Focused)
            {
                walkSide = 1;
            }
            else if (btnRight.Focused)
            {
                walkSide = 2;
            }
            else if (btnLeft.Focused)
            {
                walkSide = 3;
            }
            else
            {
                return;
            }

            tmrWalk.Start();
        }

        private void btnMouseUp(object sender, MouseEventArgs e)
        {
            btnPlayStop.Enabled = true;
            tmrWalk.Stop();
        }

        private void btnPlayStop_Click(object sender, EventArgs e)
        {
            if (importImages.downIMG.Count == 0 || importImages.upIMG.Count == 0 || importImages.rightIMG.Count == 0 || importImages.leftIMG.Count == 0)
            {
                MessageBox.Show("You must import content first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnUp.Enabled = !btnUp.Enabled;
            btnDown.Enabled = !btnDown.Enabled;
            btnRight.Enabled = !btnRight.Enabled;
            btnLeft.Enabled = !btnLeft.Enabled;

            if (btnPlayStop.Text == "PLAY ANIM")
            {
                tmrAnim.Start();
                btnPlayStop.Text = "STOP ANIM";
            }
            else
            {
                tmrAnim.Stop();
                btnPlayStop.Text = "PLAY ANIM";
            }
        }

        private void tmrAnim_Tick(object sender, EventArgs e)
        {
            currentFrame = (currentFrame + 1) % numberOfFrames;

            if (num < 5)
            {
                picFrame.Image = new Bitmap(importImages.downIMG[currentFrame]);
                num += 1;
            }
            else if (num >= 5 && num < 10)
            {
                picFrame.Image = new Bitmap(importImages.rightIMG[currentFrame]);
                num += 1;
            }
            else if (num >= 10 && num < 15)
            {
                picFrame.Image = new Bitmap(importImages.upIMG[currentFrame]);
                num += 1;
            }
            else if (num >= 15 && num < 20)
            {
                picFrame.Image = new Bitmap(importImages.leftIMG[currentFrame]);
                num += 1;
            }
            else
            {
                picFrame.Image = new Bitmap(importImages.downIMG[currentFrame]);
                num = 0;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (importImages.ShowDialog() == DialogResult.OK && importImages.downIMG.Count > 0)
            {
                previewBox.Image = new Bitmap(importImages.downIMG[currentFrame]);
                btnUp.Focus();
            }
        }

        private void btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (importImages.downIMG.Count == 0 || importImages.upIMG.Count == 0 || importImages.rightIMG.Count == 0 || importImages.leftIMG.Count == 0)
            {
                MessageBox.Show("You must import content first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.NumPad8)
            {
                btnUp.Focus();
                walkSide = 0;
                tmrWalk.Start();
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.NumPad2)
            {
                btnDown.Focus();
                walkSide = 1;
                tmrWalk.Start();
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.NumPad6)
            {
                btnRight.Focus();
                walkSide = 2;
                tmrWalk.Start();
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.NumPad4)
            {
                btnLeft.Focus();
                walkSide = 3;
                tmrWalk.Start();
            }
        }

        private void btn_KeyUp(object sender, KeyEventArgs e)
        {
            tmrWalk.Stop();
        }
    }
}