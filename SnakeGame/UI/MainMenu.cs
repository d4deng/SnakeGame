using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeGame.UI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GlobalConfig.gameBoard.Visible = true;
        }

        private void HallOfFameButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GlobalConfig.hallOfFame.RefreshContent();
            GlobalConfig.hallOfFame.Visible = true;
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
