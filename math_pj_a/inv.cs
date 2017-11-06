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
using System.IO;


namespace math_pj_a
{
    public partial class inv : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private String sqlpath = "C:\\Users\\japar\\source\\repos\\math_pj_a\\math_pj_a\\SQL\\";
        private String credentials = "Server=127.0.0.1;User Id = postgres;" + "Password=postgres;Database=ring;";
        public inv()
        {
            InitializeComponent();
        }
        public class Connect_bd
        {

        }

        private void Button1_Click(object sender, EventArgs e)

        {
            NpgsqlConnection conn = new NpgsqlConnection(credentials);
            conn.Open();
            FileInfo file = new FileInfo((sqlpath + "seleccionar_inventario.sql"));
            string sql = file.OpenText().ReadToEnd();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            conn.Close();
            }
        }


 
}
