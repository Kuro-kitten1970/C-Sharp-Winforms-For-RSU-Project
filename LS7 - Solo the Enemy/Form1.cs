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

        private int playerHP, pcHP;
        private int playerMaxHP = 1000000, pcMaxHP = 1000000;
        private int coolDownATK2 = 10, coolDownATK3 = 10;
        private int timeCount1, timeCount2;
        private int pcTimeCount1, pcTimeCount2;

        private string playerLog = Environment.NewLine + "Player ATK";
        private string pcLog = Environment.NewLine + "PC ATK";

        private Random powerOfATK = new Random();
        private Random comATKSelection = new Random();

        private void btnStart_Click(object sender, EventArgs e)
        {
            playerMaxHP = 10000; pcMaxHP = 10000;

            foreach (Control ctl in this.Controls)
            {
                if (ctl.GetType() == typeof(Button)) { ctl.Enabled = true; }
            }

            tmrComPlay.Enabled = true;
        }

        private void btnATK_Click(object sender, EventArgs e)
        {
            byte x = Convert.ToByte((sender as Button).Tag);

            AttackSystem(x, pcMaxHP, pcHP, true);
            lblPlayerHP.Text = pcHP.ToString("#,0") + "/1,000,000";
        }

        private void tmrCDPlayer_Tick(object sender, EventArgs e, Control control)
        {
            Timer timer = sender as Timer;
            byte x = Convert.ToByte(timer.Tag);

            if (x == 2) { control.Text = timeCount1.ToString(); timeCount1--; }
            if (x == 3) { control.Text = timeCount2.ToString(); timeCount2--; }

            control.Enabled = false;

            if (timeCount1 == 0)
            {
                if ((byte)timer.Tag == 2) { (sender as Timer).Enabled = false; control.Enabled = true; }
            }

            if (timeCount2 == 0)
            {
                if ((byte)timer.Tag == 3) { (sender as Timer).Enabled = false; control.Enabled = true; }
            }
        }

        private void tmrCDComATK_Tick(object sender, EventArgs e, Control control)
        {
            Timer timer = sender as Timer;
            byte x = Convert.ToByte(timer.Tag);

            if (x == 2) { control.Text = pcTimeCount1.ToString(); pcTimeCount1--; }
            if (x == 3) { control.Text = pcTimeCount2.ToString(); pcTimeCount2--; }

            if (pcTimeCount1 == 0)
            {
                if ((byte)timer.Tag == 2) { (sender as Timer).Enabled = false; control.Enabled = true; }
            }

            if (pcTimeCount2 == 0)
            {
                if ((byte)timer.Tag == 3) { (sender as Timer).Enabled = false; control.Enabled = true; }
            }
        }

        private void tmrComPlay_Tick(object sender, EventArgs e)
        {
            int comATK;

            if (HPChecker())
            {
                tmrComPlay.Enabled = false;
                return;
            }

            if (!lblATK2.Enabled && !lblATK3.Enabled)
            {
                playerHP -= AttackSystem(1, playerMaxHP, playerHP, false);
                lblPlayerHP.Text = playerHP.ToString("#,0") + "/1,000,000";
            }
            else
            {
                comATK = comATKSelection.Next(1, 4);

                switch (comATK)
                {
                    case 1:
                        playerHP -= AttackSystem(1, playerMaxHP, playerHP, false);
                        break;
                    case 2:
                        playerHP -= AttackSystem(2, playerMaxHP, playerHP, false);
                        lblATK2.Enabled = false;
                        break;
                    case 3:
                        playerHP -= AttackSystem(3, playerMaxHP, playerHP, false);
                        lblATK3.Enabled = false;
                        break;
                    default: break;
                }

                lblPlayerHP.Text = playerHP.ToString("#,0") + "/1,000,000";
            }
        }

        private int AttackSystem(byte atkCase, int maxHP, int currentHP, bool isPlayer)
        {
            int atkResult = 0;

            if (atkCase == 1)
            {
                atkResult = powerOfATK.Next(1500, 1701);
                LogShow(isPlayer, atkCase, atkResult);
            }
            else if (atkCase == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    atkResult = powerOfATK.Next(1000, 2001);
                    LogShow(isPlayer, atkCase, atkResult);
                }

                timeCount1 = coolDownATK2;
                CooldownSystem(2);
            }
            else if (atkCase == 3)
            {
                int getPercent = (currentHP * 100) / maxHP;
                if (getPercent > 25)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        atkResult = powerOfATK.Next(1400, 2501);
                        LogShow(isPlayer, atkCase, atkResult);
                    }
                }
                else
                {
                    while (getPercent <= 25 && getPercent >= 0 )
                    {
                        atkResult = powerOfATK.Next(1400, 2501);
                        LogShow(isPlayer, 3, atkResult);
                    }
                }

                timeCount2 = coolDownATK3;
                CooldownSystem(3);
            }
            else
            {

            }

            return atkResult;
        }

        private void CooldownSystem(byte numCase)
        {
            if (numCase == 2)
            {
                TimerSetUp(numCase, btnATK2, true);
            }
            else if (numCase == 3)
            {
                TimerSetUp(numCase, btnATK3, true);
            }
            else { }
        }

        private void TimerSetUp(byte i, Control control, bool isPlayer)
        {
            Timer timer = new Timer() { Interval = 1000, Tag = i };

            if (isPlayer) { timer.Tick += (sender, e) => tmrCDPlayer_Tick(sender, e, control); }
            else { timer.Tick += (sender, e) => tmrCDComATK_Tick(sender, e, control); }
            
            timer.Enabled = true;
        }

        private void LogShow(bool isPlayer, byte atkIndex, int damage)
        {
            if (isPlayer)
            {
                txbLog.Text += playerLog + atkIndex + " deals damage : " + damage;
            }
            else
            {
                txbLog.Text += pcLog + atkIndex + " deals damage : " + damage;
            }
        }

        private bool HPChecker()
        {
            if (playerHP <= 0)
            {
                tmrComPlay.Enabled = false;
                MessageBox.Show("Computer Wins!");

                foreach (Control ctl in this.Controls)
                {
                    if (ctl.GetType() == typeof(Button))
                    {
                        if (ctl.Tag != null)
                        {
                            ctl.Enabled = false;
                        }
                    }
                }

                return true;
            }
            else if (pcHP <= 0)
            {
                tmrComPlay.Enabled = false;
                MessageBox.Show("Player Wins!");

                foreach (Control ctl in this.Controls)
                {
                    if (ctl.GetType() == typeof(Button))
                    {
                        if (ctl.Tag != null)
                        {
                            ctl.Enabled = false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}