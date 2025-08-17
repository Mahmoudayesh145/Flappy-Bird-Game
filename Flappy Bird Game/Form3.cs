using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Game
{
    public partial class Hint : Form
    {
        public Hint()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }
        private void Hint_Load(object sender, EventArgs e)
        {
           
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            Address.Text = "Game Rules ";
            Address.ForeColor = Color.White;
            timer1.Interval = 160; // speed
            timer1.Tick += timer1_Tick;
            timer1.Start();
            h1.BackColor = Color.Transparent;
            h1.Font = new Font("Press Start 2P", 10, FontStyle.Regular);
            h1.Text = "1 - You Must Press On SpaceKey to Skip The Pipes  ";
            h1.ForeColor = Color.White;
            h2.Font = new Font("Press Start 2P", 10, FontStyle.Regular);
            h2.Text = "2 - You Must Pass Above Or Under The Pipes To Take Points  ";
            h2.ForeColor = Color.White;
            h21.Font = new Font("Press Start 2P", 10, FontStyle.Regular);
            h21.Text = "Like This :";
            h21.ForeColor = Color.White;
            h3.Font = new Font("Press Start 2P", 10, FontStyle.Regular);
            h3.Text = "3 - You Will Lose If The Bird Touch The Pipes Or The Ground  ";
            h3.ForeColor = Color.White;
            h4.Font = new Font("Press Start 2P", 10, FontStyle.Regular);
            h4.Text = "4 - When You Take Colored Apples ,You Will Gain Extra Points ";
            h4.ForeColor = Color.White;
            ha.Font = new Font("Press Start 2P", 10, FontStyle.Regular);
            ha.Text = "5 - When You Close Or Restart the Game , You Will Loss Your Score ";
            ha.ForeColor = Color.White;
            h5.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            h5.Text = "Play:";
            h5.BackColor= Color.Transparent;
            h5.ForeColor = Color.White;
            h45.Font = new Font("Press Start 2P", 10, FontStyle.Regular);
            h45.Text = "6 - Every 5 Points In Your Score , Pippes Speed Increases by 3 ";
            h45.BackColor = Color.Transparent;
            h45.ForeColor = Color.White;
            last.Font = new Font("Press Start 2P", 10, FontStyle.Regular);
            last.Text = "7 - You Can Change Bird-Color And Sound From Pausing Icon   ";
            last.BackColor = Color.Transparent;
            last.ForeColor = Color.White;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            pictureBox2.MouseUp += pictureBox2_MouseDown;
            

        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.Fixed3D; // pressed effect
        }
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None; // normal
        }
        private float dashOffset = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            using (Pen pen = new Pen(Color.White, 3))
            {
                pen.DashStyle = DashStyle.Dash;
                pen.DashOffset = dashOffset;
                g.Clear(this.BackColor);
                g.DrawLine(pen, 10, 40, 910, 40);
            }

            dashOffset += 1;
            if (dashOffset > 40) dashOffset = 0;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Score f = null;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Score)
                {
                    f=(Score)frm;
                }
            }
            if (f != null)
            {
                f.StartTimer();
                
            }
            this.Close();
        }
    }
}
