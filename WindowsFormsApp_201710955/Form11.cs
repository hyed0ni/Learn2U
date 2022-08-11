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
    public partial class Form11 : MetroForm
    {
        SqlConnection conn = new SqlConnection("Data Source = 222.116.108.117; User ID = 201711704; Password = gjdbals");

        public Form11()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_TuterPage_pic.Clear();
            string file_path = null;
            openFileDialog1.InitialDirectory = "C:\\";
            // openFileDialog의 시작 위치를 C:\\로 설정
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                txt_TuterPage_pic.Text = file_path.Split('\\')[file_path.Split('\\').Length - 1];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            SqlCommand cmd = new SqlCommand("insert into aaa___Class_1 (Photo) VALUES (@Photo)", conn);
            FileStream fs = new FileStream(pbxImage.Tag.ToString(), FileMode.Open, FileAccess.Read);
            byte[] bImage = new byte[fs.Length];
            fs.Read(bImage, 0, (int)fs.Length);
            cmd.Parameters.AddWithValue("@Photo", bImage);
            fs.Close();

            FileStream fs = new FileStream(pickInstall.Tag.ToString(), FileMode.Open, FileAccess.Read);
            byte[] bImage = new byte[fs.Length];
            fs.Read(bImage, 0, (int)fs.Length);

            cmd = new SqlComteReadmand(strSQL, Con);
            cmd.Parameters.AddWithValue("@ImgName", bImage);
            aRS = cmd.Execuer();
            fs.Close();
            aRS.Close();
            */
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_TuterPage_name_TextChanged(object sender, EventArgs e)
        {
            // PW 텍스트박스에서 공백이 입력되어도 처리하지 않음
            txt_TuterPage_name.Text.Trim();
            txt_TuterPage_name.Text.Replace(" ", "");
        }

        private void txt_TuterPage_date_TextChanged(object sender, EventArgs e)
        {
            txt_TuterPage_date.Text.Trim();
            txt_TuterPage_date.Text.Replace(" ", "");
        }

        private void txt_TuterPage_place_TextChanged(object sender, EventArgs e)
        {
            txt_TuterPage_place.Text.Trim();
            txt_TuterPage_place.Text.Replace(" ", "");
        }

        private void txt_TuterPage_price_TextChanged(object sender, EventArgs e)
        {
            txt_TuterPage_price.Text.Trim();
            txt_TuterPage_price.Text.Replace(" ", "");
        }

        private void txt_TuterPage_accout_TextChanged(object sender, EventArgs e)
        {
            txt_TuterPage_accout.Text.Trim();
            txt_TuterPage_accout.Text.Replace(" ", "");
        }

        private void txt_TuterPage_accountnum_TextChanged(object sender, EventArgs e)
        {
            txt_TuterPage_accountnum.Text.Trim();
            txt_TuterPage_accountnum.Text.Replace(" ", "");
        }

        private void txt_TuterPage_intro_TextChanged(object sender, EventArgs e)
        {
            txt_TuterPage_intro.Text.Trim();
            txt_TuterPage_intro.Text.Replace(" ", "");
        }
    }
}
