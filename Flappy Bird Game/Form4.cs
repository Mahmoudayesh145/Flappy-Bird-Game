using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Flappy_Bird_Game
{
    public partial class Form4 : Form
    {
        private MMDeviceEnumerator devEnum;
        private MMDevice defaultDevice;
        public Form4()
        {
            InitializeComponent();
            devEnum = new MMDeviceEnumerator();
            defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            SBar.Value = (int)(defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);

            // Handle change
            SBar.Scroll += SBar_Scroll;
        }
        Score f = null;        
    private void Form4_Load(object sender, EventArgs e)
        {
            
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Score)
                {
                    f = (Score)frm;
                }
            }
            if (f != null)
            {
                f.StopTimer();

            }
            resume.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
            resume.Text = "Resume";
            resume.ForeColor = Color.White;
            restart.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
            restart.Text = "ReStart";
            restart.ForeColor = Color.White;
            close.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
            close.Text = "Close";
            close.ForeColor = Color.White;
            Sound.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
            Sound.Text = "Sound";
            Sound.ForeColor = Color.White;
            v.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
            v.ForeColor = Color.White;
            v.Text = Convert.ToString(SBar.Value);
            speed.Font = new Font("Press Start 2P", 13, FontStyle.Regular);
            speed.ForeColor = Color.White;
            speed.Text = "Bird-Color";
            trackBar1.Value = 1;
            color.Font = new Font("Press Start 2P", 13, FontStyle.Regular);
            color.Text = "Yellow";
            color.ForeColor = Color.Yellow;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
            label1.Text = "Your Score";
            label1.ForeColor = Color.White;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
            label2.Text = f.Controls["num"].Text;
            label2.ForeColor = Color.White;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.CreateGraphics().DrawRectangle(Pens.White, 45, 22, 150, 35);
            this.CreateGraphics().DrawRectangle(Pens.White, 350, 22, 160, 35);
            this.CreateGraphics().DrawRectangle(Pens.White, 650, 22, 127, 35);
        }

        private void close_Click(object sender, EventArgs e)
        {
            close.MouseDown += (s, ev) =>
            {
                close.BackColor = Color.DodgerBlue;
                close.Location = new Point(close.Left + 1, close.Top + 1); // moves down for pressed effect
            };
            close.MouseUp += (s, ev) =>
            {
                close.BackColor = Color.LightSkyBlue;
                close.Location = new Point(close.Left - 1, close.Top - 1); // reset position
            };
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Score)
                {
                    frm.Close();
                    break;
                }
            }

        }

        private void restart_Click(object sender, EventArgs e)
        {
            restart.MouseDown += (s, ev) =>
            {
                restart.BackColor = Color.DodgerBlue;
                restart.Location = new Point(restart.Left + 1, restart.Top + 1); // moves down for pressed effect
            };
            restart.MouseUp += (s, ev) =>
            {
                restart.BackColor = Color.LightSkyBlue;
                restart.Location = new Point(restart.Left - 1, restart.Top - 1); // reset position
            };
            this.Close();
            Score oldForm1 = null;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Score)
                {
                    oldForm1 = (Score)frm;
                    break;
                }
            }
            if (oldForm1 != null)
            {
                Score f = new Score();
                this.Visible = false;
                oldForm1.Visible = false;
                f.Visible = true;
                f.FormClosed += (s, args) => oldForm1.Close();
            }
        }

        private void SBar_Scroll(object sender, EventArgs e)
        {
            // Set system volume based on TrackBar value
            float volume = SBar.Value / 100f; // Convert to 0.0 - 1.0 range
            defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = volume;
            v.Text = Convert.ToString(SBar.Value);
        }

        private void resume_Click(object sender, EventArgs e)
        {
            resume.MouseDown += (s, ev) =>
            {
                resume.BackColor = Color.DodgerBlue;
                resume.Location = new Point(resume.Left + 1, resume.Top + 1); // moves down for pressed effect
            };
            resume.MouseUp += (s, ev) =>
            {
                resume.BackColor = Color.LightSkyBlue;
                resume.Location = new Point(resume.Left - 1, resume.Top - 1); // reset position
            };

            this.Close();
            if (f != null)
            {
                f.StartTimer();

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(f!=null)
            {
                if (trackBar1.Value == 1)
                { color.Text = "Yellow";
                    color.ForeColor = Color.Yellow;
                    f.re_g(Image.FromFile(@"C:\Users\AFAQE\Desktop\courses\flappy_bird_resized.GIF"));
                }
                else if (trackBar1.Value == 2) {
                    color.Text = "Blue";
                    color.ForeColor = Color.Blue;
                    f.re_g(Image.FromFile(@"C:\Users\AFAQE\Desktop\courses\bluebird_transparent.GIF"));
                }
                else if (trackBar1.Value == 3)
                {
                    color.Text = "Pink";
                    color.ForeColor = Color.Purple;
                    f.re_g(Image.FromFile(@"C:\Users\AFAQE\Desktop\courses\pinkbird_transparent.GIF"));
                }
                else if (trackBar1.Value == 4)
                {
                    color.Text = "White";
                    color.ForeColor = Color.White;
                    Bitmap i = new Bitmap(@"C:\Users\AFAQE\Desktop\courses\l.PNG");
                    i.MakeTransparent(Color.White);
                    f.re_g(i);
                }

            }
        }
    }
}
