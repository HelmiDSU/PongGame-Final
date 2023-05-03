using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public partial class Pong : Form
    {
        bool p1MoveUp, p1MoveDown; 
        bool p2MoveUp, p2MoveDown;

        private Paddle p1;
        private Paddle p2;

        private Ball pongBall;
        private Timer timer;
        private Game game;
        private Score p1Score;
        private Score p2Score;

        public Pong()
        {
            InitializeComponent();
            p1 = new Paddle(player1, 10);
            p2 = new Paddle(player2, 10);
            pongBall = new Ball(ball);
            p1Score = new Score(player1Score);
            p2Score = new Score(player2Score);
            // game = new Game(pongBall, p1, p2, this.ClientSize.Width, this.ClientSize.Height);
            game = new Game(this, ball, player1, player2, p1Score, p2Score);
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += moveTimerEvent;
            timer.Start();

        }

        private void Pong_Load(object sender, EventArgs e)
        {

        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            if (p1MoveUp == true && player1.Top > 0)
            {
                p1.MoveUp();
            }
            if (p1MoveDown == true && player1.Top < 460)
            {
                p1.MoveDown();
            }
            if (p2MoveUp == true && player2.Top > 0)
            {
                p2.MoveUp();
            }
            if (p2MoveDown == true && player2.Top < 460)
            {
                p2.MoveDown();
            }
           // pongBall.Move();
             game.Update();

        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                p1MoveUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                p1MoveDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                p2MoveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                p2MoveDown = true;
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                p1MoveUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                p1MoveDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                p2MoveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                p2MoveDown = false;
            }
        }
    }
}
