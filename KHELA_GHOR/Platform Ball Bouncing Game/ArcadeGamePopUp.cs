using Platform_Ball_Bouncing_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platform_Ball_Bouncing_Game
{
    public partial class ArcadeGamePopUp : Form
    {
        static ArcadeGamePopUp newMessageBox;
        static string button_ID;
        public ArcadeGamePopUp()
        {
            InitializeComponent();
        }
        public static string showHighScore(string txt)
        {
            newMessageBox = new ArcadeGamePopUp(); ;
            newMessageBox.lbl_congrats.Visible = true;
            newMessageBox.picbox_lottie.BackgroundImage = Resources.Animation___1702657303627;
            newMessageBox.lbl_Score.Text = txt;
            newMessageBox.picbox_gameOver.Image = Resources.output_onlinegiftools;
            newMessageBox.lbl_Score.Text = txt;
            newMessageBox.lbl_Score.Visible = true;
            newMessageBox.lbl_Restart.Visible = true;
            // System.Media.SystemSounds.Hand.Play();
            ////  newMessageBox.pictureBox1.Image = Resources.SIGNUP_ANIMATOIN_FAILED;
            //play faild sound
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.Stream = Resources.Sound_HighScore;
            Thread.Sleep(1000);

            s.Load();
            s.Play();
            newMessageBox.ShowDialog();

            return button_ID;

        }

        public static string showScore(string txt)
        {
            newMessageBox = new ArcadeGamePopUp();

            newMessageBox.lbl_Score.Text = txt;
            newMessageBox.lbl_Score.Visible = true;
            newMessageBox.lbl_Restart.Visible = true;
            newMessageBox.picbox_gameOver.Image = Resources.Animation___1702655022387;


            //newMessageBox.lbl_Gameover.Visible = false;
            //newMessageBox.LabelEmailShow.Visible = true; 
            //newMessageBox.LabelEmailShow.Font = new Font("Microsoft Tai Le", 16);
            //newMessageBox.LabelEmailShow.Location = new System.Drawing.Point(150, 71);
            ////   newMessageBox.pictureBox1.Image = Resources.SIGNUP_ANIMATOIN_FAILED;
            // System.Media.SystemSounds.Hand.Play();


            //play faild sound
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();

            s.Stream = Resources.game_over;
            //using thred to play the game over sound after 1 sec of the pop up 
            Thread.Sleep(1000);
            s.Load();
            s.Play();
            newMessageBox.ShowDialog();
            return button_ID;


        }
        private void btn_ok1_Click(object sender, EventArgs e)
        {
            button_ID = "1";
            this.Dispose();

        }

        private void btn_cancel1_Click(object sender, EventArgs e)
        {
            button_ID = "2";
            this.Dispose();

        }

        private void lbl_gameover1_Click(object sender, EventArgs e)
        {

        }

        private void picbox_lottie_Click(object sender, EventArgs e)
        {

        }

        private void lbl_score1_Click(object sender, EventArgs e)
        {

        }

        private void picbox_gameOver_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Restart1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Score_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Gameover_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Restart_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void picbox_gameOver1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_MouseClick(object sender, MouseEventArgs e)
        {
            button_ID = "1";
            this.Dispose();
        }
    }

}
