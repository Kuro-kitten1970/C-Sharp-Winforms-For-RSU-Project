namespace Lab_Sheet_03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.picDice1 = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.picDice3 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // txtInterval
            // 
            this.txtInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInterval.Location = new System.Drawing.Point(151, 33);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(229, 29);
            this.txtInterval.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Location = new System.Drawing.Point(151, 73);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(229, 29);
            this.txtResult.TabIndex = 1;
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoll.Location = new System.Drawing.Point(188, 286);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(80, 40);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRoll_MouseDown);
            this.btnRoll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRoll_MouseUp);
            // 
            // picDice1
            // 
            this.picDice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.picDice1.Location = new System.Drawing.Point(37, 134);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(125, 125);
            this.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice1.TabIndex = 5;
            this.picDice1.TabStop = false;
            // 
            // picDice2
            // 
            this.picDice2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.picDice2.Location = new System.Drawing.Point(173, 134);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(125, 125);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice2.TabIndex = 6;
            this.picDice2.TabStop = false;
            // 
            // picDice3
            // 
            this.picDice3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.picDice3.Location = new System.Drawing.Point(314, 134);
            this.picDice3.Name = "picDice3";
            this.picDice3.Size = new System.Drawing.Size(125, 125);
            this.picDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice3.TabIndex = 7;
            this.picDice3.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(483, 348);
            this.Controls.Add(this.picDice3);
            this.Controls.Add(this.picDice2);
            this.Controls.Add(this.picDice1);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nanikore!";
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.PictureBox picDice3;
        private System.Windows.Forms.Timer timer;
    }
}

