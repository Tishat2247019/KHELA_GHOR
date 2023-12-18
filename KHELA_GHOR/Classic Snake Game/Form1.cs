using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classic_Snake_Game
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        //CG
        private int pointsSinceLastSpeedIncrease = 0;
        //CG

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;

        public Form1()
        {
            InitializeComponent();
            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
                
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
                
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
                
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
                
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
                
            else if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
                
            else if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
                
            else if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
                
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            //CG
            
            //CG

            // Setting the directions
            if (goLeft)
            {
                Settings.directions = "left";
            }
                
            else if (goRight)
            {
                Settings.directions = "right";
            }
                
            else if (goDown)
            {
                Settings.directions = "down";
            }
                
            else if (goUp)
            {
                Settings.directions = "up";
            }

            // End of Directions

            
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                        
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                        
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                        
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }
                        

                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }
                        

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                            
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            canvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canv = e.Graphics;
            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }

                else
                {
                    snakeColour = Brushes.DarkBlue;
                }
                    

                canv.FillEllipse(snakeColour, new Rectangle(
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height));
            }

            canv.FillEllipse(Brushes.DarkRed, new Rectangle(
                 food.X * Settings.Width,
                 food.Y * Settings.Height,
                 Settings.Width, Settings.Height));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RestartGame()
        {
            maxWidth = canvas.Width / Settings.Width - 1;
            maxHeight = canvas.Height / Settings.Height - 1;
            Snake.Clear();

            startButton.Enabled = false;
            score = 0;
            txtScore.Text = "Score: " + score;

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            gameTimer.Start();
        }

        /*
        //CG
        private void GenerateBonusFood()
        {
            bonusFood = new Circle { X = rand.Next(2, maxWidth - 2), Y = rand.Next(2, maxHeight - 2) };
        }
        //CG
        */

        private void EatFood()
        {
            score += 1;
            txtScore.Text = "Score: " + score;

            //CG
            pointsSinceLastSpeedIncrease += 1;
            if (pointsSinceLastSpeedIncrease >= 5)
            {
                IncreaseSpeed();
                pointsSinceLastSpeedIncrease = 0;
            }
            //CG

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        //CG
        private void IncreaseSpeed()
        {
            int currentInterval = gameTimer.Interval;

            // Increase speed by reducing the interval
            if (currentInterval > 10) // Limiting the minimum interval to 10
            {
                gameTimer.Interval -= 10;
            }
        }
        //CG
        private void GameOver()
        {
            gameTimer.Stop();

            startButton.Enabled = true;

            if (score > highScore)
            {
                highScore = score;
                txtHighScore.Text = "High Score: " + Environment.NewLine + highScore;
                txtHighScore.ForeColor = Color.Maroon;
                txtHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
