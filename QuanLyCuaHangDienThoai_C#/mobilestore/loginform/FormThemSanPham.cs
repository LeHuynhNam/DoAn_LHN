using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DTO;

namespace loginform
{
    public partial class FormThemSanPham : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();

        public FormThemSanPham()
        {
            InitializeComponent();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDienThoai.Text) == true || string.IsNullOrEmpty(txtTenDienThoai.Text) == true || string.IsNullOrEmpty(txtHangSX.Text) == true || string.IsNullOrEmpty(txtGiaBan.Text) == true || string.IsNullOrEmpty(textBoxManHinh.Text) == true || string.IsNullOrEmpty(textBoxCameraSau.Text) == true || string.IsNullOrEmpty(textBoxCameraTruoc.Text) == true || string.IsNullOrEmpty(textBoxRam.Text) == true || string.IsNullOrEmpty(textBoxRom.Text) == true || string.IsNullOrEmpty(textBoxPin.Text) == true || string.IsNullOrEmpty(textBoxHDH.Text) == true || string.IsNullOrEmpty(textBoxMaHang.Text) == true)
                MessageBox.Show("Các trường nhập không được để trống.");
            else
            {
                var z = db.SANPHAMs.Where(t => t.TenHang == txtTenDienThoai.Text).FirstOrDefault();
                if (z != null)
                {
                    MessageBox.Show("Điện thoại này đã tồn tại.");
                }
                else
                {
                    SANPHAM s = new SANPHAM();
                    s.TenHang = txtTenDienThoai.Text;
                    s.HangSX = txtHangSX.Text;
                    s.Gia = int.Parse(txtGiaBan.Text);
                    db.SANPHAMs.InsertOnSubmit(s);
                    db.SubmitChanges();
                    SANPHAM ss = db.SANPHAMs.Where(t => t.TenHang == txtTenDienThoai.Text).FirstOrDefault();
                    THONGSOKYTHUAT ts = new THONGSOKYTHUAT();
                    ts.ManHinh = textBoxManHinh.Text;
                    ts.CameraSau = textBoxCameraSau.Text;
                    ts.Cameratruoc = textBoxCameraTruoc.Text;
                    ts.Ram = textBoxRam.Text;
                    ts.Rom = textBoxRom.Text;
                    ts.Pin = textBoxPin.Text;
                    ts.HDH = textBoxHDH.Text;
                    ts.MaHang = ss.MaHang;
                    db.THONGSOKYTHUATs.InsertOnSubmit(ts);
                    db.SubmitChanges();
                }
            }
            reload();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDienThoai.Text) == true)
                MessageBox.Show("Các trường nhập không được để trống.");
            else
            {
                var z = db.SANPHAMs.Where(t => t.MaHang == int.Parse(txtMaDienThoai.Text)).FirstOrDefault();
                if (z == null)
                {
                    MessageBox.Show("Không có điện thoại này.");
                }
                else
                {
                    THONGSOKYTHUAT ts = db.THONGSOKYTHUATs.Where(t => t.MaHang == int.Parse(textBoxMaHang.Text)).FirstOrDefault();
                    db.THONGSOKYTHUATs.DeleteOnSubmit(ts);
                    db.SubmitChanges();
                    SANPHAM s = db.SANPHAMs.Where(t => t.MaHang == int.Parse(txtMaDienThoai.Text)).FirstOrDefault();
                    db.SANPHAMs.DeleteOnSubmit(s);
                    db.SubmitChanges();
                }
            }
            reload();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDienThoai.Text) == true || string.IsNullOrEmpty(txtTenDienThoai.Text) == true || string.IsNullOrEmpty(txtHangSX.Text) == true || string.IsNullOrEmpty(txtGiaBan.Text) == true || string.IsNullOrEmpty(textBoxManHinh.Text) == true || string.IsNullOrEmpty(textBoxCameraSau.Text) == true || string.IsNullOrEmpty(textBoxCameraTruoc.Text) == true || string.IsNullOrEmpty(textBoxRam.Text) == true || string.IsNullOrEmpty(textBoxRom.Text) == true || string.IsNullOrEmpty(textBoxPin.Text) == true || string.IsNullOrEmpty(textBoxHDH.Text) == true || string.IsNullOrEmpty(textBoxMaHang.Text) == true)
                MessageBox.Show("Các trường nhập không được để trống.");
            else
            {
                var z = db.SANPHAMs.Where(t => t.MaHang == int.Parse(txtMaDienThoai.Text)).FirstOrDefault();
                if (z == null)
                {
                    MessageBox.Show("Không có điện thoại này.");
                }
                else
                {
                    SANPHAM s = db.SANPHAMs.Where(t => t.MaHang == int.Parse(txtMaDienThoai.Text)).FirstOrDefault();
                    s.TenHang = txtTenDienThoai.Text;
                    s.HangSX = txtHangSX.Text;
                    s.Gia = int.Parse(txtGiaBan.Text);
                    db.SubmitChanges();
                    THONGSOKYTHUAT ts = db.THONGSOKYTHUATs.Where(t => t.MaHang == s.MaHang).FirstOrDefault();
                    ts.ManHinh = textBoxManHinh.Text;
                    ts.CameraSau = textBoxCameraSau.Text;
                    ts.Cameratruoc = textBoxCameraTruoc.Text;
                    ts.Ram = textBoxRam.Text;
                    ts.Rom = textBoxRom.Text;
                    ts.Pin = textBoxPin.Text;
                    ts.HDH = textBoxHDH.Text;
                    db.SubmitChanges();
                }
            }
            reload();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void FormThemSanPham_Load(object sender, EventArgs e)
        {
            reload();

        }
        
        private void reload()
        {
            txtMaDienThoai.Enabled = false;
            textBoxMaHang.Enabled = false;

            txtMaDienThoai.Text = "";
            txtTenDienThoai.Text = "";
            txtHangSX.Text = "";
            txtGiaBan.Text = "";
            textBoxManHinh.Text = "";
            textBoxCameraSau.Text = "";
            textBoxCameraTruoc.Text = "";
            textBoxRam.Text = "";
            textBoxRom.Text = "";
            textBoxPin.Text = "";
            textBoxHDH.Text = "";
            textBoxMaHang.Text = "";

            var ds = from s in db.SANPHAMs
                     join ts in db.THONGSOKYTHUATs
                     on s.MaHang equals ts.MaHang 
                     select new
                     {
                         s.MaHang,
                         s.TenHang,
                         s.HangSX,
                         s.Gia,
                         ts.ManHinh,
                         ts.CameraSau,
                         ts.Cameratruoc,
                         ts.Ram,
                         ts.Rom,
                         ts.Pin,
                         ts.HDH
                     };
            dgvDienThoai.DataSource = ds;   

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvDienThoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDienThoai.Text = dgvDienThoai.CurrentRow.Cells[0].Value.ToString();
            txtTenDienThoai.Text = dgvDienThoai.CurrentRow.Cells[1].Value.ToString();
            txtHangSX.Text = dgvDienThoai.CurrentRow.Cells[2].Value.ToString();
            txtGiaBan.Text = dgvDienThoai.CurrentRow.Cells[3].Value.ToString();

            int maHang = int.Parse(dgvDienThoai.CurrentRow.Cells[0].Value.ToString());
            THONGSOKYTHUAT ts = db.THONGSOKYTHUATs.Where(t => t.MaHang == maHang).FirstOrDefault();
            textBoxManHinh.Text = ts.ManHinh;
            textBoxCameraSau.Text = ts.CameraSau;
            textBoxCameraTruoc.Text = ts.Cameratruoc;
            textBoxRam.Text = ts.Ram;
            textBoxRom.Text = ts.Rom;
            textBoxPin.Text = ts.Pin;
            textBoxMaHang.Text = ts.MaHang.ToString();
            textBoxHDH.Text = ts.HDH;
        }

        private void txtGiaBan_Load(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTim.Text) == true)
                reload();
            else
            {
                string s = txtTim.Text;
                var z = db.SANPHAMs.Where(t => t.TenHang.Contains(s)).FirstOrDefault();
                if (z == null)
                {
                    MessageBox.Show("Không có điện thoại này.");
                    reload();
                }
                else
                {
                    var ds = from sp in db.SANPHAMs
                             where sp.TenHang.Contains(s)
                             join ts in db.THONGSOKYTHUATs
                             on sp.MaHang equals ts.MaHang
                             select new
                             {
                                 sp.MaHang,
                                 sp.TenHang,
                                 sp.HangSX,
                                 sp.Gia,
                                 ts.ManHinh,
                                 ts.CameraSau,
                                 ts.Cameratruoc,
                                 ts.Ram,
                                 ts.Rom,
                                 ts.Pin,
                                 ts.HDH
                             };
                    dgvDienThoai.DataSource = ds;
                }
            }
        }
    }
}
