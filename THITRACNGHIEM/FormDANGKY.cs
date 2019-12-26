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
    public partial class FormDANGKY : Form
    {
        Boolean fv = true;
        Boolean clicksua = false;
        public FormDANGKY()
        {
            InitializeComponent();
        }

        private void FormDANGKY_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "PGV")
            {
                cmbltk.Items.Add("PGV");        
            }
            if (Program.mGroup == "KHOA")
            {
                cmbltk.Items.Add("KHOA");
                cmbltk.Items.Add("GIANGVIEN");
                cmbltk.Items.Add("SINHVIEN");

            }
            cmbltk.SelectedIndex = 0;
        }

        private void cmbltk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbltk.Text.Trim() == "SINHVIEN")
            {
                label2.Visible = txtlgn.Visible = true;

                label3.Text = "User name (Mã SV):";
                label4.Visible = txtpw.Visible = true;
                txtpw.ReadOnly = true;
                txtpw.Text = "123";
                fv = false;
            }
            else
            {
                label2.Visible = txtlgn.Visible = true;
                label3.Text = "User name:";
                fv = true;
            }
        }

        private void btndk_Click(object sender, EventArgs e)
        {
            if (fv && txtlgn.Text == "")
            {
                MessageBox.Show("Chưa có Login name");
                txtlgn.Focus();
                return;
            }
            if (txtusn.Text == "")
            {
                MessageBox.Show("Chưa có User name");
                txtusn.Focus();
                return;
            }
            try
            {
                if (cmbltk.Text.Trim() == "SINHVIEN")
                {
                    txtpw.Text = "123456";
                }
            }
            catch(Exception ex)
            {
                if (txtpw.Text == "")
                {
                    MessageBox.Show("Chưa có Password");
                    txtpw.Focus();
                    return;
                }
            }
            
            
            
            String username = txtusn.Text;
            String pw = txtpw.Text;
            String loginname = "";
            String kt = "";
            if (fv == false)
            {
                loginname = username;
                kt = "select  masv from SINHVIEN where masv = '" + username + "'";
            }
            if (fv == true)
            {
                loginname = txtlgn.Text;
                kt = "select magv from dbo.GIANGVIEN where magv ='" + username + "'";
            }

            Program.myReader = Program.ExecSqlDataReader(kt);


            if (Program.myReader == null)
            {
                MessageBox.Show("Chưa có thông tin user này");
                txtusn.Focus();
                return;
            }

            //Program.myReader.Read();
            //int count = Program.myReader.GetInt32(0);
            //Program.conn.Close();
            if (clicksua == false)
            {
                try
                {
                    if (Program.ketNoi() == 0) return;
                    String sqlLop = "dbo.SP_TaoTaiKhoan";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = sqlLop;
                    Program.sqlcmd.Parameters.Add("@LGNAME", SqlDbType.Char).Value = txtlgn.Text;
                    Program.sqlcmd.Parameters.Add("@PASS", SqlDbType.Char).Value = txtpw.Text;
                    Program.sqlcmd.Parameters.Add("@USERNAME", SqlDbType.Char).Value = txtusn.Text;
                    Program.sqlcmd.Parameters.Add("@ROLE", SqlDbType.Char).Value = cmbltk.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();

                    if (Ret != "1")
                    {
                        MessageBox.Show("Tạo Tài Khoản Thành Công");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "", MessageBoxButtons.OK);
                }

                Program.conn.Close();

            }
            else
            {
                MessageBox.Show("Chưa có thông tin user này");
                txtusn.Focus();
                return;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                new FormGVQL().Show();
                this.Close();
            }
        }
    }
}
