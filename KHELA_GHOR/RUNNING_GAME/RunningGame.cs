using RUNNING_GAME.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUNNING_GAME
{
    public partial class RunningGame : Form
    {
        int gravity;
        int gravityvalue = 8;
        int obstaclespeed = 10;
        int score = 0;
        int highscore = 0;
        bool gameover = false;
        Random random = new Random();
        public RunningGame()
        {
            InitializeComponent();
            RestartGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score : " + score;
            lblHighScore.Text = "High Score : " + highscore;
            Player.Top += gravity;

            // when the player land on the platforms

            if (Player.Top > 455)
            {
                gravity = 0;
                Player.Top = 455;
                Player.Image = Properties.Resources.images_runniong_game__1_;
            }

            else if (Player.Top < 84)
            {
                gravity = 0;
                Player.Top = 84;
                Player.Image = Properties.Resources.images_runniong_game__2_;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstaclespeed;
                    if (x.Left < -100)
                    {
                        x.Left = random.Next(1000, 2000);
                        score += 1;
                    }



                    if (x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        gameTimer.Stop();
                        System.Media.SoundPlayer s = new System.Media.SoundPlayer();
                        s.Stream = Resources.smash_sound;
                        s.Load();
                        s.Play();
                        lblScore.Text += " Game Over !! Press Enter to Restert";
                        gameover = true;

                        if (score > highscore)
                        {
                            highscore = score;
                        }

                    }
                }
            }
            if (score > 10)
            {
                obstaclespeed = 15;
                gravityvalue = 10;
            }
        
    }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space ) {
                if (Player.Top == 455)
                {
                    Player.Top -= 10;
                    gravity = -gravityvalue;
                }
                else if (Player.Top == 84)
                {
                    Player.Top += 10;
                    gravity = gravityvalue;
                }
            }

            if (e.KeyCode == Keys.Enter && gameover) 
            {
                RestartGame();
                gameover = false;
            }

        }

        private void RestartGame()
        {
           
                lblScore.Parent = pictureBox1;
                lblHighScore.Parent = pictureBox2;
                lblHighScore.Top = 10;
                Player.Location = new Point(253, 265);
                Player.Image = Properties.Resources.images_runniong_game__1_;
                score = 0;
                gravityvalue = 12;
                gravity = gravityvalue;
                obstaclespeed = 8;

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "obstacle")
                    {
                        x.Left = random.Next(1000, 2000);
                    }
                }
                gameTimer.Start();
            }
        
    }
}
