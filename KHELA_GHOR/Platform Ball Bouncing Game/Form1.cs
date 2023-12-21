using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUNNING_GAME;

namespace Platform_Ball_Bouncing_Game
{
    public partial class Form1 : Form
    {

        bool gooLeft, gooRight, jumping, isGameOver;

        int jumpSpeed;
        int force;
        int score = 0;
        int highScore = 0;
        //

        //
        int playerSpeed = 7;

        int horizonrtalSpeed = 5;
        int verticalSpeed = 3;

        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;
        int enemyThreeSpeed = 3;

        //Shadow
        List<PictureBox> coinShadows = new List<PictureBox>();
        //Shadow

        //database connection
        string connectinString = "Data Source=Towsif\\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True";
        public static string username;

        public Form1()
        {
            InitializeComponent();

            // Cirular Coin
            MakePictureBoxesCircular();
            // Cirular Coin

            // Shadow
            CreateCoinShadows();
            // Shadow

            // Player
            MakePlayerCircular();
            // Player
            txtHighScore.Text = "High Score : " + GetHighScore();

            //
            
            //

        }

        public Form1(string username1)
        {
            InitializeComponent();
            // Cirular Coin
            MakePictureBoxesCircular();
            // Cirular Coin

            // Shadow
            CreateCoinShadows();
            // Shadow

            // Player
            MakePlayerCircular();
            // Player

            username = username1;
            txtHighScore.Text = "High Score : " + GetHighScore();


        }

        // Player
        private void MakePlayerCircular()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, player.Width, player.Height);

            player.Region = new Region(path);
        }
        // Player

        //Circular Coin
        private void MakePictureBoxesCircular()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "coin")
                {
                    MakeCircularPictureBox((PictureBox)control);
                }
            }
        }
        // Circular Coin

        // Circular Coin
        private void MakeCircularPictureBox(PictureBox pictureBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

            pictureBox.Region = new Region(path);
        }
        //Circular Coin

        // Shadow
        private void CreateCoinShadows()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "coin")
                {
                    // New PictureBox for the shadow
                    PictureBox shadow = new PictureBox();
                    shadow.Size = control.Size;
                    shadow.Location = new Point(control.Left - 2, control.Top - 1); // Shadow's position
                    //shadow.Location = new Point(control.Right + 10, control.Bottom + 10);
                    shadow.BackColor = Color.Gold; // Shadow's color
                    shadow.Tag = "coinShadow";

                    // Shadow circular
                    MakeCircularPictureBox(shadow);

                    // Add the Shadow PictureBox to the form and the list
                    Controls.Add(shadow);
                    coinShadows.Add(shadow);
                }
            }
        }
        // Shadow
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            
            txtScore.BackColor = Color.Transparent;
            txtHighScore.BackColor = Color.Transparent;
            txtScore.Text = "Score: " + score;
            player.Top += jumpSpeed;

            //
            if (!isGameOver)
            {
                if (score > GetHighScore())
                {
                    //highScore = GetHighScore();
                    // Update the high score display if you have a label for it
                    txtHighScore.Text = "High Score: " + score;
                }
            }
            //

            if (gooLeft == true) 
            {
                player.Left -= playerSpeed;
            }
            if (gooRight == true)
            {
                player.Left += playerSpeed;
            }

            if (jumping == true && force < 0) 
            {
                jumping = false;
            }

            if (jumping == true) 
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;

                            if ((string)x.Name == "horizontalPlatform" && gooLeft == false || (string)x.Name == "horizontalPlatform" && gooRight == false)
                            {
                                player.Left -= horizonrtalSpeed;
                            }
                        }
                        x.BringToFront();
                    }

                    if((string)x.Tag == "coin")
                    {
                        // Shadow
                        PictureBox shadow = coinShadows.FirstOrDefault(s => s.Bounds.IntersectsWith(x.Bounds));
                        // Shadow
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            //Shadow
                            if (shadow != null)
                            {
                                shadow.Visible = false; // Shadow disappear
                            }
                            //Shadow
                            score++;
                        }
                    }

                    if((string)x.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            SaveHighScore(username, score);

                            isGameOver = true;
                            //txtScore.Text = "Score: " + score + Environment.NewLine + "GAME OVER!!";
                            string id = ArcadeGamePopUp.showScore($"your score is : {score}");
                            if (id == "1")
                            {
                                RestartGame();
                            }
                        }
                    }
                }
            }

            horizontalPlatform.Left -= horizonrtalSpeed;

            if(horizontalPlatform.Left < 0 || horizontalPlatform.Left + horizontalPlatform.Width > this.ClientSize.Width)
            {
                horizonrtalSpeed =- horizonrtalSpeed;
            }

            verticalPlatform.Top += verticalSpeed;

            if(verticalPlatform.Top < 150 || verticalPlatform.Top > 480)
            {
                verticalSpeed =- verticalSpeed;
            }

            enemyOne.Left -= enemyOneSpeed;

            if(enemyOne.Left < pictureBox5.Left || enemyOne.Left + enemyOne.Width > pictureBox5.Left + pictureBox5.Width)
            {
                enemyOneSpeed = - enemyOneSpeed;
            }

            enemyTwo.Left += enemyTwoSpeed;

            if (enemyTwo.Left < pictureBox2.Left || enemyTwo.Left + enemyTwo.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            enemyThree.Left += enemyThreeSpeed;

            if (enemyThree.Left < pictureBox38.Left || enemyThree.Left + enemyThree.Width > pictureBox38.Left + pictureBox2.Width)
            {
                enemyThreeSpeed = -enemyThreeSpeed;
            }

            if (player.Top + player.Height > this.ClientSize.Height + 50)
            {
                gameTimer.Stop();
                SaveHighScore(username, score);
                isGameOver = true;
                // txtScore.Text = "Score: " + score + Environment.NewLine + "GAME OVER!!";

                string id = ArcadeGamePopUp.showScore($"your score is : {score}");
                if (id == "1")
                {
                    RestartGame();
                }
            }

            if (player.Bounds.IntersectsWith(door.Bounds) && score == 37) 
            {
                gameTimer.Stop();
                SaveHighScore(username, score);
                isGameOver = true;
                txtScore.Text = "Score: " + score + Environment.NewLine + "Congratulation";
            }
            else
            {
                //txtScore.Text = "Score: " + score + Environment.NewLine + "Collect All Coins";
            }
        }

        private void SaveHighScore(string playerName, int score)
        {

            //esblish connection;
            SqlConnection con = new SqlConnection(connectinString);

            //open connection
            con.Open();
            string game_name = "ArcadeGame";
            string user_name = playerName;
            string score1 = score.ToString();
            string query = "INSERT INTO Leader_Board (game_name, user_name, score_value) VALUES ('" + game_name + "', '" + user_name + "', '" + score1 + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            //string deleteQueary = "DELETE FROM Leader_Board WHERE game_name = 'SnakeGame' AND score_value NOT IN (SELECT TOP 10 score_value FROM Leader_Board  WHERE game_name = 'SnakeGame' ORDER BY CAST(score_value AS INT) DESC)";
            //SqlCommand cmd1 = new SqlCommand(deleteQueary, con);
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

                string query = "select max(Convert(int, score_value)) from Leader_Board where game_name = 'ArcadeGame';";
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                gooLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                gooRight = true;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }



        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                gooLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                gooRight = false;
            }
            if (jumping == true) 
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                //RestartGame();
                string message = "Simple MessageBox";
                MessageBox.Show(message);
            }
        }

        private void RestartGame()
        {
            jumping = false;
            gooLeft = false;
            gooRight = false;
            isGameOver = false;
            score = 0;

            txtScore.Text = "Score: " + score;
            txtHighScore.Text = "High Score : " + GetHighScore();

            //
            if (isGameOver)
            {
                if (score > highScore)
                {
                    highScore = score;
                    txtHighScore.Text = "High Score: " + highScore;
                }

            }
            //

            foreach (Control x in this.Controls) 
            {
                if (x is PictureBox && x.Visible == false) 
                {
                    x.Visible = true;
                }
            }


            // reset the position of player, platform and enemies

            player.Left = 72;
            player.Top = 470;

            enemyOne.Left = 330;
            enemyTwo.Left = 350;
            enemyThree.Left = 750;

            horizontalPlatform.Left = 273;
            verticalPlatform.Top = 480;
            

            gameTimer.Start();


        }
    }
}
