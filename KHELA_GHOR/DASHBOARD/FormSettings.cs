using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DASHBOARD
{
    public partial class FormSettings : Form
    {
        string connectinString = "Data Source=Towsif\\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True";
        private string loggedInUsername = Dashboard.usernmaepass;

        public FormSettings()
        {
            InitializeComponent();
        }

        private string GetEmailForUsername(string username)
        {
            
            using (SqlConnection con = new SqlConnection(connectinString))
            {
                con.Open();
                string query = "SELECT Email FROM SIGNUP_INFO WHERE UserName = @loggedInUsername";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@loggedInUsername", username);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
                
            }

        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            //lbl_username.Text = $"Username : {loggedInUsername}";
            //string emailAddress = GetEmailForUsername(loggedInUsername);
            //lbl_Email.Text = emailAddress;

            lbl_username.Text = $"Username : {loggedInUsername}";
            string emailAddress = GetEmailForUsername(loggedInUsername);
            lbl_Email.Text = $"Email : {emailAddress} "?? "Email not found";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Password_up().ShowDialog();

        }
    } 
}
