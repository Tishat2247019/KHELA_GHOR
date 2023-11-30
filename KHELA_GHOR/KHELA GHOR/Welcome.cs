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
        private Rectangle buttonOriginalRectangle1;
        private Rectangle buttonOriginalRectangle2;
        private Rectangle labelOriginalRectangle3;
        private Rectangle labelOriginalRectangle4;
        private Rectangle labelOriginalRectangle5;
        private Rectangle OriginalFormSize;

        private float originalButtonsFontSize;
        private float originalLableFontSize1;
        private float originalLableFontSize2;
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
            HeyYouLabel_Welcom.BackColor = Color.Transparent; 
            OriginalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            buttonOriginalRectangle1 = new Rectangle(btnSignIn_Welcom.Location.X, btnSignIn_Welcom.Location.Y, btnSignIn_Welcom.Width, btnSignIn_Welcom.Height);
            buttonOriginalRectangle2 = new Rectangle(btnSignUp_Welcom.Location.X, btnSignUp_Welcom.Location.Y, btnSignUp_Welcom.Width, btnSignUp_Welcom.Height);
            labelOriginalRectangle3 = new Rectangle(HeyYouLabel_Welcom.Location.X, HeyYouLabel_Welcom.Location.Y, HeyYouLabel_Welcom.Width, HeyYouLabel_Welcom.Height);
            labelOriginalRectangle4 = new Rectangle(EmtertainLabel_Welcom.Location.X, EmtertainLabel_Welcom.Location.Y, EmtertainLabel_Welcom.Width, EmtertainLabel_Welcom.Height);
            labelOriginalRectangle5 = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            originalButtonsFontSize = btnSignIn_Welcom.Font.Size;
            originalLableFontSize1 = HeyYouLabel_Welcom.Font.Size;
            originalLableFontSize2 = EmtertainLabel_Welcom.Font.Size;

            //label3.Parent = pictureBox2;
            // label3.BackColor = Color.Transparent;

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

            private void button1_Click(object sender, EventArgs e)
        {
            Login L = new Login(this);
            L.Show();
            this.Hide();
           // this.Hide();
           // L.ShowDialog();
           // this.Show();
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            Registration R = new Registration(this);
            R.Show();
            this.Hide();
        }

        private void Welcome_Resize(object sender, EventArgs e)
        {
            resizeControl(buttonOriginalRectangle1, btnSignIn_Welcom, originalButtonsFontSize);
            resizeControl(buttonOriginalRectangle2, btnSignUp_Welcom, originalButtonsFontSize);
            resizeControl(labelOriginalRectangle3, HeyYouLabel_Welcom, originalLableFontSize1);
            resizeControl(labelOriginalRectangle4, EmtertainLabel_Welcom, originalLableFontSize2);
            resizeControl(labelOriginalRectangle5, label2, originalLableFontSize1);
        }
    }
}
