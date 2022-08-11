namespace WindowsFormsApp_201710955
{
    partial class Form12
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_AdPage_view = new System.Windows.Forms.Button();
            this.btn_AdPage_delete = new System.Windows.Forms.Button();
            this.btn_AdPage_reset = new System.Windows.Forms.Button();
            this.btn_AdPage_add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_AdPage_phone = new System.Windows.Forms.TextBox();
            this.txt_AdPage_name2 = new System.Windows.Forms.TextBox();
            this.txt_AdPage_pw = new System.Windows.Forms.TextBox();
            this.txt_AdPage_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AdPage_find = new System.Windows.Forms.Button();
            this.txt_AdPage_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_AdPage_cancel = new System.Windows.Forms.Button();
            this.btn_AdPage_ok = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(47, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Orator10 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "회원정보 관리";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(250, 259);
            this.dataGridView1.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_AdPage_view);
            this.groupBox3.Controls.Add(this.btn_AdPage_delete);
            this.groupBox3.Controls.Add(this.btn_AdPage_reset);
            this.groupBox3.Controls.Add(this.btn_AdPage_add);
            this.groupBox3.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 311);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(539, 73);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "정보수정";
            // 
            // btn_AdPage_view
            // 
            this.btn_AdPage_view.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_AdPage_view.FlatAppearance.BorderSize = 0;
            this.btn_AdPage_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdPage_view.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdPage_view.Location = new System.Drawing.Point(407, 30);
            this.btn_AdPage_view.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AdPage_view.Name = "btn_AdPage_view";
            this.btn_AdPage_view.Size = new System.Drawing.Size(103, 35);
            this.btn_AdPage_view.TabIndex = 0;
            this.btn_AdPage_view.Text = "보기";
            this.btn_AdPage_view.UseVisualStyleBackColor = false;
            // 
            // btn_AdPage_delete
            // 
            this.btn_AdPage_delete.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_AdPage_delete.FlatAppearance.BorderSize = 0;
            this.btn_AdPage_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdPage_delete.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdPage_delete.Location = new System.Drawing.Point(305, 30);
            this.btn_AdPage_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AdPage_delete.Name = "btn_AdPage_delete";
            this.btn_AdPage_delete.Size = new System.Drawing.Size(96, 35);
            this.btn_AdPage_delete.TabIndex = 0;
            this.btn_AdPage_delete.Text = "삭제";
            this.btn_AdPage_delete.UseVisualStyleBackColor = false;
            // 
            // btn_AdPage_reset
            // 
            this.btn_AdPage_reset.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_AdPage_reset.FlatAppearance.BorderSize = 0;
            this.btn_AdPage_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdPage_reset.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdPage_reset.Location = new System.Drawing.Point(198, 30);
            this.btn_AdPage_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AdPage_reset.Name = "btn_AdPage_reset";
            this.btn_AdPage_reset.Size = new System.Drawing.Size(101, 35);
            this.btn_AdPage_reset.TabIndex = 0;
            this.btn_AdPage_reset.Text = "수정";
            this.btn_AdPage_reset.UseVisualStyleBackColor = false;
            // 
            // btn_AdPage_add
            // 
            this.btn_AdPage_add.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_AdPage_add.FlatAppearance.BorderSize = 0;
            this.btn_AdPage_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdPage_add.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdPage_add.Location = new System.Drawing.Point(84, 30);
            this.btn_AdPage_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AdPage_add.Name = "btn_AdPage_add";
            this.btn_AdPage_add.Size = new System.Drawing.Size(105, 35);
            this.btn_AdPage_add.TabIndex = 0;
            this.btn_AdPage_add.Text = "추가";
            this.btn_AdPage_add.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_AdPage_phone);
            this.groupBox2.Controls.Add(this.txt_AdPage_name2);
            this.groupBox2.Controls.Add(this.txt_AdPage_pw);
            this.groupBox2.Controls.Add(this.txt_AdPage_id);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 95);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(273, 208);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "고객정보";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_AdPage_phone
            // 
            this.txt_AdPage_phone.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdPage_phone.Location = new System.Drawing.Point(84, 150);
            this.txt_AdPage_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AdPage_phone.Name = "txt_AdPage_phone";
            this.txt_AdPage_phone.Size = new System.Drawing.Size(172, 30);
            this.txt_AdPage_phone.TabIndex = 1;
            // 
            // txt_AdPage_name2
            // 
            this.txt_AdPage_name2.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdPage_name2.Location = new System.Drawing.Point(84, 113);
            this.txt_AdPage_name2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AdPage_name2.Name = "txt_AdPage_name2";
            this.txt_AdPage_name2.Size = new System.Drawing.Size(172, 30);
            this.txt_AdPage_name2.TabIndex = 1;
            // 
            // txt_AdPage_pw
            // 
            this.txt_AdPage_pw.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdPage_pw.Location = new System.Drawing.Point(84, 76);
            this.txt_AdPage_pw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AdPage_pw.Name = "txt_AdPage_pw";
            this.txt_AdPage_pw.Size = new System.Drawing.Size(172, 30);
            this.txt_AdPage_pw.TabIndex = 1;
            // 
            // txt_AdPage_id
            // 
            this.txt_AdPage_id.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdPage_id.Location = new System.Drawing.Point(84, 39);
            this.txt_AdPage_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AdPage_id.Name = "txt_AdPage_id";
            this.txt_AdPage_id.Size = new System.Drawing.Size(172, 30);
            this.txt_AdPage_id.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "고객명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "PW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AdPage_find);
            this.groupBox1.Controls.Add(this.txt_AdPage_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(273, 79);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색";
            // 
            // btn_AdPage_find
            // 
            this.btn_AdPage_find.BackColor = System.Drawing.Color.LightBlue;
            this.btn_AdPage_find.FlatAppearance.BorderSize = 0;
            this.btn_AdPage_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdPage_find.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdPage_find.Location = new System.Drawing.Point(198, 29);
            this.btn_AdPage_find.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AdPage_find.Name = "btn_AdPage_find";
            this.btn_AdPage_find.Size = new System.Drawing.Size(69, 38);
            this.btn_AdPage_find.TabIndex = 2;
            this.btn_AdPage_find.Text = "검색";
            this.btn_AdPage_find.UseVisualStyleBackColor = false;
            // 
            // txt_AdPage_name
            // 
            this.txt_AdPage_name.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdPage_name.Location = new System.Drawing.Point(62, 29);
            this.txt_AdPage_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AdPage_name.Name = "txt_AdPage_name";
            this.txt_AdPage_name.Size = new System.Drawing.Size(130, 30);
            this.txt_AdPage_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_AdPage_cancel);
            this.tabPage2.Controls.Add(this.btn_AdPage_ok);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Orator10 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "클래스 관리";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_AdPage_cancel
            // 
            this.btn_AdPage_cancel.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_AdPage_cancel.FlatAppearance.BorderSize = 0;
            this.btn_AdPage_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdPage_cancel.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdPage_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_AdPage_cancel.Location = new System.Drawing.Point(423, 100);
            this.btn_AdPage_cancel.Name = "btn_AdPage_cancel";
            this.btn_AdPage_cancel.Size = new System.Drawing.Size(132, 65);
            this.btn_AdPage_cancel.TabIndex = 1;
            this.btn_AdPage_cancel.Text = "삭제";
            this.btn_AdPage_cancel.UseVisualStyleBackColor = false;
            this.btn_AdPage_cancel.Click += new System.EventHandler(this.btn_AdPage_cancel_Click);
            // 
            // btn_AdPage_ok
            // 
            this.btn_AdPage_ok.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_AdPage_ok.FlatAppearance.BorderSize = 0;
            this.btn_AdPage_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdPage_ok.Font = new System.Drawing.Font("Orator10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdPage_ok.ForeColor = System.Drawing.Color.Black;
            this.btn_AdPage_ok.Location = new System.Drawing.Point(423, 29);
            this.btn_AdPage_ok.Name = "btn_AdPage_ok";
            this.btn_AdPage_ok.Size = new System.Drawing.Size(132, 65);
            this.btn_AdPage_ok.TabIndex = 1;
            this.btn_AdPage_ok.Text = "승인";
            this.btn_AdPage_ok.UseVisualStyleBackColor = false;
            this.btn_AdPage_ok.Click += new System.EventHandler(this.btn_AdPage_ok_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(379, 341);
            this.dataGridView2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Orator10 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 43);
            this.label6.TabIndex = 1;
            this.label6.Text = "관리자 페이지";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 541);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_AdPage_view;
        private System.Windows.Forms.Button btn_AdPage_delete;
        private System.Windows.Forms.Button btn_AdPage_reset;
        private System.Windows.Forms.Button btn_AdPage_add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_AdPage_phone;
        private System.Windows.Forms.TextBox txt_AdPage_name2;
        private System.Windows.Forms.TextBox txt_AdPage_pw;
        private System.Windows.Forms.TextBox txt_AdPage_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AdPage_find;
        private System.Windows.Forms.TextBox txt_AdPage_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_AdPage_cancel;
        private System.Windows.Forms.Button btn_AdPage_ok;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
    }
}