using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lab_Sheet_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int playerCurrentHP, botCurrentHP;
        private int playerMaxHP = 1000000, botMaxHP = 100000;

        private int ATK2CD, ATK3CD;
        private int botATK2CD, botATK3CD;

        private string playerLog = Environment.NewLine + "Player ATK";
        private string botLog = Environment.NewLine + "Bot ATK";

        private Random powerOfATK = new Random();
        private Random botATKSelection = new Random();

        private void btnStart_Click(object sender, EventArgs e)
        {
            playerCurrentHP = playerMaxHP; botCurrentHP = botMaxHP;

            foreach (Control ctl in this.Controls)
            {
                if (ctl.GetType() == typeof(Button)) ctl.Enabled = true;
            }

            tmrBotPlay.Enabled = true;
        }

        private void btnATK_Click(object sender, EventArgs e)
        {
            byte x = Convert.ToByte((sender as Button).Tag);

            AttackSystem(x, ref botCurrentHP, true);
            lblBotHP.Text = botCurrentHP.ToString("#,0") + "/1,000,000";
        }

        private void tmrBotPlay_Tick(object sender, EventArgs e)
        {
            byte x = (byte)botATKSelection.Next(1, 4);

            if ((x == 2 && botATK2CD != 0) || (x == 3 && botATK3CD != 0))
            {
                AttackSystem(1, ref playerCurrentHP, false);
                lblPlayerHP.Text = playerCurrentHP.ToString("#,0") + "/1,000,000";
                return;
            }

            AttackSystem(x, ref playerCurrentHP, false);
            lblPlayerHP.Text = playerCurrentHP.ToString("#,0") + "/1,000,000";
        }

        private void tmrCD3_Tick(object sender, EventArgs e)
        {
            ATK3CD--;
            btnATK3.Text = ATK3CD.ToString();

            if (ATK3CD == 0)
            {
                btnATK3.Text = "ATK3";
                btnATK3.Enabled = true;
                tmrCD3.Enabled = false;
            }
        }

        private void tmrCD2_Tick(object sender, EventArgs e)
        {
            ATK2CD--;
            btnATK2.Text = ATK2CD.ToString();

            if (ATK2CD == 0)
            {
                btnATK2.Text = "ATK2";
                btnATK2.Enabled = true;
                tmrCD2.Enabled = false;
            }
        }

        private void tmrCDBot2_Tick(object sender, EventArgs e)
        {
            botATK2CD--;
            lblATK2.Text = botATK2CD.ToString();

            if (botATK2CD == 0)
            {
                lblATK2.Text = "ATK2";
                tmrCDBot2.Enabled = false;
            }
        }

        private void tmrCDBot3_Tick(object sender, EventArgs e)
        {
            botATK3CD--;
            lblATK3.Text = botATK3CD.ToString();

            if (botATK3CD == 0)
            {
                btnATK2.Text = "ATK2";
                tmrCDBot3.Enabled = false;
            }
        }

        private void AttackSystem(byte atkCase, ref int currentHP, bool isPlayer)
        {
            switch (atkCase)
            {
                case 1:
                    int power1 = powerOfATK.Next(1500, 1701);
                    currentHP -= power1;

                    LogShow(isPlayer, atkCase, power1);
                    HPChecker(isPlayer, currentHP);
                    break;
                case 2:
                    CooldownSystem(atkCase, isPlayer);
                    int power2 = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        power2 = powerOfATK.Next(1000, 2001);
                        currentHP -= power2;
                        LogShow(isPlayer, atkCase, power2);
                    }

                    HPChecker(isPlayer, currentHP);
                    break;
                case 3:
                    CooldownSystem(atkCase, isPlayer);

                    if (currentHP < 250000)
                    {
                        if (isPlayer)
                        {
                            playerATK3.Tick += (sender, e) => playerATK3_Tick(sender, e, ref botCurrentHP);
                            playerATK3.Enabled = true;
                        }
                        else
                        {
                            botATK3.Tick += (sender, e) => botATK3_Tick(sender, e, ref botCurrentHP);
                            botATK3.Enabled = true;
                        }
                        return;
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        int power3 = powerOfATK.Next(1400, 2501);
                        currentHP -= power3;
                        LogShow(isPlayer, atkCase, power3);
                    }

                    HPChecker(isPlayer, currentHP);
                    break;
            }
        }

        private void playerATK3_Tick(object sender, EventArgs e, ref int currentHP)
        {
            int power = powerOfATK.Next(1400, 2501);
            currentHP -= power;
            lblBotHP.Text = botCurrentHP.ToString("#,0") + "/1,000,000";
            LogShow(true, 3, power);

            HPChecker(true, currentHP);
        }

        private void botATK3_Tick(object sender, EventArgs e, ref int currentHP)
        {
            int power = powerOfATK.Next(1400, 2501);
            currentHP -= power;
            lblPlayerHP.Text = botCurrentHP.ToString("#,0") + "/1,000,000";
            LogShow(false, 3, power);

            HPChecker(false, currentHP);
        }

        private void CooldownSystem(byte Case, bool isPlayer)
        {
            if (isPlayer)
            {
                if (Case == 2 && ATK2CD == 0)
                {
                    ATK2CD = 30;
                    btnATK2.Enabled = false;
                    tmrCD2.Enabled = true;
                }
                else if (Case == 3 && ATK3CD == 0)
                {
                    ATK3CD = 90;
                    btnATK3.Enabled = false;
                    tmrCD3.Enabled = true;
                }
            }
            else
            {
                if (Case == 2 && botATK2CD == 0)
                {
                    botATK2CD = 30;
                    tmrCDBot2.Enabled = true;
                }
                else if (Case == 3 && botATK3CD == 0)
                {
                    botATK3CD = 90;
                    tmrCDBot3.Enabled = true;
                }
            }
        }

        private void LogShow(bool isPlayer, byte atkIndex, int damage)
        {
            string text = atkIndex + " deals damage : " + damage;

            txbLog.AppendText((isPlayer) ? playerLog + text : botLog + text);
            txbLog.SelectionStart = txbLog.Text.Length;
            txbLog.ScrollToCaret();
        }

        private void HPChecker(bool isPlayer, int currentHP)
        {
            if (currentHP <= 0)
            {
                ResetState(false);

                if (isPlayer) MessageBox.Show("Player Win!");
                else MessageBox.Show("Bot Win!");
            }
        }

        private void ResetState(bool isEnable)
        {
            foreach (Component component in this.components.Components)
            {
                if (component.GetType() == typeof(Timer))
                {
                    Timer timer = (Timer)component;
                    timer.Enabled = isEnable;
                }
            }

            foreach (Control ctl in this.Controls)
            {
                if (ctl.GetType() == typeof(Button) && ctl.Name != "btnStart")
                {
                    ctl.Enabled = isEnable;
                }
            }

            lblATK2.Text = "ATK2";
            lblATK3.Text = "ATK3";
            btnATK2.Text = "ATK2";
            btnATK3.Text = "ATK3";

            txbLog.Clear();
        }
    }
}