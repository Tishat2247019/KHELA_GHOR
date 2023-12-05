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
        private static bool isMatched = true;
        private Form previousForm;


        private Rectangle PanelOriginalRectangle1;
        private Rectangle OriginalFormSize;
        private float originalPanelFontSize;

        private Rectangle txtboxUserOriginalRectangle1;
        private float txtboxUserFontSizeOriginalRectangle1;
        private Rectangle PicUserBeforeOriginalRectangl2;
        private Rectangle PicUserAfterOriginalRectangl3;
        private Rectangle PanelUserOriginalRectangl4;

        private Rectangle txtboxEmailOriginalRectangle5;
        private float txtboxEmailFontSizeOriginalRectangle6;
        private Rectangle PicEmailBeforeOriginalRectangl7;
        private Rectangle PicEmailAfterOriginalRectangl8;
        private Rectangle PanelEmailOriginalRectangl9;

        private Rectangle txtboxPassOriginalRectangle10;
        private float txtboxPassFontSizeOriginalRectangle11;
        private Rectangle PicPassBeforeOriginalRectangle12;
        private Rectangle PicPassAfterOriginalRectangle13;
        private Rectangle PanelPassOriginalRectangle14;
        private Rectangle EyeBtnPassOriginalRectangle15;

        private Rectangle txtboxConPassOriginalRectangle16;
        private float txtboxConPassFontSizeOriginalRectangle17;
        private Rectangle PicConPassBeforeOriginalRectangle18;
        private Rectangle PicConPassAfterOriginalRectangle19;
        private Rectangle PanelConPassOriginalRectangl20;
        private Rectangle EyeBtnConPassOriginalRectangle21;

        private Rectangle LabelLogin1OriginalRectangle22;
        private Rectangle LabelLogin2OriginalRectangle23;
        private Rectangle BtnSignInOriginalRectangle24;
        private Rectangle BtnSignUPOriginalRectangle25;
        private Rectangle BtnBackOriginalRectangle26;


        private float originalButtonsFontSize;
        private float originalLabel1FontSize;
        private float originalLabel2FontSize;

        public Registration()
        {
            InitializeComponent();
            button_Signin.FlatStyle = FlatStyle.Flat;
            button_Signin.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41) ;
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

            picBox_userBefore.Visible = false;
            picBox_UserAfter.Visible = true;
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
            picBox_PassBefore.Visible = false;
            picBox_PassAfter.Visible = true;

        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxConPassword_Signup.Text == "Confirm Password")

            {
                txtBoxConPassword_Signup.Clear();
            }

            isclicked3 = true;
            txtBoxConPassword_Signup.UseSystemPasswordChar = true;
            picBox_ConPassBefore.Visible = false;
            picBox_ConPassAfter.Visible = true;
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

       
       
        private void clear()
        {
            txtBoxUser_SignUp.Clear();
            txtBoxPassword_Signup.Clear();
            TxtBoxEmail_SignUp.Clear();
            txtBoxConPassword_Signup.Clear();
        }

        private void default_txt()
        {
            TxtBoxEmail_SignUp.Text = "Email";
            txtBoxUser_SignUp.Text = "Username";
            txtBoxPassword_Signup.Text = "Password";
            txtBoxConPassword_Signup.Text = "Confirm Password";
        }

        private void TxtBox_Email_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (TxtBoxEmail_SignUp.Text == "Email")

            {
                TxtBoxEmail_SignUp.Clear();
            }

            isclicked_emailtxtbox = true;
            picBox_EmailAfter.Visible = true;
            picBox_EmailBefore.Visible = false;
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            //address of the SQL server and database

            string connectinString = "Data Source=LAPTOP-1LRTBSIR\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True";


            //esblish connection;
            SqlConnection con = new SqlConnection(connectinString);

            //open connection
            con.Open();
            if (isclicked1 == false || isclicked2 == false || isclicked3 == false || isclicked_emailtxtbox == false || txtBoxUser_SignUp.Text == "" || TxtBoxEmail_SignUp.Text == "" || txtBoxPassword_Signup.Text == "" || txtBoxConPassword_Signup.Text == "")
            {
                MessageBox.Show("Please fill all the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
            else if (txtBoxConPassword_Signup.Text != txtBoxPassword_Signup.Text)
            {
                MessageBox.Show("Please Confirm Your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    //txtBoxUser_SignUp.Clear();
                    //txtBoxPassword_Signup.Clear();
                    //TxtBoxEmail_SignUp.Clear();
                    //txtBoxConPassword_Signup.Clear();
                    this.clear();
                    //MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string idsuccess = SignUpExistError.showSuccess("Your Registration Is Successfull!!");
                    if (idsuccess == "1")
                    {
                        Login L = new Login(this);
                        L.Show();
                        this.Hide();
                    }
                    if (idsuccess == "2")
                    {
                        this.clear();
                        this.default_txt();
                        txtBoxPassword_Signup.UseSystemPasswordChar = false;
                        txtBoxConPassword_Signup.UseSystemPasswordChar = false;
                    }


                    this.default_txt();
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
                   string Query_UserName = "SELECT * FROM SIGNUP_INFO WHERE UserName = '" + user + "'";

                    string email = TxtBoxEmail_SignUp.Text;
                    string Queary_Email = "SELECT * FROM SIGNUP_INFO WHERE Email = '" + email + "'";

                    try
                    {

                        SqlCommand cmd_UserName = new SqlCommand(Query_UserName, con);
                        SqlDataReader reader1 = cmd_UserName.ExecuteReader();
                        if (reader1.HasRows)
                        {
                            string id1 = SignUpExistError.showmsg(user);
                            if (id1 == "1")
                            {
                                txtBoxUser_SignUp.Clear();
                            }
                            if (id1 == "2")
                            {
                                this.clear();
                                this.default_txt();
                                txtBoxPassword_Signup.UseSystemPasswordChar = false;
                                txtBoxConPassword_Signup.UseSystemPasswordChar = false;
                            }

                        }
                        reader1.Close();
                        SqlCommand cmd_Email = new SqlCommand(Queary_Email, con);
                        SqlDataReader reader2 = cmd_Email.ExecuteReader();
                        if(reader2.HasRows)
                        {
        
                                string id2 = SignUpExistError.showEmail(email);
                                if (id2 == "1")
                                {
                                    Login L = new Login(this);
                                    L.Show();
                                    this.default_txt();
                                    txtBoxPassword_Signup.UseSystemPasswordChar = false;
                                    txtBoxConPassword_Signup.UseSystemPasswordChar = false;
                                    this.Hide();
                                }
                                if (id2 == "2")
                                {
                                    this.clear();
                                    this.default_txt();
                                    txtBoxPassword_Signup.UseSystemPasswordChar = false;
                                    txtBoxConPassword_Signup.UseSystemPasswordChar = false;
                                }

                            }
                        reader2.Close();
                       
                    }
                    catch(Exception ex2)
                        {
                        Console.WriteLine("Exception while checking username or email existence: " + ex2.Message);

                    }

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
            
            if (isclicked_emailtxtbox)
            {
              errorProvider2.Clear();
                
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (isclicked2 && isclicked3) {
             if (txtBoxPassword_Signup.Text != txtBoxConPassword_Signup.Text)
                {
                    errorProvider4.SetError(this.txtBoxConPassword_Signup, "Password Mismatched");
                    isMatched = false;
                }
                else
                {
                    errorProvider4.Clear();
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxPassword_Signup.Text.Length < 6)
            {
                errorProvider3.SetError(this.txtBoxPassword_Signup, "Password Must Be At Least 6 Character");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isclicked1)
            {
           
                    errorProvider1.Clear();
               
            }
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
            button_Signin.BackColor = Color.Coral;
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
                if (string.IsNullOrEmpty(TxtBoxEmail_SignUp.Text))
                {
                    errorProvider2.SetError(this.TxtBoxEmail_SignUp, "Please Enter Your Email");

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
                //else
                //{
                //    errorProvider3.Clear();
                //}
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
                
            }
        }

        private void btnBack_Signup_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            OriginalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            PanelOriginalRectangle1 = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height);

            txtboxUserOriginalRectangle1 = new Rectangle(txtBoxUser_SignUp.Location.X, txtBoxUser_SignUp.Location.Y, txtBoxUser_SignUp.Width, txtBoxUser_SignUp.Height);
            PicUserBeforeOriginalRectangl2 = new Rectangle(picBox_userBefore.Location.X, picBox_userBefore.Location.Y, picBox_userBefore.Width, picBox_userBefore.Height);
            PicUserAfterOriginalRectangl3 = new Rectangle(picBox_UserAfter.Location.X, picBox_UserAfter.Location.Y, picBox_UserAfter.Width, picBox_UserAfter.Height);
            PanelUserOriginalRectangl4 = new Rectangle(panel2.Location.X, panel2.Location.Y, panel2.Width, panel2.Height);

            txtboxEmailOriginalRectangle5 = new Rectangle(TxtBoxEmail_SignUp.Location.X, TxtBoxEmail_SignUp.Location.Y, TxtBoxEmail_SignUp.Width, TxtBoxEmail_SignUp.Height); ;
            PicEmailBeforeOriginalRectangl7 = new Rectangle(picBox_userBefore.Location.X, picBox_EmailBefore.Location.Y, picBox_EmailBefore.Width, picBox_EmailBefore.Height); ;
            PicEmailAfterOriginalRectangl8 = new Rectangle(picBox_EmailAfter.Location.X, picBox_EmailAfter.Location.Y, picBox_EmailAfter.Width, picBox_EmailAfter.Height);
            PanelEmailOriginalRectangl9 = new Rectangle(panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height);


            txtboxPassOriginalRectangle10 = new Rectangle(txtBoxPassword_Signup.Location.X, txtBoxPassword_Signup.Location.Y, txtBoxPassword_Signup.Width, txtBoxPassword_Signup.Height);
            PicPassBeforeOriginalRectangle12 = new Rectangle(picBox_PassBefore.Location.X, picBox_PassBefore.Location.Y, picBox_PassBefore.Width, picBox_PassBefore.Height);
            PicPassAfterOriginalRectangle13 = new Rectangle(picBox_PassAfter.Location.X, picBox_PassAfter.Location.Y, picBox_PassAfter.Width, picBox_PassAfter.Height);
            PanelPassOriginalRectangle14 = new Rectangle(panel4.Location.X, panel4.Location.Y, panel4.Width, panel4.Height);
            EyeBtnPassOriginalRectangle15 = new Rectangle(picBox_Eye1.Location.X, picBox_Eye1.Location.Y, picBox_Eye1.Width, picBox_Eye1.Height);

            txtboxConPassOriginalRectangle16 = new Rectangle(txtBoxConPassword_Signup.Location.X, txtBoxConPassword_Signup.Location.Y, txtBoxConPassword_Signup.Width, txtBoxConPassword_Signup.Height);
            PicConPassBeforeOriginalRectangle18 = new Rectangle(picBox_ConPassBefore.Location.X, picBox_ConPassBefore.Location.Y, picBox_ConPassBefore.Width, picBox_ConPassBefore.Height);
            PicConPassAfterOriginalRectangle19 = new Rectangle(picBox_ConPassAfter.Location.X, picBox_ConPassAfter.Location.Y, picBox_ConPassAfter.Width, picBox_ConPassAfter.Height);
            PanelConPassOriginalRectangl20 = new Rectangle(panel5.Location.X, panel5.Location.Y, panel5.Width, panel5.Height);
            EyeBtnConPassOriginalRectangle21 = new Rectangle(picBox_Eye2.Location.X, picBox_Eye2.Location.Y, picBox_Eye2.Width, picBox_Eye2.Height);

            txtboxUserFontSizeOriginalRectangle1 = txtBoxUser_SignUp.Font.Size;
            txtboxEmailFontSizeOriginalRectangle6 = TxtBoxEmail_SignUp.Font.Size;
            txtboxPassFontSizeOriginalRectangle11 = txtBoxPassword_Signup.Font.Size;
            txtboxConPassFontSizeOriginalRectangle17 = txtBoxConPassword_Signup.Font.Size;

            LabelLogin1OriginalRectangle22 = new Rectangle(SignUp_lable1.Location.X, SignUp_lable1.Location.Y, SignUp_lable1.Width, SignUp_lable1.Height);
            LabelLogin2OriginalRectangle23 = new Rectangle(SignUp_label2.Location.X, SignUp_label2.Location.Y, SignUp_label2.Width, SignUp_label2.Height);
            BtnSignInOriginalRectangle24 = new Rectangle(button_Signin.Location.X, button_Signin.Location.Y, button_Signin.Width, button_Signin.Height);
            BtnSignUPOriginalRectangle25 = new Rectangle(button_signup.Location.X, button_signup.Location.Y, button_signup.Width, button_signup.Height);
            BtnBackOriginalRectangle26 = new Rectangle(btnBack_Signup.Location.X, btnBack_Signup.Location.Y, btnBack_Signup.Width, btnBack_Signup.Height);


            originalButtonsFontSize = button_signup.Font.Size;
            originalLabel1FontSize = SignUp_lable1.Font.Size;
            originalLabel2FontSize = SignUp_label2.Font.Size;


        }

        private void resizeControl(Rectangle r, Control c, float originalfontsize)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

            float ratio = xRatio;
            if (xRatio >= yRatio)
            {
                ratio = yRatio;
            }
            float newfontsize = originalfontsize * ratio;
            Font newfont = new Font(c.Font.FontFamily, newfontsize);
            c.Font = newfont;
        }
        private void resizeControl2(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

            float ratio = xRatio;
            if (xRatio >= yRatio)
            {
                ratio = yRatio;
            }

        }

        private void Registration_Resize(object sender, EventArgs e)
        {
            resizeControl2(PanelOriginalRectangle1, panel1);

            resizeControl(txtboxUserOriginalRectangle1, txtBoxUser_SignUp, txtboxUserFontSizeOriginalRectangle1);
            resizeControl2(PicUserBeforeOriginalRectangl2, picBox_userBefore);
            resizeControl2(PicUserAfterOriginalRectangl3, picBox_UserAfter);
            resizeControl2(PanelUserOriginalRectangl4, panel2);

            resizeControl(txtboxEmailOriginalRectangle5, TxtBoxEmail_SignUp, txtboxEmailFontSizeOriginalRectangle6);
            resizeControl2(PicEmailBeforeOriginalRectangl7, picBox_EmailBefore);
            resizeControl2(PicEmailAfterOriginalRectangl8, picBox_EmailAfter);
            resizeControl2(PanelEmailOriginalRectangl9, panel3);

            resizeControl(txtboxPassOriginalRectangle10, txtBoxPassword_Signup, txtboxPassFontSizeOriginalRectangle11);
            resizeControl2(PicPassBeforeOriginalRectangle12, picBox_PassBefore);
            resizeControl2(PicPassAfterOriginalRectangle13, picBox_PassAfter);
            resizeControl2(PanelPassOriginalRectangle14, panel4);
            resizeControl2(EyeBtnPassOriginalRectangle15, picBox_Eye1);

            resizeControl(txtboxConPassOriginalRectangle16, txtBoxConPassword_Signup, txtboxConPassFontSizeOriginalRectangle17);
            resizeControl2(PicConPassBeforeOriginalRectangle18, picBox_ConPassBefore);
            resizeControl2(PicConPassAfterOriginalRectangle19, picBox_ConPassAfter);
            resizeControl2(PanelConPassOriginalRectangl20, panel5);
            resizeControl2(EyeBtnConPassOriginalRectangle21, picBox_Eye2);

            //button  resize

            resizeControl(BtnSignUPOriginalRectangle25, button_signup, originalButtonsFontSize);
            resizeControl(BtnSignInOriginalRectangle24, button_Signin, originalButtonsFontSize);
            resizeControl2(BtnBackOriginalRectangle26, btnBack_Signup);

            // Label resize

            resizeControl(LabelLogin1OriginalRectangle22, SignUp_lable1, originalLabel1FontSize);
            resizeControl(LabelLogin2OriginalRectangle23, SignUp_label2, originalLabel2FontSize);

        }
    }







}
