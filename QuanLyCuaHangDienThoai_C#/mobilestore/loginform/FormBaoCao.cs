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
//using System.Web;
//using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting;
using DTO;

namespace loginform
{
    public partial class FormBaoCao : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            this.chart1.Series.Clear();
            this.chart1.Titles.Clear();

            this.chart1.Titles.Add("Số lượng bán");

            Series series = this.chart1.Series.Add("Số lượng");
            series.ChartType = SeriesChartType.Spline;

            dateTimePickerNam.Format = DateTimePickerFormat.Custom;
            dateTimePickerNam.CustomFormat = "yyyy";
            dateTimePickerNam.ShowUpDown = true;

            var ds = db.HOADONs.Where(t => t.NgayBan.Value.Year == dateTimePickerNam.Value.Year);
            dataGridView1.DataSource = ds;

            for (int thang = 1; thang <= 12; thang++)
            {
                int soluong = 0;
                var ds2 = db.HOADONs.Where(t => t.NgayBan.Value.Year == dateTimePickerNam.Value.Year && t.NgayBan.Value.Month == thang);
                dataGridView3.DataSource = ds2;
                for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                {
                    var ct = db.CHITIETHDs.Where(t => t.MaHD.Equals(int.Parse(dataGridView3.Rows[i].Cells[0].Value.ToString())));
                    dataGridView2.DataSource = ct;
                    for (int j = 0; j < dataGridView2.Rows.Count - 1; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[3].Value != null)
                        {
                            soluong += int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString());
                        }
                    }
                }

                series.Points.AddXY("Tháng " + thang, soluong);
            }
        }

        private void dateTimePickerNam_ValueChanged(object sender, EventArgs e)
        {
            reload();
        }
    }
}

