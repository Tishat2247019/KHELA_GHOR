using Helicopter_Shooter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Helicopter_Shooter.Properties;

namespace Helicopter_Shooter
{

    public partial class HelicopterPopUp : Form
    {
        static HelicopterPopUp newMessageBox;
        static string button_ID;
        public HelicopterPopUp()
        {
            InitializeComponent();
        }

        public static string showHighScore(string txt)
        {
            newMessageBox = new HelicopterPopUp();
            newMessageBox.lbl_congrats.Visible = true;
            newMessageBox.picBox_lottie.Visible = true;
            newMessageBox.picBox_lottie.BackgroundImage = Resources.Animation___1702657303627;
            newMessageBox.lbl_Score.Text = txt;
            newMessageBox.signUPerror_Oops.Text = "Hurray...";
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
            newMessageBox = new HelicopterPopUp();

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




        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_ID = "1";
            this.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_ID = "2";
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            button_ID = "1";
            this.Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            button_ID= "2";
            this.Dispose();
        }
    }
}
