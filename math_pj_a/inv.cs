using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace math_pj_a
{
    public partial class inv : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public inv()
        {
            InitializeComponent();
        }
        public class Connect_bd
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" + "Password=postgres;Database=ring;");
            conn.Open();
            // Define a query
            string sql = "SELECT * FROM simple_table";
            // data adapter making request from our connection
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
        // i always reset DataSet before i do
        // something with it.... i don't know why :-)

        // filling DataSet with result from NpgsqlDataAdapter
            da.Fill(ds);
            // since it C# DataSet can handle multiple tables, we will select first
            dt = ds.Tables[0];
            // connect grid to DataTable
            dataGridView1.DataSource = dt;
            // since we only showing the result we don't need connection anymore
            conn.Close();
            }
        }


 
}
