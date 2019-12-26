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
    public partial class FormBoDe : Form
    {
        int vitri;
        String maKhoa = "";
        private String GetMaKhoa()
        {
            String maKhoa = timMaKhoa();
            return maKhoa;
        }
        public FormBoDe()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormBoDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MON' table. You can move, or remove it, as needed.
           
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);

         
            // TODO: This line of code loads data into the 'dS.LUACHON' table. You can move, or remove it, as needed.
            this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lUACHONTableAdapter.Fill(this.dS.LUACHON);

            this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONTableAdapter.Fill(this.dS.MON);
            maKhoa = timMaKhoa();
         //   mONBindingSource.Filter = "MAKH = '" + maKhoa + "'";
            if (Program.mGroup == "PGV")
            {
                cmbCoSo.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPH.Enabled = btnPH.Enabled = btnGhi.Enabled =btnRefresh.Enabled =false;
                contextMenuStrip1.Enabled = false;
                bODEBindingSource.Filter = "STATUS = 0";
                groupBox1.Enabled = groupBox2.Enabled = false;
                btnThoat.Enabled = true;
            }
            else if (Program.mGroup == "KHOA")
            {
                cmbCoSo.Enabled = false;
                btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnPH.Enabled = btnPH.Enabled = btnGhi.Enabled = true;
                btnGhi.Enabled = btnPH.Enabled = false;
                bODEGridControl.Enabled = lUACHONGridControl.Enabled = true;
                groupBox1.Enabled = groupBox2.Enabled = false;
                contextMenuStrip1.Enabled = true;
                thêmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = true;
                phụcHồiToolStripMenuItem.Enabled = false;
                bODEBindingSource.Filter = "MAMH IN (" + danhSachMH() + ") AND STATUS = 0";
            }
            else if (Program.mGroup == "Giangvien")
            {
                cmbCoSo.Enabled = false;
                btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnPH.Enabled = btnPH.Enabled = true;
                thêmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = true;
                btnGhi.Enabled = btnPH.Enabled = false;
                bODEGridControl.Enabled = lUACHONGridControl.Enabled = true;
                groupBox1.Enabled = groupBox2.Enabled = false;
                contextMenuStrip1.Enabled = true;
                phụcHồiToolStripMenuItem.Enabled = false;
                
                bODEBindingSource.Filter = "MAGV = '" + Program.username + "' AND STATUS = 0";
            }
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";

            bODEBindingSource.Sort = "MAMH DESC";
         
            // Console.WriteLine(((DataRowView)bODEBindingSource[0])["TRINHDO"].ToString());
        }

        private string danhSachMH()
        {

            String ds = "";
           // String maKhoa = GetMaKhoa();
            Program.myReader = null;
            if (Program.ketNoi() == 0) return "NO CONNECT";
            String strlenh = "EXEC dbo.SP_DSMH'" + maKhoa + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            while (Program.myReader.Read())
            {
                ds += "'" + Program.myReader.GetString(0) + "',";
            }
            Program.conn.Close();
            return ds.Substring(0, ds.Length - 1);
        }

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

     
        private void bODEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

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
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Fill(this.dS.BODE);

                }
                catch (Exception ex) { }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Console.WriteLine(lUACHONBindingSource.Count);
            //return;
            btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnXoa.Enabled =false;
            btnPH.Enabled = true;
            bODEGridControl.Enabled =false;
            groupBox1.Enabled = true;
            btnGhi.Enabled = true;
            lUACHONGridControl.Enabled = groupBox2.Enabled = false;
            contextMenuStrip1.Enabled = false;
            txtMaGV.Text = Program.username; txtMaGV.Enabled = txtCH.Enabled = txtStatus.Enabled =false;
            bODEBindingSource.AddNew();
            txtStatus.Text = "0";
            cmbDapAn.SelectedIndex = cmbTrinhDo.SelectedIndex =cmbMH.SelectedIndex =-1;
       
            vitri = bODEBindingSource.Position;
            
            if (Program.ketNoi() == 0) return;
            String sqlMaCauHoi = "dbo.SP_MACAUHOI";

            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlMaCauHoi;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            txtCH.Text = Ret;
            txtMaGV.Text = Program.username;
            Program.control = "Add";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnXoa.Enabled=false;
            btnPH.Enabled = btnGhi.Enabled = true;
            bODEGridControl.Enabled = groupBox1.Enabled = true;
            lUACHONGridControl.Enabled = groupBox2.Enabled = false;
            contextMenuStrip1.Enabled = false;
            txtMaGV.Enabled = txtStatus.Enabled = false;

            vitri = bODEBindingSource.Position;
            Program.control = "Edit";

        }

        private void btnPH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            bODEBindingSource.CancelEdit();
            btnPH.Enabled = false;
            bODEGridControl.Enabled = true;
            groupBox1.Enabled = groupBox2.Enabled =false;
            lUACHONGridControl.Enabled = true;
            btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnRefresh.Enabled =btnXoa.Enabled= true;
            btnGhi.Enabled = false;
            contextMenuStrip1.Enabled = true;
            thêmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled =true;
            sửaToolStripMenuItem.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          

            if (txtND.Text == "")
            {
                MessageBox.Show("Nội dung không được rỗng", "", MessageBoxButtons.OK);
                txtND.Focus();
                return;
            }
       //     Console.WriteLine(cmbTrinhDo.GetItemText(cmbTrinhDo.SelectedItem));return;
            if (cmbTrinhDo.GetItemText(cmbTrinhDo.SelectedItem)!="DHCQ" && cmbTrinhDo.GetItemText(cmbTrinhDo.SelectedItem) != "CDCQ" && cmbTrinhDo.GetItemText(cmbTrinhDo.SelectedItem) != "VB2")
            {
                MessageBox.Show("Trình độ không hợp lệ", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.ketNoi() == 0) return;
            String sqlMaMon = "SP_KTMH_TONTAI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlMaMon;
            Program.sqlcmd.Parameters.Add("@mamon", SqlDbType.Char).Value = cmbMH.SelectedValue;
            Program.sqlcmd.Parameters.Add("@Ret1", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret1 = Program.sqlcmd.Parameters["@Ret1"].Value.ToString();
            if (Ret1 == "0")
            {
                MessageBox.Show("Môn học chưa tồn tại");
                cmbMH.Focus();
                return;
            }

            if (Program.ketNoi() == 0) return;
            String sqlCauHoi = "dbo.SP_KTRA_CAUHOITRUNG" ;
          
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlCauHoi;
            Program.sqlcmd.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = txtND.Text;
            Program.sqlcmd.Parameters.Add("@mamon", SqlDbType.Char).Value = cmbMH.SelectedValue;
            Program.sqlcmd.Parameters.Add("@cauhoi", SqlDbType.Int).Value = Int32.Parse(txtCH.Text.Trim());
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret == "1")
            {
                MessageBox.Show("Nội dung câu hỏi bị trùng");
                cmbMH.Focus();
                return;
            }

            if (Program.control == "Add")
            {
                if (cmbTrinhDo.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn trình độ", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if (cmbTrinhDo.SelectedIndex == 0)
                    {
                        ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["TRINHDO"] = "DHCQ";
                    }
                    if (cmbTrinhDo.SelectedIndex == 1)
                    {
                        ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["TRINHDO"] = "CDCQ";
                    }
                    if (cmbTrinhDo.SelectedIndex == 2)
                    {
                        ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["TRINHDO"] = "VB2";
                    }
                }
                if (cmbDapAn.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn đáp án", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if (cmbDapAn.SelectedIndex == 0)
                    {
                        ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["DAPAN"] = "A";
                    }
                    else if (cmbDapAn.SelectedIndex == 1)
                    {
                        ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["DAPAN"] = "B";
                    }
                    else if (cmbDapAn.SelectedIndex == 2)
                    {
                        ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["DAPAN"] = "C";
                    }
                    else if (cmbDapAn.SelectedIndex == 3)
                    {
                        ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["DAPAN"] = "D";
                    }
                    else if (cmbDapAn.SelectedIndex == 3)
                    {
                        ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["DAPAN"] = "E";
                    }
                    else if (cmbDapAn.SelectedIndex == 4)
                    {
                        ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["DAPAN"] = "F";
                    }
                }

                if (cmbMH.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn môn học", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {        
                        ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["MAMH"] = cmbMH.SelectedValue.ToString();
                }

                try
                {
                    this.Validate();
                    bODEBindingSource.EndEdit();
                    bODEBindingSource.ResetCurrentItem();
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Update(this.dS.BODE);
                    MessageBox.Show("Đã thêm câu hỏi thành công", "", MessageBoxButtons.OK);
                    btnRefresh.Enabled = btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnPH.Enabled = true;
                    btnGhi.Enabled = false;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
               
            }
            else if (Program.control == "Edit")
            {
                try
                {
                    
                    bODEBindingSource.EndEdit();
                    bODEBindingSource.ResetCurrentItem();
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Update(this.dS.BODE);
                    MessageBox.Show("Đã sửa câu hỏi thành công", "", MessageBoxButtons.OK);
                    btnRefresh.Enabled = btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnPH.Enabled = true;
                    btnGhi.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            //this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            //this.bODETableAdapter.Fill(this.dS.BODE);
            //if (Program.mGroup == "Giangvien")
            //{
            //    bODEBindingSource.Filter = "MAGV = '" + Program.username + "'";
            //}else if(Program.mGroup== "KHOA")
            //{
            //    bODEBindingSource.Filter = "MAMH IN (" + danhSachMH() + ")";
            //}

            cmbCoSo.Enabled = false;
            btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnPH.Enabled = btnPH.Enabled = true;
            thêmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = true;
            btnGhi.Enabled = btnPH.Enabled = false;
            bODEGridControl.Enabled = lUACHONGridControl.Enabled = true;
            groupBox1.Enabled = groupBox2.Enabled = false;
            contextMenuStrip1.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String cauhoi = ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["CAUHOI"].ToString();
            int CAUHOI = Int32.Parse(cauhoi);
            if (MessageBox.Show("Bạn có muốn xóa câu hỏi số " + txtCH.Text + " không?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Program.ketNoi() == 0) return;
                String sqlCauHoi = "dbo.SP_CAUHOICOLUACHON";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = sqlCauHoi;
                Program.sqlcmd.Parameters.Add("@cauhoi", SqlDbType.Int).Value = CAUHOI;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret == "1")
                {
                    ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["status"] = 1;
                    try
                    {
                        bODEBindingSource.EndEdit();
                        bODEBindingSource.ResetCurrentItem();
                        this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                        this.bODETableAdapter.Update(this.dS.BODE);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa câu hỏi. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                        return;
                    }
                }
                  
                }
                else
                {
                try
                {
                    bODEBindingSource.RemoveCurrent();
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Update(this.dS.BODE);
                }
                
                catch (Exception ex)
                {
                     MessageBox.Show("Lỗi xóa câu hỏi. Bạn hãy xóa lại\n" + ex.Message, "",
                     MessageBoxButtons.OK);
                     return;
                }
                   
                MessageBox.Show("Bạn đã xóa câu hỏi thành công", "", MessageBoxButtons.OK);
            }
         
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Fill(this.dS.BODE);

                // TODO: This line of code loads data into the 'dS.LUACHON' table. You can move, or remove it, as needed.
                this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lUACHONTableAdapter.Fill(this.dS.LUACHON);
                if (Program.mGroup == "PGV")
                {
                    cmbCoSo.Enabled = true;
                    btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnPH.Enabled = btnPH.Enabled = btnGhi.Enabled = false;
                    contextMenuStrip1.Enabled = false;
                    bODEBindingSource.Filter = "STATUS = 0";
                }
                else if (Program.mGroup == "KHOA")
                {
                    cmbCoSo.Enabled = false;
                    btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnPH.Enabled = btnPH.Enabled = btnGhi.Enabled = true;
                    btnGhi.Enabled = btnPH.Enabled = false;
                    bODEGridControl.Enabled = lUACHONGridControl.Enabled = true;
                    groupBox1.Enabled = groupBox2.Enabled = false;
                    contextMenuStrip1.Enabled = true;
                    thêmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = true;
                    bODEBindingSource.Filter = "MAMH IN (" + danhSachMH() + ") AND STATUS = 0";
                }
                else if (Program.mGroup == "Giangvien")
                {
                    cmbCoSo.Enabled = false;
                    btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnPH.Enabled = btnPH.Enabled = true;
                    thêmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = true;
                    btnGhi.Enabled = btnPH.Enabled = false;
                    bODEGridControl.Enabled = lUACHONGridControl.Enabled = true;
                    groupBox1.Enabled = groupBox2.Enabled = false;
                    contextMenuStrip1.Enabled = true;
                    bODEBindingSource.Filter = "MAGV = '" + Program.username + "' AND STATUS = 0";
                }
                cmbCoSo.DataSource = Program.bds_dspm;
                cmbCoSo.DisplayMember = "TENCN";
                cmbCoSo.ValueMember = "TENSERVER";
                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            FormGVQL gvql = new FormGVQL();
            gvql.Show();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Enabled = false;
            bODEGridControl.Enabled = lUACHONGridControl.Enabled = false;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnThoat.Enabled =btnRefresh.Enabled =false;
            cmbCoSo.Enabled = false;
            btnPH.Enabled = true;
            groupBox2.Enabled = true;
            txtLCCH.Enabled = txtLCTT.Enabled = false;
            phụcHồiToolStripMenuItem.Enabled = true;
            thêmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = false;
            if (lUACHONBindingSource.Count == 0)
            {
                MessageBox.Show("Không có lựa chọn để sửa", "", MessageBoxButtons.OK);
                groupBox2.Enabled = false;
                return;
            }
            Program.control = "Edit";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtLCMT.Text == "")
            {
                MessageBox.Show("Mô tả không được rỗng", "", MessageBoxButtons.OK);
                txtLCMT.Focus();
                return;
            }
            if (Program.ketNoi() == 0) return;
            String sqlCauHoi = "dbo.SP_KTRA_MOTATRUNG";

            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlCauHoi;
            Program.sqlcmd.Parameters.Add("@mota", SqlDbType.NVarChar).Value = txtLCMT.Text;
            Program.sqlcmd.Parameters.Add("@maluachon", SqlDbType.Int).Value = ((DataRowView)lUACHONBindingSource[lUACHONBindingSource.Position])["MALUACHON"];
            Program.sqlcmd.Parameters.Add("@cauhoi", SqlDbType.Int).Value = Int32.Parse(txtCH.Text.Trim());
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret == "1")
            {
                MessageBox.Show("Mô tả bị trùng");
                cmbMH.Focus();
                return;
            }

            if (Program.control == "Edit")
            {
                try
                {

                    lUACHONBindingSource.EndEdit();
                    lUACHONBindingSource.ResetCurrentItem();
                    this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lUACHONTableAdapter.Update(this.dS.LUACHON);
                    MessageBox.Show("Đã sửa lựa chọn thành công", "", MessageBoxButtons.OK);
                    groupBox1.Enabled = groupBox2.Enabled = false;
                    lUACHONGridControl.Enabled = bODEGridControl.Enabled = true;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = btnRefresh.Enabled =btnXoa.Enabled =true;
                    btnPH.Enabled = btnGhi.Enabled =false;
                    contextMenuStrip1.Enabled = true;
                    thêmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = true;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }else if (Program.control == "Add")
            {
                try
                {
                    this.Validate();
                    lUACHONBindingSource.EndEdit();
                    lUACHONBindingSource.ResetCurrentItem();
                    this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lUACHONTableAdapter.Update(this.dS.LUACHON);
                    MessageBox.Show("Đã thêm lựa chọn thành công", "", MessageBoxButtons.OK);
                    btnRefresh.Enabled = btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnXoa.Enabled=true;
                    btnGhi.Enabled =btnPH.Enabled =false;
                    contextMenuStrip1.Enabled = true;
                    thêmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled =true;
                    groupBox1.Enabled = groupBox2.Enabled = false;
                    lUACHONGridControl.Enabled = bODEGridControl.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lUACHONBindingSource.AddNew();
            lUACHONGridControl.Enabled = bODEGridControl.Enabled = false;
            groupBox1.Enabled = false;
            cmbCoSo.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnGhi.Enabled = btnThoat.Enabled =btnPH.Enabled =false;
            groupBox2.Enabled = true;
            txtLCCH.Enabled = txtLCTT.Enabled = false;
            thêmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = false;
            phụcHồiToolStripMenuItem.Enabled = true;
            Program.control = "Add";
            if(lUACHONBindingSource.Count <= 6)
            {
                String Ret="";
                if(((DataRowView)lUACHONBindingSource[0])["THUTU"].ToString() == "")
                {
                    Ret = "A";
                }else
                {
                    Program.myReader = null;
                    int kn = Program.ketNoi();
                    String strlenh = "EXEC SP_KiTU '" + ((DataRowView)lUACHONBindingSource[lUACHONBindingSource.Count - 2])["THUTU"].ToString() + "'";
                    // ((DataRowView)bds[i])["field"].ToString()
                    Program.myReader = Program.ExecSqlDataReader(strlenh);
                    while (Program.myReader.Read())
                    {
                        Ret = Program.myReader.GetString(0);
                      
                    }
                }
              
                txtLCTT.Text = Ret;  
            }
            else
            {
                MessageBox.Show("Câu hỏi đã đủ lựa chọn", "", MessageBoxButtons.OK);
                this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lUACHONTableAdapter.Fill(this.dS.LUACHON);
                thêmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = true;
                phụcHồiToolStripMenuItem.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
                btnGhi.Enabled = btnPH.Enabled = false;
                lUACHONGridControl.Enabled = bODEGridControl.Enabled = true;
                groupBox1.Enabled = groupBox2.Enabled = false;
            }
           
        }

        private void cmbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["MAMH"] = cmbMH.SelectedValue.ToString();
            }
            catch (Exception ex) { }
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lUACHONTableAdapter.Fill(this.dS.LUACHON);
            thêmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled=true;
            phụcHồiToolStripMenuItem.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
            btnGhi.Enabled = btnPH.Enabled = false;
            lUACHONGridControl.Enabled = bODEGridControl.Enabled = true;
            groupBox1.Enabled = groupBox2.Enabled = false;

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lUACHONBindingSource.Count == 0)
            {
                MessageBox.Show("Không có lựa chọ để xóa", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lựa chọn này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    lUACHONBindingSource.RemoveCurrent();
                    this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lUACHONTableAdapter.Update(this.dS.LUACHON);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lUACHONTableAdapter.Fill(this.dS.LUACHON);
                    return;
                }
            }
            if (lUACHONBindingSource.Count == 0) btnXoa.Enabled = false;
        }
    }
}

