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
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            ModifyHallOfFame();
            this.Visible = false;
            GlobalConfig.mainMenu.Visible = true;
        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {
            ModifyHallOfFame();
            this.Visible = false;
            GlobalConfig.gameBoard.Visible = true;
        }

        private void EndGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            ModifyHallOfFame();
            GlobalConfig.mainMenu.Close();
        }

        private void ModifyHallOfFame()
        {
            string score = YourScoreTextBox.Text;

            string name = YourNameTextBox.Text;

            if (name == "")
            {
                name = "Unknown";
            }

            string newRecord = $"{score},{name}";
            List<string> newHallOfFame = GetNewHallOfFame(GlobalConfig.dataFilePath.ReadData(), newRecord);
            newHallOfFame.WriteData(GlobalConfig.dataFilePath);
        }

        private List<string> GetNewHallOfFame(List<string> record, string newRecord)
        {
            if (record.Count == 0)
            {
                record.Add(newRecord);
            }

            else
            {
                string newScore = newRecord.Split(',')[0];

                int i = 0;
                while (i < record.Count)
                {
                    string score = record[i].Split(',')[0];
                    if (int.Parse(score) <= int.Parse(newScore))
                    {
                        break;
                    }
                    i++;
                }

                record.Insert(i, newRecord);

                if (record.Count > 10)
                {
                    record.RemoveAt(record.Count - 1);
                }
            }

            return record;
        }
    }
}
