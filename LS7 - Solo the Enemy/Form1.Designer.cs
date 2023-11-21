namespace Lab_Sheet_07
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblATK1 = new System.Windows.Forms.Label();
            this.lblATK2 = new System.Windows.Forms.Label();
            this.lblATK3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPCHP = new System.Windows.Forms.Label();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.btnATK1 = new System.Windows.Forms.Button();
            this.btnATK2 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnATK3 = new System.Windows.Forms.Button();
            this.tmrCDComATK = new System.Windows.Forms.Timer(this.components);
            this.tmrCDPlayer = new System.Windows.Forms.Timer(this.components);
            this.tmrComPlay = new System.Windows.Forms.Timer(this.components);
            this.txbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblATK1
            // 
            this.lblATK1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblATK1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblATK1.Location = new System.Drawing.Point(42, 20);
            this.lblATK1.Name = "lblATK1";
            this.lblATK1.Size = new System.Drawing.Size(75, 30);
            this.lblATK1.TabIndex = 0;
            this.lblATK1.Text = "ATK1";
            this.lblATK1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblATK1.UseCompatibleTextRendering = true;
            // 
            // lblATK2
            // 
            this.lblATK2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblATK2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblATK2.Location = new System.Drawing.Point(153, 20);
            this.lblATK2.Name = "lblATK2";
            this.lblATK2.Size = new System.Drawing.Size(75, 30);
            this.lblATK2.TabIndex = 1;
            this.lblATK2.Text = "ATK2";
            this.lblATK2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblATK2.UseCompatibleTextRendering = true;
            // 
            // lblATK3
            // 
            this.lblATK3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblATK3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblATK3.Location = new System.Drawing.Point(264, 20);
            this.lblATK3.Name = "lblATK3";
            this.lblATK3.Size = new System.Drawing.Size(75, 30);
            this.lblATK3.TabIndex = 2;
            this.lblATK3.Text = "ATK3";
            this.lblATK3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblATK3.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(42, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "PC HP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(42, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player HP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // lblPCHP
            // 
            this.lblPCHP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPCHP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPCHP.Location = new System.Drawing.Point(149, 80);
            this.lblPCHP.Name = "lblPCHP";
            this.lblPCHP.Size = new System.Drawing.Size(190, 30);
            this.lblPCHP.TabIndex = 5;
            this.lblPCHP.Text = "1,000,000/1,000,000";
            this.lblPCHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPCHP.UseCompatibleTextRendering = true;
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayerHP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPlayerHP.Location = new System.Drawing.Point(149, 130);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(190, 30);
            this.lblPlayerHP.TabIndex = 6;
            this.lblPlayerHP.Text = "1,000,000/1,000,000";
            this.lblPlayerHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerHP.UseCompatibleTextRendering = true;
            // 
            // btnATK1
            // 
            this.btnATK1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnATK1.Enabled = false;
            this.btnATK1.Location = new System.Drawing.Point(42, 197);
            this.btnATK1.Name = "btnATK1";
            this.btnATK1.Size = new System.Drawing.Size(75, 30);
            this.btnATK1.TabIndex = 8;
            this.btnATK1.Tag = "1";
            this.btnATK1.Text = "ATK1";
            this.btnATK1.UseCompatibleTextRendering = true;
            this.btnATK1.UseVisualStyleBackColor = true;
            this.btnATK1.Click += new System.EventHandler(this.btnATK_Click);
            // 
            // btnATK2
            // 
            this.btnATK2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnATK2.Enabled = false;
            this.btnATK2.Location = new System.Drawing.Point(153, 197);
            this.btnATK2.Name = "btnATK2";
            this.btnATK2.Size = new System.Drawing.Size(75, 30);
            this.btnATK2.TabIndex = 9;
            this.btnATK2.Tag = "2";
            this.btnATK2.Text = "ATK2";
            this.btnATK2.UseCompatibleTextRendering = true;
            this.btnATK2.UseVisualStyleBackColor = true;
            this.btnATK2.Click += new System.EventHandler(this.btnATK_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.Location = new System.Drawing.Point(153, 258);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 30);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "START";
            this.btnStart.UseCompatibleTextRendering = true;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnATK3
            // 
            this.btnATK3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnATK3.Enabled = false;
            this.btnATK3.Location = new System.Drawing.Point(264, 197);
            this.btnATK3.Name = "btnATK3";
            this.btnATK3.Size = new System.Drawing.Size(75, 30);
            this.btnATK3.TabIndex = 11;
            this.btnATK3.Tag = "3";
            this.btnATK3.Text = "ATK3";
            this.btnATK3.UseCompatibleTextRendering = true;
            this.btnATK3.UseVisualStyleBackColor = true;
            this.btnATK3.Click += new System.EventHandler(this.btnATK_Click);
            // 
            // tmrCDComATK
            // 
            this.tmrCDComATK.Interval = 1000;
            // 
            // tmrCDPlayer
            // 
            this.tmrCDPlayer.Interval = 1000;
            // 
            // tmrComPlay
            // 
            this.tmrComPlay.Interval = 1000;
            this.tmrComPlay.Tick += new System.EventHandler(this.tmrComPlay_Tick);
            // 
            // txbLog
            // 
            this.txbLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbLog.Location = new System.Drawing.Point(357, 20);
            this.txbLog.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.Size = new System.Drawing.Size(267, 268);
            this.txbLog.TabIndex = 12;
            this.txbLog.Text = "Player ATK3 deals damage : 9999";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 311);
            this.Controls.Add(this.txbLog);
            this.Controls.Add(this.btnATK3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnATK2);
            this.Controls.Add(this.btnATK1);
            this.Controls.Add(this.lblPlayerHP);
            this.Controls.Add(this.lblPCHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblATK3);
            this.Controls.Add(this.lblATK2);
            this.Controls.Add(this.lblATK1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblATK1;
        private System.Windows.Forms.Label lblATK2;
        private System.Windows.Forms.Label lblATK3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPCHP;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Button btnATK1;
        private System.Windows.Forms.Button btnATK2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnATK3;
        private System.Windows.Forms.Timer tmrCDComATK;
        private System.Windows.Forms.Timer tmrCDPlayer;
        private System.Windows.Forms.Timer tmrComPlay;
        private System.Windows.Forms.TextBox txbLog;
    }
}

