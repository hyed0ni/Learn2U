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
    public partial class Form10 : MetroForm
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void txt__TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_PayPage2_pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Today.AddDays(1).ToString("yyyy-MM-dd hh:mm:ss")+"까지 입금 완료되지 않으면 자동 취소됩니다.","확인",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_PayPage2_back_Click(object sender, EventArgs e)
        {
           
        }
    }
}
