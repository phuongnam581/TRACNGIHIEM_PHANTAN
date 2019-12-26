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
    public partial class FormInKQ : Form
    {
        public FormInKQ()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormInKQ_Load(object sender, EventArgs e)
        {
            String maLop = "";
            // TODO: This line of code loads data into the 'dS.DANGKYTHI' table. You can move, or remove it, as needed.
            this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTHITableAdapter.Fill(this.dS.DANGKYTHI);
            // TODO: This line of code loads data into the 'dS.MON' table. You can move, or remove it, as needed.
            this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONTableAdapter.Fill(this.dS.MON);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            if (Program.mGroup == "Sinhvien")
            {
                try
                {
                    if (Program.ketNoi() == 0) return;
                    String strlenh = "EXEC SP_LAYMALOPTHEOSINHVIEN N'" + Program.username + "'";
                    Program.myReader = Program.ExecSqlDataReader(strlenh);
                    while (Program.myReader.Read())
                    {
                        maLop = Program.myReader.GetString(0);
                        txtLop.Text = maLop;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }                  
            cmbMon.SelectedIndex = -1;
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            int dem = 0,dem1=0;
            if (txtLop.Text == "")
            {
                MessageBox.Show("Mã lớp không được rỗng");
                return;
            }
            Program.myReader = null;
            if (Program.ketNoi() == 0) return;
            String strlenh = "EXEC SP_KTRALOPDANGKY N'" + txtLop.Text.Trim() + "',N'" + cmbMon.SelectedValue.ToString() + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            while (Program.myReader.Read())
            {
                dem = Program.myReader.GetInt32(0);
            }
            if (dem < 1)
            {
                MessageBox.Show("Lớp của sinh viên không thi môn này", "", MessageBoxButtons.OK);
                return;
            }
            Program.conn.Close();

            dANGKYTHIBindingSource.Filter = "MAMON = '" + cmbMon.SelectedValue + "' AND MALOP = '" + txtLop.Text + "'";
            lOPBindingSource.Filter = "MALOP = '" + txtLop.Text + "'";
            if (Program.ketNoi() == 0) return;
            String sqlLop = "dbo.SP_KTRAKQBAITHI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlLop;
            Program.sqlcmd.Parameters.Add("@MaDK", SqlDbType.Int).Value = Int32.Parse(((DataRowView)dANGKYTHIBindingSource[0])["MADANGKY"].ToString());
            Program.sqlcmd.Parameters.Add("@MaSV", SqlDbType.Char).Value = Program.username;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret != "1")
            {
                MessageBox.Show("Sinh viên chưa có bài thi môn này", "", MessageBoxButtons.OK);
                return;
            }
            BAITHI_XRPT rpt = new BAITHI_XRPT(Int32.Parse(((DataRowView)dANGKYTHIBindingSource[0])["MADANGKY"].ToString()),Program.username);
                rpt.lblLop.Text = ((DataRowView)lOPBindingSource[0])["TENLOP"].ToString();
                rpt.lblHoTen.Text = Program.mHoten;
                rpt.lblMon.Text = ((DataRowView)mONBindingSource[cmbMon.SelectedIndex])["TENMH"].ToString();
                rpt.lblNgay.Text = ((DataRowView)dANGKYTHIBindingSource[0])["NGAYTHI"].ToString();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            
           

            // Console.WriteLine(((DataRowView)dANGKYTHIBindingSource[0])["MADANGKY"].ToString());
            // Console.WriteLine(dANGKYTHIBindingSource);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSV frm = new FormSV();
            frm.Show();
        }
    }
}
