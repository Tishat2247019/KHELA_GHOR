using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LOGIN_REGISTRATION
{
    public partial class Login : Form
    {
        public bool isClick;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Label_Login_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }

        private void txt_UserLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_UserLogin.Text == "Username")
            {
                txt_UserLogin.Clear();
            }

            picBox_userBefore.Visible = false;
            picBox_UserAfter.Visible = true;
        }

        private void txt_PassLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_PassLogin.Text == "Password")
            {
                txt_PassLogin.Clear();
            }
            isClick = true;
            picBox_PassBefore.Visible = false;
            picBox_PassAfter.Visible = true;
        }

        private void picBox_Eye_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void picBox_Eye_MouseDown(object sender, MouseEventArgs e)
        {
            txt_PassLogin.UseSystemPasswordChar = false ;
        }

        private void picBox_Eye_MouseUp(object sender, MouseEventArgs e)
        {
            if (isClick)
            {
                txt_PassLogin.UseSystemPasswordChar = true;
            }
        }
    }
}
