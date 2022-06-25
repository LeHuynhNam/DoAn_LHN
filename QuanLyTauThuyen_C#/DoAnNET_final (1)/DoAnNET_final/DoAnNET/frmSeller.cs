using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNET.DAO;
  

namespace DoAnNET
{
    public partial class frmSeller : Form
    {
        public frmSeller()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void frmMap_Load(object sender, EventArgs e)
        {
            dgvHDSanPham.DataSource = SanPhamDAO.Ins.showSP();
            dgvHDKhachHang.DataSource = KhachHangDAO.Ins.showKH();
            dgvHTSP.DataSource = SanPhamDAO.Ins.showSP();
            dgvTau.DataSource = TauThuyenDAO.Ins.showTT();
        }

        private void dgvHDSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvHDSanPham.SelectedRows.Count>0)
            {
                txtSPTen.Text = dgvHDSanPham.CurrentRow.Cells[1].Value.ToString().Trim();
                txtSPGia.Text = SanPhamDAO.Ins.getGiaSP(dgvHDSanPham.CurrentRow.Cells[0].Value.ToString().Trim());
                txtSPSoLuong.Text = string.Empty;
                btnHDSua.Enabled = false;
                btnHDXoa.Enabled = false;
            }
        }

        private void btnHDThem_Click(object sender, EventArgs e)
        {
            if (txtSPSoLuong.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập số lượng!");
                txtSPSoLuong.Focus();
                return;
            }
            float slkho = float.Parse(dgvHDSanPham.CurrentRow.Cells[3].Value.ToString());
            
            for (int i = 0; i < dgvHDCTHD.Rows.Count; i++)
            {
                if (txtSPTen.Text == dgvHDCTHD.Rows[i].Cells[1].Value.ToString())
                {//TH co san pham trong bang chi tiet hoa don
                    float sl = float.Parse(txtSPSoLuong.Text) + float.Parse(dgvHDCTHD.Rows[i].Cells[2].Value.ToString());
                    if(sl>slkho)
                    {
                        MessageBox.Show("Lượng hàng trong kho không đủ!");
                        txtSPSoLuong.SelectAll();
                        txtSPSoLuong.Focus();
                        return;
                    }
                    dgvHDCTHD.Rows[i].Cells[2].Value = sl.ToString();//cap nhat so luong
                    dgvHDCTHD.Rows[i].Cells[4].Value = (double)(sl * int.Parse(txtSPGia.Text));//cap nhat thanh tien
                    //this.dgvHDCTHD.Rows.Add(dgvHDSanPham.CurrentRow.Cells[0],txtSPTen.Text,txtSPGia.Text,sl.ToString(),(int.Parse(txtSPGia.Text)*sl)));
                    double thanhtien = 0;
                    for (int j = 0; j < dgvHDCTHD.Rows.Count; j++)
                    {
                        thanhtien += double.Parse(dgvHDCTHD.Rows[j].Cells[4].Value.ToString());
                    }
                    txtHDTongTien.Text = thanhtien.ToString();
                    return;
                }
            }
            if(float.Parse(txtSPSoLuong.Text)>slkho)
            {
                MessageBox.Show("Lượng hàng trong kho không đủ!");
                txtSPSoLuong.SelectAll();
                txtSPSoLuong.Focus();
                return;
            }
            this.dgvHDCTHD.Rows.Add(dgvHDSanPham.CurrentRow.Cells[0].Value.ToString(), txtSPTen.Text, txtSPSoLuong.Text, txtSPGia.Text, (double)(int.Parse(txtSPGia.Text) * float.Parse(txtSPSoLuong.Text)));
            double tt = 0;
            for (int i = 0; i < dgvHDCTHD.Rows.Count; i++)
            {
                tt += double.Parse(dgvHDCTHD.Rows[i].Cells[4].Value.ToString());
            }
            txtHDTongTien.Text = tt.ToString();
        }

        private void dgvHDKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvHDKhachHang.SelectedRows.Count>0)
            {
                txtKHTen.Text = dgvHDKhachHang.CurrentRow.Cells[1].Value.ToString().Trim();
                txtKHSDT.Text = dgvHDKhachHang.CurrentRow.Cells[2].Value.ToString().Trim();
                txtKHMST.Text = dgvHDKhachHang.CurrentRow.Cells[3].Value.ToString().Trim();
                txtKHDiaChi.Text = dgvHDKhachHang.CurrentRow.Cells[4].Value.ToString().Trim();
            }
        }

        private void ckbHDKHTT_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbHDKHTT.Checked)
            {
                txtKHTimKiem.Visible = true;
                dgvHDKhachHang.Visible = true;
                tpnHDThongTinKH.Visible = true;
                txtKHTimKiem.Text = string.Empty;
                dgvHDKhachHang.DataSource = KhachHangDAO.Ins.showKH();
            }
            else
            {
                txtKHTimKiem.Visible = false;
                dgvHDKhachHang.Visible = false;
                tpnHDThongTinKH.Visible = false;
                txtHDMaKhach.Text = string.Empty;
            }
        }

        private void txtKHTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvHDKhachHang.DataSource = KhachHangDAO.Ins.findKH(txtKHTimKiem.Text);
        }

        private void btnKHChon_Click(object sender, EventArgs e)
        {
            txtHDMaKhach.Text=dgvHDKhachHang.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnHDSua_Click(object sender, EventArgs e)
        {
            if(dgvCTHT.Rows.Count==0)
            {
                return;
            }
            float slkho = float.Parse(dgvHDSanPham.CurrentRow.Cells[3].Value.ToString());
            if (txtSPSoLuong.Text.Length==0)
            {
                MessageBox.Show("Chưa nhập số lượng!");
                txtSPSoLuong.Focus();
                return;
            }
            float sl = float.Parse(txtSPSoLuong.Text);
            if (sl > slkho)
            {
                MessageBox.Show("Lượng hàng trong kho không đủ!")/*+ float.Parse(dgvHDCTHD.Rows[i].Cells[2].Value.ToString())*/;
               
                txtSPSoLuong.SelectAll();
                txtSPSoLuong.Focus();
                return;
            }
            dgvHDCTHD.CurrentRow.Cells[2].Value = txtSPSoLuong.Text;
            dgvHDCTHD.CurrentRow.Cells[4].Value = double.Parse(txtSPSoLuong.Text) * double.Parse(dgvHDCTHD.CurrentRow.Cells[3].Value.ToString());
            MessageBox.Show("Sửa thành công!");
        }

        private void btnHDXoa_Click(object sender, EventArgs e)
        {
            if (dgvCTHT.Rows.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                dgvHDCTHD.Rows.Remove(dgvHDCTHD.CurrentRow);
                double thanhtien = 0;
                for (int i = 0; i < dgvHDCTHD.Rows.Count; i++)
                {
                    thanhtien += double.Parse(dgvHDCTHD.Rows[i].Cells[4].Value.ToString());
                }
                txtHDTongTien.Text = thanhtien.ToString();
            }
        }

        private void txtSPTimTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvHDSanPham.DataSource = SanPhamDAO.Ins.findSP(txtSPTimTenSP.Text);
        }

        private void dgvHDCTHD_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvHDCTHD.SelectedRows.Count>0)
            {
                txtSPTen.Text = dgvHDCTHD.CurrentRow.Cells[1].Value.ToString();
                txtSPGia.Text = dgvHDCTHD.CurrentRow.Cells[3].Value.ToString();
                txtSPSoLuong.Text = dgvHDCTHD.CurrentRow.Cells[2].Value.ToString();
                btnHDXoa.Enabled = true;
                btnHDSua.Enabled = true;
            }
            else
            {
                btnHDXoa.Enabled = false;
                btnHDSua.Enabled = false;
            }
        }

        private void dgvHDCTHD_DataMemberChanged(object sender, EventArgs e)
        {
            double thanhtien=0;
            for(int i=0;i<dgvHDCTHD.Rows.Count;i++)
            {
                thanhtien += double.Parse(dgvHDCTHD.Rows[i].Cells[4].Value.ToString());
            }
            txtHDTongTien.Text = thanhtien.ToString();
        }

        private void dgvHDCTHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double thanhtien = 0;
            for (int i = 0; i < dgvHDCTHD.Rows.Count; i++)
            {
                thanhtien += double.Parse(dgvHDCTHD.Rows[i].Cells[4].Value.ToString());
            }
            txtHDTongTien.Text = thanhtien.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dgvHDCTHD.Rows.Count==0)
            {
                MessageBox.Show("Hóa đơn trống!");
                return;
            }
            if(txtHDTienDua.Text.Length==0)
            {
                MessageBox.Show("Chưa nhập số tiền cần thanh toán!");
                txtHDTienDua.Focus();
                return;

            }
            if(double.Parse(txtHDTienThua.Text)<0)
            {
                MessageBox.Show("Số tiền cần thanh toán chưa đủ!");
                txtHDTienDua.SelectAll();
                txtHDTienDua.Focus();
                return;
            }
            string makh;
            if(txtHDMaKhach.Text.Length==0)
            {
                makh = null;
            }
            else
            {
                makh = txtHDMaKhach.Text;
            }
            bool kq=HoaDonDAO.Ins.addHD(makh, "DATHANHTOAN");
            if(kq)
            {
                string mahd = HoaDonDAO.Ins.getMaHD();
                if(mahd==null)
                {
                    MessageBox.Show("Lấy mã hóa đơn thất bại!");
                    return;
                }
                for(int i=0;i<dgvHDCTHD.Rows.Count;i++)
                {
                    bool result = HoaDonDAO.Ins.addCTHD(mahd, dgvHDCTHD.Rows[i].Cells[0].Value.ToString(), dgvHDCTHD.Rows[i].Cells[2].Value.ToString(), dgvHDCTHD.Rows[i].Cells[3].Value.ToString());
                    
                }
                MessageBox.Show("Thêm hóa đơn thành công!");
                frmReport frm = new frmReport();
                frm.mahd = int.Parse(mahd);
                frm.Show();
                dgvHDCTHD.Rows.Clear();
                txtHDTienDua.Text = string.Empty;
                txtHDMaKhach.Text = string.Empty;
                //txtHDTongTien.Text = string.Empty;
                txtSPSoLuong.Text = string.Empty;
                txtHDTienThua.Text = string.Empty;
                txtSPTimTenSP.Text = string.Empty;
                ckbHDKHTT.Checked = false;
            }
            else
            {
                MessageBox.Show("Hóa đơn chưa được thêm!\nCó lỗi khi thêm hóa đơn!");
                return;
            }
        }

        private void txtHDTienDua_TextChanged(object sender, EventArgs e)
        {
            if(txtHDTongTien.Text=="0")
            {
                return;
            }
            double kq = double.Parse(txtHDTienDua.Text) - double.Parse(txtHDTongTien.Text);
            txtHDTienThua.Text = kq.ToString();
        }

        //event key press
        private void KeyPressNums(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) /*&& char.IsWhiteSpace(e.KeyChar)*/)
            {
                e.Handled = true;
            }
        }

        private void txtHDTongTien_TextChanged(object sender, EventArgs e)
        {
            if(txtHDTienDua.Text.Length==0)
            {
                return;
            }
            double kq = double.Parse(txtHDTienDua.Text) - double.Parse(txtHDTongTien.Text);
            txtHDTienThua.Text = kq.ToString();
        }

        private void txtKHTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvHDCTHD.Rows.Clear();
            txtHDTienDua.Text = string.Empty;
            txtHDMaKhach.Text = string.Empty;
            //txtHDTongTien.Text = string.Empty;
            txtSPSoLuong.Text = string.Empty;
            txtHDTienThua.Text = string.Empty;
            txtSPTimTenSP.Text = string.Empty;
            ckbHDKHTT.Checked = false;
        }

        private void dgvHDCTHD_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double thanhtien = 0;
            for (int i = 0; i < dgvHDCTHD.Rows.Count; i++)
            {
                thanhtien += double.Parse(dgvHDCTHD.Rows[i].Cells[4].Value.ToString());
            }
            txtHDTongTien.Text = thanhtien.ToString();
        }

        private void dgvHTSP_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvHTSP.SelectedRows.Count>0)
            {
                txtHTTenSP.Text = dgvHTSP.CurrentRow.Cells[1].Value.ToString().Trim();
                txtHTGiaSP.Text = SanPhamDAO.Ins.getGiaSP(dgvHTSP.CurrentRow.Cells[0].Value.ToString().Trim());
                txtHTSL.Text = string.Empty;
                btnHTSua.Enabled = false;
                btnHTXoa.Enabled = false;
            }
        }

        private void dgvCTHT_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvCTHT.SelectedRows.Count>0)
            {
                txtSPTen.Text = dgvCTHT.CurrentRow.Cells[1].Value.ToString().Trim();
                txtHTGiaSP.Text = dgvCTHT.CurrentRow.Cells[3].Value.ToString().Trim();
                txtHTSL.Text = dgvCTHT.CurrentRow.Cells[2].Value.ToString().Trim();
                btnHTSua.Enabled = true;
                btnHTXoa.Enabled = true;
            }
        }

        private void dgvTau_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHTThem_Click(object sender, EventArgs e)
        {
            if(txtHTSL.Text.Length==0)
            {
                MessageBox.Show("Chưa nhập số lượng");
                txtHTSL.Focus();
                return;
            }
            for(int i=0;i<dgvCTHT.Rows.Count;i++)
            {
                if (txtHTTenSP.Text == dgvCTHT.Rows[i].Cells[1].Value.ToString())
                {
                    float sl = float.Parse(txtHTSL.Text) + float.Parse(dgvCTHT.Rows[i].Cells[2].Value.ToString());
                    dgvCTHT.Rows[i].Cells[2].Value = sl.ToString();//cap nhat so luong
                    dgvCTHT.Rows[i].Cells[4].Value = (double)(sl * int.Parse(txtHTGiaSP.Text));//cap nhat thanh tien
                    double thanhtien = 0;
                    for (int j = 0; j < dgvCTHT.Rows.Count; j++)
                    {
                        thanhtien += double.Parse(dgvCTHT.Rows[j].Cells[4].Value.ToString());
                    }
                    txtHTTongSL.Text = thanhtien.ToString();
                    return;
                }
            }

            this.dgvCTHT.Rows.Add(dgvHTSP.CurrentRow.Cells[0].Value.ToString(), txtHTTenSP.Text, txtHTSL.Text, txtHTGiaSP.Text, (double)(int.Parse(txtHTGiaSP.Text) * float.Parse(txtHTSL.Text)));
            double thanhtienHT = 0;
            for (int i = 0; i < dgvCTHT.Rows.Count; i++)
            {
                thanhtienHT += double.Parse(dgvCTHT.Rows[i].Cells[4].Value.ToString());
            }
            txtHTTongSL.Text = thanhtienHT.ToString();

        }

        private void btnHTSua_Click(object sender, EventArgs e)
        {
            if (txtHTSL.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập số lượng!");
                txtHTSL.Focus();
                return;
            }
            dgvCTHT.CurrentRow.Cells[2].Value = txtHTSL.Text;
            dgvCTHT.CurrentRow.Cells[4].Value = double.Parse(txtHTSL.Text) * double.Parse(dgvCTHT.CurrentRow.Cells[3].Value.ToString());
            double thanhtien = 0;
            for (int i = 0; i < dgvCTHT.Rows.Count; i++)
            {
                thanhtien += double.Parse(dgvCTHT.Rows[i].Cells[4].Value.ToString());
            }
            txtHTTongSL.Text = thanhtien.ToString();
            MessageBox.Show("Sửa thành công!");
        }

        private void btnHTXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                dgvCTHT.Rows.Remove(dgvCTHT.CurrentRow);
                double thanhtien = 0;
                for (int i = 0; i < dgvCTHT.Rows.Count; i++)
                {
                    thanhtien += double.Parse(dgvCTHT.Rows[i].Cells[4].Value.ToString());
                }
                txtHTTongSL.Text = thanhtien.ToString();
            }
        }

        private void btnChonTau_Click(object sender, EventArgs e)
        {
            txtHTMaTau.Text = dgvTau.CurrentRow.Cells[0].Value.ToString();

        }

        private void txtTimTau_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvTau.DataSource = TauThuyenDAO.Ins.findTTText(txtTimTau.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dgvCTHT.Rows.Count==0)
            {
                MessageBox.Show("Chưa có sản phẩm!");
                return;
            }
            if(txtHTMaTau.Text.Length==0)
            {
                MessageBox.Show("");
                return;
            }
            if(txtHTDauTieuThu.Text.Length==0||txtHTGiaDau.Text.Length==0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin dầu tiêu thụ");
                return;
            }
            if(dtNgayDi.Value>dtNgayVe.Value)
            {
                MessageBox.Show("Ngày đi phải trước ngày về!");
                return;
            }
            bool kq = HaiTrinhDAO.Ins.addHT(txtHTMaTau.Text, dtNgayDi.Value.ToShortDateString(), dtNgayVe.Value.ToShortDateString(), txtHTGiaDau.Text, txtHTDauTieuThu.Text);
            if(kq)
            {
                string maht = HaiTrinhDAO.Ins.getMaHT();
                if (maht == null)
                {
                    MessageBox.Show("Lấy mã hải trình thất bại!");
                    return;
                }
                for (int i = 0; i < dgvCTHT.Rows.Count; i++)
                {
                    bool result = HaiTrinhDAO.Ins.addCTHT(maht, dgvCTHT.Rows[i].Cells[0].Value.ToString(), dgvCTHT.Rows[i].Cells[2].Value.ToString(), dgvCTHT.Rows[i].Cells[3].Value.ToString());

                }
                MessageBox.Show("Thêm hải trình thành công!");
                txtHTMaTau.Text = string.Empty;
                txtHTDauTieuThu.Text = string.Empty;
                txtHTGiaDau.Text = string.Empty;
                txtHTTongSL.Text = string.Empty;
                txtTimTau.Text = string.Empty;
                txtHTTimSP.Text = string.Empty;
                dgvCTHT.Rows.Clear();
                dtNgayDi.Value = DateTime.Today;
                dtNgayVe.Value = DateTime.Today;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtHTMaTau.Text = string.Empty;
            txtHTDauTieuThu.Text = string.Empty;
            txtHTGiaDau.Text = string.Empty;
            txtHTTongSL.Text = string.Empty;
            txtTimTau.Text = string.Empty;
            txtHTTimSP.Text = string.Empty;
            dgvCTHT.Rows.Clear();
            dtNgayDi.Value = DateTime.Today;
            dtNgayVe.Value = DateTime.Today;
        }

        private void txtHTTimSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvHTSP.DataSource = SanPhamDAO.Ins.findSP(txtHTTimSP.Text);
        }

        private void dgvHDCTHD_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnHDSua.Enabled = true;
            btnHDXoa.Enabled = true;
        }

        private void frmSeller_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                
            }
        }
    }
}
