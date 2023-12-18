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
    public partial class Password_up : Form
    {
        private string connectionString = "Data Source=Towsif\\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True"; 
        private string currentUser = Dashboard.usernmaepass; 
        public Password_up()
        {
            InitializeComponent();
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            string currentPassword = txt_currentpass.Text;
            string newPassword = txt_newpass.Text;
            string confirmNewPassword = txt_confirmpass.Text;

            // Add validation checks here (e.g., length, complexity, matching passwords)

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the current password is correct
            if (!IsCurrentPasswordCorrect(currentPassword))
            {
                MessageBox.Show("Current Password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the password in the database
            if (UpdatePassword(newPassword))
            {
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Failed to change password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool IsCurrentPasswordCorrect(string currentPassword)
        {
            // Implement logic to check if the current password matches the one in the database
            // Use parameterized queries to prevent SQL injection
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM SIGNUP_INFO WHERE UserName = @UserName AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", currentUser);
                    cmd.Parameters.AddWithValue("@Password", currentPassword);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool UpdatePassword(string newPassword)
        {
            // Implement logic to update the password in the database
            // Use parameterized queries to prevent SQL injection
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE SIGNUP_INFO SET Password = @Password WHERE UserName = @UserName";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", currentUser);
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        private void ClearTextBoxes()
        {
            txt_currentpass.Clear();
            txt_newpass.Clear();
            txt_confirmpass.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Password_up_Load(object sender, EventArgs e)
        {
            txtBox_Username.Text = Dashboard.usernmaepass;
        }

        private void panel_usenamebelow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_currentpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_confirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_newpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
