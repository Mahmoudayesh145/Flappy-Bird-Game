namespace Flappy_Bird_Game
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.SSLabel = new System.Windows.Forms.Label();
            this.GtReady = new System.Windows.Forms.Label();
            this.SButton = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.S2Button = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loading = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SSLabel
            // 
            this.SSLabel.AutoSize = true;
            this.SSLabel.Location = new System.Drawing.Point(363, 57);
            this.SSLabel.Name = "SSLabel";
            this.SSLabel.Size = new System.Drawing.Size(44, 13);
            this.SSLabel.TabIndex = 0;
            this.SSLabel.Text = "SSLabel";
            // 
            // GtReady
            // 
            this.GtReady.AutoSize = true;
            this.GtReady.ForeColor = System.Drawing.Color.OrangeRed;
            this.GtReady.Location = new System.Drawing.Point(384, 115);
            this.GtReady.Name = "GtReady";
            this.GtReady.Size = new System.Drawing.Size(49, 13);
            this.GtReady.TabIndex = 1;
            this.GtReady.Text = "GtReady";
            // 
            // SButton
            // 
            this.SButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SButton.Image = global::Flappy_Bird_Game.Properties.Resources.Start;
            this.SButton.Location = new System.Drawing.Point(614, 389);
            this.SButton.Name = "SButton";
            this.SButton.Size = new System.Drawing.Size(100, 63);
            this.SButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SButton.TabIndex = 0;
            this.SButton.TabStop = false;
            this.SButton.Click += new System.EventHandler(this.SButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon.ico.ico");
            this.imageList1.Images.SetKeyName(1, "Start.jpg");
            // 
            // S2Button
            // 
            this.S2Button.AutoSize = true;
            this.S2Button.Location = new System.Drawing.Point(596, 353);
            this.S2Button.Name = "S2Button";
            this.S2Button.Size = new System.Drawing.Size(51, 13);
            this.S2Button.TabIndex = 2;
            this.S2Button.Text = "S2Button";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.ForeColor = System.Drawing.Color.OrangeRed;
            this.loading.Location = new System.Drawing.Point(478, 645);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(41, 13);
            this.loading.TabIndex = 3;
            this.loading.Text = "loading";
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.Location = new System.Drawing.Point(743, 353);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(33, 13);
            this.value.TabIndex = 4;
            this.value.Text = "value";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird_Game.Properties.Resources.WhatsApp_Image_2025_08_12_at_20_33_26_73cd45e5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.value);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.S2Button);
            this.Controls.Add(this.SButton);
            this.Controls.Add(this.GtReady);
            this.Controls.Add(this.SSLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SSLabel;
        private System.Windows.Forms.Label GtReady;
        private System.Windows.Forms.PictureBox SButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label S2Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.Label value;
    }
}

