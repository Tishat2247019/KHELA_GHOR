using RUNNING_GAME.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;



namespace RUNNING_GAME
{
    public partial class RunningGame : Form
    {
        int gravity;
        int gravityvalue = 8;
        int obstaclespeed = 10;
       // int highcore = 0;
        int score = 0;
        bool gameover = false;
        Random random = new Random();
        
        private Rectangle OriginalFormSize;
        private Rectangle OriginalPicBox1Size;
        private Rectangle OriginalPicBox2Size;
        private Rectangle OriginalPlayerSize;
        private Rectangle OriginalPicBox3Size;
        private Rectangle OriginalPicBox5Size;
        private Rectangle OriginalLblScorsize;
        private Rectangle OriginalLblHighScorsize;

        private float OrigijalLblScoreFontSize;
        private float OrigijalLblHighScoreFontSize;

        private Size OriginalFormSize2;
        private bool orignalsize = true;
        // private bool maxsize = false;

        private Rectangle playerafterresize;
        private Rectangle playerBeforerresize;

        string connectinString = "Data Source=Towsif\\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True";
        public static string username;

        public RunningGame()
        {
            InitializeComponent();
            OriginalFormSize2 = this.Size;
            orignalsize = true;
            RestartGame();
        }

        public RunningGame(string username1)
        {
            InitializeComponent();
            username = username1;
            RestartGame();
            orignalsize = true;

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score : " + score;
            lblHighScore.Text = "High Score : " + GetHighScore() ;
            Player.Top += gravity;
            int highscore = GetHighScore() ;


            // when the player land on the platforms


            if (orignalsize)
            {
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
                playerBeforerresize = new Rectangle(Player.Location.X, Player.Location.Y, Player.Width, Player.Height);

            }

            if (!orignalsize)
            {

                if (Player.Top > 715)
                {
                    gravity = 0;
                    Player.Top = 715;
                    Player.Image = Properties.Resources.images_runniong_game__1_;
                }

                else if (Player.Top < 124)
                {
                    gravity = 0;
                    Player.Top = 124;
                    Player.Image = Properties.Resources.images_runniong_game__2_;
                }
                playerafterresize = new Rectangle(Player.Location.X, Player.Location.Y, Player.Width, Player.Height);

            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstaclespeed;
                    if (x.Left < -100)
                    {
                        x.Left = random.Next(1500, 2000);
                        score += 1;
                    }



                    if (x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        string id = "";
                        gameover = true;
                        gameTimer.Stop();
                        System.Media.SoundPlayer s = new System.Media.SoundPlayer();
                        s.Stream = Resources.smash_sound;
                        s.Load();
                        s.Play();
                        // lblScore.Text += " Game Over !! Press Enter to Restert";
                        SaveHighScore(username, score);
                        if (score > highscore)
                        {
                            highscore = score;
                            id = RunnigGamePopUp.showHighScore($"Your score is {score}");
                        }
                        else
                        {
                         id =   RunnigGamePopUp.showScore($"Your score is {score}");
                        }

                        if (id == "1")
                        {
                            RestartGame();
                        }

                       

                    }
                } 
            }
            if (score > 10)
            {
                obstaclespeed = 15;
                gravityvalue = 13;

               
                if (score % 10 == 0)
                {
                    obstaclespeed += 2;     
                    gravityvalue += 1;      
                }
            }

        }


        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (orignalsize)
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (Player.Top == 455)
                    {
                        Player.Top -= 10;
                        gravity = -gravityvalue;
                    }
                    else if (Player.Top == 84)
                    {
                        Player.Top += 10;
                        gravity =   gravityvalue;
                    }
                  //  playerBeforerresize = new Rectangle(Player.Location.X, Player.Location.Y, Player.Width, Player.Height);

                }
                if (e.KeyCode == Keys.Enter && gameover)
                {
                    RestartGame();
                    gameover = false;
                }

            }
            if (!orignalsize)
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (Player.Top == 715)
                    {
                        Player.Top -= 20;
                        gravity = -gravityvalue;
                    }
                    else if (Player.Top == 124)
                    {
                        Player.Top += 20;
                        gravity = gravityvalue;
                    }
                   // playerafterresize = new Rectangle(Player.Location.X, Player.Location.Y, Player.Width, Player.Height);

                }
                if (e.KeyCode == Keys.Enter && gameover)
                {
                    RestartGame2();
                    gameover = false;
                }
            }
            
           

            

        }

        private  void SaveHighScore(string playerName, int score)
        {

             //esblish connection;
            SqlConnection con = new SqlConnection(connectinString);

            //open connection
            con.Open();
            string game_name = "RunningGame";
            string user_name = playerName;
            string score1 = score.ToString();
            string query = "INSERT INTO Leader_Board (game_name, user_name, score_value) VALUES ('" + game_name + "', '" + user_name+ "', '" + score1 + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            
            //string deleteQueary = "DELETE FROM Leader_Board WHERE game_name = 'RunningGame' AND score_value NOT IN (SELECT TOP 10 score_value FROM Leader_Board WHERE game_name = 'RunningGame' ORDER BY CAST(score_value AS INT) DESC)";
            //SqlCommand cmd1= new SqlCommand(deleteQueary, con);
            //cmd1.ExecuteNonQuery();
           
            
            //exucute Query
            cmd.ExecuteNonQuery();


            
            
            //close the connection
            con.Close();
          
            
        }

        private int GetHighScore()
        {
            using (SqlConnection connection = new SqlConnection(connectinString))
            {
                connection.Open();

                string query = "select max(Convert(int, score_value)) from Leader_Board WHERE game_name = 'RunningGame';";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return 0; // Default value if no high score is found
                    }
                }
            }
        }



        private void RestartGame()
        {
           
                lblScore.Parent = pictureBox1;
                lblHighScore.Parent = pictureBox2;
                lblHighScore.Top = 10;
            
            lblHighScore.Text = "High Score : " + GetHighScore();


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
        private void RestartGame2()
        {

            lblScore.Parent = pictureBox1;
            lblHighScore.Parent = pictureBox2;
            lblHighScore.Top = 10;
            Player.Location = new Point(453, 265);
            Player.Image = Properties.Resources.images_runniong_game__1_;
            score = 0;
            gravityvalue = 13;
            gravity = gravityvalue;
            obstaclespeed = 10;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left = random.Next(1000, 2000);
                }
            }
            gameTimer.Start();
        }
        //private void continueGame()
        //{

        //    lblScore.Parent = pictureBox1;
        //    lblHighScore.Parent = pictureBox2;
        //    lblHighScore.Top = 10;
        //    Player.Location = playerafterresize.Location;
        //    Player.Image = Properties.Resources.images_runniong_game__1_;
        //    score = 0;
        //    gravityvalue = 12;
        //    gravity = gravityvalue;
        //    obstaclespeed = 8;

        //    foreach (Control x in this.Controls)
        //    {
        //        if (x is PictureBox && (string)x.Tag == "obstacle")
        //        {
        //            x.Left = random.Next(1000, 2000);
        //        }
        //    }
        //    gameTimer.Start();
        //}
        private void continueGame()
        {
            lblScore.Parent = pictureBox1;
            lblHighScore.Parent = pictureBox2;
            lblHighScore.Top = 10;

            // Adjust player location based on the resized window
            //Player.Location = orignalsize ? new Point(253, 265) : new Point(453, 265);
            Player.Location = orignalsize ? playerBeforerresize.Location : playerafterresize.Location;
            

            Player.Image = Properties.Resources.images_runniong_game__1_;

            // Avoid resetting the score to zero
            // score = 0;

            gravityvalue = orignalsize ? 12 : 13;
            gravity = gravityvalue;
            obstaclespeed = orignalsize ? 8 : 10;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left = random.Next(1000, 2000);
                }
            }

            //gameTimer.Start();
        }


        private void RunningGame_Load(object sender, EventArgs e)
        {
            OriginalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);

            OriginalPicBox1Size = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
            OriginalPicBox2Size = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Width, pictureBox2.Height);
            OriginalPlayerSize= new Rectangle(Player.Location.X, Player.Location.Y, Player.Width, Player.Height);
            OriginalPicBox3Size = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Width, pictureBox3.Height); 
            OriginalPicBox5Size = new Rectangle(pictureBox5.Location.X, pictureBox5.Location.Y, pictureBox5.Width, pictureBox5.Height); 
            OriginalLblScorsize = new Rectangle(lblScore.Location.X, lblScore.Location.Y, lblScore.Width, lblScore.Height); 
            OriginalLblHighScorsize = new Rectangle(lblHighScore.Location.X, lblHighScore.Location.Y, lblHighScore.Width, lblHighScore.Height);
            //OriginalLblScorsize = new Rectangle(lbLocation.X, pictureBox5.Location.Y, pictureBox5.Width, pictureBox5.Height); 
            //  OriginalPicBox5Size = new Rectangle(pictureBox5.Location.X, pictureBox5.Location.Y, pictureBox5.Width, pictureBox5.Height);
            //  
            OrigijalLblScoreFontSize = lblScore.Font.Size;
            OrigijalLblHighScoreFontSize = lblHighScore.Font.Size;

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

          //resizeControl(OriginalPicBox5Size, lblHighScore, OrigijalLblHighScoreFontSize);
        

        private void RunningGame_Resize_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                if (gameover)
                {
                    RestartGame2();

                }
                else
                {
                    continueGame();
                }

                orignalsize = false;


                resizeControl2(OriginalPicBox1Size, pictureBox1);
                resizeControl2(OriginalPicBox2Size, pictureBox2);
                resizeControl2(OriginalPlayerSize, Player);
                resizeControl2(OriginalPicBox3Size, pictureBox3);
                resizeControl2(OriginalPicBox5Size, pictureBox5);

                resizeControl(OriginalLblScorsize, lblScore, OrigijalLblScoreFontSize);
                resizeControl(OriginalLblHighScorsize, lblHighScore, OrigijalLblHighScoreFontSize);
              //  Player.Location = playerafterresize.Location;
            }
            if (this.WindowState == FormWindowState.Normal)
            {

                if (gameover)
                {

                    RestartGame();
                }
                else
                { 
                  // continueGame();
                }
                orignalsize = true;
                pictureBox1.Location = OriginalPicBox1Size.Location;
                pictureBox1.Size = OriginalPicBox1Size.Size;
                pictureBox2.Location = OriginalPicBox2Size.Location;
                pictureBox2.Size = OriginalPicBox2Size.Size;

                // Player.Location = OriginalPlayerSize.Location;
                Player.Location = playerBeforerresize.Location;

                Player.Size = OriginalPlayerSize.Size;

                pictureBox3.Location = OriginalPicBox3Size.Location;
                pictureBox3.Size = OriginalPicBox3Size.Size;
                pictureBox5.Location = OriginalPicBox5Size.Location;
                pictureBox5.Size = OriginalPicBox5Size.Size;

                lblScore.Location = OriginalLblScorsize.Location;
                lblScore.Size = OriginalLblScorsize.Size;
                lblHighScore.Location = OriginalLblHighScorsize.Location;
                lblHighScore.Size = OriginalLblHighScorsize.Size;

            }
        }
    }
}
