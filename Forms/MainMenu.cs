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
            this.setting = new Setting();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Pong game = new Pong(this, setting);
            this.Hide();
            game.Show();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingForm settingsForm= new SettingForm(setting);
            settingsForm.ShowDialog();

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
