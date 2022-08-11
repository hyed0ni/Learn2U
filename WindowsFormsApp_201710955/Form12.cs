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

namespace WindowsFormsApp_201710955
{
    public partial class Form12 : MetroForm
    {
        /*SqlConnection conn = new SqlConnection("Data Source = 222.116.108.117; User ID = 201711704; Password = gjdbals");
        public Form4()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO customer (customerID, password, name, phone) VALUES (@customerID, @password, @name, @phone)";
                SqlCommand command = new SqlCommand();
                command.CommandText = sql;
                command.Connection = conn;
                command.Parameters.Add("@customerID", SqlDbType.Int).Value = txt_AdPage_id.Text;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = txt_AdPage_pw.Text;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txt_AdPage_name2.Text;
                command.Parameters.Add("@phone", SqlDbType.Char).Value = txt_AdPage_phone.Text;
                conn.Open();
                command.ExecuteNonQuery();
                btn_AdPage_view.PerformClick();

                txt_AdPage_id.Clear();
                txt_AdPage_pw.Clear();
                txt_AdPage_name2.Clear();
                txt_AdPage_phone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("고객자료가 이미 존재합니다.", "고객자료오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE customer SET " +

              "password = '" + txt_AdPage_pw.Text + "'," +
              "name = '" + txt_AdPage_name2.Text + "'," +
              "phone = '" + txt_AdPage_phone.Text + "'" +
              " WHERE customerID = '" + txt_AdPage_id.Text + "'";

            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            btn_AdPage_view.PerformClick(); //버튼4를 이용   

            txt_AdPage_id.Clear();
            txt_AdPage_pw.Clear();
            txt_AdPage_name2.Clear();
            txt_AdPage_phone.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "DELETE customer " +
" WHERE customerID = '" +txt_AdPage_id.Text + "'";

            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            btn_AdPage_view.PerformClick(); //버튼4를 이용   

            txt_AdPage_id.Clear();
            txt_AdPage_pw.Clear();
            txt_AdPage_name2.Clear();
            txt_AdPage_phone.Clear();
        }*/
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_AdPage_ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("승인하시겠습니까?", "승인",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        private void btn_AdPage_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
