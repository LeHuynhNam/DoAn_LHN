using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace loginform
{
    public partial class FormDangKy : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void comboBoxGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            comboBoxGioiTinh.Text = "Nam";
            comboBoxGioiTinh.DataSource = new string[] { "Nam", "Nữ" };
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            pn1.BackColor = Color.FromArgb(0, 255, 255);
            txtUser.ForeColor = Color.FromArgb(0, 255, 255);
            pn2.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtPass.UseSystemPasswordChar = true;
            pn2.BackColor = Color.FromArgb(0, 255, 255);
            txtPass.ForeColor = Color.FromArgb(0, 255, 255);

            pn1.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;
        }

        private void txtConfirmPass_Click(object sender, EventArgs e)
        {
            txtConfirmPass.Text = "";
            txtConfirmPass.UseSystemPasswordChar = true;
            pn2.BackColor = Color.FromArgb(0, 255, 255);
            txtConfirmPass.ForeColor = Color.FromArgb(0, 255, 255);

            pn1.BackColor = Color.WhiteSmoke;
            txtConfirmPass.ForeColor = Color.WhiteSmoke;
        }

        private void txtTen_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            pn2.BackColor = Color.FromArgb(0, 255, 255);
            txtTen.ForeColor = Color.FromArgb(0, 255, 255);

            pn1.BackColor = Color.WhiteSmoke;
            txtTen.ForeColor = Color.WhiteSmoke;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            pn2.BackColor = Color.FromArgb(0, 255, 255);
            txtEmail.ForeColor = Color.FromArgb(0, 255, 255);

            pn1.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.WhiteSmoke;
        }

        private void txtSDT_Click(object sender, EventArgs e)
        {
            txtSDT.Text = "";
            pn2.BackColor = Color.FromArgb(0, 255, 255);
            txtSDT.ForeColor = Color.FromArgb(0, 255, 255);

            pn1.BackColor = Color.WhiteSmoke;
            txtSDT.ForeColor = Color.WhiteSmoke;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String username = txtUser.Text;
            String password = txtPass.Text;

            var user = (from u in db.TAIKHOANs where u.Username.Equals(username) select u).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(txtUser.Text) == true || string.IsNullOrWhiteSpace(txtPass.Text) == true || string.IsNullOrWhiteSpace(txtConfirmPass.Text) == true || string.IsNullOrWhiteSpace(txtTen.Text) == true || string.IsNullOrWhiteSpace(txtEmail.Text) == true || string.IsNullOrWhiteSpace(txtSDT.Text) == true)
            {
                MessageBox.Show("Các trường nhập không được để trống.");
            }
            else if (user != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại.");
            }
            else if (txtConfirmPass.Text.Equals(txtPass.Text) == false)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp.");
            }
            else
            {
                TAIKHOAN tk = new TAIKHOAN();
                tk.Username = username;
                tk.Pass = password;
                tk.Ten = txtTen.Text;
                tk.Email = txtEmail.Text;
                tk.SDT = txtSDT.Text;
                tk.Gioitinh = comboBoxGioiTinh.Text;
                tk.Quyen = 1;
                db.TAIKHOANs.InsertOnSubmit(tk);
                db.SubmitChanges();
                MessageBox.Show("Đăng ký mới thành công.");
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
