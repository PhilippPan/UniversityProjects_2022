using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Lab6_Pan
{
    public partial class MainForm : Form
    {
        int BallSize = 20, PlatformSize = 80, GatesSize = 350, Speed = 4,  // params for settings
            ScoreP1 = 0, ScoreP2 = 0, PosY_P1, PosY_P2, PosY_M, ballPosX, ballPosY, ballSpeedX = 1, ballSpeedY = 1, GatePosY;
        bool p1_up = false, p1_down = false, p2_up = false, p2_down = false;
        Graphics graphics; Bitmap image;
        Random rnd = new Random();


        System.Timers.Timer timer;

        public MainForm()
        {
            InitializeComponent();
            SetTimer();
            GatePosY = (pbPlayGround.Height - GatesSize) / 2;
            DefaultSettings();

        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    p1_up = false;
                    break;
                case Keys.S:
                    p1_down = false;
                    break;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    p1_up = true;
                    p1_down = false;
                    break;
                case Keys.S:
                    p1_up = false;
                    p1_down = true;
                    break;
            }
        }

        private void pbPlayGround_MouseEnter(object sender, EventArgs e)
        {
            p2_down = false;
            p2_up = false;
        }

        private void pbPlayGround_MouseMove(object sender, MouseEventArgs e)
        {
            PosY_M = e.Y;
            if(PosY_M-3 > PosY_P2 + PlatformSize / 2)
            {
                p2_up = false;
                p2_down = true;
            }
            else if (PosY_M + 3 < PosY_P2 + PlatformSize / 2)
            {
                p2_up = true;
                p2_down = false;
            }
            else
            {
                p2_up = false;
                p2_down = false;
            }
        }

        private void SetTimer()
        {
            timer = new System.Timers.Timer(16);
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = false;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            image = new Bitmap(pbPlayGround.Width, pbPlayGround.Height);
            graphics = Graphics.FromImage(image);
            DrawBall(ballPosX, ballPosY, BallSize, new SolidBrush(Color.White));
            DrawPlatforms(1, PosY_P1, 10, PlatformSize, new SolidBrush(Color.LightBlue));
            DrawPlatforms(pbPlayGround.Width - 11, PosY_P2, 10, PlatformSize, new SolidBrush(Color.LightGreen));
            DrawGates(0, GatePosY, 5, GatesSize, new SolidBrush(Color.White));
            DrawGates(pbPlayGround.Width - 5, GatePosY, 5, GatesSize, new SolidBrush(Color.White));
            DrawScore(ScoreP1, ScoreP2);
            MovePlatforms();
            MoveBall();
            pbPlayGround.Image = image;
            return;

            throw new NotImplementedException();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ballSpeedX = rnd.Next(-Speed, +Speed);
            if(rnd.Next(1,6) %2 == 0) ballSpeedY = Convert.ToInt32(Math.Sqrt(Math.Pow(Speed, 2) - Math.Pow(ballSpeedX, 2)));
            else ballSpeedY = -Convert.ToInt32(Math.Sqrt(Math.Pow(Speed, 2) - Math.Pow(ballSpeedX, 2)));
            timer.Enabled = true;
            if (ballSpeedX == 0) ballSpeedX += 1;
            if (ballSpeedY == 0) ballSpeedY += 1;

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if(timer.Enabled) timer.Stop();
            SettingsForm form = new SettingsForm(BallSize, PlatformSize, GatesSize, Speed);
            form.ShowDialog();
            if (form.BS > 0) BallSize = form.BS;
            if (form.PS > 0) PlatformSize = form.PS;
            if (form.GS > 0) GatesSize = form.GS;
            if (form.S > 0)  Speed = form.S;
            GatePosY = (pbPlayGround.Height - GatesSize) / 2;
            DefaultSettings();
        }

        private void DefaultSettings()
        {
            ballPosX = pbPlayGround.Width / 2 + BallSize;
            ballPosY = pbPlayGround.Height / 2 + BallSize;
            PosY_P1 = pbPlayGround.Height / 2 - PlatformSize;
            PosY_P2 = pbPlayGround.Height / 2 - PlatformSize;


            image = new Bitmap(pbPlayGround.Width, pbPlayGround.Height);
            graphics = Graphics.FromImage(image);
            pbPlayGround.Image = image;

            DrawBall(ballPosX, ballPosY, BallSize, new SolidBrush(Color.White));
            DrawPlatforms(1, PosY_P1, 10, PlatformSize, new SolidBrush(Color.LightBlue));
            DrawPlatforms(pbPlayGround.Width - 11, PosY_P2, 10, PlatformSize, new SolidBrush(Color.LightGreen));
            DrawGates(0, GatePosY, 5, GatesSize, new SolidBrush(Color.White));
            DrawGates(pbPlayGround.Width-5, GatePosY, 5, GatesSize, new SolidBrush(Color.White));
            ballSpeedX = rnd.Next(-3, 3);
            ballSpeedY = rnd.Next(-3, 3);

        }


        private void DrawPlatforms(int x, int y, int w, int h, SolidBrush col)
        {
            graphics.FillRectangle(col, new Rectangle(x, y, w, h));
        }

        private void DrawGates(int x, int y, int w, int h, SolidBrush col)
        {
            graphics.FillRectangle(col, new Rectangle(x, y, w, h));
        }

        private void DrawBall(int x, int y, int size, SolidBrush col)
        {
            graphics.FillEllipse(col, new Rectangle(x-size/2, y-size/2, size, size));
        }
        private void DrawScore(int p1, int p2)
        {
            graphics.DrawString(p1.ToString(), new Font("Calibri", 25), new SolidBrush(Color.LightBlue), new Point(pbPlayGround.Width / 2 - 120, pbPlayGround.Height / 2));
            graphics.DrawString(p2.ToString(), new Font("Calibri", 25), new SolidBrush(Color.LightGreen), new Point(pbPlayGround.Width / 2 + 120, pbPlayGround.Height / 2));
        }

        private void MovePlatforms()
        {
            if (p1_down && PosY_P1 < pbPlayGround.Height - PlatformSize) PosY_P1 += 5;
            if (p1_up && PosY_P1 > 0) PosY_P1 -= 5;

            if (p2_down && PosY_P2 < pbPlayGround.Height - PlatformSize) PosY_P2 += 5;
            if (p2_up && PosY_P2 > 0) PosY_P2 -= 5;

            if (PosY_M - 3 < PosY_P2 + PlatformSize / 2) p2_down = false;
            if (PosY_M + 3 > PosY_P2 + PlatformSize / 2) p2_up = false;

        }

        private void MoveBall()
        {
            ballPosX += ballSpeedX;
            ballPosY += ballSpeedY;

            if (ballPosY + BallSize / 2 > pbPlayGround.Height-5 || ballPosY + BallSize / 2 < 0) ballSpeedY = -ballSpeedY;
            
            
            if(ballPosX + ballSpeedX > pbPlayGround.Width - 5)
            {
                if (ballPosY > PosY_P2 && ballPosY < PosY_P2 + PlatformSize)
                {
                    ballSpeedX = -Math.Abs(ballSpeedX);
                }
                else if (ballPosY > GatePosY && ballPosY < GatePosY + GatesSize)
                {
                    ScoreP1++;
                    ballPosX = pbPlayGround.Width - 15;
                    ballPosY = PosY_P2 + PlatformSize / 2;
                    ballSpeedX = -Math.Abs(ballSpeedX);
                } else
                {
                    ballSpeedX = -Math.Abs(ballSpeedX);
                }
            }
            if(ballPosX + ballSpeedX < 5)
            {
                if (ballPosY > PosY_P1 && ballPosY < PosY_P1 + PlatformSize)
                {
                    ballSpeedX = Math.Abs(ballSpeedX);
                }
                else if (ballPosY > GatePosY && ballPosY < GatePosY + GatesSize)
                {
                    ScoreP2++;
                    ballPosX = 15;
                    ballPosY = PosY_P1 + PlatformSize / 2;
                    ballSpeedX = Math.Abs(ballSpeedX);
                }
                else
                {
                    ballSpeedX = Math.Abs(ballSpeedX);
                }
            }

            }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (timer.Enabled) timer.Stop();
            ScoreP1 = 0;
            ScoreP2 = 0;
            DefaultSettings();
        }
    }
}
