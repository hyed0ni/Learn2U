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
    public partial class Form4 : MetroForm
    {
        SqlConnection conn = new SqlConnection("Data Source=222.116.108.117; User ID=201711704; Password=gjdbals");
        public Form4()
        {
            InitializeComponent();
        }

        private void btn1_ClassPage_Click(object sender, EventArgs e)
        {
            // Form4 폼 실행
            Form5 F4 = new Form5();
            F4.Show();
        }

        private void btn2_ClassGpPage_Click(object sender, EventArgs e)
        {
            // Form4 폼 실행
            Form5 F4 = new Form5();
            F4.Show();
        }

        private void btn3_ClassGpPage_Click(object sender, EventArgs e)
        {
            // Form4 폼 실행
            Form5 F4 = new Form5();
            F4.Show();
        }

        private void btn4_ClassGpPage_Click(object sender, EventArgs e)
        {
            // Form4 폼 실행
            Form5 F4 = new Form5();
            F4.Show();
        }

        private void btn5_ClassGpPage_Click(object sender, EventArgs e)
        {
            // Form4 폼 실행
            Form5 F4 = new Form5();
            F4.Show();
        }

        private void btn6_ClassGpPage_Click(object sender, EventArgs e)
        {
            // Form4 폼 실행
            Form5 F4 = new Form5();
            F4.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
