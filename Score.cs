using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;
using PongGame;

namespace PongGame
{
    public class Score
    {
        private int points;
        private Label score;

        public string ScoreText
        {
            get { return score.Text; }
        }

        public Score(Label score)
        {
            this.score = score;
            points = 0;
        }

        public int Points
        {
            get { return points; }
            set 
            { 
                points = value;
                score.Text = points.ToString();
            }
        }

        public void Goal()
        {
            points++;
            score.Text = points.ToString();
        }

        public void Reset()
        {
            points = 0;
            score.Text = points.ToString();
        }
    }
}
