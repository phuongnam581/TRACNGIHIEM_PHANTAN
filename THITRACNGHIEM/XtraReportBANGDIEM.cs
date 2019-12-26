using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace THITRACNGHIEM
{
    public partial class XtraReportBANGDIEM : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportBANGDIEM(String malop, String mamon)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_INBANGDIEMTableAdapter.Fill(ds1.SP_INBANGDIEM, malop, mamon);




        }

    }
}
