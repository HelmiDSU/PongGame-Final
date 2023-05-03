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
        private int width;
        private int height;
        private bool rightWallHit = true;

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

        public Game(Form form, PictureBox ball, PictureBox paddle1, PictureBox paddle2, Score p1Score, Score p2Score)
        {
            this.form = form;
            this.ball = new Ball(ball);
            this.paddle1 = new Paddle(paddle1, 7);
            this.paddle2 = new Paddle(paddle2, 7);
            this.p1Score = p1Score;
            this.p2Score = p2Score;

            this.width = form.ClientSize.Width;
            this.height = form.ClientSize.Height;
        }

        public void Update()
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
            if (ball.Bounds.Right  >= width)
            {
                p1Score.Goal();
                ball.Reset();
            }
            if (p1Score.Points == 5 || p2Score.Points == 5)
            {
                Reset();
            }
        }

        public void Reset()
        {
            ball.Reset();
            p1Score.Reset();
            p2Score.Reset();
            paddle1.Reset();
            paddle2.Reset();

        }
    }
}
