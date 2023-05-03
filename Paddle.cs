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

        public void MoveUp()
        {
            paddlePictureBox.Top -= speed;
        }


        public void MoveDown()
        {
            paddlePictureBox.Top += speed;
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
