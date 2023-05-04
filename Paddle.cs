using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public class Paddle
    {
        private PictureBox paddlePictureBox;
        private int speed;
        private Setting settings;
        private Point location;
        public Color color 
        {
            get
            {
                return color;
            }
            set
            {
                paddlePictureBox.BackColor = value;
            }
        }

        public Paddle(PictureBox pictureBox, Setting settings)
        {
            this.settings = settings; 
            paddlePictureBox = pictureBox;
            speed = settings.PaddleSpeed;
            location = pictureBox.Location;
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public void MoveUp()
        {
            if (paddlePictureBox.Top > 0)
            {
                paddlePictureBox.Top -= speed;

            }
        }


        public void MoveDown()
        {
            if (paddlePictureBox.Bottom < paddlePictureBox.Parent.ClientSize.Height)
            {
                paddlePictureBox.Top += speed;
            }
        }

        public void Reset()
        {
            paddlePictureBox.Location = location;
        }

        public Rectangle Bounds
        {
            get { return paddlePictureBox.Bounds; }
        }
    }

}
