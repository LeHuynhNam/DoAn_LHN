using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;

namespace loginform
{
    public partial class FormHoaDon : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        int thanhTien = 0;
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }


        private void dgvDienThoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDienThoai.Text = dgvDienThoai.CurrentRow.Cells[0].Value.ToString();
            txtTenDienThoai.Text = dgvDienThoai.CurrentRow.Cells[1].Value.ToString();
            SANPHAM s = db.SANPHAMs.Where(t => t.TenHang == txtTenDienThoai.Text).FirstOrDefault();
            txtGiaBan.Text = (nupSoLuong.Value * s.Gia).ToString();
        }

        private void txtTimDienThoai_TextChanged(object sender, EventArgs e)
        {
            var dt = db.SANPHAMs.Where(t => t.TenHang.Contains(txtTimDienThoai.Text));
            if (dt == null)
                dgvDienThoai.DataSource = db.SANPHAMs.Select(t => t);
            else
                dgvDienThoai.DataSource = dt;
        }

        private void dgvDienThoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDienThoai.CurrentRow.Index;
            txtMaDienThoai.Text = dgvDienThoai.Rows[i].Cells[0].Value.ToString();
            txtTenDienThoai.Text = dgvDienThoai.Rows[i].Cells[1].Value.ToString();
            txtGiaBan.Text = dgvDienThoai.Rows[i].Cells[3].Value.ToString();
        }

        private void dtpNgayBan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            txtMaHoaDon.Enabled = false;
            txtMaKhachHang.Enabled = false;
            txtMaDienThoai.Enabled = false;
            txtTenDienThoai.Enabled = false;
            dtpNgayBan.Enabled = false;
            txtGiaBan.Enabled = false;
            textBoxThanhTien.Enabled = false;

            txtMaHoaDon.Text = "";
            txtMaKhachHang.Text = "";
            txtTenKhach.Text = "";
            txtMaDienThoai.Text = "";
            txtTenDienThoai.Text = "";
            txtGiaBan.Text = "0";
            textBoxThanhTien.Text = "0";
            nupSoLuong.Value = 1;

            dtpNgayBan.Value = DateTime.Now;

            var dt = db.SANPHAMs.Select(t => t);
            dgvDienThoai.DataSource = dt;

            dgvGioHang.Rows.Clear();
            dgvGioHang.Refresh();

            thanhTien = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string s = txtTenKhach.Text;
            var k = db.TAIKHOANs.Where(t => t.Ten == s).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(txtTenKhach.Text) == true || string.IsNullOrWhiteSpace(txtMaKhachHang.Text) == true)
            {
                MessageBox.Show("Trường nhập không được để trống.");
            }
            else if (k == null || k.Quyen == 2)
            {
                MessageBox.Show("Không tồn tại khách hàng này.");
            }
            else
            {
                if (dgvGioHang.Rows.Count == 1)
                {
                    MessageBox.Show("Chưa có điện thoại.");
                }
                else
                {
                    thanhTien = 0;
                    string sanpham = "";
                    HOADON h = new HOADON();
                    h.MaKH = int.Parse(txtMaKhachHang.Text);
                    h.TenKhach = txtTenKhach.Text;
                    h.NgayBan = dtpNgayBan.Value;
                    h.ThanhTien = int.Parse(textBoxThanhTien.Text);
                    db.HOADONs.InsertOnSubmit(h);
                    db.SubmitChanges();
                    txtMaHoaDon.Text = h.MaHD.ToString();
                    HOADON hid = db.HOADONs.Where(t => t.MaHD == int.Parse(txtMaHoaDon.Text)).FirstOrDefault();
                    int id = hid.MaHD;

                    for (int i = 0; i < dgvGioHang.Rows.Count - 1; i++)
                    {
                        CHITIETHD ct = new CHITIETHD();
                        string tenDT = dgvGioHang.Rows[i].Cells[1].Value.ToString();
                        ct.MaHD = id;
                        ct.TenHang = dgvGioHang.Rows[i].Cells[1].Value.ToString();
                        ct.SoLuong = int.Parse(nupSoLuong.Value.ToString());
                        ct.ThanhTien = int.Parse(dgvGioHang.Rows[i].Cells[3].Value.ToString());
                        db.CHITIETHDs.InsertOnSubmit(ct);
                        db.SubmitChanges();
                        if (!sanpham.Equals(""))
                        {
                            sanpham += ", ";
                        }
                        sanpham += ct.TenHang + " (" + ct.SoLuong.ToString() + " cái - " + ct.ThanhTien.ToString() + " VND)"; 
                    }

                    
                    WordExport w = new WordExport();
                    w.In(h.MaHD.ToString(), h.MaKH.ToString(), h.TenKhach, DateTime.Now.ToShortDateString(), h.ThanhTien.ToString(), sanpham);

                    MessageBox.Show("Đã xuất hoá đơn.");
                    reload();
                }
            }
        }

        private void txtTenKhach_TextChanged(object sender, EventArgs e)
        {
            var tk = db.TAIKHOANs.Where(t => t.Ten.Equals(txtTenKhach.Text)).FirstOrDefault();
            if (tk != null && tk.Quyen == 1)
            {
                TAIKHOAN tkhoan = db.TAIKHOANs.Where(t => t.Ten.Equals(txtTenKhach.Text)).FirstOrDefault();
                txtMaKhachHang.Text = tkhoan.MaKH.ToString();
                txtTenKhach.Text = tkhoan.Ten;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dgvDienThoai_SelectionChanged(object sender, EventArgs e)
        {
            txtMaDienThoai.Text = dgvDienThoai.CurrentRow.Cells[0].Value.ToString();
            txtTenDienThoai.Text = dgvDienThoai.CurrentRow.Cells[1].Value.ToString();
            SANPHAM s = db.SANPHAMs.Where(t => t.TenHang == txtTenDienThoai.Text).FirstOrDefault();
            txtGiaBan.Text = (nupSoLuong.Value * s.Gia).ToString();
        }

        private void nupSoLuong_ValueChanged(object sender, EventArgs e)
        {
            SANPHAM s = db.SANPHAMs.Where(t => t.TenHang == txtTenDienThoai.Text).FirstOrDefault();
            txtGiaBan.Text = (nupSoLuong.Value * s.Gia).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count > 1)
            {
                int tongGia = int.Parse(dgvGioHang.CurrentRow.Cells[3].Value.ToString());
                thanhTien -= tongGia;
                textBoxThanhTien.Text = thanhTien.ToString();
                dgvGioHang.Rows.RemoveAt(dgvGioHang.CurrentRow.Index);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count > 1)
            {
                for (int i = 0; i < dgvGioHang.Rows.Count - 1; i++)
                {
                    string dataDSChon = dgvGioHang.Rows[i].Cells[1].Value.ToString();
                    string dataDT = dgvDienThoai.CurrentRow.Cells[1].Value.ToString();
                    if (dataDSChon.Equals(dataDT))
                    {
                        MessageBox.Show("Đã thêm điện thoại này.");
                        return;
                    }
                }
            }
            string id = dgvDienThoai.CurrentRow.Cells[0].Value.ToString();
            string ten = dgvDienThoai.CurrentRow.Cells[1].Value.ToString();
            string sl = nupSoLuong.Value.ToString();
            string gia = dgvDienThoai.CurrentRow.Cells[3].Value.ToString();
            int tongGia = int.Parse(sl) * int.Parse(gia);
            SANPHAM s = db.SANPHAMs.Where(t => t.TenHang == ten).FirstOrDefault();
            int index = dgvGioHang.Rows.Add();
            dgvGioHang.Rows[index].Cells[0].Value = id;
            dgvGioHang.Rows[index].Cells[1].Value = ten;
            dgvGioHang.Rows[index].Cells[2].Value = sl;
            dgvGioHang.Rows[index].Cells[3].Value = tongGia.ToString();
            thanhTien += tongGia;
            textBoxThanhTien.Text = thanhTien.ToString();
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
