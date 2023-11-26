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
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            textBox2.UseSystemPasswordChar = true;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.UseSystemPasswordChar = false;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
        }
    }
}
