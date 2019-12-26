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
    public partial class FormGIANGVIEN : Form
    {
        int vitri = 0;
        String makh;
        public FormGIANGVIEN()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.GVBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormGIANGVIEN_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            // TODO: This line of code loads data into the 'dS.DANGKYTHI' table. You can move, or remove it, as needed.
            this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTHITableAdapter.Fill(this.dS.DANGKYTHI);
            // TODO: This line of code loads data into the 'dS.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            //makh = ((DataRowView)GVBDS[0])["MAKH"].ToString();

            txtdc.ReadOnly = true;
            txtho.ReadOnly = true;
            txthocvi.ReadOnly = true;
            txtmagv.ReadOnly = true;
            txtstt.ReadOnly = true;
            txtten.ReadOnly = true;
            txtmakh.ReadOnly = false;
            btnghi.Enabled = false;
            cmbCoSo.Enabled = false;
            btnphuchoi.Enabled = btnrefresh.Enabled = false;
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";
            if(Program.mGroup == "PGV")
            {
                cmbCoSo.Enabled = true;
                btnghi.Enabled = btnphuchoi.Enabled = btnsua.Enabled = btnthem.Enabled = btnxoa.Enabled = false;
                gIANGVIENGridControl.Enabled = false;
                btnrefresh.Enabled = true;
            }

            if (Program.mGroup == "KHOA")
            {
                cmbCoSo.Enabled = false;
                btnghi.Enabled = false;
                btnphuchoi.Enabled = btnrefresh.Enabled = btnsua.Enabled = btnthem.Enabled = btnxoa.Enabled = true;
                gIANGVIENGridControl.Enabled = true;

                int pos = GVBDS.Find("MAGV", Program.username);
               
               
                GVBDS.Filter = "MAKH = '" + ((DataRowView)GVBDS[pos])["MAKH"].ToString() + "'";
            }

        }

        private void btnthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                new FormGVQL().Show();
                this.Close();
            }
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cmbCoSo.SelectedValue.ToString();

                if (cmbCoSo.SelectedIndex != Program.mCoso) // khác với cơ sở đăng nhập ban đầu
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
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Fill(this.dS.BODE);
                    this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dANGKYTHITableAdapter.Fill(this.dS.DANGKYTHI);
                    this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
                }
            }
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtdc.ReadOnly = false;
            txtho.ReadOnly = false;
            txthocvi.ReadOnly = false;
            btnthem.Enabled = false;
            txtmagv.ReadOnly = false;
            txtstt.ReadOnly = false;
            txtmakh.ReadOnly = false;
            txtten.ReadOnly = false;
            //txtstt.Text = "0";
            //txtstt.Enabled = false;
            btnghi.Enabled = true;
            btnphuchoi.Enabled = btnrefresh.Enabled = true;
            GVBDS.AddNew();
            //txtmakh.Text = makh;
            txtstt.ReadOnly = true;
            txtmakh.Enabled = true;
            gIANGVIENGridControl.Enabled = true;
            txtmagv.Focus();
        }

        private void btnghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Program.ketNoi() == 0) return;
                String sqlGV = "dbo.SP_KIEMTRAMAGVTONTAI";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = sqlGV;
                Program.sqlcmd.Parameters.Add("@MAGV", SqlDbType.Char).Value = txtmagv.Text;
                Program.sqlcmd.Parameters.Add("@Ret1", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret1 = Program.sqlcmd.Parameters["@Ret1"].Value.ToString();
                if (Ret1 == "1")
                {
                    MessageBox.Show("Mã giảng viên đã tồn tại", "", MessageBoxButtons.OK);
                    return;
                }
                if (Program.ketNoi() == 0) return;
                String sqlLop = "dbo.SP_KIEMTRAMAKHTONTAI";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = sqlLop;
                Program.sqlcmd.Parameters.Add("@MAKH", SqlDbType.Char).Value = txtmakh.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret != "1")
                {
                    MessageBox.Show("Mã khoa chưa tồn tại", "", MessageBoxButtons.OK);
                    return;
                }
                dS.EnforceConstraints = false;
                GVBDS.EndEdit();
                GVBDS.ResetCurrentItem();
                this.gIANGVIENTableAdapter.Update(this.dS.GIANGVIEN);
                MessageBox.Show("Thêm Thành Công");

            }
            catch (Exception ex)
            {                
                    MessageBox.Show("Lỗi ghi giảng viên . " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnrefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                vitri = GVBDS.Position;
                this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
                btnghi.Enabled = btnphuchoi.Enabled = btnsua.Enabled = btnthoat.Enabled = btnxoa.Enabled = true;
                gIANGVIENGridControl.Enabled = true;
                btnphuchoi.Enabled = true;
                btnthem.Enabled = true;
                btnghi.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                if (Program.ketNoi() == 0) return;
                String sqlLop = "dbo.SP_KIEMTRAGVDKT";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = sqlLop;
                Program.sqlcmd.Parameters.Add("@MAGV", SqlDbType.Char).Value = txtmagv.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret == "1")
                {
                    MessageBox.Show("Giảng Viên Đã Đăng Ký Thi , không Được Xóa", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Bạn Chắc Chứ", "", MessageBoxButtons.OK);

                }
                GVBDS.RemoveCurrent();
                this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Update(this.dS.GIANGVIEN);
                MessageBox.Show("Xóa Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa giảng viên . " + ex.Message, "", MessageBoxButtons.OK);
            }
            if (GVBDS.Count == 0)
            {
                btnxoa.Enabled = false;
            }
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = GVBDS.Position;
            gIANGVIENGridControl.Enabled = false;
            txtdc.ReadOnly = false;
            txtho.ReadOnly = false;
            txthocvi.ReadOnly = false;
            txtmagv.ReadOnly = false;
            txtmakh.ReadOnly = false;
            txtten.ReadOnly = false;
            btnphuchoi.Enabled = btnrefresh.Enabled = true;
            txtstt.Enabled = false;
            btnghi.Enabled = true;
        }

        private void btnphuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GVBDS.CancelEdit();
            if (btnthem.Enabled = false)
            {
                vitri = GVBDS.Position;
            }
            btnghi.Enabled = true;
            btnrefresh.Enabled = true;
        }
    }
}
