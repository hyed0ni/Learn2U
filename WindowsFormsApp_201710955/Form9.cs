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
    public partial class Form9 : MetroForm
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            cbx_Paypage_card.Items.Add("국민카드");
            cbx_Paypage_card.Items.Add("신한카드");
            cbx_Paypage_card.Items.Add("하나카드");
            cbx_Paypage_card.Items.Add("농협카드");
            cbx_Paypage_card.Items.Add("비씨카드");
            cbx_Paypage_card.Items.Add("롯데카드");
            cbx_Paypage_card.Items.Add("현대카드");
            cbx_Paypage_card.Items.Add("카카오뱅크카드");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_PayPage_pay_Click(object sender, EventArgs e)
        {
            if (cb02_PayPage.Checked == true || cb03_PayPage.Checked == true ||cb01_PayPage.Checked==true)
            {
                MessageBox.Show("결제가 완료되었습니다!", "결제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (cb02_PayPage.Checked == false || cb03_PayPage.Checked==false)
            {
                MessageBox.Show("약관에 동의하여 주십시오.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbx_Paypage_card_SelectedIndexChanged(object sender, EventArgs e)
        {
            string b;
            if (cbx_Paypage_card.Text == "선택해주세요") // 지역 콤보박스의 텍스트를 선택하지 않으면 b = null
            {
                b = null;
            }
            else // 지역을 선택하면 a = 텍스트의 값
            {
                b = cbx_Paypage_card.Text;
            }
            txt_PayPage_card.Text = cbx_Paypage_card.SelectedItem.ToString();
        }

        private void cb01_PayPage_CheckedChanged(object sender, EventArgs e)
        {
            if (cb01_PayPage.Checked)
            {
                cb02_PayPage.Checked = true;
                cb03_PayPage.Checked = true;
            }
            
        }

        private void cb02_PayPage_CheckedChanged(object sender, EventArgs e)
        {
            if (cb02_PayPage.Checked == false)
            {
                cb01_PayPage.Checked = false;
            }
        }

        private void cb03_PayPage_CheckedChanged(object sender, EventArgs e)
        {
            if (cb03_PayPage.Checked == false)
            {
                cb01_PayPage.Checked = false;
            }
        }
    }
}
