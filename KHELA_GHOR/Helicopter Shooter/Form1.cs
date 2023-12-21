using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helicopter_Shooter
{
    public partial class Form1 : Form
    {   //global variables
        bool goUp, goDown, goleft, goright, shot, gameOver;

        int score = 0;
        int speed = 8; //player speed
        int UFOspeed = 10;
        int BombSpeed = 10;
        int BirdSpeed = 10;
        

        Random rand = new Random();//ufo placement

        Random randA = new Random();//bomb placement
        
        Random randB = new Random();//bird placement
        

        int playerSpeed = 7;
        int index = 0;//change ufo images in one picture box
        int index2 = 0;//change bomb images in one picture box
        int index3 = 0;//change bird images in one picture box



        public Form1()
        {
            InitializeComponent();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {   
            //when key is pressed
            if(e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            if (e.KeyCode == Keys.Space && shot == false )
            {
                MakeBullet();
                shot = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {   
            //when key is released
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (shot == true)
            {
                shot = false;
            }

            if(e.KeyCode == Keys.Enter && gameOver ==true)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            explosion.Visible = false;
            goUp = false;
            goDown = false;
            goleft = false;
            goright = false;
            shot = false;
            gameOver = false;
            score = 0;
            speed = 8;
            UFOspeed = 10;
            BombSpeed = 10;
            BirdSpeed = 10;
            
            txtScore.Text = "Score" + score;

            ChangeUFO();//UFO Reposition
            ChangeBomb();//Bomb Reposition
            ChangeBird();//Bird Reposition

            player.Top = 119;

            //pillar1.Left = 579;
            pillar2.Left = 253;

            GameTimer.Start();
        }

        private void GameOver()
        {  
            playSound();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(10, 5);
            explosion.BackColor = Color.Transparent;
            GameTimer.Stop();
            txtScore.Text = "Score " + score + " \nGame Over, Press Enter To Retry!";
            gameOver = true;
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            explosion.Visible = false;
            txtScore.Text = "Score: " + score;
            
            //up down movement
            if(goUp == true && player.Top > 0)
            {
                player.Top -= playerSpeed;
            }
            if(goDown == true && player.Top + player.Height  < this.ClientSize.Height)
            {
                player.Top += playerSpeed;
            }

            //left right movement
            if(goleft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if(goright == true && player.Left + player.Width  < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            }

           

            ufo.Left -= UFOspeed;
            bomb.Top += BombSpeed;
            bird.Left -= BirdSpeed;

            if(ufo.Left + ufo.Width < 0 )
            {
                ChangeUFO();
            }

            if (bomb.Top > this.ClientSize.Height)
            {
                ChangeBomb();
            }

            if (bird.Left + bird.Width < 0)
            {
                ChangeBird();
            }

            //MovingPillars
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "pillar") 
                {
                    x.Left -= speed;

                    if(x.Left < -200)
                    {
                        x.Left = 1500;
                    }
                    //crash with pillar
                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameOver();
                    }
                }

                if(x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Left += 25;

                    if(x.Left > 900)
                    {
                        RemoveBullet(((PictureBox)x));
                    }

                    //intraction between bullet & UFO
                    if(ufo.Bounds.IntersectsWith(x.Bounds))
                    {
                        RemoveBullet(((PictureBox)x));
                        score += 1;
                        ChangeUFO();
                    }
                     //intraction between bullet & bird
                    if(bird.Bounds.IntersectsWith(x.Bounds))
                    {
                        RemoveBullet(((PictureBox)x));
                        score += 1;
                        ChangeBird();
                    }

                }

            }

            if (player.Bounds.IntersectsWith(ufo.Bounds))
            {
                GameOver();
                string id = HelicopterPopUp.showScore($"Your score is {score}");
                if (id == "1")
                {
                    RestartGame();
                }
            }
            if(player.Bounds.IntersectsWith(bomb.Bounds))
            {
                GameOver();
                string id = HelicopterPopUp.showScore($"Your score is {score}");
                if (id == "1") {
                    RestartGame();

                }
            }
            if(player.Bounds.IntersectsWith(bird.Bounds))
            {
                GameOver();
                string id = HelicopterPopUp.showScore($"Your score is {score}");
                if (id == "1") {
                    RestartGame();

                }
            }
            
            if (score > 10)
            {
                speed = 12;
                UFOspeed = 18;
                BombSpeed = 15;
                BirdSpeed = 15;
            }
        }
        

        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }

        private void MakeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.BlueViolet;
            bullet.Height = 5;
            bullet.Width = 10;

            bullet.Left = player.Left + player.Width;
            bullet.Top = player.Top + player.Height / 2;

            bullet.Tag = "bullet";
            this.Controls.Add(bullet);

        }

        private void ChangeUFO()
        {
            if(index > 3)
            {
                index = 1;
            }
            else
            {
                index += 1;
            }

            switch (index)
            {
                case 1:
                    ufo.Image = Properties.Resources.alien1;
                    break;
                case 2:
                    ufo.Image = Properties.Resources.alien2;
                    break;
                case 3:
                    ufo.Image = Properties.Resources.alien3;
                    break;
            }

            ufo.Left = 1500;
            ufo.Top = rand.Next(20, this.ClientSize.Height - ufo.Height);

        }

       
        private void ChangeBomb()

        {
            if (index2 > 2)
            {
                index2 = 1;
            }
            else
            {
                index2 += 1;
            }
            switch (index2)
            {
                case 1:
                    bomb.Image = Properties.Resources.bomb1;
                    break;
                case 2:
                    bomb.Image = Properties.Resources.bomb2;
                    break;
            }

            bomb.Left = randA.Next(10, this.ClientSize.Width - bomb.Width);
            bomb.Top = 0; // Reset bomb to the top

        }
        private void ChangeBird()

        {
            if (index3 > 2)
            {
                index3 = 1;
            }
            else
            {
                index3 += 1;
            }
            switch (index3)
            {
                case 1:
                    bird.Image = Properties.Resources.bird1;
                    break;
                case 2:
                    bird.Image = Properties.Resources.bird2;
                    break;
            }

            bird.Left = 1500;
            bird.Top = rand.Next(20, this.ClientSize.Height - bird.Height);


        }

        public void playSound()
        {
            System.Media.SoundPlayer playClash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playClash.Play();
        }

    }
}
