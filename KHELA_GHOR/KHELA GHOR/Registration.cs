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
        private static bool isclicked1 = false;
        private static bool isclicked2 = false;
        private static bool isclicked3 = false;
        private static bool isclicked_emailtxtbox = false;
        private Form previousForm;

        public Registration()
        {
            InitializeComponent();
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.MouseOverBackColor = Color.Coral;
        }
        public Registration(Form form) : this()
        {
            previousForm = form;
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);

        //    this.textBox1.SelectionStart = this.textBox2.Text.Length;
        //    this.textBox1.DeselectAll();

        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Clear();
            }
            isclicked1 = true;

            pictureBox2.Visible = false;
            pictureBox7.Visible = true;
           // pictureBox2.BackgroundImage = null; 

            //pictureBox2.BackgroundImage = KHELA_GHOR.Properties.Resources.USER_AFTER;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxPassword_Signup.Text == "Password")
            {
                txtBoxPassword_Signup.Clear();
            }
            isclicked2 = true;

            txtBoxPassword_Signup.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox8.Visible = true;

        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxConPassword_Signup.Text == "Confirm Password")

            {
                txtBoxConPassword_Signup.Clear();
            }

            isclicked3 = true;
            txtBoxConPassword_Signup.UseSystemPasswordChar = true;
            pictureBox6.Visible = false;
            pictureBox9.Visible = true;
        }


        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxPassword_Signup.UseSystemPasswordChar = false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            if (isclicked2)
            {
                txtBoxPassword_Signup.UseSystemPasswordChar = true;

            }
        }


        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxConPassword_Signup.UseSystemPasswordChar = false;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            if (isclicked3)
            {
                txtBoxConPassword_Signup.UseSystemPasswordChar = true;

            }
        }

       

        private void TxtBox_Email_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (TxtBox_Email.Text == "Email")

            {
                TxtBox_Email.Clear();
            }

            isclicked_emailtxtbox = true;
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
            button1.BackColor = Color.Coral;
            Login L = new Login(this);
            L.Show();
            this.Hide();
        }

        private void Label_SignUp_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (isclicked1)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    errorProvider1.SetError(this.textBox1, "Please Enter Your Username!!");
                }
                else
                {
                    errorProvider1.Clear();
                }

            }
        }

        private void TxtBox_Email_Leave(object sender, EventArgs e)
        {
            if (isclicked_emailtxtbox)
            {
                if (string.IsNullOrEmpty(TxtBox_Email.Text)){
                    errorProvider2.SetError(this.TxtBox_Email, "Please Enter Your Email");

                }
                else
                {
                    errorProvider2.Clear();
                }
            }
        }


        private void txtBoxPassword_Signup_Leave(object sender, EventArgs e)
        {
            if (isclicked2)
            {
                if (string.IsNullOrEmpty(txtBoxPassword_Signup.Text))
                {
                    errorProvider3.SetError(this.txtBoxPassword_Signup, "Please Enter Your Password");
                }
                else
                {
                    errorProvider3.Clear();
                }
            }

        }

        private void txtBoxConPassword_Signup_Leave(object sender, EventArgs e)
        {
            if (isclicked3 && isclicked2)

            {
                if (string.IsNullOrEmpty(txtBoxConPassword_Signup.Text))
                {
                    errorProvider4.SetError(this.txtBoxConPassword_Signup, "Please Confirm Your Password");
                }
                else if (txtBoxPassword_Signup.Text != txtBoxConPassword_Signup.Text)
                {
                    errorProvider4.SetError(this.txtBoxConPassword_Signup, "Password Mismatched");
                }
                else
                {
                    errorProvider4.Clear();
                }
            }
        }

        private void btnBack_Signup_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }
    }

   

       

   
        
}
