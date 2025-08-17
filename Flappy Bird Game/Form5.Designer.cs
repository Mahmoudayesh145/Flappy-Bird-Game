namespace Flappy_Bird_Game
{
    partial class gameover
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
            this.h1 = new System.Windows.Forms.Label();
            this.h2 = new System.Windows.Forms.Label();
            this.h3 = new System.Windows.Forms.Label();
            this.h4 = new System.Windows.Forms.Label();
            this.h5 = new System.Windows.Forms.Label();
            this.h6 = new System.Windows.Forms.Label();
            this.h7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // h1
            // 
            this.h1.AutoSize = true;
            this.h1.Location = new System.Drawing.Point(229, 54);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(19, 13);
            this.h1.TabIndex = 0;
            this.h1.Text = "h1";
            // 
            // h2
            // 
            this.h2.AutoSize = true;
            this.h2.Location = new System.Drawing.Point(89, 148);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(19, 13);
            this.h2.TabIndex = 1;
            this.h2.Text = "h2";
            // 
            // h3
            // 
            this.h3.AutoSize = true;
            this.h3.Location = new System.Drawing.Point(543, 148);
            this.h3.Name = "h3";
            this.h3.Size = new System.Drawing.Size(35, 13);
            this.h3.TabIndex = 2;
            this.h3.Text = "label2";
            // 
            // h4
            // 
            this.h4.AutoSize = true;
            this.h4.Location = new System.Drawing.Point(73, 209);
            this.h4.Name = "h4";
            this.h4.Size = new System.Drawing.Size(35, 13);
            this.h4.TabIndex = 3;
            this.h4.Text = "label3";
            // 
            // h5
            // 
            this.h5.AutoSize = true;
            this.h5.Location = new System.Drawing.Point(543, 209);
            this.h5.Name = "h5";
            this.h5.Size = new System.Drawing.Size(35, 13);
            this.h5.TabIndex = 4;
            this.h5.Text = "label4";
            // 
            // h6
            // 
            this.h6.AutoSize = true;
            this.h6.Location = new System.Drawing.Point(140, 314);
            this.h6.Name = "h6";
            this.h6.Size = new System.Drawing.Size(35, 13);
            this.h6.TabIndex = 5;
            this.h6.Text = "label5";
            this.h6.Click += new System.EventHandler(this.h6_Click);
            // 
            // h7
            // 
            this.h7.AutoSize = true;
            this.h7.Location = new System.Drawing.Point(464, 314);
            this.h7.Name = "h7";
            this.h7.Size = new System.Drawing.Size(35, 13);
            this.h7.TabIndex = 6;
            this.h7.Text = "label6";
            this.h7.Click += new System.EventHandler(this.h7_Click);
            // 
            // gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird_Game.Properties.Resources.WhatsApp_Image_2025_08_16_at_11_26_11_7d68db72;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.h7);
            this.Controls.Add(this.h6);
            this.Controls.Add(this.h5);
            this.Controls.Add(this.h4);
            this.Controls.Add(this.h3);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.h1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gameover";
            this.Opacity = 0.85D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.gameover_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label h1;
        private System.Windows.Forms.Label h2;
        private System.Windows.Forms.Label h3;
        private System.Windows.Forms.Label h4;
        private System.Windows.Forms.Label h5;
        private System.Windows.Forms.Label h6;
        private System.Windows.Forms.Label h7;
    }
}