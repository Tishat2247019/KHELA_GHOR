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
   
    public partial class SignUpExistError : Form
    {
        static SignUpExistError newMessageBox; 
        public SignUpExistError()
        {
            InitializeComponent();
        }

        public static void showmsg(string txt)
        {
            newMessageBox = new SignUpExistError();
            newMessageBox.label1.Text = ($"The Username {txt} already exist");
            System.Media.SystemSounds.Hand.Play();
            newMessageBox.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
