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
using DoAnNET.POJO;

namespace DoAnNET
{
    public partial class frmManager : Form
    {
        //loadDataSet ldata = new loadDataSet();
        public frmManager()
        {
            InitializeComponent();
            //tapcontrol.TabPages.RemoveByKey("tpNhanVien");//xoa 1 tabpage khoi tab
            //dgvTaiKhoan.DataSource = ldata.getTaiKhoan();
            //dgvNhanVien.DataSource = ldata.getNhanVien();
            //dgvTau.DataSource = ldata.getTauThuyen();
        }
        //xu li tab nhan vien

        //them nhan vien
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if(btnThemNV.Text=="Thêm")
            {
                txtNameNV.Text = string.Empty;
                //txtDOBNV.Text = string.Empty;
                txtAddNV.Text = string.Empty;
                txtPhoneNumsNV.Text = string.Empty;
                txtIDBHXHNV.Text = string.Empty;
                txtMaTauNV.Text = string.Empty;
                txtMaTauNV.Enabled = false;
                btnLuuNV.Enabled = true;
                btnThemNV.Text = "Hủy";
                btnXoaNV.Enabled = false;
                btnSuaNV.Enabled = false;
                dgvNhanVien.Enabled = false;
            }
            else
            {
                btnThemNV.Text = "Thêm";
                btnLuuNV.Enabled = false;
                btnXoaNV.Enabled = false;
                dgvNhanVien.Enabled = true;
                dgvNhanVien.DataSource = NhanVienDAO.Ins.hienThiNV();
            }
            
        }
        //luu nhan vien
        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            if (txtNameNV.Text.Length == 0 || txtAddNV.Text.Length == 0 || txtPhoneNumsNV.Text.Length == 0 || txtIDBHXHNV.Text.Length == 0 )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi lưu!");
                return;
            }
            nhanVien nv = new nhanVien();
            nv.hoten = txtNameNV.Text;
            nv.ngaysinh = dtNgaySinhNV.Value.ToShortDateString();
            nv.diachi = txtAddNV.Text;
            nv.cccd = txtPhoneNumsNV.Text;
            nv.mabhxh = txtIDBHXHNV.Text;
            nv.maloai = cbbLoaiNV.SelectedValue.ToString();
            //MessageBox.Show(nv.ngaysinh + nv.maloai);
            if (MessageBox.Show("Bạn có muốn lưu nhân viên mới?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = NhanVienDAO.Ins.addNV(nv);
                if (kq)
                {

                    MessageBox.Show("Thêm thành công!");
                    btnLuuNV.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại, vui lòng thử lại!");
                }
            }          
        }
        //sua nhan vien
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (txtNameNV.Text.Length == 0 || txtAddNV.Text.Length == 0 || txtPhoneNumsNV.Text.Length == 0 || txtIDBHXHNV.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi sửa!");
                return;
            }
            nhanVien nv = new nhanVien();
            nv.id = int.Parse(dgvNhanVien.CurrentRow.Cells[0].Value.ToString());
            nv.hoten = txtNameNV.Text;
            nv.ngaysinh = dtNgaySinhNV.Value.ToShortDateString();
            nv.diachi = txtAddNV.Text;
            nv.cccd = txtPhoneNumsNV.Text;
            nv.mabhxh = txtIDBHXHNV.Text;
            nv.maloai = cbbLoaiNV.SelectedValue.ToString();
            //MessageBox.Show(nv.maloai);
            if (MessageBox.Show("Bạn có muốn lưu lại thay đổi?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = NhanVienDAO.Ins.updateNV(nv);
                if (kq)
                {

                    MessageBox.Show("Sửa thành công!");
                    dgvNhanVien.DataSource = NhanVienDAO.Ins.hienThiNV();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại, vui lòng thử lại!");
                }
            }
        }
        //xoa nhan vien
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if(txtMaTauNV!=null&&dgvNhanVien.CurrentRow.Cells[5].Value.ToString()=="Thuyền trưởng")
            {
                MessageBox.Show("Bạn không thể xóa thuyền trưởng đang quản lí thuyền");
                return;
            }
            nhanVien nv = new nhanVien();
            nv.id = int.Parse(dgvNhanVien.CurrentRow.Cells[0].Value.ToString());
            //MessageBox.Show(nv.id.ToString());
            //return;
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = NhanVienDAO.Ins.deleteNV(nv);
                if (kq)
                {

                    MessageBox.Show("Xóa thành công!");
                    dgvNhanVien.DataSource = NhanVienDAO.Ins.hienThiNV();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại, vui lòng thử lại!");
                }
            }
        }
        //tim kiem nhan vien
        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            DataTable tbl = NhanVienDAO.Ins.timNV(txtTimKiemNV.Text);
            dgvNhanVien.DataSource = tbl;
        }
        //end xu li tab nhan vien

        

        private void frmtest_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'qLTAUDataSet.HAITRINH' table. You can move, or remove it, as needed.
            //this.hAITRINHTableAdapter.Fill(this.qLTAUDataSet.HAITRINH);
            //// TODO: This line of code loads data into the 'qLTAUDataSet.TAIKHOAN' table. You can move, or remove it, as needed.
            //this.tAIKHOANTableAdapter.Fill(this.qLTAUDataSet.TAIKHOAN);
            //// TODO: This line of code loads data into the 'qLTAUDataSet.TAUTHUYEN' table. You can move, or remove it, as needed.
            //this.tAUTHUYENTableAdapter.Fill(this.qLTAUDataSet.TAUTHUYEN);
            //// TODO: This line of code loads data into the 'qLTAUDataSet.sanpham' table. You can move, or remove it, as needed.
            //this.sanphamTableAdapter.Fill(this.qLTAUDataSet.sanpham);
            //// TODO: This line of code loads data into the 'qLTAUDataSet.LOAINV' table. You can move, or remove it, as needed.
            //this.lOAINVTableAdapter.Fill(this.qLTAUDataSet.LOAINV);
            //// TODO: This line of code loads data into the 'qLTAUDataSet.khachhang' table. You can move, or remove it, as needed.
            //this.khachhangTableAdapter.Fill(this.qLTAUDataSet.khachhang);
            //// TODO: This line of code loads data into the 'qLTAUDataSet.HOADON' table. You can move, or remove it, as needed.
            //this.hOADONTableAdapter.Fill(this.qLTAUDataSet.HOADON);
            //// TODO: This line of code loads data into the 'qLTAUDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            ////this.nHANVIENTableAdapter.Fill(this.qLTAUDataSet.NHANVIEN);
            dgvNhanVien.DataSource = NhanVienDAO.Ins.hienThiNV();
            cbbLoaiNV.DataSource = NhanVienDAO.Ins.getLoaiNV();
            cbbLoaiNV.DisplayMember = "tenloai";
            cbbLoaiNV.ValueMember = "maloai";
            //tab tau thuyen
            dgvTau.DataSource = TauThuyenDAO.Ins.showTT();
            dgvSanPham.DataSource = SanPhamDAO.Ins.showSP();
            dgvTaiKhoan.DataSource = taiKhoanDAO.Ins.showTK();
            dgvHoaDon.DataSource = HoaDonDAO.Ins.showHD();
            dgvHaiTrinh.DataSource = HaiTrinhDAO.Ins.showHT();
            dgvKhachHang.DataSource = KhachHangDAO.Ins.showKH();
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                txtNameNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString().Trim();
                //txtDOBNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtAddNV.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString().Trim();
                txtIDBHXHNV.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString().Trim();
                cbbLoaiNV.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString().Trim();
                txtMaTauNV.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString().Trim();
                txtPhoneNumsNV.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString().Trim();
                dtNgaySinhNV.Value = (DateTime)dgvNhanVien.CurrentRow.Cells[2].Value;
                btnSuaNV.Enabled = true;
            }
            else
            {
                btnSuaNV.Enabled = false;
            }
            
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel17_Paint(object sender, PaintEventArgs e)
        {

        }

        

        //event key press
        private void KeyPressNums(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) /*&& char.IsWhiteSpace(e.KeyChar)*/)
            {
                e.Handled = true;
            }
        }

        //xu li tab tau thuyen

        private void dgvTau_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTau.SelectedRows.Count > 0)
                {
                    //load txt
                    txtSoTau.Text = dgvTau.CurrentRow.Cells[0].Value.ToString().Trim();
                    cbbLoaiTauTT.Text = dgvTau.CurrentRow.Cells[1].Value.ToString().Trim();
                    txtThuyenTruong.Text = dgvTau.CurrentRow.Cells[2].Value.ToString().Trim();
                    //load dgvThuyenVien
                    dgvThuyenVien.DataSource = NhanVienDAO.Ins.getNVbyTau(txtSoTau.Text);
                }
            }
            catch { }
        }

        private void btnThemThuyenVien_Click(object sender, EventArgs e)
        {
            if (btnThemThuyenVien.Text != "Hủy")
            {
                dgvTau.Enabled = false;
                dgvThuyenVien.DataSource = NhanVienDAO.Ins.getNVFree();
                btnChonThemTVTT.Visible = true;
                btnThemThuyenVien.Text = "Hủy";
                btnDoiTT.Enabled = false;
               
                if(NhanVienDAO.Ins.getNumsTV(txtSoTau.Text)>4)
                {
                    btnChonThemTVTT.Enabled = false;
                }
            }
            else
            {
                btnDoiTT.Enabled = true;
                btnThemThuyenVien.Text = "Thêm thuyền viên";
                dgvTau.Enabled = true;
                btnChonThemTVTT.Enabled = true;
                btnChonThemTVTT.Visible = false;
                dgvThuyenVien.DataSource = NhanVienDAO.Ins.getNVbyTau(txtSoTau.Text);
            }
        }

        private void btnChonThemTVTT_Click(object sender, EventArgs e)
        {
            if(dgvThuyenVien.SelectedRows.Count==0)
            {
                MessageBox.Show("Không có thuyền viên hợp lệ để thêm!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm thuyền viên này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = NhanVienDAO.Ins.updateTTTV(dgvThuyenVien.CurrentRow.Cells[0].Value.ToString(), txtSoTau.Text);
                if(kq)
                {
                    MessageBox.Show("Thêm thuyền viên thành công!");
                    //sau them kiem tra xem so tv da max chua
                    if (NhanVienDAO.Ins.getNumsTV(txtSoTau.Text) > 4)
                    {
                        btnChonThemTVTT.Enabled = false;
                    }
                    dgvThuyenVien.DataSource = NhanVienDAO.Ins.getNVFree();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
        }

        private void btnDoiTT_Click(object sender, EventArgs e)
        {
            if(btnDoiTT.Text!="Hủy")
            {
                btnThemThuyenVien.Enabled = false;
                btnDoiTT.Text = "Hủy";
                btnChonTT.Visible = true;
                dgvTau.Enabled = false;
                dgvThuyenVien.DataSource = NhanVienDAO.Ins.getTTFree();
                
            }
            else
            {
                btnThemThuyenVien.Enabled = true;
                btnDoiTT.Text = "Đổi thuyền trưởng";
                btnChonTT.Visible = false;
                dgvTau.Enabled = true;
                dgvThuyenVien.DataSource = NhanVienDAO.Ins.getNVbyTau(txtSoTau.Text);
            }
        }

        private void btnChonTT_Click(object sender, EventArgs e)
        {
            if (dgvThuyenVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có thuyền trưởng hợp lệ để thêm!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn thay đổi thuyền trưởng?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = TauThuyenDAO.Ins.changeTT(txtSoTau.Text, dgvThuyenVien.CurrentRow.Cells[0].Value.ToString());
                if(kq)
                {
                    MessageBox.Show("Đổi thuyền trưởng thành công!");
                    //cap nhat lai danh sach tt trong
                    dgvThuyenVien.DataSource = NhanVienDAO.Ins.getTTFree();
                    dgvTau.DataSource = TauThuyenDAO.Ins.showTT();
                    btnThemThuyenVien.Enabled = true;
                    btnDoiTT.Text = "Đổi thuyền trưởng";
                    btnChonTT.Visible = false;
                    dgvTau.Enabled = true;
                    dgvThuyenVien.DataSource = NhanVienDAO.Ins.getNVbyTau(txtSoTau.Text);
                }
                else
                {
                    MessageBox.Show("Thay đổi thất bại!");
                }
            }
        }

        private void btnThemTT_Click(object sender, EventArgs e)
        {
            if (btnThemTT.Text == "Hủy")
            {
                btnThemTT.Text = "Thêm";
                btnLuuTT.Enabled = false;
                txtSoTau.Enabled = false;
                txtSoTau.Text = dgvTau.CurrentRow.Cells[0].Value.ToString().Trim();
                cbbLoaiTauTT.Text = dgvTau.CurrentRow.Cells[1].Value.ToString().Trim();
                txtThuyenTruong.Text = dgvTau.CurrentRow.Cells[2].Value.ToString().Trim();
                //load dgvThuyenVien
                dgvThuyenVien.DataSource = NhanVienDAO.Ins.getNVbyTau(txtSoTau.Text);
                dgvNhanVien.Enabled = true;
                dgvTau.Enabled = true;
            }
            else
            {
                txtSoTau.Text = string.Empty;
                txtSoTau.Enabled = true;
                txtThuyenTruong.Text = string.Empty;
                btnLuuTT.Enabled = true;
                
                btnThemTT.Text = "Hủy";
                dgvTau.Enabled = false;
                dgvNhanVien.Enabled = false;
            }
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            if(txtSoTau.Text.Length==0)
            {
                MessageBox.Show("Vui lòng nhập mã tàu!");
                txtSoTau.Focus();
                return;
            }
            if(TauThuyenDAO.Ins.findTT(txtSoTau.Text.Trim())==0)
            {
                MessageBox.Show("Số tàu đã tồn tại!");
                txtSoTau.Focus();
                return;
            }
            if(TauThuyenDAO.Ins.findTT(txtSoTau.Text)==2)
            {
                MessageBox.Show("Lỗi truy vấn CSDL! (1) ");
                return;
            }

            bool kq=TauThuyenDAO.Ins.addTT(txtSoTau.Text, cbbLoaiTauTT.Text);
            if(kq)
            {
                MessageBox.Show("Thêm thành công!");
                btnThemTT.Text = "Thêm";
                btnLuuTT.Enabled = false;
                txtSoTau.Enabled = false;
                txtSoTau.Text = dgvTau.CurrentRow.Cells[0].Value.ToString().Trim();
                cbbLoaiTauTT.Text = dgvTau.CurrentRow.Cells[1].Value.ToString().Trim();
                txtThuyenTruong.Text = dgvTau.CurrentRow.Cells[2].Value.ToString().Trim();
                //load dgvThuyenVien
                dgvThuyenVien.DataSource = NhanVienDAO.Ins.getNVbyTau(txtSoTau.Text);
                dgvNhanVien.Enabled = true;
                dgvTau.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm!");
            }
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            bool kq = TauThuyenDAO.Ins.editTT(txtSoTau.Text, cbbLoaiTauTT.Text);
            if (kq)
            {
                MessageBox.Show("Sửa thành công!");
                dgvTau.DataSource = TauThuyenDAO.Ins.showTT();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        //tab san pham

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                //load txt
                txtTenSPHH.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString().Trim();
                txtSLHH.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString().Trim();
                cbbDVTHH.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString().Trim();
                dgvGia.DataSource = SanPhamDAO.Ins.showGia(dgvSanPham.CurrentRow.Cells[0].Value.ToString().Trim());
                if (SanPhamDAO.Ins.checkGiaSP(DateTime.Now.ToShortDateString(), dgvSanPham.CurrentRow.Cells[0].Value.ToString()))
                {
                    btnCapNhatGiaSP.Enabled = false;
                }
                else
                {
                    btnCapNhatGiaSP.Enabled = true;
                }
            }
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = SanPhamDAO.Ins.findSP(txtTenSPHH.Text);
        }

        private void dgvGia_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGia.SelectedRows.Count > 0)
            {
                txtGiaSP.Text = dgvGia.CurrentRow.Cells[0].Value.ToString().Trim();
                dtNgayCNGiaSP.Value = (DateTime)dgvGia.CurrentRow.Cells[1].Value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThemSP.Text=="Hủy")
            {
                btnThemSP.Text = "Thêm";
                btnTimSP.Enabled = true;
                dgvSanPham.Enabled = true;
                btnLuuSP.Enabled = false;
                txtTenSPHH.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString().Trim();
                txtSLHH.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString().Trim();
                cbbDVTHH.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString().Trim();
                dgvGia.DataSource = SanPhamDAO.Ins.showGia(dgvSanPham.CurrentRow.Cells[0].Value.ToString().Trim());
                if (SanPhamDAO.Ins.checkGiaSP(DateTime.Now.ToShortDateString(), dgvSanPham.CurrentRow.Cells[0].Value.ToString()))
                {
                    btnCapNhatGiaSP.Enabled = false;
                }
                else
                {
                    btnCapNhatGiaSP.Enabled = true;
                }
                btnCapNhatGiaSP.Enabled = true;
                btnSuaGiaSP.Enabled = true;
                btnLuuGiaSP.Enabled = true;
            }
            else
            {
                btnThemSP.Text = "Hủy";
                btnTimSP.Enabled = false;
                btnLuuSP.Enabled = true;
                dgvSanPham.Enabled = false;
                txtTenSPHH.Text = string.Empty;
                txtSLHH.Text = "0";
                txtGiaSP.Text = string.Empty;
                btnCapNhatGiaSP.Enabled = false;
                btnSuaGiaSP.Enabled = false;
                btnLuuGiaSP.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenSPHH.Text.Length==0||txtGiaSP.Text.Length==0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                return;
            }
            bool kq = SanPhamDAO.Ins.addSP(txtTenSPHH.Text, cbbDVTHH.Text);

            if(kq)
            {
                string id = SanPhamDAO.Ins.getIDSP();
                if(id==null)
                {
                    MessageBox.Show("Lấy mã thất bại!");
                    return;
                }
                bool kq2 = SanPhamDAO.Ins.addGiaSP(txtGiaSP.Text, dtNgayCNGiaSP.Value.ToShortDateString(), id);
                if (kq2)
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
                dgvSanPham.DataSource = SanPhamDAO.Ins.showSP();
                btnThemSP.Text = "Thêm";
                btnTimSP.Enabled = true;
                dgvSanPham.Enabled = true;
                btnLuuSP.Enabled = false;
                txtTenSPHH.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString().Trim();
                txtSLHH.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString().Trim();
                cbbDVTHH.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString().Trim();
                dgvGia.DataSource = SanPhamDAO.Ins.showGia(dgvSanPham.CurrentRow.Cells[0].Value.ToString().Trim());
                if (SanPhamDAO.Ins.checkGiaSP(DateTime.Now.ToShortDateString(), dgvSanPham.CurrentRow.Cells[0].Value.ToString()))
                {
                    btnCapNhatGiaSP.Enabled = false;
                }
                else
                {
                    btnCapNhatGiaSP.Enabled = true;
                }
                btnCapNhatGiaSP.Enabled = true;
                btnSuaGiaSP.Enabled = true;
                btnLuuGiaSP.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }

        }

        private void btnCapNhatGiaSP_Click(object sender, EventArgs e)
        {
            if(btnCapNhatGiaSP.Text=="Hủy")
            {
                dgvSanPham.Enabled = true;
                btnCapNhatGiaSP.Text = "Cập nhật giá";
                btnLuuGiaSP.Enabled = false;
                btnSuaGiaSP.Enabled = true;
            }
            else
            {
                if (SanPhamDAO.Ins.checkGiaSP(dtNgayCNGiaSP.Value.ToShortDateString(), dgvSanPham.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("");
                }
                btnCapNhatGiaSP.Text = "Hủy";
                dgvSanPham.Enabled = false;
                btnLuuGiaSP.Enabled = true;
                btnSuaGiaSP.Enabled = false;
                txtGiaSP.Text = string.Empty;
                txtGiaSP.Focus();
                dtNgayCNGiaSP.Value = DateTime.Now;
                
            }
        }

        private void btnSuaGiaSP_Click(object sender, EventArgs e)
        {
            if(btnSuaGiaSP.Text=="Hủy")
            {
                btnSuaGiaSP.Text = "Sửa";
                dgvSanPham.Enabled = true;
                btnCapNhatGiaSP.Enabled = true;
                btnLuuGiaSP.Enabled = false;
            }
            else
            {
                btnSuaGiaSP.Text = "Hủy";
                dgvSanPham.Enabled = false;
                btnCapNhatGiaSP.Enabled = false;
                btnLuuGiaSP.Enabled = true;
                txtGiaSP.SelectAll();
                txtGiaSP.Focus();

            }
        }

        private void btnLuuGiaSP_Click(object sender, EventArgs e)
        {
            if(txtGiaSP.Text.Length==0)
            {
                MessageBox.Show("Vui lòng nhập giá!");
                txtGiaSP.Focus();
                return;
            }
            if(btnSuaGiaSP.Enabled)
            {
                bool kq = SanPhamDAO.Ins.editGiaSP(txtGiaSP.Text, dtNgayCNGiaSP.Value.ToShortDateString(), dgvSanPham.CurrentRow.Cells[0].Value.ToString());
                if (kq)
                {
                    MessageBox.Show("Sửa giá thành công!");
                    btnLuuGiaSP.Enabled = false;
                    btnSuaGiaSP.Text = "Sửa";
                    btnCapNhatGiaSP.Enabled = true;
                    dgvSanPham.Enabled = true;
                    dgvGia.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sửa giá thất bại!");
                }
            }
            if(btnCapNhatGiaSP.Enabled)
            {
                bool kq = SanPhamDAO.Ins.addGiaSP(txtGiaSP.Text, dtNgayCNGiaSP.Value.ToShortDateString(), dgvSanPham.CurrentRow.Cells[0].Value.ToString());
                if(kq)
                {
                    MessageBox.Show("Cập nhật giá thành công!");
                    btnLuuGiaSP.Enabled = false;
                    btnCapNhatGiaSP.Text = "Cập nhật giá";
                    btnSuaGiaSP.Enabled = true;
                    dgvSanPham.Enabled = true;
                    dgvGia.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cập nhật giá thất bại!");
                }
            }
        }


        //tab tai khoan

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvTaiKhoan.SelectedRows.Count>0)
            {
                txtTenDNTK.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString();
                txtTenNVTK.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            dgvNhanVienChuaTK.Visible = true;
            tblpLuuTK.Visible = true;
            dgvNhanVienChuaTK.DataSource = taiKhoanDAO.Ins.showNVChuaTK();
            btnDoiMK.Enabled = false;
            btnXoaTK.Enabled = false;
            btnThemTK.Enabled = false;
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = taiKhoanDAO.Ins.delTK(txtTenDNTK.Text);
                if(kq)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvTaiKhoan.DataSource = taiKhoanDAO.Ins.showTK();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if(btnDoiMK.Text=="Hủy")
            {
                btnDoiMK.Text = "Đổi mật khẩu";
                dgvTaiKhoan.Enabled = true;
                btnThemTK.Enabled = true;
                btnXoaTK.Enabled = false;
                tblpDoiMKTK.Visible = false;
                return;
            }
            btnDoiMK.Text = "Hủy";
            dgvTaiKhoan.Enabled = false;
            tblpDoiMKTK.Visible = true;
            btnThemTK.Enabled = false;
            btnXoaTK.Enabled = false;
        }

        private void btnLuuMKTK_Click(object sender, EventArgs e)
        {
            if(txtNhapMKTK.Text.Length==0||txtNhapLaiMKTK.Text.Length==0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if(txtNhapLaiMKTK.Text!=txtNhapMKTK.Text)
            {
                MessageBox.Show("Mật khẩu chưa chính xác!");
                txtNhapMKTK.SelectAll();
                txtNhapMKTK.Focus();
                return;
            }
            bool kq = taiKhoanDAO.Ins.editMKTK(txtTenDNTK.Text, txtNhapMKTK.Text);
            if(kq)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                btnDoiMK.Text = "Đổi mật khẩu";
                dgvTaiKhoan.Enabled = true;
                btnThemTK.Enabled = true;
                btnXoaTK.Enabled = false;
                tblpDoiMKTK.Visible = false;
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!");

            }
        }

        private void btnTimKiemTK_Click(object sender, EventArgs e)
        {
            if(btnTimKiemTK.Text=="Hủy")
            {
                dgvTaiKhoan.DataSource = taiKhoanDAO.Ins.showTK();
                btnTimKiemTK.Text = "Tìm kiếm";
                txtTimKiemTK.Text = string.Empty;
                return;
            }
            btnTimKiemTK.Text = "Hủy";
            dgvTaiKhoan.DataSource = taiKhoanDAO.Ins.findTK(txtTimKiemTK.Text);
        }

        private void btnHuyNewTK_Click(object sender, EventArgs e)
        {
            dgvNhanVienChuaTK.Visible = false;
            tblpLuuTK.Visible = false;
            btnXoaTK.Enabled = true;
            btnDoiMK.Enabled = true;
            btnThemTK.Enabled = true;
        }

        private void dgvNhanVienChuaTK_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvNhanVienChuaTK.SelectedRows.Count>0)
            {
                txtNewTenNV.Text = dgvNhanVienChuaTK.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnLuuNewTK_Click(object sender, EventArgs e)
        {
            if(txtTenTKNewTK.Text.Length==0||txtMKNewTK.Text.Length==0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if(taiKhoanDAO.Ins.checkTenTK(txtTenTKNewTK.Text)==false)
            {
                MessageBox.Show("Tên đăng nhập trùng!");
                txtTenTKNewTK.Focus();
                return;
            }
            bool kq = taiKhoanDAO.Ins.addTK(dgvNhanVienChuaTK.CurrentRow.Cells[0].Value.ToString(), txtTenTKNewTK.Text, txtMKNewTK.Text);
            if(kq)
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                dgvNhanVienChuaTK.DataSource = taiKhoanDAO.Ins.showNVChuaTK();
                dgvTaiKhoan.DataSource = taiKhoanDAO.Ins.showTK();
                txtTenTKNewTK.Text = string.Empty;
                txtMKNewTK.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!");
            }
        }


        //tab hoa don
        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvHoaDon.SelectedRows.Count>0)
            {
                txtNameKHHD.Text = dgvHoaDon.CurrentRow.Cells[1].Value.ToString().Trim();
                txtTongTienHD.Text = dgvHoaDon.CurrentRow.Cells[2].Value.ToString().Trim();
                dtNgayLapHD.Value = (DateTime)dgvHoaDon.CurrentRow.Cells[3].Value;
                txtTinhTrangHD.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString().Trim();
                dgvCTHoaDon.DataSource = HoaDonDAO.Ins.showCTHD(dgvHoaDon.CurrentRow.Cells[0].Value.ToString().Trim());
            }
        }

        private void dgvCTHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvCTHoaDon.SelectedRows.Count>0)
            {
                txtTenSPCTHD.Text = dgvCTHoaDon.CurrentRow.Cells[0].Value.ToString().Trim();
                txtSLCTHD.Text = dgvCTHoaDon.CurrentRow.Cells[1].Value.ToString().Trim();
                txtGiaCTHD.Text = dgvCTHoaDon.CurrentRow.Cells[2].Value.ToString().Trim();
                txtThanhTienCTHD.Text = dgvCTHoaDon.CurrentRow.Cells[3].Value.ToString().Trim();
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if(txtTinhTrangHD.Text.Length==0)
            {
                MessageBox.Show("Vui lòng nhập trạng thái hóa đơn!");
                txtTinhTrangHD.Focus();
                return;
            }
            bool kq = HoaDonDAO.Ins.editHD(dgvCTHoaDon.CurrentRow.Cells[0].Value.ToString(), txtTinhTrangHD.Text);
            if(kq)
            {
                MessageBox.Show("Cập nhật thành công!");

            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnSuaCTHD_Click(object sender, EventArgs e)
        {
            //if(btnSuaCTHD.Text=="Hủy")
            //{
            //    btnSuaCTHD.Text = "Sửa";
            //    dgvHoaDon.Enabled = true;
            //    dgvCTHoaDon.Enabled = true;
            //    btnLuuCTHD.Enabled = false;
            //    return;
            //}
            //btnSuaCTHD.Text = "Hủy";
            //dgvHoaDon.Enabled = false;
            //dgvCTHoaDon.Enabled = false;
            //btnLuuCTHD.Enabled = true;
        }

        private void dgvHaiTrinh_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvCTHaiTrinh_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (btnThemKH.Text == "Hủy")
            {
                btnThemKH.Text = "Thêm";
                btnLuuKH.Enabled = false;
                dgvKhachHang.Enabled = true;
                if (dgvKhachHang.SelectedRows.Count > 0)
                {
                    txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString().Trim();
                    txtSDTKH.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString().Trim();
                    txtMSTKH.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString().Trim();
                    txtDiaChiKH.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString().Trim();
                    txtLoaiKH.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString().Trim();
                }
                return;
            }
            btnThemKH.Text = "Hủy";
            dgvKhachHang.Enabled = false;
            txtTenKH.Text = string.Empty;
            txtSDTKH.Text = string.Empty;
            txtMSTKH.Text = string.Empty;
            txtDiaChiKH.Text = string.Empty;
            txtLoaiKH.Text = string.Empty;
            btnLuuKH.Enabled = true;
            txtTenKH.Focus();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {

            frmReport frm = new frmReport();
            frm.mahd = int.Parse(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());

            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.mahd = int.Parse(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
            frm.Show();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(btnHDTimKiem.Text=="Hủy")
            {
                btnHDTimKiem.Text = "Tìm kiếm";
                txtHDTimKiem.Text = string.Empty;
                dgvHoaDon.DataSource = HoaDonDAO.Ins.showHD();
                return;
            }
            btnHDTimKiem.Text = "Hủy";
            dgvHoaDon.DataSource = HoaDonDAO.Ins.findHD(txtHDTimKiem.Text);
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            if (btnTimKH.Text == "Hủy")
            {
                btnTimKH.Text = "Tìm kiếm";
                txtTimKiemKH.Text = string.Empty;
                dgvKhachHang.DataSource = KhachHangDAO.Ins.showKH();
                return;
            }
            btnTimKH.Text = "Hủy";
            dgvKhachHang.DataSource = KhachHangDAO.Ins.findKH(txtTimKiemKH.Text);
        }

        private void btnLuuCTHD_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnHTTimKiem.Text == "Hủy")
            {
                btnHTTimKiem.Text = "Tìm kiếm";
                txtHTTimKiem.Text = string.Empty;
                dgvHaiTrinh.DataSource = HaiTrinhDAO.Ins.showHT();
                return;
            }
            btnHTTimKiem.Text = "Hủy";
            dgvHaiTrinh.DataSource = HaiTrinhDAO.Ins.findHT(txtHTTimKiem.Text);
        }

        private void dgvHaiTrinh_SelectionChanged_1(object sender, EventArgs e)
        {
            if(dgvHaiTrinh.SelectedRows.Count>0)
            {
                txtMaTauHT.Text = dgvHaiTrinh.CurrentRow.Cells[1].Value.ToString().Trim();
                txtNgayDiHT.Text = dgvHaiTrinh.CurrentRow.Cells[2].Value.ToString().Trim();
                txtNgayVeHT.Text = dgvHaiTrinh.CurrentRow.Cells[3].Value.ToString().Trim();
                txtTongSLHT.Text = dgvHaiTrinh.CurrentRow.Cells[4].Value.ToString().Trim();
                txtDoanhThuHT.Text = dgvHaiTrinh.CurrentRow.Cells[5].Value.ToString().Trim();
                txtDauHT.Text = dgvHaiTrinh.CurrentRow.Cells[6].Value.ToString().Trim();
                txtGiaDauHT.Text = dgvHaiTrinh.CurrentRow.Cells[7].Value.ToString().Trim();
                dgvCTHaiTrinh.DataSource = HaiTrinhDAO.Ins.showCTHT(dgvHaiTrinh.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void dgvCTHaiTrinh_SelectionChanged_1(object sender, EventArgs e)
        {
            if(dgvCTHaiTrinh.SelectedRows.Count>0)
            {
                txtTenSPHT.Text = dgvCTHaiTrinh.CurrentRow.Cells[1].Value.ToString().Trim();
                txtDonGiaHT.Text = dgvCTHaiTrinh.CurrentRow.Cells[2].Value.ToString().Trim();
                txtSLHT.Text = dgvCTHaiTrinh.CurrentRow.Cells[2].Value.ToString().Trim(); ;
                txtThanhTienHT.Text = dgvCTHaiTrinh.CurrentRow.Cells[2].Value.ToString().Trim();
            }
        }

        private void btnThemKH_Click_1(object sender, EventArgs e)
        {
            if(btnThemKH.Text=="Hủy")
            {
                btnThemKH.Text = "Thêm";
                dgvKhachHang.Enabled = true;
                btnLuuKH.Enabled = false;
                btnSuaKH.Enabled = true;
                btnXoaKH.Enabled = true;
                if (dgvKhachHang.SelectedRows.Count > 0)
                {
                    txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString().Trim();
                    txtSDTKH.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString().Trim();
                    txtMSTKH.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString().Trim();
                    txtDiaChiKH.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString().Trim();
                    txtLoaiKH.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString().Trim();
                }
                return;

            }
            btnThemKH.Text = "Hủy";
            txtTenKH.Text = string.Empty;
            txtSDTKH.Text = string.Empty;
            txtMSTKH.Text = string.Empty;
            txtDiaChiKH.Text = string.Empty;
            txtLoaiKH.Text = string.Empty;
            dgvKhachHang.Enabled = false;
            btnLuuKH.Enabled = true;
            btnSuaKH.Enabled = false;
            btnXoaKH.Enabled = false;

        }

        private void btnLuuKH_Click_1(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Length == 0 || txtDiaChiKH.Text.Length == 0 || txtSDTKH.Text.Length == 0 || txtMSTKH.Text.Length == 0 || txtLoaiKH.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi lưu!");
                return;
            }
            khachHang kh = new khachHang();
            kh.hoten = txtTenKH.Text;
            kh.sdt = txtSDTKH.Text;
            kh.diachi = txtDiaChiKH.Text;
            kh.masothue = txtMSTKH.Text;
            kh.loaikh = txtLoaiKH.Text;
            //MessageBox.Show(nv.ngaysinh + nv.maloai);
            if (MessageBox.Show("Bạn có muốn lưu khách hàng mới?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = KhachHangDAO.Ins.addKH(kh);
                if (kq)
                {
                    MessageBox.Show("Thêm thành công!");
                    btnLuuKH.Enabled = false;
                    dgvKhachHang.Enabled = true;
                    dgvKhachHang.DataSource = KhachHangDAO.Ins.showKH();

                }
                else
                {
                    MessageBox.Show("Thêm thất bại, vui lòng thử lại!");
                }
            }
        }

        private void btnSuaKH_Click_1(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Length == 0 || txtDiaChiKH.Text.Length == 0 || txtSDTKH.Text.Length == 0 || txtMSTKH.Text.Length == 0/* || txtLoaiKH.Text.Length == 0*/)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi sửa!");
                return;
            }
            khachHang kh = new khachHang();
            kh.id = int.Parse(dgvKhachHang.CurrentRow.Cells[0].Value.ToString());
            kh.hoten = txtTenKH.Text;
            kh.sdt = txtSDTKH.Text;
            kh.diachi = txtDiaChiKH.Text;
            kh.masothue = txtMSTKH.Text;
            kh.loaikh = txtLoaiKH.Text;
            //MessageBox.Show(nv.maloai);
            if (MessageBox.Show("Bạn có muốn lưu lại thay đổi?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = KhachHangDAO.Ins.updateKH(kh);
                if (kq)
                {

                    MessageBox.Show("Sửa thành công!");
                    dgvKhachHang.DataSource = KhachHangDAO.Ins.showKH();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại, vui lòng thử lại!");
                }
            }
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvKhachHang.SelectedRows.Count>0)
            {
                txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString().Trim();
                txtSDTKH.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString().Trim();
                txtMSTKH.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString().Trim();
                txtDiaChiKH.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString().Trim();
                txtLoaiKH.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString().Trim();
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            //if (txtMaTauNV != null && dgvNhanVien.CurrentRow.Cells[5].Value.ToString() == "Thuyền trưởng")
            //{
            //    MessageBox.Show("Bạn không thể xóa thuyền trưởng đang quản lí thuyền");
            //    return;
            //}
            khachHang kh = new khachHang();
            kh.id = int.Parse(dgvKhachHang.CurrentRow.Cells[0].Value.ToString());
            //MessageBox.Show(nv.id.ToString());
            //return;
            if (MessageBox.Show("Bạn có muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = KhachHangDAO.Ins.deleteKH(kh);
                if (kq)
                {

                    MessageBox.Show("Xóa thành công!");
                    dgvKhachHang.DataSource = KhachHangDAO.Ins.showKH();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại, vui lòng thử lại!");
                }
            }
        }

        private void frmtest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
               
            }    
        }

        private void btnXoaTVTT_Click(object sender, EventArgs e)
        {
            if(dgvThuyenVien.Rows.Count==0)
            {
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa thuyền viên này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if(dgvThuyenVien.CurrentRow.Cells[1].Value.ToString().Trim()=="TT")                
                {
                    bool kq1 = NhanVienDAO.Ins.delTT((dgvTau.CurrentRow.Cells[0].Value.ToString()));
                    if (kq1)
                    {
                        dgvThuyenVien.DataSource = NhanVienDAO.Ins.getNVbyTau(txtSoTau.Text);
                        dgvTau.CurrentRow.Cells[2].Value = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                    return;
                }
                bool kq = NhanVienDAO.Ins.delMaTauNV((dgvThuyenVien.CurrentRow.Cells[0].Value.ToString()));
                if(kq)
                {
                    dgvThuyenVien.DataSource= NhanVienDAO.Ins.getNVbyTau(txtSoTau.Text);
                    
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void tapcontrol_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tapcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = NhanVienDAO.Ins.hienThiNV();
            cbbLoaiNV.DataSource = NhanVienDAO.Ins.getLoaiNV();
            cbbLoaiNV.DisplayMember = "tenloai";
            cbbLoaiNV.ValueMember = "maloai";
            //tab tau thuyen
            dgvTau.DataSource = TauThuyenDAO.Ins.showTT();
            dgvSanPham.DataSource = SanPhamDAO.Ins.showSP();
            dgvTaiKhoan.DataSource = taiKhoanDAO.Ins.showTK();
            dgvHoaDon.DataSource = HoaDonDAO.Ins.showHD();
            dgvHaiTrinh.DataSource = HaiTrinhDAO.Ins.showHT();
            dgvKhachHang.DataSource = KhachHangDAO.Ins.showKH();
        }
    }
}
