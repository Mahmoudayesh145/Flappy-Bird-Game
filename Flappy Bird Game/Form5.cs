using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Flappy_Bird_Game
{
    public partial class gameover : Form
    {
        public gameover()
        {
            InitializeComponent();
        }

        private void gameover_Load(object sender, EventArgs e)
        {
            h1.BackColor = Color.Transparent;
            h1.Font = new Font("Press Start 2P", 25, FontStyle.Regular);
            h1.Text = "Game Over";
            h1.ForeColor = Color.Black;
            h2.BackColor = Color.Transparent;
            h2.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
            h2.Text = "Your Score";
            h2.ForeColor = Color.Black;
            h4.BackColor = Color.Transparent;
            h4.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
            h4.Text = "Top Score";
            h4.ForeColor = Color.Black;
            Score f = null;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Score)
                {
                    f = (Score)frm;
                }
            }
            int max = 0;
            if (f != null)
            {
                h3.Text = f.Controls["num"].Text;
                h3.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
                h3.ForeColor = Color.Black;
                h3.BackColor = Color.Transparent;
                using (StreamWriter file = new StreamWriter("r.txt", true))
                { file.WriteLine(h3.Text); }
                using (StreamReader sr = new StreamReader(@"C:\Users\AFAQE\Desktop\courses\New folder\Flappy Bird Game\Flappy Bird Game\bin\Debug\r.txt"))
                {
                    string line="";
                    while ((line = sr.ReadLine()) != null)
                    {
                        int s = int.Parse(line);
                        if(s>=max)
                        {
                            max = s;
                        }
                    }
                }
                h5.Text = Convert.ToString(max);
                h5.Font = new Font("Press Start 2P", 15, FontStyle.Regular);
                h5.ForeColor = Color.Black;
                h5.BackColor = Color.Transparent;
            }
            h6.Font = new Font("Press Start 2P", 18, FontStyle.Regular);
            h6.Text = " Again ";
            h6.ForeColor = Color.Black;
            h6.BackColor = Color.Transparent;
            h7.Font = new Font("Press Start 2P", 18, FontStyle.Regular);
            h7.Text = "Close";
            h7.ForeColor = Color.Black;
            h7.BackColor = Color.Transparent;
        }

        private void h6_Click(object sender, EventArgs e)
        {
            h6.MouseDown += (s, ev) =>
            {
                h6.BackColor = Color.DodgerBlue;
                h6.Location = new Point(h6.Left + 1, h6.Top + 1); // moves down for pressed effect
            };
            h6.MouseUp += (s, ev) =>
            {
                h6.BackColor = Color.LightSkyBlue;
                h6.Location = new Point(h6.Left - 1, h6.Top - 1); // reset position
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
                f.Visible = true;
                oldForm1.Visible = false;
                f.FormClosed += (s, args) => oldForm1.Close();
            }
        }

        private void h7_Click(object sender, EventArgs e)
        {
            h7.MouseDown += (s, ev) =>
            {
                h7.BackColor = Color.DodgerBlue;
                h7.Location = new Point(h7.Left + 1, h7.Top + 1); // moves down for pressed effect
            };
            h7.MouseUp += (s, ev) =>
            {
                h7.BackColor = Color.LightSkyBlue;
                h7.Location = new Point(h7.Left - 1, h7.Top - 1); // reset position
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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.CreateGraphics().DrawRectangle(Pens.Black, 138, 300, 185, 50);
            this.CreateGraphics().DrawRectangle(Pens.Black, 450, 300, 160, 50);
        }
    }
}
