namespace Flappy_Bird_Game
{
    partial class Form4
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
            this.resume = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.Sound = new System.Windows.Forms.Label();
            this.SBar = new System.Windows.Forms.TrackBar();
            this.v = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.speed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // resume
            // 
            this.resume.AutoSize = true;
            this.resume.Location = new System.Drawing.Point(57, 29);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(35, 13);
            this.resume.TabIndex = 0;
            this.resume.Text = "label1";
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.Location = new System.Drawing.Point(357, 29);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(35, 13);
            this.restart.TabIndex = 1;
            this.restart.Text = "label2";
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Location = new System.Drawing.Point(658, 29);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(35, 13);
            this.close.TabIndex = 2;
            this.close.Text = "label3";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Sound
            // 
            this.Sound.AutoSize = true;
            this.Sound.Location = new System.Drawing.Point(57, 134);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(12, 13);
            this.Sound.TabIndex = 3;
            this.Sound.Text = "s";
            // 
            // SBar
            // 
            this.SBar.Location = new System.Drawing.Point(185, 124);
            this.SBar.Maximum = 100;
            this.SBar.Name = "SBar";
            this.SBar.Size = new System.Drawing.Size(483, 45);
            this.SBar.TabIndex = 4;
            this.SBar.TickFrequency = 10;
            this.SBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SBar.Scroll += new System.EventHandler(this.SBar_Scroll);
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(697, 139);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(35, 13);
            this.v.TabIndex = 5;
            this.v.Text = "label2";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(682, 210);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(35, 13);
            this.color.TabIndex = 8;
            this.color.Text = "label2";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(185, 195);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(483, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(9, 207);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(12, 13);
            this.speed.TabIndex = 6;
            this.speed.Text = "s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.v);
            this.Controls.Add(this.SBar);
            this.Controls.Add(this.Sound);
            this.Controls.Add(this.close);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.resume);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form4";
            this.Opacity = 0.88D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resume;
        private System.Windows.Forms.Label restart;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label Sound;
        private System.Windows.Forms.TrackBar SBar;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}