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
    public partial class Form1 : MetroForm
    {
        SqlConnection conn = new SqlConnection("Data Source = 222.116.108.117; User ID = 201711704; Password = gjdbals");

        Form2 F2 = new Form2();
        public delegate void FormSendDataHandler(string sendstring); // 델리게이트 선언

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 메인 폼이 열리면 ID 텍스트박스에 포커스 설정됨
            this.ActiveControl = txt_MainPage_ID;
        }

        private void btn_MainPage_home_Click(object sender, EventArgs e)
        {
            // HOME 버튼을 클릭하면 첫 번째 페이지로 이동함
            tabControl1_MainPage.SelectedTab = this.tabPage1_MainPage;
        }

        private void btn_MainPage_category_Click(object sender, EventArgs e)
        {
            // 카테고리 버튼을 클릭하면 두 번째 페이지로 이동함
            tabControl1_MainPage.SelectedTab = this.tabPage2_MainPage;
        }

        private void btn_MainPage_basket_Click(object sender, EventArgs e)
        {
            // 로그아웃 상태에서 장바구니 버튼을 클릭하면 세 번째 페이지 이동 차단
            MessageBox.Show("로그인 후 이용할 수 있습니다.", "Please Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_MainPage_mypage_Click(object sender, EventArgs e)
        {
            // 로그아웃 상태에서 마이페이지 버튼을 클릭하면 네 번째 페이지 이동 차단
            MessageBox.Show("로그인 후 이용할 수 있습니다.", "Please Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txt_MainPage_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ID 텍스트박스에서 숫자나 백스페이스키만 입력받음
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txt_MainPage_PW_TextChanged(object sender, EventArgs e)
        {
            // PW 텍스트박스에서 공백이 입력되어도 처리하지 않음
            txt_MainPage_PW.Text.Trim();
            txt_MainPage_PW.Text.Replace(" ", "");
        }

        private void btn_MainPage_login_Click(object sender, EventArgs e)
        {
            string sql = "select * from aaa___Member_1 where ID = '" + txt_MainPage_ID.Text + "' and PW = '" + txt_MainPage_PW.Text + "'";

            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = conn;
            SqlDataReader reader;
            conn.Open();
            reader = command.ExecuteReader();
            this.Hide();

            // 관리자 로그인 성공 > 메인1 폼 닫고 관리자 폼 열기
            if (txt_MainPage_ID.Text == "123456789" && txt_MainPage_PW.Text == "rhksflwk")
            {
                MessageBox.Show("관리자님 환영합니다!", "로그인 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form12 F10 = new Form12();
                F10.Show();
                this.Hide();
            }
            // 이용자 로그인 성공 (로그인한 이용자의 이름 불러오기) > 메인1 폼 닫고 메인2 폼 열기
            else if (reader.HasRows)
            {
                MessageBox.Show(txt_MainPage_ID.Text + "님 환영합니다!", "로그인 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Form2 F2 = new Form2();
                F2.Passvalue = (txt_MainPage_ID.Text + "님"); // 메인2 폼에 메인1 폼의 ID 텍스트박스 값 내보내기
                F2.ShowDialog();
                Form1 F1 = new Form1();
                F1.Hide();
            }
            // 로그인 실패
            else
            {
                MessageBox.Show("아이디와 비밀번호를 다시 확인해주세요.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MainPage_ID.Text = "";
                txt_MainPage_PW.Clear();
                txt_MainPage_ID.Focus();
            }
            conn.Close();
        }

        private void btn_MainPage_join_Click(object sender, EventArgs e)
        {
            // 회원가입 버튼을 클릭하면 회원가입 폼 열기
            Form3 F3 = new Form3();
            F3.Show();
        }

        private void btn1_MainPage_Click(object sender, EventArgs e)
        {
            // 클래스 이름 버튼을 클릭하면 클래스 폼 열기
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void btn2_MainPage_Click(object sender, EventArgs e)
        {
            // 클래스 이름 버튼을 클릭하면 클래스 폼 열기
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void btn3_MainPage_Click(object sender, EventArgs e)
        {
            // 클래스 이름 버튼을 클릭하면 클래스 폼 열기
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void btn4_MainPage_Click(object sender, EventArgs e)
        {
            // 클래스 이름 버튼을 클릭하면 클래스 폼 열기
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void btn5_MainPage_Click(object sender, EventArgs e)
        {
            // 클래스 이름 버튼을 클릭하면 클래스 폼 열기
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void btn6_MainPage_Click(object sender, EventArgs e)
        {
            // 클래스 이름 버튼을 클릭하면 클래스 폼 열기
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void TabControl2_MainPage_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }

        private void tabpage2_mypage_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_MainPage_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_MainPage_home_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_MainPage_more_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_MainPage_ctg_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_MainPage_ctg_Click(object sender, EventArgs e)
        {

        }

        private void label1_MainPage_ID_Click(object sender, EventArgs e)
        {

        }
    }
}
