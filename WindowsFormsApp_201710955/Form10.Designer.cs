namespace WindowsFormsApp_201710955
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_PayPage2_03 = new System.Windows.Forms.TextBox();
            this.txt_PayPage2_02 = new System.Windows.Forms.TextBox();
            this.txt_PayPage2_01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PayPage2_back = new System.Windows.Forms.Button();
            this.btn_PayPage2_pay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_PayPage2_03);
            this.groupBox1.Controls.Add(this.txt_PayPage2_02);
            this.groupBox1.Controls.Add(this.txt_PayPage2_01);
            this.groupBox1.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입금 계좌";
            // 
            // txt_PayPage2_03
            // 
            this.txt_PayPage2_03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PayPage2_03.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PayPage2_03.Location = new System.Drawing.Point(44, 150);
            this.txt_PayPage2_03.Name = "txt_PayPage2_03";
            this.txt_PayPage2_03.Size = new System.Drawing.Size(344, 31);
            this.txt_PayPage2_03.TabIndex = 0;
            this.txt_PayPage2_03.Text = "3333-0207-94481  카카오뱅크";
            this.txt_PayPage2_03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_PayPage2_02
            // 
            this.txt_PayPage2_02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PayPage2_02.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PayPage2_02.Location = new System.Drawing.Point(44, 100);
            this.txt_PayPage2_02.Name = "txt_PayPage2_02";
            this.txt_PayPage2_02.Size = new System.Drawing.Size(344, 31);
            this.txt_PayPage2_02.TabIndex = 0;
            this.txt_PayPage2_02.Text = "784910-1686-7807  하나은행";
            this.txt_PayPage2_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_PayPage2_01
            // 
            this.txt_PayPage2_01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PayPage2_01.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PayPage2_01.Location = new System.Drawing.Point(44, 50);
            this.txt_PayPage2_01.Name = "txt_PayPage2_01";
            this.txt_PayPage2_01.Size = new System.Drawing.Size(344, 31);
            this.txt_PayPage2_01.TabIndex = 0;
            this.txt_PayPage2_01.Text = "111-123445-1111   신한은행";
            this.txt_PayPage2_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PayPage2_01.TextChanged += new System.EventHandler(this.txt__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orator10 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "무통장 입금";
            // 
            // btn_PayPage2_back
            // 
            this.btn_PayPage2_back.FlatAppearance.BorderSize = 0;
            this.btn_PayPage2_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PayPage2_back.Font = new System.Drawing.Font("Orator10 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayPage2_back.Location = new System.Drawing.Point(4, 9);
            this.btn_PayPage2_back.Name = "btn_PayPage2_back";
            this.btn_PayPage2_back.Size = new System.Drawing.Size(54, 39);
            this.btn_PayPage2_back.TabIndex = 28;
            this.btn_PayPage2_back.Text = "←";
            this.btn_PayPage2_back.UseVisualStyleBackColor = true;
            this.btn_PayPage2_back.Click += new System.EventHandler(this.btn_PayPage2_back_Click);
            // 
            // btn_PayPage2_pay
            // 
            this.btn_PayPage2_pay.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_PayPage2_pay.FlatAppearance.BorderSize = 0;
            this.btn_PayPage2_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PayPage2_pay.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayPage2_pay.Location = new System.Drawing.Point(78, 366);
            this.btn_PayPage2_pay.Name = "btn_PayPage2_pay";
            this.btn_PayPage2_pay.Size = new System.Drawing.Size(432, 51);
            this.btn_PayPage2_pay.TabIndex = 29;
            this.btn_PayPage2_pay.Text = "결제 신청";
            this.btn_PayPage2_pay.UseVisualStyleBackColor = false;
            this.btn_PayPage2_pay.Click += new System.EventHandler(this.btn_PayPage2_pay_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 454);
            this.Controls.Add(this.btn_PayPage2_pay);
            this.Controls.Add(this.btn_PayPage2_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_PayPage2_03;
        private System.Windows.Forms.TextBox txt_PayPage2_02;
        private System.Windows.Forms.TextBox txt_PayPage2_01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PayPage2_back;
        private System.Windows.Forms.Button btn_PayPage2_pay;
    }
}