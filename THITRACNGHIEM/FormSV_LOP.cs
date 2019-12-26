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
    public partial class FormSV_LOP : Form
    {
        int vitri = 0;
        String makh;
        Boolean them = false;
        public FormSV_LOP()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.SV_BDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormSV_LOP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DANGKYTHI' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTHITableAdapter.Fill(this.dS.DANGKYTHI);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            // TODO: This line of code loads data into the 'dS.CTBAITHI' table. You can move, or remove it, as needed.
            this.cTBAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTBAITHITableAdapter.Fill(this.dS.CTBAITHI);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            makh = ((DataRowView)LOP_BDS[0])["MAKH"].ToString();

            cmbcoso.DataSource = Program.bds_dspm;
            cmbcoso.DisplayMember = "TENCN";
            cmbcoso.ValueMember = "TENSERVER";
            cmbcoso.Enabled = false;
            if (Program.mGroup == "PGV")
            {
                cmbcoso.Enabled = true;
                btnghi.Enabled = btnluu.Enabled = btnphuchoi.Enabled = btnsua.Enabled = btnthem.Enabled = btnxoa.Enabled = false;
                btnrefresh.Enabled = true;
                sINHVIENGridControl.Enabled = true;
                lOPGridControl.Enabled = true;
            }
            else
            {
                cmbcoso.Enabled = false;
            }


            groupBox1.Enabled = groupBox3.Enabled = false;
            lOPGridControl.Enabled = true;
            btnghi.Enabled = btnphuchoi.Enabled = false;
            txtdc.ReadOnly = txtho.ReadOnly = txtmakh.ReadOnly = txtmalop.ReadOnly = txtmasv.ReadOnly = txtngaysinh.ReadOnly = txtstt.ReadOnly = txtstt1.ReadOnly = txtten.ReadOnly = true;
        }

        private void btnthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                new FormGVQL().Show();
                this.Close();
            }
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtdc.ReadOnly = txtho.ReadOnly = txtmalop.ReadOnly = txtmasv.ReadOnly = txtngaysinh.ReadOnly = txtstt.ReadOnly = txtten.ReadOnly = false;
            lOPGridControl.Enabled = true;
            groupBox1.Enabled = true;           
            groupBox3.Enabled = false;
            lOPGridControl.Enabled = false;
            btnsua.Enabled = btnxoa.Enabled = false;
            btnghi.Enabled = btnphuchoi.Enabled = btnrefresh.Enabled = btnthoat.Enabled = true;
            btnthem.Enabled = false;
            sINHVIENGridControl.Enabled = true;
            SV_BDS.AddNew();
            txtmasv.Focus();
        }

        private void btnghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtmasv.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu");
                return;
            }
            
            if (txtmalop.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã lớp :", "", MessageBoxButtons.OK);
                txtmalop.Focus();
                return;
            }
            if (txtho.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ :", "", MessageBoxButtons.OK);
                txtho.Focus();
                return;
            }
            if (txtten.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên :", "", MessageBoxButtons.OK);
                txtten.Focus();
                return;
            }
            if (txtngaysinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập ngày sinh :", "", MessageBoxButtons.OK);
                txtngaysinh.Focus();
                return;
            }
            if (txtstt.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã lớp :", "", MessageBoxButtons.OK);
                txtstt.Focus();
                return;
            }

            if (Program.ketNoi() == 0) return;
            String sqlGV = "dbo.SP_KIEMTRAMASVTONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlGV;
            Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.Char).Value = txtmasv.Text;
            Program.sqlcmd.Parameters.Add("@Ret2", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret2 = Program.sqlcmd.Parameters["@Ret2"].Value.ToString();
            if (Ret2 == "1")
            {
                MessageBox.Show("Mã sinh viên đã tồn tại", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.ketNoi() == 0) return;
            String sqlML1 = "dbo.SP_KIEMTRAMALOPTONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlML1;
            Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.Char).Value = txtmalop.Text;
            Program.sqlcmd.Parameters.Add("@Ret4", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret4 = Program.sqlcmd.Parameters["@Ret4"].Value.ToString();
            if (Ret4 != "1")
            {
                MessageBox.Show("Mã lớp chưa tồn tại", "", MessageBoxButtons.OK);
                return;
            }

            btnphuchoi.Enabled = btnrefresh.Enabled = btnsua.Enabled = btnthoat.Enabled = btnxoa.Enabled = true;
            SV_BDS.EndEdit();
            SV_BDS.ResetCurrentItem();
            dS.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
            MessageBox.Show("Thêm Thành Công", "exit" , MessageBoxButtons.OK);
            them = false;
        }

        private void cmbcoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cmbcoso.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cmbcoso.SelectedValue.ToString();

                if (cmbcoso.SelectedIndex != Program.mCoso) // khác với cơ sở đăng nhập ban đầu
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
                    MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
                else
                {
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS.LOP);


                }
            }
        }

        private void btnphuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SV_BDS.Position = 0;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                btnthem.Enabled = btnsua.Enabled = btnrefresh.Enabled = btnghi.Enabled = btnthoat.Enabled = btnxoa.Enabled = true;
                sINHVIENGridControl.Enabled = true;
                btnrefresh.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnrefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                vitri = SV_BDS.Position;
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                btnghi.Enabled = btnphuchoi.Enabled = btnsua.Enabled = btnthoat.Enabled = btnxoa.Enabled = btnthem.Enabled = true;
                sINHVIENGridControl.Enabled = true;
                btnphuchoi.Enabled = true;
                btnghi.Enabled = btnphuchoi.Enabled = false;
                lOPGridControl.Enabled = true;
                groupBox1.Enabled = false;
                sINHVIENGridControl.Enabled = false;
                groupBox3.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            sINHVIENGridControl.Enabled = true;
            them = false;
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtmasv.Text.Trim() == "")
            {
                MessageBox.Show("Chọn sinh viên để xóa");
                return;
            }

            if (SV_BDS.Count == 0)
            {
                btnxoa.Enabled = false;
            }
            if ((MessageBox.Show("Bạn có thật sự muốn xóa khoa này ?? ", "Xác nhận",
                  MessageBoxButtons.OKCancel) == DialogResult.OK))
                SV_BDS.RemoveCurrent();
            this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
            SV_BDS.Position = SV_BDS.Find("MASV", txtmasv);
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = SV_BDS.Position;
            sINHVIENGridControl.Enabled = true;
            groupBox1.Enabled = true;
            txtstt.Enabled = false;
            txtmasv.ReadOnly = false;
            lOPGridControl.Enabled = false;
            txtho.ReadOnly = false;
            txtdc.ReadOnly = false;
            txtmalop.ReadOnly = false;
            txtngaysinh.ReadOnly = false;
            txtten.ReadOnly = false;
            btnghi.Enabled = true;
            btnsua.Enabled = btnthem.Enabled = false;
            btnphuchoi.Enabled = btnrefresh.Enabled = true;
        }

        private void tHÊMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            groupBox1.Enabled = false;
            txtmakh.ReadOnly = txtmalop.ReadOnly = txtstt1.ReadOnly = false;
            sINHVIENGridControl.Enabled = false;
            btnghi.Enabled = btnphuchoi.Enabled = btnsua.Enabled = btnthem.Enabled = btnxoa.Enabled = false;
            lOPGridControl.Enabled = false;
            LOP_BDS.AddNew();
            txtstt.Text = "0";
            
            txtmalop.Focus();
        }

        private void xÓAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtmalop.Text.Trim() == "")
            {
                MessageBox.Show("Chọn lớp để xóa");
                return;
            }

            if (Program.ketNoi() == 0) return;
            String sqlLop = "dbo.SP_KIEMTRAMALOPDKT";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlLop;
            Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.Char).Value = txtmalop1.Text;
            Program.sqlcmd.Parameters.Add("@Ret3", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret3 = Program.sqlcmd.Parameters["@Ret3"].Value.ToString();
            if (Ret3 == "1")
            {
                MessageBox.Show("Môn Học Đã Đăng Kí Thi, Không Xóa Được", "", MessageBoxButtons.OK);
                return;
            }

            if (LOP_BDS.Count == 0)
            {
                btnxoa.Enabled = false;
            }
            if ((MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?? ", "Xác nhận",
                  MessageBoxButtons.OKCancel) == DialogResult.OK))
                LOP_BDS.RemoveCurrent();
            this.lOPTableAdapter.Update(this.dS.LOP);
            MessageBox.Show("Xóa Thành CÔng");
            LOP_BDS.Position = LOP_BDS.Find("MALOP", txtmalop);
        }

        private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                vitri = LOP_BDS.Position;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                lOPGridControl.Enabled = true;
                groupBox3.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void sỬAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitri = LOP_BDS.Position;
            lOPGridControl.Enabled = false;
            groupBox3.Enabled = true;
            txtmakh.Enabled = false;
            txtmalop.ReadOnly = txtmakh.ReadOnly = txtstt1.ReadOnly = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmalop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu");
                return;
            }
            if (txtmakh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã khoa :", "", MessageBoxButtons.OK);
                txtstt1.Focus();
                return;
            }
            if (Program.ketNoi() == 0) return;
            String sqlGV1 = "dbo.SP_KIEMTRAMALOPTONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlGV1;
            Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.Char).Value = txtmalop1.Text;
            Program.sqlcmd.Parameters.Add("@Ret12", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret12 = Program.sqlcmd.Parameters["@Ret12"].Value.ToString();
            if (Ret12 == "1")
            {
                MessageBox.Show("Mã lớp đã tồn tại", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.ketNoi() == 0) return;
            String sqlTL = "dbo.SP_KIEMTRATENLOPTONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlTL;
            Program.sqlcmd.Parameters.Add("@TENLOP", SqlDbType.Char).Value = txtten.Text;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret == "1")
            {
                MessageBox.Show("Tên lớp đã tồn tại", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.ketNoi() == 0) return;
            String sqlLop = "dbo.SP_KIEMTRAMAKHTONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlLop;
            Program.sqlcmd.Parameters.Add("@MAKH", SqlDbType.Char).Value = txtmakh.Text;
            Program.sqlcmd.Parameters.Add("@Ret3", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret3 = Program.sqlcmd.Parameters["@Ret3"].Value.ToString();
            if (Ret3 != "1")
            {
                MessageBox.Show("Mã khoa chưa tồn tại", "", MessageBoxButtons.OK);
                return;
            }
            LOP_BDS.EndEdit();
            LOP_BDS.ResetCurrentItem();
            this.lOPTableAdapter.Update(this.dS.LOP);
            MessageBox.Show("Thêm Thành Công", "exit", MessageBoxButtons.OK);
            them = false;
        }
    }
}
