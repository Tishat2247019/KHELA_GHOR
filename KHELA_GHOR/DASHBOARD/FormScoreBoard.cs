using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DASHBOARD
{
    public partial class FormScoreBoard : Form
    {
        public static string username;
        public FormScoreBoard()
        {
            InitializeComponent();
            username = Dashboard.usernmaepass;
            player_ownScore();
        }

        public void player_ownScore()
        {
            string connectinString = "Data Source=Towsif\\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectinString);

            //open connection
            con.Open();

            string query = "SELECT TOP 10 game_name as 'Game Name', CAST(score_value AS INT) as Scores \r\nFROM Leader_Board WHERE user_name = '"+username+"'\r\nORDER BY CAST(score_value AS INT) DESC;";

            SqlCommand cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView2.DataSource = dt;

            //close the connection
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Running Game")
            {
                string connectinString = "Data Source=Towsif\\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectinString);

                //open connection
                con.Open();

                string query = "SELECT TOP 10 user_name as 'User Name', CAST(score_value AS INT) as Scores \r\nFROM Leader_Board WHERE game_name = 'RunningGame'\r\nORDER BY CAST(score_value AS INT) DESC;";

                SqlCommand cmd = new SqlCommand(query, con);
                var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;

                //close the connection
                con.Close();
            }
            if (comboBox1.Text == "Car Racing")
            {
                string connectinString = "Data Source=Towsif\\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectinString);

                //open connection
                con.Open();

                string query = "SELECT TOP 10 user_name as 'User Name', CAST(score_value AS INT) as Scores \r\nFROM Leader_Board WHERE game_name = 'CarRacing'\r\nORDER BY CAST(score_value AS INT) DESC;";

                SqlCommand cmd = new SqlCommand(query, con);
                var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;

                //close the connection
                con.Close();
            }
            if (comboBox1.Text == "Classic Snake Game")
            {
                string connectinString = "Data Source=Towsif\\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectinString);

                //open connection
                con.Open();

                string query = "SELECT TOP 10 user_name as 'User Name', CAST(score_value AS INT) as Scores \r\nFROM Leader_Board WHERE game_name = 'SnakeGame'\r\nORDER BY CAST(score_value AS INT) DESC;";

                SqlCommand cmd = new SqlCommand(query, con);
                var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;

                //close the connection
                con.Close();
            }

        }
        private void ApplyRowColors()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int rowIndex = row.Index;

                // Check if the row index is odd (1, 3, 5, etc.)
                if (rowIndex % 2 == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Red; // Set the desired color
                }
                else
                {
                    // Reset the background color for even rows
                    row.DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex != .Index)
            //    return;

            //e.CellStyle.BackColor = Color.FromArgb(int.Parse(((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem).Row[4].ToString()));

            // Check if the current column has a valid index
            //if (e.ColumnIndex < 0 || e.ColumnIndex >= dataGridView1.Columns.Count)
            //    return;

            //// Check if the current column is the one you want to apply formatting to
            //string targetColumnName = "user_name"; // Replace with the actual column name
            //if (dataGridView1.Columns[e.ColumnIndex].Name != targetColumnName)
            //    return;

            //// Check if the current row index is even (every second row)
            //if (e.RowIndex % 2 == 1) // Index is zero-based
            //{
            //    // Get the cell value
            //    object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            //    if (value != null && !string.IsNullOrEmpty(value.ToString()))
            //    {
            //        if (int.TryParse(value.ToString(), out int colorValue))
            //        {
            //            e.CellStyle.BackColor = Color.FromArgb(colorValue);
            //        }
            //        else
            //        {
            //            // Handle the case where the value is not a valid integer
            //            e.CellStyle.BackColor = Color.Red; // or another default color
            //        }
            //    }
            //    else
            //    {
            //        // Handle the case where the value is null or empty
            //        e.CellStyle.BackColor = Color.Green; // or another default color
            //    }
            //}
            //else
            //{
            //    // Reset the background color for even rows
            //    e.CellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
            //}

            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView2.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int rowIndex = row.Index;

                // Check if the row index is odd (1, 3, 5, etc.)
                if (rowIndex % 2 == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(241, 90, 41); // Set the desired color
                }
                else
                {
                    // Reset the background color for even rows
                    row.DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                }
            }
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                int rowIndex = row.Index;

                // Check if the row index is odd (1, 3, 5, etc.)
                if (rowIndex % 2 == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(241, 90, 41); // Set the desired color
                }
                else
                {
                    // Reset the background color for even rows
                    row.DefaultCellStyle.BackColor = dataGridView2.DefaultCellStyle.BackColor;
                }
            }

        }

        private void FormScoreBoard_Load(object sender, EventArgs e)
        {
            //ApplyRowColors();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
