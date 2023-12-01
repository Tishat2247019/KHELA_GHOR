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
using System.Data.SqlClient;

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
            if (txtBoxUser_SignUp.Text == "Username")
            {
                txtBoxUser_SignUp.Clear();
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
            if (TxtBoxEmail_SignUp.Text == "Email")

            {
                TxtBoxEmail_SignUp.Clear();
            }

            isclicked_emailtxtbox = true;
            email_after.Visible = true;
            email_before.Visible = false;
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            //address of the SQL server and database

            string connectinString = "Data Source=Towsif\\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True";


            //esblish connection;
            SqlConnection con = new SqlConnection(connectinString);

            //open connection
            con.Open();
            if (isclicked1 == false || isclicked2 == false || isclicked3 == false || isclicked_emailtxtbox == false || txtBoxUser_SignUp.Text == "" || TxtBoxEmail_SignUp.Text == "" || txtBoxPassword_Signup.Text == "" || txtBoxConPassword_Signup.Text == "")
            {
                MessageBox.Show("Please fill all the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           


            else
            {
                try
                {
                   

            
                    string Username = txtBoxUser_SignUp.Text;
                    string Email = TxtBoxEmail_SignUp.Text;
                    string Password = txtBoxPassword_Signup.Text;
                    //prepare Query
                    string Query = "INSERT INTO SIGNUP_INFO(UserName, Email, Password) VALUES('" + Username + "', '" + Email + "', '" + Password + "')";

                    //exucute Query
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();

                    txtBoxUser_SignUp.Clear();
                    txtBoxPassword_Signup.Clear();
                    TxtBoxEmail_SignUp.Clear();
                    txtBoxConPassword_Signup.Clear();
                    MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtBoxEmail_SignUp.Text = "Email";
                    txtBoxUser_SignUp.Text = "Username";
                    txtBoxPassword_Signup.Text = "Password";
                    txtBoxConPassword_Signup.Text = "Confirm Password";
                    txtBoxPassword_Signup.UseSystemPasswordChar = false;
                    txtBoxConPassword_Signup.UseSystemPasswordChar = false;

                    isclicked1 = false;
                    isclicked2 = false;
                    isclicked3 = false;
                    isclicked_emailtxtbox = false;

                }
                catch(Exception ex) 
                {
                    //MessageBox.Show($"Username {txtBoxUser_SignUp.Text} Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string user = txtBoxUser_SignUp.Text;
                    SignUpExistError.showmsg(user);
                }

                //close connection;
                finally
                {
                con.Close();
                    
                }
                


            }
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
                if (string.IsNullOrEmpty(txtBoxUser_SignUp.Text))
                {
                    errorProvider1.SetError(this.txtBoxUser_SignUp, "Please Enter Your Username!!");
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
                if (string.IsNullOrEmpty(TxtBoxEmail_SignUp.Text)){
                    errorProvider2.SetError(this.TxtBoxEmail_SignUp, "Please Enter Your Email");

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
