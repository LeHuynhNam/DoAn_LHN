using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class KhongChuaKyTuDacBiet : TextBox
    {
        ErrorProvider err = new ErrorProvider();
        public KhongChuaKyTuDacBiet()
        {
            InitializeComponent();
            this.Leave += KhongChuaKyTuDacBiet_Leave;
        }

        private void KhongChuaKyTuDacBiet_Leave(object sender, EventArgs e)
        {
            err.Clear();
            //if (this.Text.Any(c => char.IsSymbol(c)))

            err.SetError(this, "tên đăng nhập không chứa ký tự đặc biệt");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
