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
using WMPLib;

namespace Flappy_Bird_Game
{
    public partial class Score : Form
    {
       
    WindowsMediaPlayer player1 = new WindowsMediaPlayer();
    WindowsMediaPlayer d = new WindowsMediaPlayer();
        public Score()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
    
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            player1.settings.autoStart = false;
            d.settings.autoStart = false;
            player1.URL = @"C:\Users\AFAQE\Desktop\courses\this.wav";
            d.URL = @"C:\Users\AFAQE\Desktop\courses\death.wav";
            Hint hint = new Hint();
            hint.Visible=true;
            hint.TopMost = true;
            hint.ShowInTaskbar = false;
            hint.FormBorderStyle = FormBorderStyle.None;
            Bitmap bmp = new Bitmap(@"C:\Users\AFAQE\Desktop\courses\Pause.jpg");
            bmp.MakeTransparent(Color.Black);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = bmp;
            pictureBox1.Location= new Point(1240,10);
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            Bitmap b_d = new Bitmap(@"C:\Users\AFAQE\Desktop\courses\a.PNG");
            b_d.MakeTransparent(Color.Black);
            Bitmap b_u = new Bitmap(@"C:\Users\AFAQE\Desktop\courses\b.PNG");
            b_u.MakeTransparent(Color.Black);
            Bitmap a = new Bitmap(@"C:\Users\AFAQE\Desktop\courses\apple-removebg-preview.PNG");
            a.MakeTransparent(Color.Black);
            apple.Image = a;
            apple.BackColor = Color.Transparent;
            u_1.BackColor = Color.Transparent;
            u_2.BackColor = Color.Transparent;
            u_3.BackColor = Color.Transparent;
            d_1.BackColor = Color.Transparent;
            d_2.BackColor = Color.Transparent;
            d_3.BackColor = Color.Transparent;
            u_1.Image = b_d;
            u_2.Image = b_d;
            u_3.Image = b_d;
            d_1.Image = b_u;
            d_2.Image = b_u;
            d_3.Image = b_u;
            bird.Image = Image.FromFile(@"C:\Users\AFAQE\Desktop\courses\flappy_bird_resized.GIF");
            bird.BackColor = Color.Transparent;
            s.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
            s.Text = "Score";
            s.BackColor= Color.Transparent;
            s.ForeColor = Color.Black;
            num.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
            num.Text = "0";
            num.BackColor = Color.Transparent;
            num.ForeColor = Color.Black;
          
        }
        public void re_g(Image im)
        {
            bird.Image =im;
            bird.BackColor = Color.Transparent;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D; // pressed effect
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None; // normal
        }
        int gravitu = 12;
        public int PipeSpeed = 8;
        int score = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 f=new Form4();
            f.Visible = true;
            f.TopMost = true;
            f.FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                gravitu = -12;
            }
        }

        private void up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravitu = 12;
                SoundPlayer s = new SoundPlayer(@"C:\Users\AFAQE\Desktop\courses\as.wav");
                s.Play();
            }
        }
        int i = 0;
        int j = 0;
        int o = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            bird.Top += gravitu;
            u_1.Left -= PipeSpeed + 4;
            u_2.Left -= PipeSpeed+4;
            u_3.Left -= PipeSpeed+4;
            d_1.Left -= PipeSpeed+4;
            d_2.Left -= PipeSpeed+4;
            d_3.Left -= PipeSpeed+4;
            apple.Left -= PipeSpeed+4;
            if(score - o >= 5 )
            {
                PipeSpeed += 3;
                o = score;
            }
            if(u_1.Left<-120)
            {
                player1.controls.play();
                score++;
                u_1.Left = 1090;
                
            }
            if (d_1.Left < -120)
            {
                player1.controls.play();
                score++;
                d_1.Left = 1090;
            }
            if (u_2.Left < -120)
            {
                player1.controls.play();
                score++;
                u_2.Left = 1090;
            }
            if (d_2.Left < -120)
            {
                player1.controls.play();
                score++;
                d_2.Left = 1090;
            }
            if (apple.Left < -120)
            {
                if (i % 2 == 1)
                {
                    player1.controls.play();
                    score++;
                    apple.Visible = true;
                    apple.Top = 72;
                    apple.Left = 1090;
                }
                else if(j%2==0)
                {
                    player1.controls.play();
                    score++;
                    apple.Visible = true;
                    apple.Left = 1300;
                    apple.Top = 350;
                    j++;
                }
                else
                {
                    player1.controls.play();
                    score++;


                }
            }
            if (u_3.Left < -120)
            {
                player1.controls.play();
                score++;
                u_3.Left = 1090;
            }
            if (d_3.Left < -120)
            {
                player1.controls.play();
                score++;
                d_3.Left = 1090;
            }
            num.Text = Convert.ToString(score);
            if(bird.Bounds.IntersectsWith(u_1.Bounds)||
               bird.Bounds.IntersectsWith(u_2.Bounds)||
               bird.Bounds.IntersectsWith(u_3.Bounds)||
               bird.Bounds.IntersectsWith(d_1.Bounds)||
               bird.Bounds.IntersectsWith(d_2.Bounds)||
               bird.Bounds.IntersectsWith(d_3.Bounds)||
               bird.Top >= 550||
               bird.Top <= -1)
            {
                d.controls.play();
                gameover g = new gameover();
                g.Visible = true;
                g.TopMost = true;
                timer1.Stop();
            }
            if(bird.Bounds.IntersectsWith(apple.Bounds))
            {
                o = score - 1;
                score += 3;
                i = apple.Left;
                j = apple.Top;
                apple.Left = 1200;
                apple.Top = 120;
            }
        }
        public void StartTimer()
        {
            timer1.Start();
        }
        public void StopTimer()
        {
            timer1.Stop();
        }
    }
}
