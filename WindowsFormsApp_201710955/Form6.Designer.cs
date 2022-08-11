namespace WindowsFormsApp_201710955
{
    partial class Form6
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
            this.btn_LoginPage_join = new System.Windows.Forms.Button();
            this.btn_LoginPage_login = new System.Windows.Forms.Button();
            this.label1_LoginPage_PW = new System.Windows.Forms.Label();
            this.label1_LoginPage_ID = new System.Windows.Forms.Label();
            this.txt_LoginPage_PW = new System.Windows.Forms.TextBox();
            this.txt_LoginPage_ID = new System.Windows.Forms.TextBox();
            this.btn_LoginPage_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_LoginPage_join
            // 
            this.btn_LoginPage_join.BackColor = System.Drawing.Color.White;
            this.btn_LoginPage_join.FlatAppearance.BorderSize = 0;
            this.btn_LoginPage_join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoginPage_join.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginPage_join.Location = new System.Drawing.Point(226, 96);
            this.btn_LoginPage_join.Name = "btn_LoginPage_join";
            this.btn_LoginPage_join.Size = new System.Drawing.Size(91, 27);
            this.btn_LoginPage_join.TabIndex = 3;
            this.btn_LoginPage_join.Text = "Sign In";
            this.btn_LoginPage_join.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LoginPage_join.UseVisualStyleBackColor = false;
            this.btn_LoginPage_join.Click += new System.EventHandler(this.btn_LoginPage_join_Click);
            // 
            // btn_LoginPage_login
            // 
            this.btn_LoginPage_login.BackColor = System.Drawing.Color.White;
            this.btn_LoginPage_login.FlatAppearance.BorderSize = 0;
            this.btn_LoginPage_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoginPage_login.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginPage_login.Location = new System.Drawing.Point(226, 62);
            this.btn_LoginPage_login.Name = "btn_LoginPage_login";
            this.btn_LoginPage_login.Size = new System.Drawing.Size(68, 27);
            this.btn_LoginPage_login.TabIndex = 2;
            this.btn_LoginPage_login.Text = "Login";
            this.btn_LoginPage_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LoginPage_login.UseVisualStyleBackColor = false;
            this.btn_LoginPage_login.Click += new System.EventHandler(this.btn_LoginPage_login_Click);
            // 
            // label1_LoginPage_PW
            // 
            this.label1_LoginPage_PW.AutoSize = true;
            this.label1_LoginPage_PW.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_LoginPage_PW.Location = new System.Drawing.Point(18, 99);
            this.label1_LoginPage_PW.Name = "label1_LoginPage_PW";
            this.label1_LoginPage_PW.Size = new System.Drawing.Size(28, 23);
            this.label1_LoginPage_PW.TabIndex = 9;
            this.label1_LoginPage_PW.Text = "PW";
            this.label1_LoginPage_PW.Click += new System.EventHandler(this.label1_LoginPage_PW_Click);
            // 
            // label1_LoginPage_ID
            // 
            this.label1_LoginPage_ID.AutoSize = true;
            this.label1_LoginPage_ID.Font = new System.Drawing.Font("Orator10 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_LoginPage_ID.Location = new System.Drawing.Point(18, 66);
            this.label1_LoginPage_ID.Name = "label1_LoginPage_ID";
            this.label1_LoginPage_ID.Size = new System.Drawing.Size(28, 23);
            this.label1_LoginPage_ID.TabIndex = 10;
            this.label1_LoginPage_ID.Text = "ID";
            // 
            // txt_LoginPage_PW
            // 
            this.txt_LoginPage_PW.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_LoginPage_PW.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_LoginPage_PW.Location = new System.Drawing.Point(52, 96);
            this.txt_LoginPage_PW.Name = "txt_LoginPage_PW";
            this.txt_LoginPage_PW.PasswordChar = '●';
            this.txt_LoginPage_PW.Size = new System.Drawing.Size(170, 27);
            this.txt_LoginPage_PW.TabIndex = 1;
            this.txt_LoginPage_PW.TextChanged += new System.EventHandler(this.txt_LoginPage_PW_TextChanged);
            // 
            // txt_LoginPage_ID
            // 
            this.txt_LoginPage_ID.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_LoginPage_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_LoginPage_ID.Location = new System.Drawing.Point(52, 63);
            this.txt_LoginPage_ID.Name = "txt_LoginPage_ID";
            this.txt_LoginPage_ID.Size = new System.Drawing.Size(170, 27);
            this.txt_LoginPage_ID.TabIndex = 0;
            this.txt_LoginPage_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LoginPage_ID_KeyPress);
            // 
            // btn_LoginPage_back
            // 
            this.btn_LoginPage_back.BackColor = System.Drawing.Color.White;
            this.btn_LoginPage_back.FlatAppearance.BorderSize = 0;
            this.btn_LoginPage_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoginPage_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginPage_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_LoginPage_back.Location = new System.Drawing.Point(1, 8);
            this.btn_LoginPage_back.Name = "btn_LoginPage_back";
            this.btn_LoginPage_back.Size = new System.Drawing.Size(45, 32);
            this.btn_LoginPage_back.TabIndex = 4;
            this.btn_LoginPage_back.Text = "←";
            this.btn_LoginPage_back.UseVisualStyleBackColor = false;
            this.btn_LoginPage_back.Click += new System.EventHandler(this.btn_LoginPage_back_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 146);
            this.Controls.Add(this.btn_LoginPage_back);
            this.Controls.Add(this.btn_LoginPage_join);
            this.Controls.Add(this.btn_LoginPage_login);
            this.Controls.Add(this.label1_LoginPage_PW);
            this.Controls.Add(this.label1_LoginPage_ID);
            this.Controls.Add(this.txt_LoginPage_PW);
            this.Controls.Add(this.txt_LoginPage_ID);
            this.Name = "Form6";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LoginPage_join;
        private System.Windows.Forms.Button btn_LoginPage_login;
        private System.Windows.Forms.Label label1_LoginPage_PW;
        private System.Windows.Forms.Label label1_LoginPage_ID;
        private System.Windows.Forms.TextBox txt_LoginPage_PW;
        private System.Windows.Forms.TextBox txt_LoginPage_ID;
        private System.Windows.Forms.Button btn_LoginPage_back;
    }
}