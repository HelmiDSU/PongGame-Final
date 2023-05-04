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
    public partial class GameOver : Form
    {
        
        public GameOver(string winner)
        {
            InitializeComponent();

            winnerLabel.Text = $"{winner} wins!";
        }

        private void GameOver_Load(object sender, EventArgs e)
        {

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
