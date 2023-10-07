namespace Lab_Sheet_04
{
    partial class Nani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nani));
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnPlayStop = new System.Windows.Forms.Button();
            this.picFrame = new System.Windows.Forms.PictureBox();
            this.tmrAnim = new System.Windows.Forms.Timer(this.components);
            this.tmrWalk = new System.Windows.Forms.Timer(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(460, 147);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(60, 30);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "UP";
            this.btnUp.UseCompatibleTextRendering = true;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnUp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_KeyUp);
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMouseUp);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(512, 183);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(60, 30);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "RIGHT";
            this.btnRight.UseCompatibleTextRendering = true;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnRight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_KeyUp);
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(407, 183);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(60, 30);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "LEFT";
            this.btnLeft.UseCompatibleTextRendering = true;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnLeft.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_KeyUp);
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMouseUp);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(460, 219);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(60, 30);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseCompatibleTextRendering = true;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_KeyUp);
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMouseDown);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMouseUp);
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlayStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPlayStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayStop.Location = new System.Drawing.Point(460, 101);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Size = new System.Drawing.Size(60, 40);
            this.btnPlayStop.TabIndex = 4;
            this.btnPlayStop.Text = "PLAY ANIM";
            this.btnPlayStop.UseCompatibleTextRendering = true;
            this.btnPlayStop.UseVisualStyleBackColor = false;
            this.btnPlayStop.Click += new System.EventHandler(this.btnPlayStop_Click);
            // 
            // picFrame
            // 
            this.picFrame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picFrame.Location = new System.Drawing.Point(257, 48);
            this.picFrame.Name = "picFrame";
            this.picFrame.Size = new System.Drawing.Size(32, 64);
            this.picFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrame.TabIndex = 5;
            this.picFrame.TabStop = false;
            // 
            // tmrAnim
            // 
            this.tmrAnim.Tick += new System.EventHandler(this.tmrAnim_Tick);
            // 
            // tmrWalk
            // 
            this.tmrWalk.Tick += new System.EventHandler(this.tmrWalk_Tick);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(12, 209);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(60, 40);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Import Images";
            this.btnLoad.UseCompatibleTextRendering = true;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // previewBox
            // 
            this.previewBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.previewBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.previewBox.Location = new System.Drawing.Point(17, 25);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(32, 64);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewBox.TabIndex = 7;
            this.previewBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Preview";
            // 
            // Nani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.picFrame);
            this.Controls.Add(this.btnPlayStop);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnUp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Nani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprite Sheet Player";
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnPlayStop;
        private System.Windows.Forms.PictureBox picFrame;
        private System.Windows.Forms.Timer tmrAnim;
        private System.Windows.Forms.Timer tmrWalk;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Label label1;
    }
}

