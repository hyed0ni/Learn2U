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
    public partial class Form6 : MetroForm
    {
        SqlConnection conn = new SqlConnection("Data Source = 222.116.108.117; User ID = 201711704; Password = gjdbals");

        public Form6()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // 로그인 폼이 열리면 ID 텍스트박스에 포커스 설정됨
            this.ActiveControl = txt_LoginPage_ID;
        }

        private void txt_LoginPage_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ID 텍스트박스에서 숫자나 백스페이스키만 입력받음
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txt_LoginPage_PW_TextChanged(object sender, EventArgs e)
        {
            // PW 텍스트박스에서 공백이 입력되어도 처리하지 않음
            txt_LoginPage_PW.Text.Trim();
            txt_LoginPage_PW.Text.Replace(" ", "");
        }

        private void btn_LoginPage_login_Click(object sender, EventArgs e)
        {
            string qq = "select * from aaa___Member1 where ID = '" + txt_LoginPage_ID.Text
            + "' and PW = '" + txt_LoginPage_PW.Text + "'";
            SqlCommand command = new SqlCommand();
            command.CommandText = qq;
            command.Connection = conn;
            SqlDataReader reader;
            conn.Open();
            reader = command.ExecuteReader();

            if (txt_LoginPage_ID.Text == "123456789" && txt_LoginPage_PW.Text == "rhksflwk") // 관리자 계정 로그인 성공
            {
                MessageBox.Show("관리자님 환영합니다!", "로그인 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form8 F8 = new Form8();
                F8.Show();
                this.Close();
            }
            else if (reader.HasRows) // 이용자 계정 로그인 성공 > 클래스 신청 폼으로 이동 (로그인한 이용자의 이름 출력)
            {
                MessageBox.Show(txt_LoginPage_ID.Text + "님 환영합니다!", "로그인 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form12 F10 = new Form12();
                F10.Show();
                this.Close();
            }
            else // 로그인 실패
            {
                MessageBox.Show("아이디와 비밀번호를 다시 확인해주세요.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_LoginPage_ID.Text = "";
                txt_LoginPage_PW.Clear();
                txt_LoginPage_ID.Focus();
            }
            conn.Close();
        }

        private void btn_LoginPage_join_Click(object sender, EventArgs e)
        {
            // 회원가입2 폼으로 이동
            Form7 F7 = new Form7();
            F7.Show();
            this.Close();
        }

        private void btn_LoginPage_back_Click(object sender, EventArgs e)
        {
            // Yes 버튼을 누르면 로그인 폼을 닫음
            if (MessageBox.Show("로그인을 취소하시겠습니까?", "로그인 취소", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void label1_LoginPage_PW_Click(object sender, EventArgs e)
        {

        }
    }
}
