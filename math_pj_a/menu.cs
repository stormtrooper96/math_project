using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_pj_a
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void Factb_Click(object sender, EventArgs e)
        {
            fact myForm = new fact();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }


        private void Invb_Click_1(object sender, EventArgs e)
        {
            inv myForm = new inv();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
