using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THITRACNGHIEM
{
    public partial class FormGVQL : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormGVQL()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void FormGVQL_Load(object sender, EventArgs e)
        {
            maNV.Text = "Mã số: " + Program.username;
            mHoTen.Text = "Họ tên: " + Program.mHoten;
            mNhom.Text = "Nhóm: " + Program.mGroup;
            if (Program.mGroup == "Giangvien")
            {
                btnTaoTK.Enabled = btnMon.Enabled = btnKhoa.Enabled = btnGV.Enabled = btnSV.Enabled = btnDKT.Enabled = false;
            }
            else if (Program.mGroup == "KHOA")
            {
                btnDKT.Enabled = false;
            }else if (Program.mGroup == "PGV")
            {
                btnTT.Enabled = false;
            }

        }

        private void btnDN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formDN));
            if (form == null)
            {
                //IsMdiContainer = true;
                formDN f = new formDN();
                //f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
            this.Close();
        }

      

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                new formDN().Show();
                this.Close();
            }
        }

        private void btnMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormMon));
            if (form == null)
            {
                //IsMdiContainer = true;
                FormMon f = new FormMon();
                //f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
            this.Close();
        }

        private void btnBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormBoDe));
            if (form == null)
            {
                //IsMdiContainer = true;
                FormBoDe f = new FormBoDe();
                //f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
            this.Close();
        }

        private void btnDKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormDKThi));
            if (form == null)
            {
                //IsMdiContainer = true;
                FormDKThi f = new FormDKThi();
                //f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
            this.Close();
        }

        private void btnGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormGIANGVIEN));
            if (form == null)
            {
                //IsMdiContainer = true;
                FormGIANGVIEN f = new FormGIANGVIEN();
                //f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
            this.Close();
        }

        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormKHOA));
            if (form == null)
            {
                //IsMdiContainer = true;
                FormKHOA f = new FormKHOA();
                //f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
            this.Close();
        }

        private void btnSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormSV_LOP));
            if (form == null)
            {
                //IsMdiContainer = true;
                FormSV_LOP f = new FormSV_LOP();
                //f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
            this.Close();
        }

        private void btnD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormINBANGDIEM));
            if (form == null)
            {
                //IsMdiContainer = true;
                FormINBANGDIEM f = new FormINBANGDIEM();
                //f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
            this.Close();
        }

        private void btnTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormLayDe));
            if (form == null)
            {
                //IsMdiContainer = true;
                FormLayDe f = new FormLayDe();
                //f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
            this.Close();
        }

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormDANGKY));
            if (form == null)
            {
                //IsMdiContainer = true;
                FormDANGKY f = new FormDANGKY();
                //f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
            this.Close();
        }
    }
}
