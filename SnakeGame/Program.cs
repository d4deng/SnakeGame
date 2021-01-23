using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SnakeGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfig.mainMenu = new SnakeGame.UI.MainMenu();
            GlobalConfig.gameBoard = new SnakeGame.UI.GameBoard();
            GlobalConfig.hallOfFame = new SnakeGame.UI.HallOfFame();
            GlobalConfig.endGame = new SnakeGame.UI.EndGame();
            Application.Run(GlobalConfig.mainMenu);
        }
    }
}
