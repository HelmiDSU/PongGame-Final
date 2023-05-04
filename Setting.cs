using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    public class Setting
    {
        private int ballSpeed = 50;
        private int paddleSpeed = 7;
        public Color PaddleColor { get; set; }
        public Color BallColor { get; set; }
        public Color BackGroundColor { get; set; }

        public int BallSpeed
        {
            get
            {
                return ballSpeed;
            }
            set
            {
                ballSpeed = value;
            }
        }
        public int PaddleSpeed {
            get
            {
                return paddleSpeed;
            }
            set
            {
                paddleSpeed = value;  
            } 
        }



    }
}