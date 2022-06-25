
namespace loginform
{
    partial class FormDangKy
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pn2 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pn1 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(62, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(62, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(247, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "EXIT";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pn2
            // 
            this.pn2.BackColor = System.Drawing.Color.White;
            this.pn2.Location = new System.Drawing.Point(62, 134);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(249, 1);
            this.pn2.TabIndex = 15;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPass.Location = new System.Drawing.Point(62, 111);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(249, 17);
            this.txtPass.TabIndex = 10;
            this.txtPass.Text = "Password";
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.White;
            this.pn1.Location = new System.Drawing.Point(62, 84);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(249, 1);
            this.pn1.TabIndex = 14;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Transparent;
            this.txtUser.Location = new System.Drawing.Point(60, 61);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(249, 24);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "Username";
            this.txtUser.Click += new System.EventHandler(this.txtUser_Click);
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(62, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 1);
            this.panel1.TabIndex = 18;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtConfirmPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtConfirmPass.Location = new System.Drawing.Point(62, 159);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(249, 17);
            this.txtConfirmPass.TabIndex = 17;
            this.txtConfirmPass.Text = "Confirm Password";
            this.txtConfirmPass.Click += new System.EventHandler(this.txtConfirmPass_Click);
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(60, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 1);
            this.panel2.TabIndex = 20;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTen.Location = new System.Drawing.Point(60, 206);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(249, 17);
            this.txtTen.TabIndex = 19;
            this.txtTen.Text = "Tên";
            this.txtTen.Click += new System.EventHandler(this.txtTen_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(60, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 1);
            this.panel3.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEmail.Location = new System.Drawing.Point(60, 251);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 17);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.Text = "Email";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(60, 327);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 1);
            this.panel4.TabIndex = 22;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSDT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSDT.Location = new System.Drawing.Point(60, 304);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(249, 17);
            this.txtSDT.TabIndex = 21;
            this.txtSDT.Text = "SĐT";
            this.txtSDT.Click += new System.EventHandler(this.txtSDT_Click);
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(141, 367);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(145, 21);
            this.comboBoxGioiTinh.TabIndex = 23;
            this.comboBoxGioiTinh.SelectedIndexChanged += new System.EventHandler(this.comboBoxGioiTinh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Giới tính";
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(373, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.Label label1;
    }
}