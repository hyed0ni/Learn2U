using MetroFramework.Forms;
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

namespace WindowsFormsApp_201710955
{
    public partial class Form8 : MetroForm
    {
        SqlConnection conn = new SqlConnection("Data Source=222.116.108.117; User ID=201711704; Password=gjdbals");
        public Form8()
        {
            InitializeComponent();
        }

        private void btn1_ApplyPage_apply_Click(object sender, EventArgs e)
        {
            Form9 F9 = new Form9();
            F9.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btn1_ApplyPage_back_Click(object sender, EventArgs e)
        {
            Form10 F10 = new Form10();
            F10.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }
    }
}
