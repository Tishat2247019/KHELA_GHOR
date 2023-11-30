using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace LOGIN_REGISTRATION
{
    public partial class Registration : Form
    {
        private static bool isclicked2 = false;
        private static bool isclicked3 = false;

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.textBox1.SelectionStart = this.textBox2.Text.Length;
            this.textBox1.DeselectAll();

        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Clear();
            }

            pictureBox2.Visible = false;
            pictureBox7.Visible = true;
           // pictureBox2.BackgroundImage = null; 

            //pictureBox2.BackgroundImage = KHELA_GHOR.Properties.Resources.USER_AFTER;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Clear();
            }
            isclicked2 = true;

            textBox2.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox8.Visible = true;

        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox3.Text == "Confirm Password")

            {
                textBox3.Clear();
            }

            isclicked3 = true;
            textBox3.UseSystemPasswordChar = true;
            pictureBox6.Visible = false;
            pictureBox9.Visible = true;
        }


        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            if (isclicked2)
            {
                textBox2.UseSystemPasswordChar = true;

            }
        }


        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.UseSystemPasswordChar = false;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            if (isclicked3)
            {
                textBox3.UseSystemPasswordChar = true;

            }
        }

       

        private void TxtBox_Email_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (TxtBox_Email.Text == "Email")

            {
                TxtBox_Email.Clear();
            }

            isclicked3 = true;
            email_after.Visible = true;
            email_before.Visible = false;
        }

        private void button_signup_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_before_Click(object sender, EventArgs e)
        {

        }

        private void email_after_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }

   

       

   
        
}
