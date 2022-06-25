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
    public partial class Form1 : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            pn1.BackColor = Color.FromArgb(0, 255, 255);
            txtUser.ForeColor = Color.FromArgb(0, 255, 255);
            pn2.BackColor = Color.WhiteSmoke;
            txtUser.ForeColor = Color.WhiteSmoke;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtPass.PasswordChar = '*';
            pn2.BackColor = Color.FromArgb(0, 255, 255);
            txtPass.ForeColor = Color.FromArgb(0, 255, 255);

            pn1.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            var user = (from u in db.TAIKHOANs where u.Username.Equals(username) select u).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(txtUser.Text) == true || string.IsNullOrWhiteSpace(txtPass.Text) == true)
            {
                MessageBox.Show("Các trường nhập không được để trống.");
            }
            else if (user == null)
            {
                MessageBox.Show("Tài khoản không tồn tại.");
            }
            else if (!user.Pass.Equals(password))
            {
                MessageBox.Show("Sai mật khẩu.");
            }
            else
            {
                if (user.Quyen.Equals(1))      // 1 = Khach hang; 2 = Quan ly
                {
                    this.Hide();
                    mobilestore m = new mobilestore();
                    m.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    mobilestoreNV m = new mobilestoreNV();
                    m.ShowDialog();
                    this.Show();
                }
            }
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
        
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangKy f = new FormDangKy();
            f.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
