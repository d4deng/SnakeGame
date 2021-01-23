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
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

        }

        private void GameBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalConfig.mainMenu.Close();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GlobalConfig.mainMenu.Visible = true;
        }
    }
}
