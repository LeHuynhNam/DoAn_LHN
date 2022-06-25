using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAnNET
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if(taiKhoanDAO.Ins.checkLogin(txtUSN.Text,txtPW.Text)=="QL")
            //if(true)
            {
                frmManager control = new frmManager();
                
                control.Show();
                this.Hide();
            }
            else if(taiKhoanDAO.Ins.checkLogin(txtUSN.Text, txtPW.Text) == "NVVP")
            {
                frmSeller frm = new frmSeller();
                
                frm.Show();
                this.Hide();
                //this.Close();
                //frm.ShowDialog();
                //txtPW.Text = string.Empty;

            }
            else if(taiKhoanDAO.Ins.checkLogin(txtUSN.Text, txtPW.Text) != null)          
            {
                MessageBox.Show("Thông tin đăng nhập chưa đúng!");
            }
            else
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
