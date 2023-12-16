using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing
{
    public partial class Form1 : Form
    {
        private Rectangle OriginalFormSize;
        private Dictionary<Control, Rectangle> originalControlSizes = new Dictionary<Control, Rectangle>();
        private Dictionary<Control, float> originalFontSizes = new Dictionary<Control, float>();

        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();


        bool goleft, goright;


        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            score++;
 
            if (goleft == true && player.Left > 2)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 904)
            {
                player.Left += playerSpeed;
            }

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 436)
            {
                roadTrack2.Top = -436;
            }
            if (roadTrack1.Top > 436)
            {
                roadTrack1.Top = -436;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            if (AI1.Top > 425)
            {
                changeAIcars(AI1);
            }
            if (AI2.Top > 425)
            {
                changeAIcars(AI2);
            }

            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }
            //Award & speed depend on score
            if(score > 40 && score<500)
            {
                award.Image = Properties.Resources.bronze;
            }
            if(score > 500 && score<2000)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed = 20;
                trafficSpeed = 22;
            }
            if(score > 2000)
            {
                award.Image = Properties.Resources.gold;
                roadSpeed = 27;
                trafficSpeed = 25;
            }

        }

        private void changeAIcars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 9);

            switch (carImage)
            {

                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }

            tempCar.Top = carPosition.Next(50, 700) * -1;

            if((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(11, 375);
            }
            if((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(511, 876);
            }
        }

        public void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            btnStart.Enabled = true;
        }

        public void ResetGame()
        {
            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            AI1.Top = carPosition.Next(300, 500) * -1;
            AI1.Left = carPosition.Next(11, 375);

            AI2.Top = carPosition.Next(300, 500) * -1;
            AI2.Left = carPosition.Next(511, 876);

            gameTimer.Start();
        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OriginalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);

            foreach (Control control in this.Controls)
            {
                originalControlSizes.Add(control, control.Bounds);
                if (control is Label || control is CheckBox || control is Button)
                {
                    originalFontSizes.Add(control, control.Font.Size);
                }
            }
        }


        private void form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                return;

            float xRatio = (float)this.Width / OriginalFormSize.Width;
            float yRatio = (float)this.Height / OriginalFormSize.Height;

            foreach (Control control in this.Controls)
            {
                if (originalControlSizes.ContainsKey(control))
                {
                    Rectangle originalSize = originalControlSizes[control];

                    int newX = (int)(originalSize.X * xRatio);
                    int newY = (int)(originalSize.Y * yRatio);
                    int newWidth = (int)(originalSize.Width * xRatio);
                    int newHeight = (int)(originalSize.Height * yRatio);

                    if (control is TextBox || control is PictureBox)
                    {
                        TextBox textBox = (TextBox)control;
                        float textBoxFontSize = textBox.Font.Size * Math.Min(xRatio, yRatio);
                        Font textBoxFont = new Font(textBox.Font.FontFamily, textBoxFontSize, textBox.Font.Style);
                        textBox.Font = textBoxFont;
                    }

                    control.Location = new Point(newX, newY);
                    control.Size = new Size(newWidth, newHeight);

                    if (originalFontSizes.ContainsKey(control))
                    {
                        float originalFontSize = originalFontSizes[control];
                        float newFontSize = originalFontSize * Math.Min(xRatio, yRatio);

                        Font newFont = new Font(control.Font.FontFamily, newFontSize, control.Font.Style);

                        if (control is Label || control is CheckBox)
                        {
                            control.Font = newFont;
                            // Adjust CheckBox and Labels position
                            control.Location = new Point(newX, newY);
                        }
                        else if (control is Button)
                        {
                            ((Button)control).Font = newFont;
                        }
                    }

                    // Additional logic for repositioning specific PictureBoxes
                    if (control == roadTrack1 || control == roadTrack2 || control == AI1 || control == AI2)
                    {
                        control.Left = (int)(control.Left * xRatio);
                        control.Top = (int)(control.Top * yRatio);
                    }
                }
            }
        }

        private void player_Click(object sender, EventArgs e)
        {
            
        }

        private void roadTrack2_Click(object sender, EventArgs e)
        {

        }

        public void playSound()
        {
            System.Media.SoundPlayer playClash = new System.Media.SoundPlayer(Properties.Resources.hit);
            //playClash.Play();
        }

    }
}
