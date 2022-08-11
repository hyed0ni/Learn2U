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
    public partial class Form5 : MetroForm
    {
        SqlConnection conn = new SqlConnection("Data Source = 222.116.108.117; User ID = 201711704; Password = gjdbals");

        public Form5()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Form4가 실행되면 txt_ClassPage_ID에 포커스 설정됨
            this.ActiveControl = txt_ClassPage_ID;
        }

        private void btn_ClassPage_expn1_Click(object sender, EventArgs e)
        {
            // 설명 1 버튼을 누르면 tabpage1_ClassPage가 선택됨
            tabControl1_ClassPage.SelectedTab = this.tabPage1_ClassPage;
        }

        private void btn_ClassPage_expn2_Click(object sender, EventArgs e)
        {
            // 설명 2 버튼을 누르면 tabpage2_ClassPage가 선택됨
            tabControl1_ClassPage.SelectedTab = this.tabPage2_ClassPage;
        }

        private void btn1_ClassPage_Click(object sender, EventArgs e)
        {
            // 로그인 상태일 경우 Form8로 이동, Form5 폼 닫기
            // 로그아웃 상태일 경우 Form6 폼 열기
            // Form5 F5 = new Form5();
            // F5.Show();

            // Yes 버튼을 누르면 신청 완료
            /*
            if (MessageBox.Show("클래스를 신청하시겠습니까?", "클래스 신청", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("신청이 완료되었습니다.", "신청 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
            */
        }

        private void txt_ClassPage_place_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ClassPage_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {

        }
    }
}
