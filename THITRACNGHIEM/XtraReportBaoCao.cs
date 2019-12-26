using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace THITRACNGHIEM
{
    public partial class XtraReportBaoCao : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportBaoCao(int madki,String masv)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_INBAITHITableAdapter.Fill(ds1.SP_INBAITHI, madki,masv);
        }

    }
}
