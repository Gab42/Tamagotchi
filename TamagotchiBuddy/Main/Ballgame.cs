using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    public partial class Ballgame : Form
    {
        Bitmap Backbuffer;
        Timer GameTimer = new Timer();
        const int BallAxisSpeed = 4;
        int score = 0;
        Point BallPos = new Point(100, 100);
        Point BallSpeed = new Point(BallAxisSpeed, BallAxisSpeed);
        const int BallSize = 20;

        public Ballgame()
        {
            InitializeComponent();

            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);
                      
            GameTimer.Interval = 10;
            GameTimer.Tick += new EventHandler(GameTimer_Tick);
            GameTimer.Start();
            
            this.ResizeEnd += new EventHandler(Form1_CreateBackBuffer);
            this.Load += new EventHandler(Form1_CreateBackBuffer);
            this.Paint += new PaintEventHandler(Form1_Paint);            
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                BallSpeed.X = -BallAxisSpeed;
            else if (e.KeyCode == Keys.Right)
                BallSpeed.X = BallAxisSpeed;
            else if (e.KeyCode == Keys.Up)
                BallSpeed.Y = -BallAxisSpeed; 
            else if (e.KeyCode == Keys.Down)
                BallSpeed.Y = BallAxisSpeed;
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Backbuffer != null)
            {
                e.Graphics.DrawImageUnscaled(Backbuffer, Point.Empty);
            }
        }

        void Form1_CreateBackBuffer(object sender, EventArgs e)
        {
            if (Backbuffer != null)
            {
                Backbuffer.Dispose();
            }
            Backbuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
        }

        void Draw()
        {
            if (Backbuffer != null)
            {
                using (var g = Graphics.FromImage(Backbuffer))
                {
                    g.Clear(Color.White);
                    g.FillEllipse(Brushes.PaleVioletRed, BallPos.X - BallSize / 2, BallPos.Y - BallSize / 2, BallSize, BallSize);
                }
                Invalidate();
            }
        }
        
        bool HitLeft()
        {
            if(BallPos.X <= 9)
            {
                return true;
            }            
            return false;
        }
        bool HitRight()
        {
            if (BallPos.X >= 275)
            {
                return true;
            }
            return false;
        }
        bool HitUp()
        {
            if (BallPos.Y <= 9)
            {
                return true;
            }
            return false;
        }
        bool dead()
        {
            if(BallPos.Y >= 280)
            {
                return true;
            }
            return false;
        }

        void GameTimer_Tick(object sender, EventArgs e)
        {
            BallPos.X += BallSpeed.X;
            BallPos.Y += BallSpeed.Y;
            Draw();
            if (HitLeft())
            {
                BallSpeed.X = BallAxisSpeed;
                score++;
            }
            if (HitRight())
            {
                BallSpeed.X = -BallAxisSpeed;
                score++;
            }
            if (HitUp())
            {
                BallSpeed.Y = BallAxisSpeed;
                score++;
            }
            if (dead())
            {
                GameTimer.Stop();
                MessageBox.Show("GAME OVER!!!");
                if (score > 10 && Pet.Fun < 6)
                {
                    Pet.Fun += 1;
                }
                this.Close();
            }
            Score.Text = "Score: " + score.ToString();
        }      
    }
}
