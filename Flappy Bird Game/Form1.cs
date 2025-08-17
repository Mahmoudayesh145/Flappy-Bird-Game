using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Media;
using WMPLib;
namespace Flappy_Bird_Game
{
    
    public partial class MainPage : Form
    {
        WindowsMediaPlayer sp = new WindowsMediaPlayer();
        public MainPage()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            SSLabel.BackColor = Color.Transparent;
            GtReady.BackColor = Color.Transparent;
            SSLabel.Font = new Font("Press Start 2P", 45, FontStyle.Regular);
            SSLabel.Text = "FlappyBird";
            SSLabel.ForeColor= Color.White;
            GtReady.Font = new Font("Press Start 2P", 30, FontStyle.Regular);
            GtReady.Text = "\n\n  Get Ready!";
            GtReady.ForeColor = Color.Lime;
            SButton.BackColor = Color.Transparent;
            S2Button.Text = "START";
            S2Button.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            S2Button.FlatStyle = FlatStyle.Flat;
            S2Button.BackColor = Color.Transparent;
            S2Button.ForeColor = Color.OrangeRed;
            S2Button.Size = new Size(200, 60);
            Bitmap bmp = new Bitmap(@"C:\Users\AFAQE\Desktop\courses\New folder\Flappy Bird Game\Flappy Bird Game\Properties\\Start.jpg");
            bmp.MakeTransparent(Color.Black);
            SButton.BackColor = Color.Transparent; 
            SButton.Image = bmp;
            SButton.MouseDown += SButton_MouseDown;
            SButton.MouseUp += SButton_MouseUp;
            timer1.Interval = 1;
            timer1.Stop();
            loading.Font = new Font("Press Start 2P", 8, FontStyle.Regular);
            loading.Text = "Loading...";
            loading.BackColor = Color.Transparent; 
            loading.ForeColor = Color.Teal;
            loading.Visible = false;
            loading.Location = new Point(478, 630);
            value.Font = new Font("Press Start 2P", 8, FontStyle.Regular);
            value.Text = "";
            value.BackColor = Color.Transparent;
            value.ForeColor = Color.Teal;
            value.Visible = false;
            value.Location = new Point(845, 630);
            //sp = new SoundPlayer(@"C:\Users\AFAQE\Desktop\courses\New folder\Flappy Bird Game\Flappy Bird Game\bin\Debug\\sound.wav");
            sp.URL = @"C:\Users\AFAQE\Desktop\courses\New folder\Flappy Bird Game\Flappy Bird Game\bin\Debug\\sound.wav";
            sp.controls.play();
            sp.settings.setMode("loop", true);
        }
        private void SButton_MouseDown(object sender, MouseEventArgs e)
        {
            SButton.BorderStyle = BorderStyle.Fixed3D; // pressed effect
        }
        private void SButton_MouseUp(object sender, MouseEventArgs e)
        {
            SButton.BorderStyle = BorderStyle.None; // normal
        }
        private void SButton_Click(object sender, EventArgs e)
        {
           
            loading.Visible = true;
            value.Visible = true;
            this.CreateGraphics().DrawRectangle(Pens.Teal, 478, 645, 400, 20);
             timer1.Start();
        }

        private int progressWidth = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressWidth < 395)
            {
                progressWidth += 4;
                Graphics g = this.CreateGraphics();
                g.FillRectangle(Brushes.Teal, 480, 647, progressWidth, 17);
               value.Text = Convert.ToString(progressWidth / 4 ) + "%";
                if(progressWidth/4==99)
                {
               value.Text =  "100%";

                }
            }
            else
            {
                    timer1.Stop();
                    Score f = new Score();
                    f.WindowState = FormWindowState.Maximized;
                    this.Visible = false;
                    f.Visible = true;
                    f.FormClosed += (s, args) => this.Close();
                    timer1.Dispose();

            }

        }
    }
}
