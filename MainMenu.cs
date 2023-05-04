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
    public partial class MainMenu : Form
    {
        private Setting setting;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Pong game = new Pong(this);
            this.Hide();
            game.Show();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingForm setingsForm= new SettingForm();
            setingsForm.ShowDialog();

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
