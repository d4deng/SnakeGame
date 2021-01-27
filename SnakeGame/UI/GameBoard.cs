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
        private Timer timer;

        private List<Label> snake;
        private Point TailPos;
        private Label gold;
        private int dx = 0;
        private int dy = 0;

        private const int SPEED = 20;

        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += SnakeMove;
            timer.Tick += EatGold;
            timer.Tick += UpdateBoard;
        }

        private void GenerateNewGame()
        {
            snake = new List<Label>();
            Label snakeHead = new Label();
            snakeHead.BackColor = Color.Green;
            snakeHead.Location = GetRandomPosition();
            snakeHead.Size = new Size(20, 20);
            snake.Add(snakeHead);
            TailPos = snakeHead.Location;

            foreach (var bodyPart in snake)
            {
                this.GamePanel.Controls.Add(bodyPart);
            }

            GenerateNewGold();
        }

        private void GenerateNewGold()
        {
            gold = new Label();
            gold.BackColor = Color.Yellow;
            gold.Location = GetRandomPosition();
            gold.Size = new Size(20, 20);
            this.GamePanel.Controls.Add(gold);
        }

        private Point GetRandomPosition()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int posX = 0;
            int posY = 0;
            bool isNewLocation = false;
            while (!isNewLocation)
            {
                isNewLocation = true;
                posX = rnd.Next(0, 40);
                posY = rnd.Next(0, 30);

                foreach (Label snakePart in snake)
                {
                    if (snakePart.Location.X == posX & snakePart.Location.Y == posY)
                    {
                        isNewLocation = false;
                        break;
                    }
                }
            }

            Point output = new Point(20*posX, 20*posY);
            return output;
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

        private void CreateLabelButton_Click(object sender, EventArgs e)
        {
        }

        private void ResetForm()
        {
            this.ScoreTextBox.Text = "0";
            dx = 0;
            dy = 0;
            if (snake != null)
            {
                foreach (Label snakePart in snake)
                {
                    this.GamePanel.Controls.Remove(snakePart);
                }
                snake = null;
            }
            if (gold != null)
            {
                this.GamePanel.Controls.Remove(gold);
                gold = null;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ResetForm();
            GenerateNewGame();
            timer.Start();
        }

        private void EatGold(object sender, EventArgs e)
        {
            if (snake[0].Location == gold.Location)
            {
                SnakeGrow();
                this.GamePanel.Controls.Remove(gold);
                GenerateNewGold();
                EarnScore();
            }
        }

        private void SnakeGrow()
        {
            Label snakeTail = new Label();
            snakeTail.BackColor = Color.Green;
            snakeTail.Location = TailPos;
            snakeTail.Size = new Size(20, 20);
            snake.Add(snakeTail);
            this.GamePanel.Controls.Add(snakeTail);
        }

        private void EarnScore()
        {
            this.ScoreTextBox.Text = (int.Parse(this.ScoreTextBox.Text) + 1).ToString();
        }


        private void SnakeMove(object sender, EventArgs e)
        {
            for (int i = snake.Count - 1; i > 0; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }

            snake[0].Location = new Point(snake[0].Location.X + dx, snake[0].Location.Y + dy);
        }

        private void UpdateBoard(object sender, EventArgs e)
        {
            bool gameOver = false;
            if (snake[0].Location.X < 0 | snake[0].Location.X > 780 | snake[0].Location.Y < 0 | snake[0].Location.Y > 580)
            {
                gameOver = true;
            }
            else
            {
                for (int i = 1; i < snake.Count; i++)
                {
                    if (snake[0].Location == snake[i].Location)
                    {
                        gameOver = true;
                        break;
                    }
                }
            }

            if (gameOver)
            {
                GlobalConfig.endGame.SetScoreText(this.ScoreTextBox.Text);
                StartButton_Click(sender, e);
                this.Visible = false;
                GlobalConfig.endGame.Visible = true;
            }
            else
            {
                TailPos = snake.Last().Location;
            }
            
        }

        private void GameBoard_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    if (dx != -SPEED) { dx = SPEED; dy = 0; }
                    break;
                case Keys.A:
                    if (dx != SPEED) { dx = -SPEED; dy = 0; }
                    break;
                case Keys.W:
                    if (dy != SPEED) { dy = -SPEED; dx = 0; }
                    break;
                case Keys.S:
                    if (dy != -SPEED) { dy = SPEED; dx = 0; }
                    break;
            }
        }
    }
}
