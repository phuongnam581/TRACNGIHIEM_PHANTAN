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
    public partial class FormBD : Form
    {
        public FormBD()
        {
            InitializeComponent();
        }

     

        private void FormBD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MON' table. You can move, or remove it, as needed.
           
            this.mONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONTableAdapter.Fill(this.dS.MON);
            mONBindingSource.Filter = "MAMH IN (" + danhSachMH() + ")";
            //cmbMHM.SelectedIndex = 0;
            // TODO: This line of code loads data into the 'dS.LUACHON' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
           // MessageBox.Show(cmbMHM.SelectedValue.ToString());
            //bODEBindingSource.Filter = "MAMH = '" + cmbMHM.SelectedValue.ToString() + "'";
          //  bODEBindingSource.Filter = "";
            this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lUACHONTableAdapter.Fill(this.dS.LUACHON);

           
        }

       
        private string danhSachMH()
        {
            
            String ds = "";
            String maKhoa = timMaKhoa();
            String strlenh = "EXEC dbo.SP_DSMH'" + maKhoa + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            while (Program.myReader.Read())
            {
                ds += "'" + Program.myReader.GetString(0) + "',";
            }

            return ds.Substring(0, ds.Length - 1);

           
        }
       
        private String timMaKhoa()
        {
            String maKhoa = "";
            String timMaKhoa = "select makh from giangvien where magv = '" + Program.username + "'";
            Program.myReader = Program.ExecSqlDataReader(timMaKhoa);
            if (Program.myReader.Read())
            {
                maKhoa = Program.myReader.GetString(0).ToString();
            }
            Program.conn.Close();
            return maKhoa;
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
    }
}
