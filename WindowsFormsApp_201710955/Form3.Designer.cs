namespace WindowsFormsApp_201710955
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1_JoinPage = new System.Windows.Forms.GroupBox();
            this.btn_JoinPage_IDcheck = new System.Windows.Forms.Button();
            this.label1_JoinPage_phone = new System.Windows.Forms.Label();
            this.label1_JoinPage_PWconfirm = new System.Windows.Forms.Label();
            this.label1_JoinPage_PW = new System.Windows.Forms.Label();
            this.label1_JoinPage_name = new System.Windows.Forms.Label();
            this.label1_JoinPage_ID = new System.Windows.Forms.Label();
            this.txt_JoinPage_phone = new System.Windows.Forms.TextBox();
            this.txt_JoinPage_name = new System.Windows.Forms.TextBox();
            this.txt_JoinPage_PWconfirm = new System.Windows.Forms.TextBox();
            this.txt_JoinPage_PW = new System.Windows.Forms.TextBox();
            this.txt_JoinPage_ID = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2_JoinPage = new System.Windows.Forms.GroupBox();
            this.label1_JoinPage_addr = new System.Windows.Forms.Label();
            this.cbx_JoinPage_addr = new System.Windows.Forms.ComboBox();
            this.groupBox2_JoinPage_interest = new System.Windows.Forms.GroupBox();
            this.cb12_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb08_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb04_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb15_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb11_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb07_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb03_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb14_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb10_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb06_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb02_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb13_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb09_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb05_JoinPage = new System.Windows.Forms.CheckBox();
            this.cb01_JoinPage = new System.Windows.Forms.CheckBox();
            this.label1_JoinPage_gender = new System.Windows.Forms.Label();
            this.groupBox2_JoinPage_gender = new System.Windows.Forms.GroupBox();
            this.rb_JoinPage_W = new System.Windows.Forms.RadioButton();
            this.rb_JoinPage_M = new System.Windows.Forms.RadioButton();
            this.btn_JoinPage_join = new System.Windows.Forms.Button();
            this.label1_JoinPage_join = new System.Windows.Forms.Label();
            this.btn_JoinPage_back = new System.Windows.Forms.Button();
            this.groupBox1_JoinPage.SuspendLayout();
            this.groupBox2_JoinPage.SuspendLayout();
            this.groupBox2_JoinPage_interest.SuspendLayout();
            this.groupBox2_JoinPage_gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1_JoinPage
            // 
            this.groupBox1_JoinPage.Controls.Add(this.btn_JoinPage_IDcheck);
            this.groupBox1_JoinPage.Controls.Add(this.label1_JoinPage_phone);
            this.groupBox1_JoinPage.Controls.Add(this.label1_JoinPage_PWconfirm);
            this.groupBox1_JoinPage.Controls.Add(this.label1_JoinPage_PW);
            this.groupBox1_JoinPage.Controls.Add(this.label1_JoinPage_name);
            this.groupBox1_JoinPage.Controls.Add(this.label1_JoinPage_ID);
            this.groupBox1_JoinPage.Controls.Add(this.txt_JoinPage_phone);
            this.groupBox1_JoinPage.Controls.Add(this.txt_JoinPage_name);
            this.groupBox1_JoinPage.Controls.Add(this.txt_JoinPage_PWconfirm);
            this.groupBox1_JoinPage.Controls.Add(this.txt_JoinPage_PW);
            this.groupBox1_JoinPage.Controls.Add(this.txt_JoinPage_ID);
            this.groupBox1_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1_JoinPage.ForeColor = System.Drawing.Color.Black;
            this.groupBox1_JoinPage.Location = new System.Drawing.Point(12, 71);
            this.groupBox1_JoinPage.Name = "groupBox1_JoinPage";
            this.groupBox1_JoinPage.Size = new System.Drawing.Size(439, 232);
            this.groupBox1_JoinPage.TabIndex = 6;
            this.groupBox1_JoinPage.TabStop = false;
            this.groupBox1_JoinPage.Text = "필수 항목 입력";
            this.groupBox1_JoinPage.Enter += new System.EventHandler(this.groupBox1_JoinPage_Enter);
            // 
            // btn_JoinPage_IDcheck
            // 
            this.btn_JoinPage_IDcheck.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_JoinPage_IDcheck.FlatAppearance.BorderSize = 0;
            this.btn_JoinPage_IDcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JoinPage_IDcheck.Font = new System.Drawing.Font("Orator10 BT", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JoinPage_IDcheck.Location = new System.Drawing.Point(340, 47);
            this.btn_JoinPage_IDcheck.Name = "btn_JoinPage_IDcheck";
            this.btn_JoinPage_IDcheck.Size = new System.Drawing.Size(85, 27);
            this.btn_JoinPage_IDcheck.TabIndex = 1;
            this.btn_JoinPage_IDcheck.Text = "중복 확인";
            this.btn_JoinPage_IDcheck.UseVisualStyleBackColor = false;
            this.btn_JoinPage_IDcheck.Click += new System.EventHandler(this.btn_JoinPage_IDcheck_Click);
            // 
            // label1_JoinPage_phone
            // 
            this.label1_JoinPage_phone.AutoSize = true;
            this.label1_JoinPage_phone.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_JoinPage_phone.Location = new System.Drawing.Point(18, 182);
            this.label1_JoinPage_phone.Name = "label1_JoinPage_phone";
            this.label1_JoinPage_phone.Size = new System.Drawing.Size(48, 19);
            this.label1_JoinPage_phone.TabIndex = 7;
            this.label1_JoinPage_phone.Text = "연락처";
            // 
            // label1_JoinPage_PWconfirm
            // 
            this.label1_JoinPage_PWconfirm.AutoSize = true;
            this.label1_JoinPage_PWconfirm.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_JoinPage_PWconfirm.Location = new System.Drawing.Point(18, 116);
            this.label1_JoinPage_PWconfirm.Name = "label1_JoinPage_PWconfirm";
            this.label1_JoinPage_PWconfirm.Size = new System.Drawing.Size(94, 19);
            this.label1_JoinPage_PWconfirm.TabIndex = 7;
            this.label1_JoinPage_PWconfirm.Text = "비밀번호 확인";
            // 
            // label1_JoinPage_PW
            // 
            this.label1_JoinPage_PW.AutoSize = true;
            this.label1_JoinPage_PW.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_JoinPage_PW.Location = new System.Drawing.Point(18, 83);
            this.label1_JoinPage_PW.Name = "label1_JoinPage_PW";
            this.label1_JoinPage_PW.Size = new System.Drawing.Size(61, 19);
            this.label1_JoinPage_PW.TabIndex = 7;
            this.label1_JoinPage_PW.Text = "비밀번호";
            // 
            // label1_JoinPage_name
            // 
            this.label1_JoinPage_name.AutoSize = true;
            this.label1_JoinPage_name.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_JoinPage_name.Location = new System.Drawing.Point(18, 149);
            this.label1_JoinPage_name.Name = "label1_JoinPage_name";
            this.label1_JoinPage_name.Size = new System.Drawing.Size(35, 19);
            this.label1_JoinPage_name.TabIndex = 8;
            this.label1_JoinPage_name.Text = "이름";
            // 
            // label1_JoinPage_ID
            // 
            this.label1_JoinPage_ID.AutoSize = true;
            this.label1_JoinPage_ID.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_JoinPage_ID.Location = new System.Drawing.Point(18, 50);
            this.label1_JoinPage_ID.Name = "label1_JoinPage_ID";
            this.label1_JoinPage_ID.Size = new System.Drawing.Size(48, 19);
            this.label1_JoinPage_ID.TabIndex = 8;
            this.label1_JoinPage_ID.Text = "아이디";
            // 
            // txt_JoinPage_phone
            // 
            this.txt_JoinPage_phone.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_JoinPage_phone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_JoinPage_phone.Location = new System.Drawing.Point(124, 179);
            this.txt_JoinPage_phone.Name = "txt_JoinPage_phone";
            this.txt_JoinPage_phone.Size = new System.Drawing.Size(210, 27);
            this.txt_JoinPage_phone.TabIndex = 5;
            this.txt_JoinPage_phone.MouseHover += new System.EventHandler(this.txt_JoinPage_phone_MouseHover);
            // 
            // txt_JoinPage_name
            // 
            this.txt_JoinPage_name.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_JoinPage_name.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.txt_JoinPage_name.Location = new System.Drawing.Point(124, 146);
            this.txt_JoinPage_name.Name = "txt_JoinPage_name";
            this.txt_JoinPage_name.Size = new System.Drawing.Size(210, 27);
            this.txt_JoinPage_name.TabIndex = 4;
            this.txt_JoinPage_name.TextChanged += new System.EventHandler(this.txt_JoinPage_name_TextChanged);
            // 
            // txt_JoinPage_PWconfirm
            // 
            this.txt_JoinPage_PWconfirm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_JoinPage_PWconfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_JoinPage_PWconfirm.Location = new System.Drawing.Point(124, 113);
            this.txt_JoinPage_PWconfirm.Name = "txt_JoinPage_PWconfirm";
            this.txt_JoinPage_PWconfirm.PasswordChar = '●';
            this.txt_JoinPage_PWconfirm.Size = new System.Drawing.Size(210, 27);
            this.txt_JoinPage_PWconfirm.TabIndex = 3;
            this.txt_JoinPage_PWconfirm.TextChanged += new System.EventHandler(this.txt_JoinPage_PW_TextChanged);
            // 
            // txt_JoinPage_PW
            // 
            this.txt_JoinPage_PW.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_JoinPage_PW.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_JoinPage_PW.Location = new System.Drawing.Point(124, 80);
            this.txt_JoinPage_PW.Name = "txt_JoinPage_PW";
            this.txt_JoinPage_PW.PasswordChar = '●';
            this.txt_JoinPage_PW.Size = new System.Drawing.Size(210, 27);
            this.txt_JoinPage_PW.TabIndex = 2;
            this.txt_JoinPage_PW.TextChanged += new System.EventHandler(this.txt_JoinPage_PW_TextChanged);
            // 
            // txt_JoinPage_ID
            // 
            this.txt_JoinPage_ID.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_JoinPage_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_JoinPage_ID.Location = new System.Drawing.Point(124, 47);
            this.txt_JoinPage_ID.Name = "txt_JoinPage_ID";
            this.txt_JoinPage_ID.Size = new System.Drawing.Size(210, 27);
            this.txt_JoinPage_ID.TabIndex = 0;
            this.txt_JoinPage_ID.TextChanged += new System.EventHandler(this.txt_JoinPage_ID_TextChanged);
            this.txt_JoinPage_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_JoinPage_ID_KeyPress);
            this.txt_JoinPage_ID.MouseHover += new System.EventHandler(this.txt_JoinPage_ID_MouseHover);
            // 
            // groupBox2_JoinPage
            // 
            this.groupBox2_JoinPage.Controls.Add(this.label1_JoinPage_addr);
            this.groupBox2_JoinPage.Controls.Add(this.cbx_JoinPage_addr);
            this.groupBox2_JoinPage.Controls.Add(this.groupBox2_JoinPage_interest);
            this.groupBox2_JoinPage.Controls.Add(this.label1_JoinPage_gender);
            this.groupBox2_JoinPage.Controls.Add(this.groupBox2_JoinPage_gender);
            this.groupBox2_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2_JoinPage.ForeColor = System.Drawing.Color.Black;
            this.groupBox2_JoinPage.Location = new System.Drawing.Point(12, 309);
            this.groupBox2_JoinPage.Name = "groupBox2_JoinPage";
            this.groupBox2_JoinPage.Size = new System.Drawing.Size(439, 277);
            this.groupBox2_JoinPage.TabIndex = 6;
            this.groupBox2_JoinPage.TabStop = false;
            this.groupBox2_JoinPage.Text = "선택 항목 입력";
            this.groupBox2_JoinPage.Enter += new System.EventHandler(this.groupBox1_JoinPage_Enter);
            // 
            // label1_JoinPage_addr
            // 
            this.label1_JoinPage_addr.AutoSize = true;
            this.label1_JoinPage_addr.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_JoinPage_addr.Location = new System.Drawing.Point(242, 56);
            this.label1_JoinPage_addr.Name = "label1_JoinPage_addr";
            this.label1_JoinPage_addr.Size = new System.Drawing.Size(35, 19);
            this.label1_JoinPage_addr.TabIndex = 7;
            this.label1_JoinPage_addr.Text = "지역";
            // 
            // cbx_JoinPage_addr
            // 
            this.cbx_JoinPage_addr.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_JoinPage_addr.FormattingEnabled = true;
            this.cbx_JoinPage_addr.Items.AddRange(new object[] {
            "서울",
            "경기",
            "인천",
            "부산",
            "경상, 대구, 울산",
            "대전, 충청",
            "강원",
            "광주, 전라, 제주"});
            this.cbx_JoinPage_addr.Location = new System.Drawing.Point(285, 52);
            this.cbx_JoinPage_addr.Name = "cbx_JoinPage_addr";
            this.cbx_JoinPage_addr.Size = new System.Drawing.Size(140, 27);
            this.cbx_JoinPage_addr.TabIndex = 9;
            this.cbx_JoinPage_addr.TabStop = false;
            this.cbx_JoinPage_addr.Text = "선택해주세요";
            // 
            // groupBox2_JoinPage_interest
            // 
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb12_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb08_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb04_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb15_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb11_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb07_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb03_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb14_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb10_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb06_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb02_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb13_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb09_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb05_JoinPage);
            this.groupBox2_JoinPage_interest.Controls.Add(this.cb01_JoinPage);
            this.groupBox2_JoinPage_interest.Font = new System.Drawing.Font("Orator10 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2_JoinPage_interest.Location = new System.Drawing.Point(6, 100);
            this.groupBox2_JoinPage_interest.Name = "groupBox2_JoinPage_interest";
            this.groupBox2_JoinPage_interest.Size = new System.Drawing.Size(427, 171);
            this.groupBox2_JoinPage_interest.TabIndex = 12;
            this.groupBox2_JoinPage_interest.TabStop = false;
            this.groupBox2_JoinPage_interest.Text = "관심분야";
            // 
            // cb12_JoinPage
            // 
            this.cb12_JoinPage.AutoSize = true;
            this.cb12_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb12_JoinPage.Location = new System.Drawing.Point(336, 99);
            this.cb12_JoinPage.Name = "cb12_JoinPage";
            this.cb12_JoinPage.Size = new System.Drawing.Size(57, 23);
            this.cb12_JoinPage.TabIndex = 0;
            this.cb12_JoinPage.TabStop = false;
            this.cb12_JoinPage.Text = "요가";
            this.cb12_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb08_JoinPage
            // 
            this.cb08_JoinPage.AutoSize = true;
            this.cb08_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb08_JoinPage.Location = new System.Drawing.Point(336, 68);
            this.cb08_JoinPage.Name = "cb08_JoinPage";
            this.cb08_JoinPage.Size = new System.Drawing.Size(83, 23);
            this.cb08_JoinPage.TabIndex = 0;
            this.cb08_JoinPage.TabStop = false;
            this.cb08_JoinPage.Text = "필라테스";
            this.cb08_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb04_JoinPage
            // 
            this.cb04_JoinPage.AutoSize = true;
            this.cb04_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb04_JoinPage.Location = new System.Drawing.Point(336, 37);
            this.cb04_JoinPage.Name = "cb04_JoinPage";
            this.cb04_JoinPage.Size = new System.Drawing.Size(57, 23);
            this.cb04_JoinPage.TabIndex = 0;
            this.cb04_JoinPage.TabStop = false;
            this.cb04_JoinPage.Text = "보컬";
            this.cb04_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb15_JoinPage
            // 
            this.cb15_JoinPage.AutoSize = true;
            this.cb15_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb15_JoinPage.Location = new System.Drawing.Point(230, 130);
            this.cb15_JoinPage.Name = "cb15_JoinPage";
            this.cb15_JoinPage.Size = new System.Drawing.Size(70, 23);
            this.cb15_JoinPage.TabIndex = 0;
            this.cb15_JoinPage.TabStop = false;
            this.cb15_JoinPage.Text = "일본어";
            this.cb15_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb11_JoinPage
            // 
            this.cb11_JoinPage.AutoSize = true;
            this.cb11_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb11_JoinPage.Location = new System.Drawing.Point(230, 99);
            this.cb11_JoinPage.Name = "cb11_JoinPage";
            this.cb11_JoinPage.Size = new System.Drawing.Size(96, 23);
            this.cb11_JoinPage.TabIndex = 0;
            this.cb11_JoinPage.TabStop = false;
            this.cb11_JoinPage.Text = "핸드메이드";
            this.cb11_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb07_JoinPage
            // 
            this.cb07_JoinPage.AutoSize = true;
            this.cb07_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb07_JoinPage.Location = new System.Drawing.Point(230, 68);
            this.cb07_JoinPage.Name = "cb07_JoinPage";
            this.cb07_JoinPage.Size = new System.Drawing.Size(96, 23);
            this.cb07_JoinPage.TabIndex = 0;
            this.cb07_JoinPage.TabStop = false;
            this.cb07_JoinPage.Text = "프로그래밍";
            this.cb07_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb03_JoinPage
            // 
            this.cb03_JoinPage.AutoSize = true;
            this.cb03_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb03_JoinPage.Location = new System.Drawing.Point(230, 37);
            this.cb03_JoinPage.Name = "cb03_JoinPage";
            this.cb03_JoinPage.Size = new System.Drawing.Size(90, 23);
            this.cb03_JoinPage.TabIndex = 0;
            this.cb03_JoinPage.TabStop = false;
            this.cb03_JoinPage.Text = "작사/작곡";
            this.cb03_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb14_JoinPage
            // 
            this.cb14_JoinPage.AutoSize = true;
            this.cb14_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb14_JoinPage.Location = new System.Drawing.Point(124, 130);
            this.cb14_JoinPage.Name = "cb14_JoinPage";
            this.cb14_JoinPage.Size = new System.Drawing.Size(70, 23);
            this.cb14_JoinPage.TabIndex = 0;
            this.cb14_JoinPage.TabStop = false;
            this.cb14_JoinPage.Text = "중국어";
            this.cb14_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb10_JoinPage
            // 
            this.cb10_JoinPage.AutoSize = true;
            this.cb10_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb10_JoinPage.Location = new System.Drawing.Point(124, 99);
            this.cb10_JoinPage.Name = "cb10_JoinPage";
            this.cb10_JoinPage.Size = new System.Drawing.Size(96, 23);
            this.cb10_JoinPage.TabIndex = 0;
            this.cb10_JoinPage.TabStop = false;
            this.cb10_JoinPage.Text = "제품디자인";
            this.cb10_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb06_JoinPage
            // 
            this.cb06_JoinPage.AutoSize = true;
            this.cb06_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb06_JoinPage.Location = new System.Drawing.Point(124, 68);
            this.cb06_JoinPage.Name = "cb06_JoinPage";
            this.cb06_JoinPage.Size = new System.Drawing.Size(70, 23);
            this.cb06_JoinPage.TabIndex = 0;
            this.cb06_JoinPage.TabStop = false;
            this.cb06_JoinPage.Text = "스포츠";
            this.cb06_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb02_JoinPage
            // 
            this.cb02_JoinPage.AutoSize = true;
            this.cb02_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb02_JoinPage.Location = new System.Drawing.Point(124, 37);
            this.cb02_JoinPage.Name = "cb02_JoinPage";
            this.cb02_JoinPage.Size = new System.Drawing.Size(83, 23);
            this.cb02_JoinPage.TabIndex = 0;
            this.cb02_JoinPage.TabStop = false;
            this.cb02_JoinPage.Text = "영상편집";
            this.cb02_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb13_JoinPage
            // 
            this.cb13_JoinPage.AutoSize = true;
            this.cb13_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb13_JoinPage.Location = new System.Drawing.Point(16, 130);
            this.cb13_JoinPage.Name = "cb13_JoinPage";
            this.cb13_JoinPage.Size = new System.Drawing.Size(83, 23);
            this.cb13_JoinPage.TabIndex = 0;
            this.cb13_JoinPage.TabStop = false;
            this.cb13_JoinPage.Text = "영어회화";
            this.cb13_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb09_JoinPage
            // 
            this.cb09_JoinPage.AutoSize = true;
            this.cb09_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb09_JoinPage.Location = new System.Drawing.Point(16, 99);
            this.cb09_JoinPage.Name = "cb09_JoinPage";
            this.cb09_JoinPage.Size = new System.Drawing.Size(83, 23);
            this.cb09_JoinPage.TabIndex = 0;
            this.cb09_JoinPage.TabStop = false;
            this.cb09_JoinPage.Text = "현대미술";
            this.cb09_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb05_JoinPage
            // 
            this.cb05_JoinPage.AutoSize = true;
            this.cb05_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb05_JoinPage.Location = new System.Drawing.Point(16, 68);
            this.cb05_JoinPage.Name = "cb05_JoinPage";
            this.cb05_JoinPage.Size = new System.Drawing.Size(83, 23);
            this.cb05_JoinPage.TabIndex = 0;
            this.cb05_JoinPage.TabStop = false;
            this.cb05_JoinPage.Text = "악기연주";
            this.cb05_JoinPage.UseVisualStyleBackColor = true;
            // 
            // cb01_JoinPage
            // 
            this.cb01_JoinPage.AutoSize = true;
            this.cb01_JoinPage.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb01_JoinPage.Location = new System.Drawing.Point(16, 37);
            this.cb01_JoinPage.Name = "cb01_JoinPage";
            this.cb01_JoinPage.Size = new System.Drawing.Size(83, 23);
            this.cb01_JoinPage.TabIndex = 0;
            this.cb01_JoinPage.TabStop = false;
            this.cb01_JoinPage.Text = "메이크업";
            this.cb01_JoinPage.UseVisualStyleBackColor = true;
            // 
            // label1_JoinPage_gender
            // 
            this.label1_JoinPage_gender.AutoSize = true;
            this.label1_JoinPage_gender.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_JoinPage_gender.Location = new System.Drawing.Point(18, 55);
            this.label1_JoinPage_gender.Name = "label1_JoinPage_gender";
            this.label1_JoinPage_gender.Size = new System.Drawing.Size(35, 19);
            this.label1_JoinPage_gender.TabIndex = 7;
            this.label1_JoinPage_gender.Text = "성별";
            // 
            // groupBox2_JoinPage_gender
            // 
            this.groupBox2_JoinPage_gender.Controls.Add(this.rb_JoinPage_W);
            this.groupBox2_JoinPage_gender.Controls.Add(this.rb_JoinPage_M);
            this.groupBox2_JoinPage_gender.Font = new System.Drawing.Font("굴림", 1.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2_JoinPage_gender.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2_JoinPage_gender.Location = new System.Drawing.Point(59, 45);
            this.groupBox2_JoinPage_gender.Name = "groupBox2_JoinPage_gender";
            this.groupBox2_JoinPage_gender.Size = new System.Drawing.Size(144, 40);
            this.groupBox2_JoinPage_gender.TabIndex = 11;
            this.groupBox2_JoinPage_gender.TabStop = false;
            this.groupBox2_JoinPage_gender.Text = "groupBox2";
            // 
            // rb_JoinPage_W
            // 
            this.rb_JoinPage_W.AutoSize = true;
            this.rb_JoinPage_W.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_JoinPage_W.ForeColor = System.Drawing.Color.Black;
            this.rb_JoinPage_W.Location = new System.Drawing.Point(81, 9);
            this.rb_JoinPage_W.Name = "rb_JoinPage_W";
            this.rb_JoinPage_W.Size = new System.Drawing.Size(56, 23);
            this.rb_JoinPage_W.TabIndex = 10;
            this.rb_JoinPage_W.Text = "여성";
            this.rb_JoinPage_W.UseVisualStyleBackColor = true;
            // 
            // rb_JoinPage_M
            // 
            this.rb_JoinPage_M.AutoSize = true;
            this.rb_JoinPage_M.Font = new System.Drawing.Font("Orator10 BT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_JoinPage_M.ForeColor = System.Drawing.Color.Black;
            this.rb_JoinPage_M.Location = new System.Drawing.Point(6, 9);
            this.rb_JoinPage_M.Name = "rb_JoinPage_M";
            this.rb_JoinPage_M.Size = new System.Drawing.Size(56, 23);
            this.rb_JoinPage_M.TabIndex = 10;
            this.rb_JoinPage_M.Text = "남성";
            this.rb_JoinPage_M.UseVisualStyleBackColor = true;
            // 
            // btn_JoinPage_join
            // 
            this.btn_JoinPage_join.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_JoinPage_join.FlatAppearance.BorderSize = 0;
            this.btn_JoinPage_join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JoinPage_join.Font = new System.Drawing.Font("Orator10 BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JoinPage_join.Location = new System.Drawing.Point(12, 592);
            this.btn_JoinPage_join.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_JoinPage_join.Name = "btn_JoinPage_join";
            this.btn_JoinPage_join.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_JoinPage_join.Size = new System.Drawing.Size(215, 49);
            this.btn_JoinPage_join.TabIndex = 0;
            this.btn_JoinPage_join.Text = "가입하기";
            this.btn_JoinPage_join.UseVisualStyleBackColor = false;
            this.btn_JoinPage_join.Click += new System.EventHandler(this.btn_JoinPage_join_Click);
            // 
            // label1_JoinPage_join
            // 
            this.label1_JoinPage_join.AutoSize = true;
            this.label1_JoinPage_join.Font = new System.Drawing.Font("Orator10 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_JoinPage_join.Location = new System.Drawing.Point(151, 25);
            this.label1_JoinPage_join.Name = "label1_JoinPage_join";
            this.label1_JoinPage_join.Size = new System.Drawing.Size(167, 43);
            this.label1_JoinPage_join.TabIndex = 22;
            this.label1_JoinPage_join.Text = " 회원가입 ";
            // 
            // btn_JoinPage_back
            // 
            this.btn_JoinPage_back.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_JoinPage_back.FlatAppearance.BorderSize = 0;
            this.btn_JoinPage_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JoinPage_back.Font = new System.Drawing.Font("Orator10 BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JoinPage_back.Location = new System.Drawing.Point(236, 592);
            this.btn_JoinPage_back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_JoinPage_back.Name = "btn_JoinPage_back";
            this.btn_JoinPage_back.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_JoinPage_back.Size = new System.Drawing.Size(215, 49);
            this.btn_JoinPage_back.TabIndex = 1;
            this.btn_JoinPage_back.Text = "돌아가기";
            this.btn_JoinPage_back.UseVisualStyleBackColor = false;
            this.btn_JoinPage_back.Click += new System.EventHandler(this.btn_JoinPage_back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 653);
            this.Controls.Add(this.label1_JoinPage_join);
            this.Controls.Add(this.btn_JoinPage_back);
            this.Controls.Add(this.btn_JoinPage_join);
            this.Controls.Add(this.groupBox2_JoinPage);
            this.Controls.Add(this.groupBox1_JoinPage);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1_JoinPage.ResumeLayout(false);
            this.groupBox1_JoinPage.PerformLayout();
            this.groupBox2_JoinPage.ResumeLayout(false);
            this.groupBox2_JoinPage.PerformLayout();
            this.groupBox2_JoinPage_interest.ResumeLayout(false);
            this.groupBox2_JoinPage_interest.PerformLayout();
            this.groupBox2_JoinPage_gender.ResumeLayout(false);
            this.groupBox2_JoinPage_gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1_JoinPage;
        private System.Windows.Forms.Label label1_JoinPage_PW;
        private System.Windows.Forms.Label label1_JoinPage_ID;
        private System.Windows.Forms.TextBox txt_JoinPage_PW;
        private System.Windows.Forms.TextBox txt_JoinPage_ID;
        private System.Windows.Forms.Button btn_JoinPage_IDcheck;
        private System.Windows.Forms.Label label1_JoinPage_phone;
        private System.Windows.Forms.Label label1_JoinPage_name;
        private System.Windows.Forms.TextBox txt_JoinPage_phone;
        private System.Windows.Forms.TextBox txt_JoinPage_name;
        private System.Windows.Forms.Label label1_JoinPage_PWconfirm;
        private System.Windows.Forms.TextBox txt_JoinPage_PWconfirm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2_JoinPage;
        private System.Windows.Forms.Label label1_JoinPage_addr;
        private System.Windows.Forms.Label label1_JoinPage_gender;
        private System.Windows.Forms.ComboBox cbx_JoinPage_addr;
        private System.Windows.Forms.GroupBox groupBox2_JoinPage_gender;
        private System.Windows.Forms.RadioButton rb_JoinPage_W;
        private System.Windows.Forms.RadioButton rb_JoinPage_M;
        private System.Windows.Forms.GroupBox groupBox2_JoinPage_interest;
        private System.Windows.Forms.Button btn_JoinPage_join;
        private System.Windows.Forms.Label label1_JoinPage_join;
        private System.Windows.Forms.CheckBox cb12_JoinPage;
        private System.Windows.Forms.CheckBox cb08_JoinPage;
        private System.Windows.Forms.CheckBox cb04_JoinPage;
        private System.Windows.Forms.CheckBox cb15_JoinPage;
        private System.Windows.Forms.CheckBox cb11_JoinPage;
        private System.Windows.Forms.CheckBox cb07_JoinPage;
        private System.Windows.Forms.CheckBox cb03_JoinPage;
        private System.Windows.Forms.CheckBox cb14_JoinPage;
        private System.Windows.Forms.CheckBox cb10_JoinPage;
        private System.Windows.Forms.CheckBox cb06_JoinPage;
        private System.Windows.Forms.CheckBox cb02_JoinPage;
        private System.Windows.Forms.CheckBox cb13_JoinPage;
        private System.Windows.Forms.CheckBox cb09_JoinPage;
        private System.Windows.Forms.CheckBox cb05_JoinPage;
        private System.Windows.Forms.CheckBox cb01_JoinPage;
        private System.Windows.Forms.Button btn_JoinPage_back;
    }
}