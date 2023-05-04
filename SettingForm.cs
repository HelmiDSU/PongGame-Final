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
 
        public SettingForm(Setting settings)
        {
            InitializeComponent();
            this.settings = settings;

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (ballTextBox.Text != "")
            {
                int ballSpeed = int.Parse(ballTextBox.Text);

                if (!int.TryParse(ballTextBox.Text, out ballSpeed))
                {
                    MessageBox.Show("Please Enter a valid number for the ball speed.");
                    return;
                }
                settings.BallSpeed = ballSpeed;
            }
            if (paddleTextBox.Text != "")
            {
                int paddleSpeed = int.Parse(paddleTextBox.Text);
                if (!int.TryParse(paddleTextBox.Text, out paddleSpeed))
                {
                    MessageBox.Show("Please Enter a valid number for the paddle speed.");
                    return;
                }
                settings.PaddleSpeed = paddleSpeed;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ballColorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = ballColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ballColorButton.BackColor = ballColorDialog.Color;
            }
            settings.BallColor = ballColorButton.BackColor;


        }

        private void paddleColorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = paddleColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                paddleColorButton.BackColor = paddleColorDialog.Color;
            }
            settings.PaddleColor = paddleColorButton.BackColor;
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = backgroundDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                backgroundColorButton.BackColor = backgroundDialog.Color;
            }
            settings.BackGroundColor = backgroundColorButton.BackColor;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
