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
        private int ballSpeed = 10;
        private int paddleSpeed = 7;
        private Color paddleColor = Color.White;
        private Color ballColor = Color.White;
        private Color backGroundColor = Color.Black;
        public Color PaddleColor 
        {
            get
            {
                return paddleColor;
            }
            set
            {
                ballColor = value;
            } 
        }
        public Color BallColor
        {
            get
            {
                return ballColor;
            }
            set
            {
                ballColor = value;
            }
        }
        public Color BackGroundColor
        {
            get
            {
                return backGroundColor;
            }
            set
            {
                backGroundColor = value;
            }
        }

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