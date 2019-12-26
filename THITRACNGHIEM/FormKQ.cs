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
    public partial class FormKQ : Form
    {
        public FormKQ()
        {
            InitializeComponent();
        }

        private void lblSoCau_Click(object sender, EventArgs e)
        {

        }

        private void FormKQ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            lblSoCau.Text += FormThi.soCau;
            lblDung.Text += FormThi.caudung;
            lblDiem.Text += FormThi.diem;
        }

        private void FormKQ_FormClosing(object sender, FormClosingEventArgs e)
        {
             FormThi.demThoat=false;
            FormThi.check = true;
           // FormThi frm = new FormThi();
          //  frm.btnThoat.Enabled = true;
       
            if (Program.mGroup == "Sinhvien")
            {
                bANGDIEMBindingSource.AddNew();
                ((DataRowView)bANGDIEMBindingSource[bANGDIEMBindingSource.Position])["MADANGKY"] = FormThi.maDangKy;
                ((DataRowView)bANGDIEMBindingSource[bANGDIEMBindingSource.Position])["MASV"] = Program.username;
                ((DataRowView)bANGDIEMBindingSource[bANGDIEMBindingSource.Position])["DIEM"] = FormThi.diem;
                bANGDIEMBindingSource.EndEdit();
                try
                {
                    bANGDIEMTableAdapter.Update(this.dS.BANGDIEM);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }      
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            //  FormThi formThi = new FormThi();
            // formThi.Activate();
          
                this.Close();
                Program.formThi.Show();
           
            
        }

        private void bANGDIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bANGDIEMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
    }
}
