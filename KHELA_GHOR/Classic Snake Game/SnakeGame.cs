using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Windows.Forms;

namespace Classic_Snake_Game
{
    public partial class SnakeGame : Form
    {
        private Rectangle OriginalFormSize;
        private Rectangle OriginalCanvasSize;
        private Rectangle OriginalbtnStartSize;

        //labels

        private Rectangle OriginaLblScoreSize;
        private Rectangle OriginaLblHighScoreSize;

        // labels font size
        private float OriginalbtnStartFontSize;
        private float OriginalLblScoreFontSize;
        private float OriginalLbHighlScoreFontSize;


        private bool orignalsize = true;
        // private bool maxsize = false;

        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;

        public SnakeGame()
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

        private void EatFood()
        {
            score += 1;
            txtScore.Text = "Score: " + score;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        private void SnakeGame_Load(object sender, EventArgs e)
        {
             OriginalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);

                OriginalCanvasSize = new Rectangle(canvas.Location.X, canvas.Location.Y, canvas.Width, canvas.Height);
                OriginalbtnStartSize  = new Rectangle(startButton.Location.X, startButton.Location.Y, startButton.Width, startButton.Height);
                // resize font of the start button
                OriginalbtnStartFontSize = startButton.Font.Size;

            /// resize of the Labels size
            OriginaLblScoreSize = new Rectangle(txtScore.Location.X, txtScore.Location.Y, txtScore.Width, txtScore.Height);
            OriginaLblHighScoreSize = new Rectangle(txtHighScore.Location.X, txtHighScore.Location.Y, txtHighScore.Width, txtHighScore.Height);

            // resize of the Labels font
            OriginalLblScoreFontSize = txtScore.Font.Size;
            OriginalLbHighlScoreFontSize = txtHighScore.Font.Size;
                

            
        }


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
        private void resizeControl(Rectangle r, Control c, float originalfontsize)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

            float ratio = xRatio;
            if (xRatio >= yRatio)
            {
                ratio = yRatio;
            }
            float newfontsize = originalfontsize * ratio;
            Font newfont = new Font(c.Font.FontFamily, newfontsize);
            c.Font = newfont;
        }
        private void resizeControl2(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

            float ratio = xRatio;
            if (xRatio >= yRatio)
            {
                ratio = yRatio;
            }
        }
        private void SnakeGame_Resize(object sender, EventArgs e)
        {
            //resizeControl2(OriginalCanvasSize, canvas);
           // resizeControl(OriginalbtnStartSize, startButton, OriginalbtnStartFontSize);

            //labels
           // resizeControl(OriginaLblScoreSize, txtScore, OriginalLblScoreFontSize);
          // resizeControl(OriginaLblHighScoreSize, txtHighScore, OriginalLbHighlScoreFontSize);

        }

        }
    }
