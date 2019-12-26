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
    public partial class FormDKThi : Form
    {
        public FormDKThi()
        {
            InitializeComponent();
        }

        private void dANGKYTHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dANGKYTHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormDKThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.BAITHILOP' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dS.BAITHILOP' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dS.MON' table. You can move, or remove it, as needed.
            this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONTableAdapter.Fill(this.dS.MON);
            // TODO: This line of code loads data into the 'dS.DANGKYTHI' table. You can move, or remove it, as needed.
            this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTHITableAdapter.Fill(this.dS.DANGKYTHI);

            this.bAITHILOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bAITHILOPTableAdapter.Fill(this.dS.BAITHILOP);

            dANGKYTHIBindingSource.Filter = "status=0";
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";
           // Console.WriteLine(((DataRowView)dANGKYTHIBindingSource[0])["MADANGKY"]);
            btnTaoBaiThi.Enabled = true;
            groupBox.Enabled = false;
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
                btnThem.Enabled = btnX.Enabled = btnSua.Enabled = btnPH.Enabled = btnRefresh.Enabled = btnTaoBaiThi.Enabled = btnGhi.Enabled = false;
            }
            else
            {
                Program.login = Program.loginDN;
                Program.password = Program.passwordDN;
                btnThem.Enabled = btnX.Enabled = btnSua.Enabled = btnPH.Enabled = btnRefresh.Enabled = btnTaoBaiThi.Enabled = btnGhi.Enabled = true;

            }



            if (Program.ketNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                try
                {
                    this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONTableAdapter.Fill(this.dS.MON);
                    // TODO: This line of code loads data into the 'dS.DANGKYTHI' table. You can move, or remove it, as needed.
                    this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dANGKYTHITableAdapter.Fill(this.dS.DANGKYTHI);
                   
                }
                catch (Exception ex) { }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox.Enabled = true;
            dANGKYTHIGridControl.Enabled = false;
            btnGhi.Enabled = true; btnPH.Enabled = true;
            btnThoat.Enabled = btnThem.Enabled = btnRefresh.Enabled = false;
            Program.control = "Add";
            dANGKYTHIBindingSource.AddNew();
            cmbTrinhDo.SelectedIndex = cmbMH.SelectedIndex = -1;
            txtMaGV.Enabled = true;
            txtNV.Enabled = false;
            txtNV.Text = Program.username;
            txtMaDKi.Enabled = false;
            txtStatus.Enabled = false;
            txtStatus.Text = "0";
            cmbNgayThi.Value = DateTime.Now;
            btnSua.Enabled = btnX.Enabled = btnTaoBaiThi.Enabled = false;
            groupBox.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int dem = 0;
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Lớp không được trống", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Giáo viên không được trống", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return;
            }
            if (txtSoCauThi.Text == "" || Int32.Parse(txtSoCauThi.Text) > 50 || Int32.Parse(txtSoCauThi.Text) < 10)
            {
                MessageBox.Show("Số câu thi không hợp lệ", "", MessageBoxButtons.OK);
                txtSoCauThi.Focus();
                return;
            }
            if (cmbMH.SelectedIndex == -1)
            {
                MessageBox.Show("Mã môn chưa chọn", "", MessageBoxButtons.OK);
                cmbMH.Focus();
                return;
            }

            if (txtTG.Text == "" || Int32.Parse(txtTG.Text) > 180 || Int32.Parse(txtTG.Text) < 10)
            {
                MessageBox.Show("Thời gian thi không hợp lệ", "", MessageBoxButtons.OK);
                txtSoCauThi.Focus();
                return;
            }
            if (txtBD.Text == "" || Int32.Parse(txtBD.Text) > 8 || Int32.Parse(txtBD.Text) < 1)
            {
                MessageBox.Show("Tiết bắt đầu không hợp lệ", "", MessageBoxButtons.OK);
                txtBD.Focus();
                return;
            }

            if (cmbNgayThi.Value <= DateTime.Now)
            {
                MessageBox.Show("Ngày thi không hợp lệ", "", MessageBoxButtons.OK);
                cmbNgayThi.Focus();
                return;
            }
            
            if(cmbTrinhDo.SelectedValue=="DHCQ" || cmbTrinhDo.SelectedValue=="VB2" || cmbTrinhDo.SelectedValue == "CDCQ")
            {
                MessageBox.Show("Trình độ không hợp lệ", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.ketNoi() == 0) return;
            String sqlLop = "dbo.SP_KTLOPTONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlLop;
            Program.sqlcmd.Parameters.Add("@MaLop", SqlDbType.Char).Value = txtMaLop.Text;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret != "1")
            {
                MessageBox.Show("Lớp học chưa tồn tại", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.ketNoi() == 0) return;
            String sqlGV = "dbo.SP_KTGVTONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlGV;
            Program.sqlcmd.Parameters.Add("@MaGV", SqlDbType.Char).Value = txtMaGV.Text;
            Program.sqlcmd.Parameters.Add("@Ret1", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret1 = Program.sqlcmd.Parameters["@Ret1"].Value.ToString();
            if (Ret1 != "1")
            {
                MessageBox.Show("Giảng viên chưa tồn tại", "", MessageBoxButtons.OK);
                return;
            }
           

            if (Program.control == "Add")
            {

                if (cmbTrinhDo.SelectedIndex == -1)
                {
                    MessageBox.Show("Trình độ chưa chọn", "", MessageBoxButtons.OK);
                    cmbTrinhDo.Focus();
                    return;
                }
                else
                {
                    if (cmbTrinhDo.SelectedIndex == 0)
                    {
                        ((DataRowView)dANGKYTHIBindingSource[dANGKYTHIBindingSource.Position])["TRINHDO"] = "DHCQ";
                    }
                    if (cmbTrinhDo.SelectedIndex == 1)
                    {
                        ((DataRowView)dANGKYTHIBindingSource[dANGKYTHIBindingSource.Position])["TRINHDO"] = "CDCQ";
                    }
                    if (cmbTrinhDo.SelectedIndex == 2)
                    {
                        ((DataRowView)dANGKYTHIBindingSource[dANGKYTHIBindingSource.Position])["TRINHDO"] = "VB2";
                    }
                }
                Program.myReader = null;
                if (Program.ketNoi() == 0) return;
                String strlenh = "EXEC SP_KTRALOPDANGKY N'" + txtMaLop.Text.Trim() + "',N'" + cmbMH.SelectedValue.ToString() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                while (Program.myReader.Read())
                {
                    dem = Program.myReader.GetInt32(0);
                }
                if (dem >= 1)
                {
                    MessageBox.Show("Lớp đã được đăng kí thi môn học này", "", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    this.Validate();
                    dANGKYTHIBindingSource.EndEdit();
                    dANGKYTHIBindingSource.ResetCurrentItem();
                    this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dANGKYTHITableAdapter.Update(this.dS.DANGKYTHI);
                    MessageBox.Show("Đã đăng kí thành công", "", MessageBoxButtons.OK);
                    btnRefresh.Enabled = btnThem.Enabled = btnThoat.Enabled = btnPH.Enabled = btnSua.Enabled = btnX.Enabled = btnTaoBaiThi.Enabled = true;
                    btnGhi.Enabled = false;
                    dANGKYTHIGridControl.Enabled = true;
                    groupBox.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            } else if (Program.control == "Edit")
            {
                dANGKYTHIBindingSource.EndEdit();
                dANGKYTHIBindingSource.ResetCurrentItem();
                this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTHITableAdapter.Update(this.dS.DANGKYTHI);
                MessageBox.Show("Đã sửa đăng kí thi thành công", "", MessageBoxButtons.OK);
                groupBox.Enabled = false;
                dANGKYTHIGridControl.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnX.Enabled = btnRefresh.Enabled = btnTaoBaiThi.Enabled = true;
                btnPH.Enabled = btnGhi.Enabled = true;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox.Enabled = true;
            dANGKYTHIGridControl.Enabled = false;
            txtStatus.Enabled = txtMaDKi.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;
            btnRefresh.Enabled = btnThem.Enabled = btnX.Enabled = btnSua.Enabled = btnTaoBaiThi.Enabled = btnThoat.Enabled = false;
            groupBox.Enabled = true;
            cmbMH.Enabled = false;
            Program.control = "Edit";
        }

        private void btnX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int phieuDangKy = Int32.Parse(((DataRowView)dANGKYTHIBindingSource[dANGKYTHIBindingSource.Position])["MADANGKY"].ToString());
            if (MessageBox.Show("Bạn có muốn xóa đăng ký số " + txtMaDKi.Text + " không?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Program.ketNoi() == 0) return;
                String sql = "dbo.SP_KTRADANGKYBAITHILOP";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = sql;
                Program.sqlcmd.Parameters.Add("@MaDK", SqlDbType.Int).Value = phieuDangKy;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret == "1")
                {
                    ((DataRowView)dANGKYTHIBindingSource[dANGKYTHIBindingSource.Position])["status"] = 1;
                    try
                    {
                        dANGKYTHIBindingSource.EndEdit();
                        dANGKYTHIBindingSource.ResetCurrentItem();
                        this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
                        this.dANGKYTHITableAdapter.Update(this.dS.DANGKYTHI);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa phiếu đăng ký này. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                        return;
                    }
                }
                try
                {
                    dANGKYTHIBindingSource.RemoveCurrent();
                    this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dANGKYTHITableAdapter.Update(this.dS.DANGKYTHI);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu đăng ký. Bạn hãy xóa lại\n" + ex.Message, "",
                    MessageBoxButtons.OK);
                    return;
                }

            }
            else
            {
                
                MessageBox.Show("Bạn đã xóa phiếu đăng ký thành công", "", MessageBoxButtons.OK);
            }

        }

        private void btnPH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dANGKYTHIBindingSource.CancelEdit();
            dANGKYTHIGridControl.Enabled = true;
            groupBox.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnX.Enabled = btnRefresh.Enabled = btnThoat.Enabled =btnTaoBaiThi.Enabled =true;
            btnGhi.Enabled = btnPH.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.dANGKYTHITableAdapter.Fill(this.dS.DANGKYTHI);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close(); ;
            FormGVQL frm = new FormGVQL();
            frm.Show();
        }

        private void btnTaoBaiThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int maDangKy = Int32.Parse(((DataRowView)dANGKYTHIBindingSource[dANGKYTHIBindingSource.Position])["MADANGKY"].ToString());
            String trinhDo = ((DataRowView)dANGKYTHIBindingSource[dANGKYTHIBindingSource.Position])["TRINHDO"].ToString();
            int i = 0;

            if (Program.ketNoi() == 0) return;
            String sqlGV = "dbo.SP_KTRATAOBAITHI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlGV;
            Program.sqlcmd.Parameters.Add("@MADANGKY", SqlDbType.Int).Value = maDangKy;
            Program.sqlcmd.Parameters.Add("@Ret1", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret1 = Program.sqlcmd.Parameters["@Ret1"].Value.ToString();
            if (Ret1 == "1")
            {
                MessageBox.Show("Bài thi đã được tạo", "", MessageBoxButtons.OK);
                return;
            }

            Program.myReader = null;
            if (Program.ketNoi() == 0) return;
            try
            {
                String strlenh = "EXEC SP_LAYCAUHOITHI N'" + txtMaLop.Text.Trim() + "',N'" + cmbMH.SelectedValue.ToString() + "',N'" + trinhDo + "',N'" + txtSoCauThi.Text.ToString() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                Program.myReader.Read();
                do
                {
                    int cauHoi = Program.myReader.GetInt32(0);

                    BaiThiLop b = new BaiThiLop(cauHoi, maDangKy);
                    BaiThiLop.baiThiLop.Add(b);
                } while (Program.myReader.Read());
                Program.myReader.Close();
            }
            catch(Exception ex)
            {
                return;
            }
          

            foreach (BaiThiLop bt in BaiThiLop.baiThiLop)
            {
                bAITHILOPBindingSource.AddNew();
                ((DataRowView)bAITHILOPBindingSource[bAITHILOPBindingSource.Position])["CAUHOI"] = bt.getCauHoi();
                ((DataRowView)bAITHILOPBindingSource[bAITHILOPBindingSource.Position])["MADANGKY"] = bt.getMaDangKy();
                bAITHILOPBindingSource.EndEdit();
            }
            try
            {
                bAITHILOPTableAdapter.Update(this.dS.BAITHILOP);
                MessageBox.Show("Tạo bài thi thành công", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
    }
}
