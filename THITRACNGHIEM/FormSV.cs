using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace THITRACNGHIEM
{
    public partial class FormSV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormSV()
        {
            InitializeComponent();
        }

        private void FormSV_Load(object sender, EventArgs e)
        {
            maSV.Text = "Mã Sinh Viên: "+Program.username;
            mHoTen.Text = "Họ Tên: "+Program.mHoten;
            mNhom.Text = "Nhóm: "+Program.mGroup;
        }
      
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                new formDN().Show();
                this.Close();
            }
        }

        private void btnThi_ItemClick(object sender, ItemClickEventArgs e)
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

        private void btnXemKQ_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormInKQ));
            if (form == null)
            {
                //IsMdiContainer = true;
                FormInKQ f = new FormInKQ();
                //f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
            this.Close();
        }
    }
}