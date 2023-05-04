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
        private Point location;

        public Paddle(PictureBox pictureBox, int startSpeed)
        {
            paddlePictureBox = pictureBox;
            speed = startSpeed;
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
