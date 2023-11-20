namespace Lab_Sheet_06
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
            this.btnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.playerPicture = new System.Windows.Forms.PictureBox();
            this.pcPicture = new System.Windows.Forms.PictureBox();
            this.tmrPlay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStart.Location = new System.Drawing.Point(425, 202);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 63);
            this.btnStart.TabIndex = 0;
            this.btnStart.Tag = "";
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Lab_Sheet_06.Properties.Resources.pR;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(163, 306);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 123);
            this.button2.TabIndex = 1;
            this.button2.Tag = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnRSP_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Lab_Sheet_06.Properties.Resources.pS;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.Location = new System.Drawing.Point(425, 306);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 123);
            this.button3.TabIndex = 2;
            this.button3.Tag = "1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnRSP_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Lab_Sheet_06.Properties.Resources.pP;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button4.Location = new System.Drawing.Point(689, 306);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 123);
            this.button4.TabIndex = 3;
            this.button4.Tag = "2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnRSP_Click);
            // 
            // playerPicture
            // 
            this.playerPicture.Image = global::Lab_Sheet_06.Properties.Resources.W;
            this.playerPicture.Location = new System.Drawing.Point(295, 47);
            this.playerPicture.Margin = new System.Windows.Forms.Padding(4);
            this.playerPicture.Name = "playerPicture";
            this.playerPicture.Size = new System.Drawing.Size(133, 123);
            this.playerPicture.TabIndex = 4;
            this.playerPicture.TabStop = false;
            // 
            // pcPicture
            // 
            this.pcPicture.Image = global::Lab_Sheet_06.Properties.Resources.W;
            this.pcPicture.Location = new System.Drawing.Point(576, 47);
            this.pcPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pcPicture.Name = "pcPicture";
            this.pcPicture.Size = new System.Drawing.Size(133, 123);
            this.pcPicture.TabIndex = 5;
            this.pcPicture.TabStop = false;
            // 
            // tmrPlay
            // 
            this.tmrPlay.Interval = 10;
            this.tmrPlay.Tick += new System.EventHandler(this.tmrPlay_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 506);
            this.Controls.Add(this.pcPicture);
            this.Controls.Add(this.playerPicture);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Sheet 6";
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox playerPicture;
        private System.Windows.Forms.PictureBox pcPicture;
        private System.Windows.Forms.Timer tmrPlay;
    }
}

