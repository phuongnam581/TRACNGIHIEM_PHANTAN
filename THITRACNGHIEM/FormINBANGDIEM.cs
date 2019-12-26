using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITRACNGHIEM
{
    public partial class FormINBANGDIEM : Form
    {
        String malop, mamh;
        public FormINBANGDIEM()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            malop = cmbtenlop.SelectedValue.ToString();
            mamh = cmbtenmh.SelectedValue.ToString();
            XtraReportBANGDIEM report = new XtraReportBANGDIEM(malop, mamh);
            report.lbltenlop.Text = cmbtenlop.Text.Trim();
            report.lbltenmon.Text = cmbtenmh.Text.Trim();
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                new FormGVQL().Show();
                this.Close();
            }
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cmbCoSo.SelectedValue.ToString();
            }
            catch (Exception ex) { }
            if (cmbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.login = Program.remoteLogin;
                Program.password = Program.remotepwd;
            }
            else
            {
                Program.login = Program.loginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.ketNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                try
                {
                    this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONTableAdapter.Fill(this.dS.MON);
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    // this.sP_INBANGDIEMTableAdapter1.Fill(this.dSCS.SP_INBANGDIEM,malop,mamh,lan);
                }
                catch (Exception ex) { }

            }
        }

        private void FormINBANGDIEM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MON' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONTableAdapter.Fill(this.dS.MON);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);


            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";
            if (Program.mGroup == "PGV")
            {
                cmbCoSo.Enabled = true;
            }
            else
            {
                cmbCoSo.Enabled = false;

            }
            

        }
    }
}
