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
    public partial class FormMon : Form
    {
        int vitri = 0;
        String maKhoa = "";
        String makh;
        Boolean them = false;
        bool clicksua = false;
        String mamh = "";
        public FormMon()
        {
            InitializeComponent();
        }

        private void mONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.MON_BDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        //private string danhSachMH()
        //{

        //    String ds = "";
        //    // String maKhoa = GetMaKhoa();
        //    Program.myReader = null;
        //    if (Program.ketNoi() == 0) return "NO CONNECT";
        //    String strlenh = "EXEC dbo.SP_DSMH'" + maKhoa + "'";
        //    Program.myReader = Program.ExecSqlDataReader(strlenh);
        //    while (Program.myReader.Read())
        //    {
        //        ds += "'" + Program.myReader.GetString(0) + "',";
        //    }

        //    return ds.Substring(0, ds.Length - 1);
        //}

        private String timMaKhoa()
        {
            String maKhoa = "";
            String timMaKhoa = "SELECT MAKH FROM GIANGVIEN WHERE MAGV = '" + Program.username + "'";
            Program.myReader = Program.ExecSqlDataReader(timMaKhoa);
            if (Program.myReader.Read())
            {
                maKhoa = Program.myReader.GetString(0).ToString();
            }
            Program.conn.Close();
            return maKhoa;
        }
        private void FormMon_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            // TODO: This line of code loads data into the 'dS.DANGKYTHI' table. You can move, or remove it, as needed.
            this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTHITableAdapter.Fill(this.dS.DANGKYTHI);
            // TODO: This line of code loads data into the 'dS.MON' table. You can move, or remove it, as needed.
            this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONTableAdapter.Fill(this.dS.MON);

            makh = ((DataRowView)MON_BDS[0])["MAKH"].ToString();
            comboBox1.DataSource = Program.bds_dspm;
            comboBox1.DisplayMember = "TENCN";
            comboBox1.ValueMember = "TENSERVER";

            txtmakh.ReadOnly = true;
            txtstt.ReadOnly = true;
            txtmamh.ReadOnly = true;       
            txttenmh.ReadOnly = true;
            btnphuchoi.Enabled = btnrefresh.Enabled = false;
            btnghi.Enabled = false;
            comboBox1.Enabled = false;
            if (Program.mGroup == "PGV")
            {
                comboBox1.Enabled = true;
                btnghi.Enabled = btnphuchoi.Enabled = btnsua.Enabled = btnthem.Enabled = btnxoa.Enabled = false;
                btnrefresh.Enabled = true;
                mONGridControl.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = false;
            }
            if (Program.mGroup == "KHOA")
            {
                maKhoa = timMaKhoa();
                MON_BDS.Filter = "MAKH = '" + maKhoa + "'";
            }
            
        }

        
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtmamh.ReadOnly = false;
            txtstt.ReadOnly = false;
            btnthem.Enabled = false;
            
            txttenmh.ReadOnly = false;
            btnghi.Enabled = true;
            btnphuchoi.Enabled = btnrefresh.Enabled = true;
            vitri = MON_BDS.Position;
            MON_BDS.AddNew();
            txtstt.ReadOnly = true;
            txtstt.Text = makh;
            txtmamh.Focus();
        }

        private void btnthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                new FormGVQL().Show();
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (comboBox1.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = comboBox1.SelectedValue.ToString();

                if (comboBox1.SelectedIndex != Program.mCoso) // khác với cơ sở đăng nhập ban đầu
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
                    this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dANGKYTHITableAdapter.Fill(this.dS.DANGKYTHI);
                    this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONTableAdapter.Fill(this.dS.MON);

                }
            }
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = MON_BDS.Position;
            clicksua = true;
            mONGridControl.Enabled = false;
            btnphuchoi.Enabled = btnrefresh.Enabled = true;
            txtmamh.ReadOnly = false;
            txtstt.Enabled = false;
            btnghi.Enabled = true;
            txttenmh.ReadOnly = false;
            btnthem.Enabled = false;
        }

        private void btnghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtmamh.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được thiếu");
                return;
            }
            
            if (txttenmh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên môn học :", "", MessageBoxButtons.OK);
                txttenmh.Focus();
                return;
            }

            if (Program.ketNoi() == 0) return;
            String sqlMH = "dbo.SP_KIEMTRAMAMHTONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlMH;            
            Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.Char).Value = txtmamh.Text;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret == "1")
            {
                MessageBox.Show("Môn học đã tồn tại", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.ketNoi() == 0) return;
            String sqlTMH = "dbo.SP_KIEMTRATENMHTONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlTMH;
            Program.sqlcmd.Parameters.Add("@TENMH", SqlDbType.Char).Value = txttenmh.Text;
            Program.sqlcmd.Parameters.Add("@Ret1", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret1 = Program.sqlcmd.Parameters["@Ret1"].Value.ToString();
            if (Ret1 == "1")
            {
                MessageBox.Show("Môn học đã tồn tại", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.ketNoi() == 0) return;
            String sqlLop = "dbo.SP_KIEMTRAMAKHTONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlLop;
            Program.sqlcmd.Parameters.Add("@MAKH", SqlDbType.Char).Value = txtmakh.Text;
            Program.sqlcmd.Parameters.Add("@Ret5", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret5 = Program.sqlcmd.Parameters["@Ret5"].Value.ToString();
            if (Ret5 != "1")
            {
                MessageBox.Show("Mã khoa chưa tồn tại", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.ketNoi() == 0) return;
            String sqlKH = "dbo.SP_KIEMTRAMAMHTONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlKH;
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
            MON_BDS.EndEdit();
            MON_BDS.ResetCurrentItem();
            dS.EnforceConstraints = false;
            this.mONTableAdapter.Update(this.dS.MON);
            MessageBox.Show("Thêm Thành Công");
            them = false;
        }

        private void btnrefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                vitri = MON_BDS.Position;
                this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONTableAdapter.Fill(this.dS.MON);
                btnghi.Enabled = btnphuchoi.Enabled = btnsua.Enabled = btnthoat.Enabled = btnxoa.Enabled = true;
                mONGridControl.Enabled = true;
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

        private void btnphuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MON_BDS.CancelEdit();
            this.mONTableAdapter.Fill(this.dS.MON);
            them = false;
            btnrefresh.Enabled = true;
            btnghi.Enabled = true;
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtmamh.Text.Trim() == "")
            {
                MessageBox.Show("Chọn môn học để xóa");
                return;
            }
            if (Program.ketNoi() == 0) return;
            String sqlLop = "dbo.SP_KIEMTRAMAMHDKT";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlLop;
            Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NVarChar).Value = txtmamh.Text;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret == "1")
            {
                MessageBox.Show("Môn Học Đã Đăng Ký Thi , không Được Xóa", "", MessageBoxButtons.OK);
                return;
            }
            
            if ((MessageBox.Show("Bạn có thật sự muốn xóa môn học này ?? ", "Xác nhận",
                  MessageBoxButtons.OKCancel) == DialogResult.OK))
                MON_BDS.RemoveCurrent();
            this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONTableAdapter.Update(this.dS.MON);
            MessageBox.Show("XÓa Thành Công");
            if (MON_BDS.Count == 0)
            {
                btnxoa.Enabled = false;
            }
        }
    }
}
