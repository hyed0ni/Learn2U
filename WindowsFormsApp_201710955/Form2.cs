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
    public partial class Form2 : MetroForm
    {
        SqlConnection conn = new SqlConnection("Data Source = 222.116.108.117; User ID = 201711704; Password = gjdbals");

        private string Form2_value;
        public string Passvalue
        {
            get { return this.Form2_value; }
            set { this.Form2_value = value; }
        }

        public Form2()
        {
            InitializeComponent();
            tabControl2_MainPage2.DrawItem += TabControl2_MainPage2_DrawItem;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txt_MainPage2_member.Text = Passvalue; // 메인1 폼, 회원가입 폼의 ID 텍스트박스 값 가져오기

            // 데이터그리드뷰 필드 너비 자동 조정
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // 데이터그리드뷰 레코드 높이 자동 조정
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView5.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // 데이터그리드뷰 전체 레코드 선택
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_MainPage2_home_Click(object sender, EventArgs e)
        {
            // HOME 버튼을 클릭하면 첫 번째 페이지로 이동함
            tabControl1_MainPage2.SelectedTab = this.tabPage1_MainPage2;
        }

        private void btn_MainPage2_category_Click(object sender, EventArgs e)
        {
            // 카테고리 버튼을 클릭하면 두 번째 페이지로 이동함
            tabControl1_MainPage2.SelectedTab = this.tabPage2_MainPage2;
        }

        private void btn_MainPage2_basket_Click(object sender, EventArgs e)
        {
            // 장바구니 버튼을 클릭하면 세 번째 페이지로 이동함
            tabControl1_MainPage2.SelectedTab = this.tabPage3_MainPage2;
        }

        private void btn_MainPage2_mypage_Click(object sender, EventArgs e)
        {
            // 마이페이지 버튼을 클릭하면 네 번째 페이지로 이동함
            tabControl1_MainPage2.SelectedTab = this.tabPage4_MainPage2;
        }

        private void btn_MainPage_logout_Click(object sender, EventArgs e)
        {
            // 로그아웃 버튼을 클릭하면 메인2 폼 닫고 메인1 폼 열기
            if (MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form2 F2 = new Form2();
                F2.Hide();
                Form1 F1 = new Form1();
                F1.Show();
            }
        }

        private void btn1_MainPage2_Click(object sender, EventArgs e)
        {
            // 클래스 이름 버튼을 클릭하면 클래스 폼 열기
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void btn2_MainPage2_Click(object sender, EventArgs e)
        {
            // 클래스 이름 버튼을 클릭하면 클래스 폼 열기
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void btn3_MainPage2_Click(object sender, EventArgs e)
        {
            // 클래스 이름 버튼을 클릭하면 클래스 폼 열기
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void btn4_MainPage2_Click(object sender, EventArgs e)
        {
            // 클래스 이름 버튼을 클릭하면 클래스 폼 열기
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void btn5_MainPage2_Click(object sender, EventArgs e)
        {
            // 클래스 이름 버튼을 클릭하면 클래스 폼 열기
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void btn6_MainPage2_Click(object sender, EventArgs e)
        {
            // 클래스 이름 버튼을 클릭하면 클래스 폼 열기
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            // 클래스 카테고리 사진을 클릭하면 클래스 그룹 폼 열기
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void btn_MainPage2_1select_Click(object sender, EventArgs e)
        {
            // 장바구니 목록 데이터그리드뷰 데이터 불러오기
            string sql = "select C1.CName 클래스, M1.Name 강사, C1.Schedule 일정, C1.Place 장소 from aaa___Apply A inner join aaa___Class_1 C1 on A.CNumber = C1.CNumber inner join aaa___Member_1 M1 on C1.ID = M1.ID where M1.ID = '201710955'";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btn_MainPage2_1apply_Click(object sender, EventArgs e)
        {
            // 클래스 신청하기 버튼을 클릭하면 클래스신청 폼 열기
            Form8 F8 = new Form8();
            F8.Show();
        }

        private void TabControl2_MainPage2_DrawItem(object sender, DrawItemEventArgs e)
        {
            // 마이페이지 탭 컨트롤에서 좌우 맞춤 탭 표시
            Graphics g = e.Graphics;
            Brush _textBrush;
            TabPage _tabPage = tabControl2_MainPage2.TabPages[e.Index];
            Rectangle _tabBounds = tabControl2_MainPage2.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                _textBrush = new SolidBrush(Color.Black);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            Font _tabFont = new Font("나눔바른펜", 15f, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void btn_MainPage2_2select_Click(object sender, EventArgs e)
        {
            // 신청목록 조회 버튼을 클릭하면 신청 목록 데이터그리드뷰 데이터 불러오기
            string sql = "SELECT * FROM aaa___Apply";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void btn_MainPage2_2delete_Click(object sender, EventArgs e)
        {
            // 신청 목록의 클래스에서 취소하기
        }

        private void btn_MainPage2_3select_Click(object sender, EventArgs e)
        {
            // 취소 / 환불 목록 조회 버튼을 클릭하면 취소 / 환불 목록 데이터그리드뷰 데이터 불러오기
            string sql = "SELECT * FROM aaa___Apply__Cancel";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView3.DataSource = table;
        }

        private void btn_MainPage2_4select_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_MainPage_Enter(object sender, EventArgs e)
        {

        }

        private void txt_MainPage2_member_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_basket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_MainPage2_Enter(object sender, EventArgs e)
        {

        }

        private void tabpage2_mypage_Click(object sender, EventArgs e)
        {
            /*
            // 신청 목록 페이지를 선택하면 신청목록 데이터그리드뷰 데이터 불러오기
            string sql1 = "SELECT * FROM aaa___Apply";
            SqlCommand command1 = new SqlCommand();
            command1.CommandText = sql1;
            command1.Connection = conn;
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            dataGridView1_mypage.DataSource = table1;
            */
        }

        private void tabpage2_mypage_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            // 신청 목록 페이지를 선택하면 신청목록 데이터그리드뷰 데이터 불러오기
            string sql1 = "SELECT * FROM aaa___Apply";
            SqlCommand command1 = new SqlCommand();
            command1.CommandText = sql1;
            command1.Connection = conn;
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            dataGridView1_mypage.DataSource = table1;
            */
        }

        private void btn6_MainPage_Click(object sender, EventArgs e)
        {

        }

        private void btn5_MainPage_Click(object sender, EventArgs e)
        {

        }

        private void btn4_MainPage_Click(object sender, EventArgs e)
        {

        }

        private void btn3_MainPage_Click(object sender, EventArgs e)
        {

        }

        private void btn2_MainPage_Click(object sender, EventArgs e)
        {

        }

        private void btn1_MainPage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
