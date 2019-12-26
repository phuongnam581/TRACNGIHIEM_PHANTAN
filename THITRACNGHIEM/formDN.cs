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
    public partial class formDN : Form
    {
        public formDN()
        {
            InitializeComponent();
        }

        private void formDN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRAC_NGHIEMDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.tRAC_NGHIEMDataSet.V_DS_PHANMANH);
            cmbCoSo.SelectedIndex = 1;
            cmbCoSo.SelectedIndex = 0;
            rdoGV.Checked = true;

        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {       
            if (cmbCoSo.SelectedValue != null)
            {
                Program.servername = cmbCoSo.SelectedValue.ToString();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (rdoGV.Checked || rdoPGV.Checked)
            {
                if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được trống", "", MessageBoxButtons.OK);
                    return;
                }
            }else
            {
                if (txtTaiKhoan.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được trống", "", MessageBoxButtons.OK);
                    return;
                }
            }

            Program.servername = cmbCoSo.SelectedValue.ToString();
            Program.login = txtTaiKhoan.Text;
           
            if (rdoSV.Checked)
            {
                Program.password = "123";
            }
            else if(rdoGV.Checked || rdoPGV.Checked)
            {
                Program.password = txtMatKhau.Text;
            }

            if (Program.ketNoi() == 0) return;
            Program.bds_dspm = bdsDSPM;
            Program.mCoso = cmbCoSo.SelectedIndex;
            Program.loginDN = Program.login;
            Program.passwordDN = Program.password;
            String sql="";

            if (rdoGV.Checked)
            {
                sql = "EXEC sp_dngiangvien  '" + Program.login + "'";

            }
            else if(rdoSV.Checked)
            {
                sql = "EXEC sp_dnsv  '" + Program.login + "'";
            }
            else if (rdoPGV.Checked)
            {
                sql = "EXEC sp_dnpgv  '" + Program.login + "'";
            }

            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (rdoGV.Checked)
            {
                if (Program.myReader.GetString(2).Trim().Equals("Sinhvien") || Program.myReader.GetString(2).Trim().Equals("PGV"))
                {
                    MessageBox.Show("Đăng nhập không thành công\nXem lại thông tin đăng nhập.", "", MessageBoxButtons.OK);
                    return;
                }
            }
            else if(rdoSV.Checked)
            {
                if (Program.myReader.GetString(2).Trim().Equals("Giangvien") || Program.myReader.GetString(2).Trim().Equals("PGV"))
                {
                    MessageBox.Show("Đăng nhập không thành công\nXem lại thông tin đăng nhập.", "", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (rdoPGV.Checked)
            {
                if (Program.myReader.GetString(2).Trim().Equals("Giangvien") || Program.myReader.GetString(2).Trim().Equals("Sinhvien"))
                {
                    MessageBox.Show("Đăng nhập không thành công\nXem lại thông tin đăng nhập.", "", MessageBoxButtons.OK);
                    return;
                }
            }

            Program.username = Program.myReader.GetString(0).Trim();
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Bạn không có quyền truy cập", "", MessageBoxButtons.OK);
                return;
            }

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            if (rdoSV.Checked)
            {
                Program.formsv = new FormSV();
                Program.formsv.Activate();
                Program.formsv.Show();
            }
            else if(rdoGV.Checked || rdoPGV.Checked)
            {
                Program.formmain = new FormGVQL();
                Program.formmain.Activate();
                Program.formmain.Show();
            }

            this.Hide();

        }

        private void rdoSV_CheckedChanged(object sender, EventArgs e)
        {
            lblMK.Visible=false;
            txtMatKhau.Visible = false;
        }

        private void rdoGV_CheckedChanged(object sender, EventArgs e)
        {
            lblMK.Visible = true;
            txtMatKhau.Visible = true;
        }

        private void rdoPGV_CheckedChanged(object sender, EventArgs e)
        {
            lblMK.Visible = true;
            txtMatKhau.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }

    //private void btnThoat_Click(object sender, EventArgs e)
    //    {
    //      //  Close();
    //    }
}
