namespace WindowsFormsApp_201710955
{
    partial class Form11
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TuterPage_find = new System.Windows.Forms.Button();
            this.btn_TuterPage_delete = new System.Windows.Forms.Button();
            this.txt_TuterPage_pic = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TuterPage_name = new System.Windows.Forms.TextBox();
            this.txt_TuterPage_date = new System.Windows.Forms.TextBox();
            this.txt_TuterPage_place = new System.Windows.Forms.TextBox();
            this.txt_TuterPage_price = new System.Windows.Forms.TextBox();
            this.txt_TuterPage_accout = new System.Windows.Forms.TextBox();
            this.txt_TuterPage_accountnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TuterPage_intro = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TuterPage_intro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_TuterPage_accountnum);
            this.groupBox1.Controls.Add(this.txt_TuterPage_accout);
            this.groupBox1.Controls.Add(this.txt_TuterPage_price);
            this.groupBox1.Controls.Add(this.txt_TuterPage_place);
            this.groupBox1.Controls.Add(this.txt_TuterPage_date);
            this.groupBox1.Controls.Add(this.txt_TuterPage_name);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 568);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "클래스 정보";
            // 
            // btn_TuterPage_find
            // 
            this.btn_TuterPage_find.BackColor = System.Drawing.Color.LightBlue;
            this.btn_TuterPage_find.FlatAppearance.BorderSize = 0;
            this.btn_TuterPage_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TuterPage_find.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TuterPage_find.Location = new System.Drawing.Point(18, 79);
            this.btn_TuterPage_find.Name = "btn_TuterPage_find";
            this.btn_TuterPage_find.Size = new System.Drawing.Size(172, 37);
            this.btn_TuterPage_find.TabIndex = 0;
            this.btn_TuterPage_find.Text = "찾기";
            this.btn_TuterPage_find.UseVisualStyleBackColor = false;
            this.btn_TuterPage_find.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_TuterPage_delete
            // 
            this.btn_TuterPage_delete.BackColor = System.Drawing.Color.LightBlue;
            this.btn_TuterPage_delete.FlatAppearance.BorderSize = 0;
            this.btn_TuterPage_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TuterPage_delete.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TuterPage_delete.Location = new System.Drawing.Point(196, 79);
            this.btn_TuterPage_delete.Name = "btn_TuterPage_delete";
            this.btn_TuterPage_delete.Size = new System.Drawing.Size(172, 37);
            this.btn_TuterPage_delete.TabIndex = 0;
            this.btn_TuterPage_delete.Text = "삭제";
            this.btn_TuterPage_delete.UseVisualStyleBackColor = false;
            this.btn_TuterPage_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_TuterPage_pic
            // 
            this.txt_TuterPage_pic.Location = new System.Drawing.Point(18, 35);
            this.txt_TuterPage_pic.Name = "txt_TuterPage_pic";
            this.txt_TuterPage_pic.Size = new System.Drawing.Size(350, 38);
            this.txt_TuterPage_pic.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TuterPage_pic);
            this.groupBox2.Controls.Add(this.btn_TuterPage_delete);
            this.groupBox2.Controls.Add(this.btn_TuterPage_find);
            this.groupBox2.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 133);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사진 삽입";
            // 
            // txt_TuterPage_name
            // 
            this.txt_TuterPage_name.Location = new System.Drawing.Point(155, 37);
            this.txt_TuterPage_name.Name = "txt_TuterPage_name";
            this.txt_TuterPage_name.Size = new System.Drawing.Size(267, 38);
            this.txt_TuterPage_name.TabIndex = 3;
            this.txt_TuterPage_name.TextChanged += new System.EventHandler(this.txt_TuterPage_name_TextChanged);
            // 
            // txt_TuterPage_date
            // 
            this.txt_TuterPage_date.Location = new System.Drawing.Point(155, 84);
            this.txt_TuterPage_date.Name = "txt_TuterPage_date";
            this.txt_TuterPage_date.Size = new System.Drawing.Size(267, 38);
            this.txt_TuterPage_date.TabIndex = 4;
            this.txt_TuterPage_date.TextChanged += new System.EventHandler(this.txt_TuterPage_date_TextChanged);
            // 
            // txt_TuterPage_place
            // 
            this.txt_TuterPage_place.Location = new System.Drawing.Point(155, 131);
            this.txt_TuterPage_place.Name = "txt_TuterPage_place";
            this.txt_TuterPage_place.Size = new System.Drawing.Size(267, 38);
            this.txt_TuterPage_place.TabIndex = 5;
            this.txt_TuterPage_place.TextChanged += new System.EventHandler(this.txt_TuterPage_place_TextChanged);
            // 
            // txt_TuterPage_price
            // 
            this.txt_TuterPage_price.Location = new System.Drawing.Point(155, 178);
            this.txt_TuterPage_price.Name = "txt_TuterPage_price";
            this.txt_TuterPage_price.Size = new System.Drawing.Size(267, 38);
            this.txt_TuterPage_price.TabIndex = 6;
            this.txt_TuterPage_price.TextChanged += new System.EventHandler(this.txt_TuterPage_price_TextChanged);
            // 
            // txt_TuterPage_accout
            // 
            this.txt_TuterPage_accout.Location = new System.Drawing.Point(155, 225);
            this.txt_TuterPage_accout.Name = "txt_TuterPage_accout";
            this.txt_TuterPage_accout.Size = new System.Drawing.Size(267, 38);
            this.txt_TuterPage_accout.TabIndex = 7;
            this.txt_TuterPage_accout.TextChanged += new System.EventHandler(this.txt_TuterPage_accout_TextChanged);
            // 
            // txt_TuterPage_accountnum
            // 
            this.txt_TuterPage_accountnum.Location = new System.Drawing.Point(155, 272);
            this.txt_TuterPage_accountnum.Name = "txt_TuterPage_accountnum";
            this.txt_TuterPage_accountnum.Size = new System.Drawing.Size(267, 38);
            this.txt_TuterPage_accountnum.TabIndex = 8;
            this.txt_TuterPage_accountnum.TextChanged += new System.EventHandler(this.txt_TuterPage_accountnum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "클래스 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "일정";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "장소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "금액";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "예금주";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "계좌번호";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "클래스 설명";
            // 
            // txt_TuterPage_intro
            // 
            this.txt_TuterPage_intro.Location = new System.Drawing.Point(155, 319);
            this.txt_TuterPage_intro.Name = "txt_TuterPage_intro";
            this.txt_TuterPage_intro.Size = new System.Drawing.Size(267, 96);
            this.txt_TuterPage_intro.TabIndex = 16;
            this.txt_TuterPage_intro.Text = "";
            this.txt_TuterPage_intro.TextChanged += new System.EventHandler(this.txt_TuterPage_intro_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Orator10 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 43);
            this.label8.TabIndex = 3;
            this.label8.Text = "클래스 등록";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "승인신청";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(276, 661);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 711);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form11";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txt_TuterPage_intro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TuterPage_accountnum;
        private System.Windows.Forms.TextBox txt_TuterPage_accout;
        private System.Windows.Forms.TextBox txt_TuterPage_price;
        private System.Windows.Forms.TextBox txt_TuterPage_place;
        private System.Windows.Forms.TextBox txt_TuterPage_date;
        private System.Windows.Forms.TextBox txt_TuterPage_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_TuterPage_pic;
        private System.Windows.Forms.Button btn_TuterPage_delete;
        private System.Windows.Forms.Button btn_TuterPage_find;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}