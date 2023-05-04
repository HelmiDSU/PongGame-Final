using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public class Game
    {
        private Form form;
        private Ball ball;
        private Paddle paddle1; 
        private Paddle paddle2;
        private Score p1Score;
        private Score p2Score;
        private Setting settings;
        private int width;
        private int height;
        private bool gameStarted = false;

        public Paddle Paddle1
        {
            get
            {
                return paddle1;
            }
        }

        public Paddle Paddle2
        {
            get
            {
                return paddle2;
            }
        }

        public Game(Form form, PictureBox ball, PictureBox paddle1, PictureBox paddle2, Score p1Score, Score p2Score, Setting settings)
        {
            this.form = form;
            this.settings = settings;
            this.ball = new Ball(ball, settings);
            this.paddle1 = new Paddle(paddle1, settings);
            this.paddle2 = new Paddle(paddle2, settings);
            this.p1Score = p1Score;
            this.p2Score = p2Score;

            this.width = form.ClientSize.Width;
            this.height = form.ClientSize.Height;
        }

        public void Update()
        {

            if (!gameStarted)
            {
                StartGameDelay();
            }
            else
            {
                // Move the ball
                ball.Move();

                // Check for collision with the paddle
                if (ball.Bounds.IntersectsWith(paddle1.Bounds) || ball.Bounds.IntersectsWith(paddle2.Bounds))
                {
                    ball.ReverseXVelocity();
                }
                if (ball.Bounds.Left <= 0)
                {
                    p2Score.Goal();
                    ball.Reset();
                }
                if (ball.Bounds.Right >= width)
                {
                    p1Score.Goal();
                    ball.Reset();
                }
                if (p1Score.Points == 5 || p2Score.Points == 5)
                {
                    Reset();
                    Pause();

                    var gameOverForm = new GameOver(p1Score.Points>= 5 ? "Player 1" : "Player2");
                    var result = gameOverForm.ShowDialog();

                    if (result == DialogResult.Retry)
                    {
                        Reset();
                        gameOverForm.Close();

                    }
                    else if(result == DialogResult.Cancel)
                    {
                        var mainMenuForm = new MainMenu();
                        mainMenuForm.ShowDialog();
                        form.Hide();
                    }
                }
            }
           
        }

        private void StartGameDelay()
        {
            var timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, args) =>
            {
                timer.Stop();
                gameStarted = true;
            };
            timer.Start();
        }
        public void Reset()
        {
            ball.Reset();
            p1Score.Reset();
            p2Score.Reset();
            paddle1.Reset();
            paddle2.Reset();

        }

        public void Pause()
        {
            ball.Speed = 0;
            paddle1.Speed = 0;
            paddle2.Speed = 0;
        }
    }
}
