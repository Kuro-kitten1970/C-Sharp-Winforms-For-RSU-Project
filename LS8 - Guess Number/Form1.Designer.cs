namespace Lab_Sheet_08
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtNumResult = new System.Windows.Forms.TextBox();
            this.txtHint = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess.Location = new System.Drawing.Point(75, 22);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(115, 40);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtNumResult
            // 
            this.txtNumResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtNumResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumResult.CausesValidation = false;
            this.txtNumResult.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNumResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumResult.ForeColor = System.Drawing.Color.Black;
            this.txtNumResult.HideSelection = false;
            this.txtNumResult.Location = new System.Drawing.Point(12, 101);
            this.txtNumResult.MaxLength = 200;
            this.txtNumResult.Name = "txtNumResult";
            this.txtNumResult.ReadOnly = true;
            this.txtNumResult.ShortcutsEnabled = false;
            this.txtNumResult.Size = new System.Drawing.Size(250, 37);
            this.txtNumResult.TabIndex = 1;
            this.txtNumResult.TabStop = false;
            this.txtNumResult.Text = "???";
            this.txtNumResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHint
            // 
            this.txtHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtHint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHint.CausesValidation = false;
            this.txtHint.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHint.ForeColor = System.Drawing.Color.Black;
            this.txtHint.HideSelection = false;
            this.txtHint.Location = new System.Drawing.Point(12, 151);
            this.txtHint.MaxLength = 200;
            this.txtHint.Name = "txtHint";
            this.txtHint.ReadOnly = true;
            this.txtHint.ShortcutsEnabled = false;
            this.txtHint.Size = new System.Drawing.Size(250, 37);
            this.txtHint.TabIndex = 2;
            this.txtHint.TabStop = false;
            this.txtHint.Text = "Hint";
            this.txtHint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_Sheet_08.Properties.Resources.alice_shimada_nod_4x_RIFE_RIFE3_1_50fps;
            this.pictureBox1.Location = new System.Drawing.Point(75, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(274, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtHint);
            this.Controls.Add(this.txtNumResult);
            this.Controls.Add(this.btnGuess);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Sheet 08";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtNumResult;
        private System.Windows.Forms.TextBox txtHint;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

