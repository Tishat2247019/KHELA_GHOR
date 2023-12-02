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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Data.SqlClient;
using DASHBOARD;

namespace LOGIN_REGISTRATION
{
    public partial class Login : Form
    {
        public static bool isClick_username = false;
        public static bool isClick_password = false;
        private Form previousForm;
        private Rectangle PanelOriginalRectangle1;
        private Rectangle OriginalFormSize;
        private float originalPanelFontSize;

        private Rectangle txtboxUserOriginalRectangle1;
        private float txtboxUserFontSizeOriginalRectangle1;
        private Rectangle PicUserBeforeOriginalRectangl2;
        private Rectangle PicUserAfterOriginalRectangl3;
        private Rectangle PanelUserOriginalRectangl4;

        private Rectangle txtboxPassOriginalRectangle5;
        private float txtboxPassFontSizeOriginalRectangle5;
        private Rectangle PicPassBeforeOriginalRectangle6;
        private Rectangle PicPassAfterOriginalRectangle7;
        private Rectangle PanelPassOriginalRectangle8;
        private Rectangle EyeBtnOriginalRectangle9;

        private Rectangle LabelLogin1OriginalRectangle10;
        private Rectangle LabelLogin2OriginalRectangle11;
        private Rectangle BtnSignInOriginalRectangle12;
        private Rectangle BtnSignUPOriginalRectangle13;
        private Rectangle BtnBackOriginalRectangle14;


        private float originalButtonsFontSize;
        private float originalLabel1FontSize;
        private float originalLabel2FontSize;


        public Login()
        {
            InitializeComponent();
            btnSignup_Login.FlatStyle = FlatStyle.Flat;
            btnSignup_Login.FlatAppearance.MouseOverBackColor = Color.Coral;
            //btnBack_Login.FlatAppearance.MouseOverBackColor = Color.Coral;
        }

        public Login(Form form) : this()
        {
            previousForm = form;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            OriginalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            PanelOriginalRectangle1 = new Rectangle(panel_Login.Location.X, panel_Login.Location.Y, panel_Login.Width, panel_Login.Height);

            txtboxUserOriginalRectangle1 = new Rectangle(txt_UserLogin.Location.X, txt_UserLogin.Location.Y, txt_UserLogin.Width, txt_UserLogin.Height);
            PicUserBeforeOriginalRectangl2 = new Rectangle(picBox_userBefore.Location.X, picBox_userBefore.Location.Y, picBox_userBefore.Width, picBox_userBefore.Height);
            PicUserAfterOriginalRectangl3 = new Rectangle(picBox_UserAfter.Location.X, picBox_UserAfter.Location.Y, picBox_UserAfter.Width, picBox_UserAfter.Height);
            PanelUserOriginalRectangl4 = new Rectangle(panel2.Location.X, panel2.Location.Y, panel2.Width, panel2.Height);

            txtboxPassOriginalRectangle5 = new Rectangle(txt_PassLogin.Location.X, txt_PassLogin.Location.Y, txt_PassLogin.Width, txt_PassLogin.Height);
            PicPassBeforeOriginalRectangle6 = new Rectangle(picBox_PassBefore.Location.X, picBox_PassBefore.Location.Y, picBox_PassBefore.Width, picBox_PassBefore.Height);
            PicPassAfterOriginalRectangle7 = new Rectangle(picBox_PassAfter.Location.X, picBox_PassAfter.Location.Y, picBox_PassAfter.Width, picBox_PassAfter.Height);
            PanelPassOriginalRectangle8 = new Rectangle(panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height);
            EyeBtnOriginalRectangle9 = new Rectangle(picBox_Eye.Location.X, picBox_Eye.Location.Y, picBox_Eye.Width, picBox_Eye.Height);

            LabelLogin1OriginalRectangle10 = new Rectangle(Login_label1.Location.X, Login_label1.Location.Y, Login_label1.Width, Login_label1.Height);
            LabelLogin2OriginalRectangle11 = new Rectangle(Login_Label2.Location.X, Login_Label2.Location.Y, Login_Label2.Width, Login_Label2.Height);
            BtnSignInOriginalRectangle12 = new Rectangle(btnSignin_Login.Location.X, btnSignin_Login.Location.Y, btnSignin_Login.Width, btnSignin_Login.Height);
            BtnSignUPOriginalRectangle13 = new Rectangle(btnSignup_Login.Location.X, btnSignup_Login.Location.Y, btnSignup_Login.Width, btnSignup_Login.Height);
            BtnBackOriginalRectangle14 = new Rectangle(btnBack_Login.Location.X, btnBack_Login.Location.Y, btnBack_Login.Width, btnBack_Login.Height);

            originalPanelFontSize = panel_Login.Font.Size;
            txtboxUserFontSizeOriginalRectangle1 = txt_UserLogin.Font.Size;
            txtboxPassFontSizeOriginalRectangle5 = txt_PassLogin.Font.Size;
            originalButtonsFontSize = btnSignup_Login.Font.Size;
            originalLabel1FontSize = Login_label1.Font.Size;
            originalLabel2FontSize = Login_Label2.Font.Size;

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
        private void Login_Resize(object sender, EventArgs e)
        {
            resizeControl(PanelOriginalRectangle1, panel_Login, originalPanelFontSize);

            resizeControl(txtboxUserOriginalRectangle1, txt_UserLogin, txtboxUserFontSizeOriginalRectangle1);
            resizeControl2(PicUserBeforeOriginalRectangl2, picBox_userBefore);
            resizeControl2(PicUserAfterOriginalRectangl3, picBox_UserAfter);
            resizeControl2(PanelUserOriginalRectangl4, panel2);

            resizeControl(txtboxPassOriginalRectangle5, txt_PassLogin, txtboxPassFontSizeOriginalRectangle5);
            resizeControl2(PicPassBeforeOriginalRectangle6, picBox_PassBefore);
            resizeControl2(PicPassAfterOriginalRectangle7, picBox_PassAfter);
            resizeControl2(PanelPassOriginalRectangle8, panel3);
            resizeControl2(EyeBtnOriginalRectangle9, picBox_Eye);

            resizeControl(LabelLogin1OriginalRectangle10, Login_label1, originalLabel1FontSize);
            resizeControl(LabelLogin2OriginalRectangle11, Login_Label2, originalLabel2FontSize);
            resizeControl(BtnSignInOriginalRectangle12, btnSignin_Login, originalButtonsFontSize);
            resizeControl(BtnSignUPOriginalRectangle13, btnSignup_Login, originalButtonsFontSize);
            resizeControl2(BtnBackOriginalRectangle14, btnBack_Login);

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
            Registration R = new Registration(this);
            R.Show();
            this.Hide();
        }

        private void txt_UserLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_UserLogin.Text == "Username")
            {
                txt_UserLogin.Clear();
            }
            isClick_username = true;

            picBox_userBefore.Visible = false;
            picBox_UserAfter.Visible = true;
        }

        private void txt_PassLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_PassLogin.Text == "Password")
            {
                txt_PassLogin.Clear();
            }
            isClick_password = true;
            txt_PassLogin.UseSystemPasswordChar = true;
            picBox_PassBefore.Visible = false;
            picBox_PassAfter.Visible = true;
        }

        private void picBox_Eye_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void picBox_Eye_MouseDown(object sender, MouseEventArgs e)
        {
            txt_PassLogin.UseSystemPasswordChar = false;
        }

        private void picBox_Eye_MouseUp(object sender, MouseEventArgs e)
        {
            if (isClick_password)
            {
                txt_PassLogin.UseSystemPasswordChar = true;
            }
        }

        private void txt_UserLogin_Leave(object sender, EventArgs e)
        {
            if (isClick_username)
            {
                if (string.IsNullOrEmpty(txt_UserLogin.Text))
                {
                    errorProvider1.SetError(this.txt_UserLogin, "Please Enter Your Username!!");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }

        }

        private void txt_PassLogin_Leave(object sender, EventArgs e)
        {
            if (isClick_password)
            {
                if (string.IsNullOrEmpty(txt_PassLogin.Text))
                {
                    errorProvider2.SetError(this.txt_PassLogin, "Please Enter Your Password!!");
                }
                else
                {
                    errorProvider2.Clear();
                }
            }
        }

        private void btnSignin_Login_Click(object sender, EventArgs e)
        {
            //address of the SQL server and database
            if ((!isClick_password || !isClick_username || txt_UserLogin.Text == "" || txt_PassLogin.Text == ""))
            {
                SignUpExistError.showLogin("Please Fill Up All Data");
            }
            else
            {
                string connectinString = "Data Source=Towsif\\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True";


                //esblish connection;
                SqlConnection con = new SqlConnection(connectinString);
                string Query = "SELECT * FROM SIGNUP_INFO WHERE UserName = '" + txt_UserLogin.Text + "' AND Password = '" + txt_PassLogin.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    new Dashboard().Show();
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SignUpExistError.showLogin("Invalid Login Details");
                    txt_UserLogin.Clear();
                    txt_PassLogin.Clear();

                    txt_UserLogin.Focus();
                }

            }


        }

        private void btnBack_Login_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            previousForm.Show();
            this.Hide();
        }
    }
}
