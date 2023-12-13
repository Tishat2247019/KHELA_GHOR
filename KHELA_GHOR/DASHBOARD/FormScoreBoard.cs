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
        public FormScoreBoard()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectinString = "Data Source=Towsif\\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectinString);

            //open connection
            con.Open();

            string query = "SELECT user_name, score_value FROM Leader_Board";

            SqlCommand cmd = new SqlCommand(query, con);
           var reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt; 

            //close the connection
            con.Close();


        }
    }
}
