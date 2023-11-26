using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LOGIN_REGISTRATION
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox2.Parent = this;
            //label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;

            //label3.Parent = pictureBox2;
           // label3.BackColor = Color.Transparent;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }
    }
}
