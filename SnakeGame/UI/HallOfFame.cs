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
    public partial class HallOfFame : Form
    {
        private List<TextBox> ScoreTextBoxes;
        private List<TextBox> NameTextBoxes;

        public HallOfFame()
        {
            InitializeComponent();
            ScoreTextBoxes = new List<TextBox> { FirstPlaceScoreTextBox,
                                                 SecondPlaceScoreTextBox,
                                                 ThirdPlaceScoreTextBox,
                                                 FourthPlaceScoreTextBox,
                                                 FifthPlaceScoreTextBox,
                                                 SixthPlaceScoreTextBox,
                                                 SeventhPlaceScoreTextBox,
                                                 EighthPlaceScoreTextBox,
                                                 NinthPlaceScoreTextBox,
                                                 TenthPlaceScoreTextBox};

            NameTextBoxes = new List<TextBox> { FirstPlaceNameTextBox,
                                                SecondPlaceNameTextBox,
                                                ThirdPlaceNameTextBox,
                                                FourthPlaceNameTextBox,
                                                FifthPlaceNameTextBox,
                                                SixthPlaceNameTextBox,
                                                SeventhPlaceNameTextBox,
                                                EighthPlaceNameTextBox,
                                                NinthPlaceNameTextBox,
                                                TenthPlaceNameTextBox};

            RefreshContent();
        }

        public void RefreshContent()
        {
            List<string> hallOfFame = GlobalConfig.dataFilePath.ReadData();
            for (int i = 0; i < hallOfFame.Count; i++)
            {
                string[] record = hallOfFame[i].Split(',');
                ScoreTextBoxes[i].Text = record[0];
                NameTextBoxes[i].Text = record[1];
            }
        }

        private void HallOfFame_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GlobalConfig.mainMenu.Visible = true;
        }

        private void HallOfFame_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalConfig.mainMenu.Close();
        }
    }
}
