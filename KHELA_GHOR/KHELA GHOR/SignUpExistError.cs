using KHELA_GHOR.Properties;
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

namespace LOGIN_REGISTRATION
{
   
    public partial class SignUpExistError : Form
    {
        static SignUpExistError newMessageBox; 
        static string button_ID;
        public SignUpExistError()
        {
            InitializeComponent();
        }

        public static string showmsg(string txt)
        {
            newMessageBox = new SignUpExistError();
            newMessageBox.label1.Text = ($"The Username {txt} already exist");
           // System.Media.SystemSounds.Hand.Play();
            newMessageBox.pictureBox1.Image = Resources.SIGNUP_ANIMATOIN_FAILED;
            //play faild sound
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.Stream = Resources.failed_sound;
            s.Load();
            s.Play();
            newMessageBox.ShowDialog();

            return button_ID;
          
        }

        public static string showEmail(string txt)
        {
            newMessageBox = new SignUpExistError();
            newMessageBox.LabelEmailShow.Text = txt;
            newMessageBox.label1.Visible = false;
            newMessageBox.LabelEmailShow.Visible = true; 
            newMessageBox.LabelEmailShow.Font = new Font("Microsoft Tai Le", 16);
            newMessageBox.LabelEmailShow.Location = new System.Drawing.Point(150, 71);
            newMessageBox.LableEmailSuggest1.Visible = true;
            newMessageBox.pictureBox1.Image = Resources.SIGNUP_ANIMATOIN_FAILED;
            newMessageBox.LableEmailSuggest2.Visible = true;
           // System.Media.SystemSounds.Hand.Play();
            //play faild sound
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.Stream = Resources.failed_sound;
            s.Load();
            s.Play();
            newMessageBox.ShowDialog();
            return button_ID;

           
        }

        public static string showLogin(string txt)
        {
            newMessageBox = new SignUpExistError();
            newMessageBox.label1.Visible = false;
            newMessageBox.pictureBox1.Image = Resources.SIGNUP_ANIMATOIN_FAILED;
            newMessageBox.LableEmailSuggest1.Font = new Font("Microsoft Tai Le", 18);
            newMessageBox.LableEmailSuggest1.Location = new System.Drawing.Point(150,131);
            newMessageBox.LableEmailSuggest1.Text = txt;
            newMessageBox.LableEmailSuggest1.Visible = true;
            //play faild sound
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.Stream = Resources.failed_sound;
            s.Load();
            s.Play();
            //  System.Media.SystemSounds.Hand.Play();
            newMessageBox.ShowDialog();

            
            return button_ID;
        }

        public static string showSuccess(string txt)
        {
            newMessageBox = new SignUpExistError();
            newMessageBox.label1.Visible = false;
            newMessageBox.pictureBox1.Image = Resources.SIGNUP_ANIMATION_SUCCESS;
            newMessageBox.pictureBox1.Location = new System.Drawing.Point(-5, 73);
            newMessageBox.LableEmailSuggest1.Font = new Font("Microsoft Tai Le", 18);
            newMessageBox.LableEmailSuggest1.Location = new System.Drawing.Point(150, 100);
            newMessageBox.LableEmailSuggest1.Text = txt;

            //play success sound
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.Stream = Resources.success_sound;
            s.Load();
            s.Play();


            newMessageBox.LableEmailSuggest1.Visible = true; 
            newMessageBox.LableEmailSuggest2.Visible = true;
            System.Media.SystemSounds.Hand.Play();
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
            this.Dispose() ;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_ID= "2";
            this.Dispose() ;
        }
    }
}
