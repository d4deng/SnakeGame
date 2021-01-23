using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SnakeGame.UI;

namespace SnakeGame
{
    static class GlobalConfig
    {
        public static string dataFilePath = @"C:\Users\dengd\Documents\SnakeGame\HallOfFame.csv";

        public static MainMenu mainMenu;
        public static GameBoard gameBoard;
        public static HallOfFame hallOfFame;
        public static EndGame endGame;
    }
}
