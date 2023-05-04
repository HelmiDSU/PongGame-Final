using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PongGame.Properties;

namespace PongGame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainMenu mainMenu = new MainMenu();
            Setting settings = new Setting();
            Pong pongGame = new Pong(mainMenu, settings);
            Application.Run(mainMenu);
        }
    }
}
