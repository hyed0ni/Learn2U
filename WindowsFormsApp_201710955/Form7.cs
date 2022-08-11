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
    public partial class Form7 : MetroForm
    {
        SqlConnection conn = new SqlConnection("Data Source = 222.116.108.117; User ID = 201711704; Password = gjdbals");

        public Form7()
        {
            InitializeComponent();
        }

        private Boolean idChecked = false;

        private void Form6_Load(object sender, EventArgs e)
        {
            // 회원가입2 폼이 열리면 ID 텍스트박스에 포커스 설정됨
            this.ActiveControl = txt_JoinPage2_ID;
        }

        private void txt_JoinPage2_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ID 텍스트박스에서 숫자나 백스페이스키만 입력받음
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txt_JoinPage2_PW_TextChanged(object sender, EventArgs e)
        {
            // PW 텍스트박스에서 공백이 입력되어도 처리하지 않음
            txt_JoinPage2_PW.Text.Trim();
            txt_JoinPage2_PW.Text.Replace(" ", "");
        }

        private void txt_JoinPage2_PWconfirm_TextChanged(object sender, EventArgs e)
        {
            // PW 확인 텍스트박스에서 공백이 입력되어도 처리하지 않음
            txt_JoinPage2_PWconfirm.Text.Trim();
            txt_JoinPage2_PWconfirm.Text.Replace(" ", "");
        }

        private void txt_JoinPage2_phone_MouseHover(object sender, EventArgs e)
        {
            // 연락처 텍스트박스에 마우스를 가져갔을 때 부연설명 표시
            this.toolTip1.SetToolTip(this.txt_JoinPage2_phone, "하이픈(-)을 함께 입력해주세요.");
        }

        private void txt_JoinPage2_ID_MouseHover(object sender, EventArgs e)
        {
            // ID 텍스트박스에 마우스를 가져갔을 때 부연설명 표시
            this.toolTip1.SetToolTip(this.txt_JoinPage2_ID, "숫자만 입력해주세요.");
        }

        private void btn_JoinPage2_IDcheck_Click(object sender, EventArgs e)
        {
            if (!idChecked) // ID 중복체크
            {
                string sql = "select ID from aaa___Member_1 where ID= '" + txt_JoinPage2_ID.Text + "'";
                SqlCommand command = new SqlCommand();
                command.CommandText = sql;
                command.Connection = conn;
                conn.Open();
                var myRead = command.ExecuteReader();

                if (myRead.HasRows) // ID 중복
                {
                    idChecked = false;
                    MessageBox.Show("사용할 수 없는 아이디입니다.", "아이디 중복", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_JoinPage2_ID.Clear();
                    txt_JoinPage2_ID.Focus();
                }
                else // ID 사용가능
                {
                    idChecked = true;
                    MessageBox.Show("사용 가능한 아이디입니다.", "아이디 사용가능", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_JoinPage2_join_Click(object sender, EventArgs e)
        {
            // 성별 변수 선언 (a)
            string a;
            if (rb_JoinPage2_M.Checked) // '남성' 라디오버튼 선택하면 a = '남성'
            {
                a = rb_JoinPage2_M.Text;
            }
            else if (rb_JoinPage2_W.Checked) // '여성' 라디오버튼 선택하면 a = '여성'
            {
                a = rb_JoinPage2_W.Text;
            }
            else // 라디오버튼을 선택하지 않으면 a = null
            {
                a = null;
            }

            // 지역 변수 선언 (b)
            string b;
            if (cbx_JoinPage2_addr.Text == "선택해주세요") // 지역 콤보박스의 텍스트를 선택하지 않으면 b = null
            {
                b = null;
            }
            else // 지역을 선택하면 a = 텍스트의 값
            {
                b = cbx_JoinPage2_addr.Text;
            }

            // '메이크업' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '1' 데이터 삽입
            if (cb01_JoinPage2.Checked)
            {
                int q = 1;
                cb01_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb01_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '영상편집' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '2' 데이터 삽입
            if (cb02_JoinPage2.Checked)
            {
                int q = 2;
                cb02_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb02_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '작사/작곡' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '3' 데이터 삽입
            if (cb03_JoinPage2.Checked)
            {
                int q = 3;
                cb03_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb03_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '보컬' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '4' 데이터 삽입
            if (cb04_JoinPage2.Checked)
            {
                int q = 4;
                cb04_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb04_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '악기연주' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '5' 데이터 삽입
            if (cb05_JoinPage2.Checked)
            {
                int q = 5;
                cb05_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb05_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '스포츠' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '6' 데이터 삽입
            if (cb06_JoinPage2.Checked)
            {
                int q = 6;
                cb06_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb06_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '프로그래밍' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '7' 데이터 삽입
            if (cb07_JoinPage2.Checked)
            {
                int q = 7;
                cb07_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb07_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '필라테스' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '8' 데이터 삽입
            if (cb08_JoinPage2.Checked)
            {
                int q = 8;
                cb08_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb08_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '현대미술' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '9' 데이터 삽입
            if (cb09_JoinPage2.Checked)
            {
                int q = 9;
                cb09_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb09_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '제품디자인' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '10' 데이터 삽입
            if (cb10_JoinPage2.Checked)
            {
                int q = 10;
                cb10_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb10_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '핸드메이드' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '11' 데이터 삽입
            if (cb11_JoinPage2.Checked)
            {
                int q = 11;
                cb11_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb11_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '요가' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '12' 데이터 삽입
            if (cb12_JoinPage2.Checked)
            {
                int q = 12;
                cb12_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb12_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '영어회화' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '13' 데이터 삽입
            if (cb13_JoinPage2.Checked)
            {
                int q = 13;
                cb13_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb13_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '중국어' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '14' 데이터 삽입
            if (cb14_JoinPage2.Checked)
            {
                int q = 14;
                cb14_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb14_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // '일본어' 체크박스 선택하면 aaa___Member_2 테이블 FNumber 필드에 '15' 데이터 삽입
            if (cb15_JoinPage2.Checked)
            {
                int q = 15;
                cb15_JoinPage2.Text = q.ToString();
                string sql2 = "INSERT INTO aaa___Member_2 (ID, FNumber) VALUES('" + txt_JoinPage2_ID.Text + "', '" + cb15_JoinPage2.Text + "')";
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = sql2;
                command2.Connection = conn;
                conn.Open();
                command2.ExecuteNonQuery();
                conn.Close();
            }

            // 필수 항목 텍스트박스에 공란이 있을 경우 회원가입 불가
            if (txt_JoinPage2_ID.Text == "" || txt_JoinPage2_PW.Text == "" || txt_JoinPage2_PWconfirm.Text == "" || txt_JoinPage2_name.Text == "" || txt_JoinPage2_phone.Text == "")
            {
                MessageBox.Show("필수 항목을 모두 입력해주세요.", "회원가입 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // PW 텍스트박스의 값과 PW 텍스트박스의 값이 일치하지 않는 경우 회원가입 불가
            else if (txt_JoinPage2_PW.Text != txt_JoinPage2_PWconfirm.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "회원가입 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // 회원가입 성공 > 메인2 폼으로 이동
            else
            {
                // aaa___Member_1 테이블 ID, PW, Name, Phone, Gender, City 필드에 데이터 삽입
                string sql1 = "INSERT INTO aaa___Member_1 (ID, PW, Name, Phone, Gender, City) VALUES('" + txt_JoinPage2_ID.Text + "', '" + txt_JoinPage2_PW.Text + "', '" +
                    txt_JoinPage2_name.Text + "','" + txt_JoinPage2_phone.Text + "','" + a + "','" + b + "')";

                SqlCommand command = new SqlCommand();
                command.CommandText = sql1;
                command.Connection = conn;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("회원가입이 완료되었습니다.", "회원가입 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form8 F8 = new Form8();
                F8.Show();
                this.Hide();
            }
        }

        private void btn_JoinPage2_back_Click(object sender, EventArgs e)
        {
            // Yes 버튼을 누르면 회원가입2 폼을 닫음
            if (MessageBox.Show("가입을 취소하시겠습니까?", "회원가입 취소", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txt_JoinPage2_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
