namespace AdamAsmacaOdev
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
            this.lblWorldDisplay = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWorldDisplay
            // 
            this.lblWorldDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWorldDisplay.Font = new System.Drawing.Font("Rockwell", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorldDisplay.Location = new System.Drawing.Point(2, 9);
            this.lblWorldDisplay.Name = "lblWorldDisplay";
            this.lblWorldDisplay.Size = new System.Drawing.Size(719, 102);
            this.lblWorldDisplay.TabIndex = 0;
            this.lblWorldDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuess.ForeColor = System.Drawing.Color.HotPink;
            this.btnGuess.Location = new System.Drawing.Point(2, 506);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(217, 71);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "GUESS!\r\n\r\n";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // tbGuess
            // 
            this.tbGuess.Font = new System.Drawing.Font("Rockwell", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbGuess.Location = new System.Drawing.Point(570, 518);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(151, 60);
            this.tbGuess.TabIndex = 2;
            this.tbGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(2, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(723, 578);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblWorldDisplay);
            this.Name = "Form1";
            this.Text = "Adam Asmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWorldDisplay;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

