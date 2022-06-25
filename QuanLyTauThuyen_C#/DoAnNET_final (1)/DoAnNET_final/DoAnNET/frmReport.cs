using CrystalDecisions.Shared;
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
    public partial class frmReport : Form
    {
        public int mahd { get; set; }
        public frmReport()
        {
            InitializeComponent();
        }
        
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            report_HoaDon rpt = new report_HoaDon();
            rpt.SetDatabaseLogon("sa", "123", "NGCHIUTRNC995", "QLTAU");
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pdv.Value = mahd;
            ParameterValues pv = new ParameterValues();
            pv.Add(pdv);
            rpt.DataDefinition.ParameterFields["@mahd"].ApplyCurrentValues(pv);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }
    }
}
