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
    public partial class FormLayDe : Form
    {
        public FormLayDe()
        {
            InitializeComponent();
        }

        private void mONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormLayDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DANGKYTHI' table. You can move, or remove it, as needed.
            this.dANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTHITableAdapter.Fill(this.dS.DANGKYTHI);
            String maLop = "";
            String maKhoa = "";
            // TODO: This line of code loads data into the 'dS.MON' table. You can move, or remove it, as needed.
            this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONTableAdapter.Fill(this.dS.MON);
            cmbMaMon.SelectedIndex = -1;
            if (Program.mGroup == "Sinhvien")
            {
                if (Program.ketNoi() == 0) return;
                String strlenh = "EXEC SP_LAYMALOPTHEOSINHVIEN N'" + Program.username+ "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                while (Program.myReader.Read())
                {
                     maLop = Program.myReader.GetString(0);
                }
             
                txtMaLop.Text = maLop;
                txtMaLop.ReadOnly = true;           
            }
           
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            int dem = 0;
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Mã lớp không hợp lệ", "", MessageBoxButtons.OK);
                return;
            }
            if (cmbMaMon.SelectedIndex == -1)
            {
                MessageBox.Show("Mã môn không được trống", "", MessageBoxButtons.OK);
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
                MessageBox.Show("Lớp học chưa tồn tại trong cơ sở", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.ketNoi() == 0) return;
            String strlenh = "EXEC SP_KTRALOPDANGKY N'" + txtMaLop.Text.Trim() + "',N'" + cmbMaMon.SelectedValue.ToString() + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            while (Program.myReader.Read())
            {
                dem = Program.myReader.GetInt32(0);
            }
            if (dem < 1)
            {
                MessageBox.Show("Sinh viên không thi môn này", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.ketNoi() == 0) return;
            String sqlThi = "dbo.SP_KTRATHI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlThi;
            Program.sqlcmd.Parameters.Add("@MaLop", SqlDbType.Char).Value = txtMaLop.Text;
            Program.sqlcmd.Parameters.Add("@MaMon", SqlDbType.Char).Value = cmbMaMon.SelectedValue;
            Program.sqlcmd.Parameters.Add("@MaSV", SqlDbType.Char).Value = Program.username;
            Program.sqlcmd.Parameters.Add("@Ret2", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret2 = Program.sqlcmd.Parameters["@Ret2"].Value.ToString();
            if (Ret2 == "1")
            {
                MessageBox.Show("Sinh viên đã thi môn này!", "", MessageBoxButtons.OK);
                return;
            }
            dANGKYTHIBindingSource.Filter = "MAMON= '" + cmbMaMon.SelectedValue + "' AND MALOP= '" + txtMaLop.Text + "'";
            if (Program.ketNoi() == 0) return;
            String sqlBaiThiTonTai = "dbo.SP_KTRATAOBAITHI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = sqlBaiThiTonTai;
            Program.sqlcmd.Parameters.Add("@MADANGKY", SqlDbType.Int).Value = Int32.Parse(((DataRowView)dANGKYTHIBindingSource[dANGKYTHIBindingSource.Position])["MADANGKY"].ToString());
            Program.sqlcmd.Parameters.Add("@Ret3", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret3 = Program.sqlcmd.Parameters["@Ret3"].Value.ToString();
            if (Ret3 != "1")
            {
                MessageBox.Show("Bài thi chưa được tạo! Vui lòng liên hệ phòng giáo vụ", "", MessageBoxButtons.OK);
                return;
            }
            Program.maLop = txtMaLop.Text.ToString();
            Program.maMon = cmbMaMon.SelectedValue.ToString();

         //   Program.formLayde = new FormLayDe();
            this.Close();
            Program.formThi = new FormThi();
            Program.formThi.Activate();
            Program.formThi.Show();
            if (Program.mGroup == "Sinhvien")
            {
               // Program.formsv = new FormSV();
                Program.formsv.Close();
            }else if(Program.mGroup== "KHOA" || Program.mGroup == "Giangvien")
            {
               // Program.formmain = new FormGVQL();
                Program.formmain.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) //btnThoat
        {

            this.Close();
        }

        private void FormLayDe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.mGroup == "Giangvien" || Program.mGroup == "KHOA")
            {
             
                Program.formmain = new FormGVQL();
                Program.formmain.Show();
            }
            else if (Program.mGroup == "Sinhvien")
            {
               
                Program.formsv = new FormSV();
                Program.formsv.Show();
            }
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
