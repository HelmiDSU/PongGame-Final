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
    public partial class SettingForm : Form
    {
        private Setting settings;

        public SettingForm()
        {
            InitializeComponent();
        }
        public SettingForm(Setting settings)
        {
            InitializeComponent();
            this.settings = settings;
        }

        private void save_Click(object sender, EventArgs e)
        {
            int ballSpeed = int.Parse(ballTextBox.Text);
            int paddleSpeed = int.Parse(paddleTextBox.Text);

            if (!int.TryParse(ballTextBox.Text, out ballSpeed))
            {
                MessageBox.Show("Please Enter a valid number for the ball speed.");
                return;
            }
            if (!int.TryParse(paddleTextBox.Text, out paddleSpeed))
            {
                MessageBox.Show("Please Enter a valid number for the paddle speed.");
                return;
            }


            settings.BallSpeed = ballSpeed;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
