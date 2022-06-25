using AventStack.ExtentReports.Gherkin.Model;
using MongoDB.Bson.Serialization.Serializers;
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
    public partial class mobilestore : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();

        public mobilestore()
        {
            InitializeComponent();
        }

        private void mobilestore_Load(object sender, EventArgs e)
        {
            textBoxManHinh.Enabled = false;
            textBoxCameraSau.Enabled = false;
            textBoxCameraTruoc.Enabled = false;
            textBoxRam.Enabled = false;
            textBoxRom.Enabled = false;
            textBoxPin.Enabled = false;
            textBoxMaHang.Enabled = false;
            textBoxHDH.Enabled = false;

            var ds = db.SANPHAMs.Select(t => t);
            dataGridViewDienThoai.DataSource = ds;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewDienThoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int maHang = int.Parse(dataGridViewDienThoai.CurrentRow.Cells[0].Value.ToString());
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

        private void paneltitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimDienThoai_TextChanged(object sender, EventArgs e)
        {

            var dt = db.SANPHAMs.Where(t => t.TenHang.Contains(txtTimDienThoai.Text));
            if (dt == null)
                dataGridViewDienThoai.DataSource = db.SANPHAMs.Select(t => t);
            else
                dataGridViewDienThoai.DataSource = dt;
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            FormLienHe lh = new FormLienHe();
            lh.ShowDialog();
        }
    }
}
