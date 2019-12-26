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
    public partial class FormKHOA : Form
    {
        int vitri = 0;
        String makh;
        String macs;
        Boolean them = false;
        public FormKHOA()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.KHOA_BDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormKHOA_Load(object sender, EventArgs e)
        {
            String maKH = "";
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.MON' table. You can move, or remove it, as needed.
            this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONTableAdapter.Fill(this.dS.MON);
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            //makh = ((DataRowView)KHOA_BDS[0])["MAKH"].ToString();
            macs = ((DataRowView)KHOA_BDS[0])["MACS"].ToString();


            txttenkhoa.ReadOnly = true;
            txtstt.ReadOnly = true;
            txtmacs.ReadOnly = true;
            txtmakh.Enabled = false;
            btnghi.Enabled = false;
            btnphuchoi.Enabled = btnrefresh.Enabled = false;
            cmbcoso.DataSource = Program.bds_dspm;
            cmbcoso.Enabled = false;
            cmbcoso.DisplayMember = "TENCN";
            cmbcoso.ValueMember = "TENSERVER";  
            if(Program.mGroup == "PGV")
            {
                cmbcoso.Enabled = true;
                btnghi.Enabled = btnphuchoi.Enabled = btnsua.Enabled = btnxoa.Enabled = false;
                btnrefresh.Enabled = true;
                btnthem.Enabled = true;
                kHOAGridControl.Enabled = false;
            }         
            if (Program.mGroup == "KHOA")
            {
                btnthem.Enabled = false;              
                cmbcoso.Enabled = false;
                btnghi.Enabled = false;
               btnrefresh.Enabled = btnsua.Enabled = btnxoa.Enabled = true;
                btnphuchoi.Enabled = false;
                kHOAGridControl.Enabled = true;               
                Program.myReader = null;
                if (Program.ketNoi() == 0) return;
                try
                {
                    String strlenh = "EXEC SP_LAYMAKHOAGIANGVIEN N'" +Program.username+"'";
                    Program.myReader = Program.ExecSqlDataReader(strlenh);
                    Program.myReader.Read();
                    do
                    {
                         maKH = Program.myReader.GetString(0);
                    } while (Program.myReader.Read());
                    Program.myReader.Close();
                    Console.WriteLine(maKH);
                   
                  
                }
                catch (Exception ex)
                {
                    return;
                }
                   KHOA_BDS.Filter = "MAKH = '" + maKH + "'";
              //  KHOA_BDS.Filter = "MAKH=CNTT";
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

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            vitri = KHOA_BDS.Position;
            kHOAGridControl.Enabled = false;
            txtstt.Enabled = false;
            txtmakh.ReadOnly = false;
            txtstt.ReadOnly = false;           
            txttenkhoa.ReadOnly = false;
            btnghi.Enabled = true;
            btnphuchoi.Enabled = btnrefresh.Enabled = true;
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            btnsua.Enabled = btnxoa.Enabled = false;
            btnthem.Enabled = true;
            txtmakh.ReadOnly = false;
            txttenkhoa.ReadOnly = false;
            txtstt.ReadOnly = false;
            btnghi.Enabled = true;
            groupBox1.Enabled = true;
            btnphuchoi.Enabled = btnrefresh.Enabled = true;
            kHOAGridControl.Enabled = false;
            txtmakh.Enabled = true;
            txtmacs.Text = macs;
            txtmacs.ReadOnly = false;    
            KHOA_BDS.AddNew();
            //txtmakh.Text = makh;
            //txtmakh.ReadOnly = true;
            txtstt.Text = "0";
            txtstt.Enabled = false;
            txtmakh.Focus();
        }

        private void btnghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtmakh.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu");
                return;
            }
            if (txttenkhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên môn học :", "", MessageBoxButtons.OK);
                txttenkhoa.Focus();
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
            if (Ret == "1")
            {
                MessageBox.Show("Mã khoa đã tồn tại", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.ketNoi() == 0) return;
            String sqlkhoa = "dbo.SP_KIEMTRATENKHTONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlkhoa;
            Program.sqlcmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = txttenkhoa.Text;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret1 = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret1 == "1")
            {
                MessageBox.Show("Tên khoa đã tồn tại", "", MessageBoxButtons.OK);
                return;
            }
            btnphuchoi.Enabled = btnrefresh.Enabled = btnsua.Enabled = btnthoat.Enabled = btnxoa.Enabled = true;
            KHOA_BDS.EndEdit();
            KHOA_BDS.ResetCurrentItem();
            this.kHOATableAdapter.Update(this.dS.KHOA);
            MessageBox.Show("Thêm Thành Công", "" , MessageBoxButtons.OK);
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
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Fill(this.dS.KHOA);
                    this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
                    this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONTableAdapter.Fill(this.dS.MON);
                }
            }
        }

        private void btnphuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               
                KHOA_BDS.Position = 0;
                this.kHOATableAdapter.Fill(this.dS.KHOA);
                 btnsua.Enabled = btnrefresh.Enabled =  btnthoat.Enabled = btnxoa.Enabled = true;
                btnphuchoi.Enabled = btnghi.Enabled = false;
                kHOAGridControl.Enabled = true;
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
                if (Program.mGroup == "KHOA" || Program.mGroup == "GIANGVIEN")
                {
                    btnthem.Enabled = false;
                    btnghi.Enabled = btnphuchoi.Enabled = btnsua.Enabled = btnxoa.Enabled = false;
                }
                vitri = KHOA_BDS.Position;
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dS.KHOA);
                btnghi.Enabled = btnphuchoi.Enabled = btnsua.Enabled = btnthoat.Enabled = btnxoa.Enabled  = true;
                kHOAGridControl.Enabled = true;
                btnphuchoi.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            kHOAGridControl.Enabled = true;
            them = false;
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtmakh.Text.Trim() == "")
            {
                MessageBox.Show("Chọn khoa để xóa");
                return;
            }

            if (KHOA_BDS.Count > 0)
            {
                MessageBox.Show(" không thể xóa");
                return;
            }
            if (KHOA_BDS.Count == 0)
            {
                btnxoa.Enabled = false;
            }
            if ((MessageBox.Show("Bạn có thật sự muốn xóa khoa này ?? ", "Xác nhận",
                  MessageBoxButtons.OKCancel) == DialogResult.OK))
                KHOA_BDS.RemoveCurrent();
            this.kHOATableAdapter.Update(this.dS.KHOA);
            MessageBox.Show("Xóa Thành Công" , "" ,MessageBoxButtons.OK);
            KHOA_BDS.Position = KHOA_BDS.Find("MAKH", txtmakh);
        }
    }
}
