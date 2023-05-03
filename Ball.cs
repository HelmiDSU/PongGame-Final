using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PongGame;

namespace PongGame
{
    public class Ball
    {
        private PictureBox ball;
        private int xSpeed, ySpeed;
        private int xMax, yMax;

        public Ball(PictureBox ball)
        {
            this.ball = ball;
            xSpeed = 10;
            ySpeed = 10;
            xMax = ball.Parent.ClientSize.Width - ball.Width;
            yMax = ball.Parent.ClientSize.Height - ball.Height;
        }

        public void Move()
        {
            int newX = ball.Location.X + xSpeed;
            int newY = ball.Location.Y + ySpeed;

            // check for collision with left or right edge
            if (newX < 0 || newX > xMax)
            {
                ReverseXVelocity();
            }

            // check for collision with top or bottom edge
            if (newY < 0  || newY > yMax)
            {
                ReverseYVelocity();
            }

            // check for collision with paddle
         /*  if (ball.Bounds.IntersectsWith(paddle1.Bounds) || ball.Bounds.IntersectsWith(paddle2.Bounds))
            {
                ReverseYVelocity();
            }
         */
            ball.Location = new Point(newX, newY);
        }

        public void ReverseXVelocity()
        {
            xSpeed = -xSpeed;
        }

        public void ReverseYVelocity()
        {
            ySpeed = -ySpeed;
        }

        public void Reset()
        {
            ball.Location = new Point((ball.Parent.ClientSize.Width - ball.Width) / 2, (ball.Parent.ClientSize.Height - ball.Height) / 2);
            Random rand = new Random();
            int xDirection = rand.Next(0,3) == 0 ? -1 : 1;
            int yDirection = rand.Next(0,3) == 0 ? -1 : 1;
            xSpeed = Math.Abs(xSpeed) * xDirection;
            ySpeed = Math.Abs(ySpeed) * yDirection;
        }

        public Rectangle Bounds
        {
            get { return ball.Bounds; }
        }
    }
}
