namespace THITRACNGHIEM
{
    partial class FormSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSV));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemKQ = new DevExpress.XtraBars.BarButtonItem();
            this.btnDX = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.maSV = new System.Windows.Forms.ToolStripStatusLabel();
            this.mHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.mNhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnThi,
            this.btnXemKQ,
            this.btnDX,
            this.btnThoat});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1228, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnThi
            // 
            this.btnThi.Caption = "Thi";
            this.btnThi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThi.Glyph")));
            this.btnThi.Id = 1;
            this.btnThi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThi.LargeGlyph")));
            this.btnThi.Name = "btnThi";
            this.btnThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThi_ItemClick);
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Caption = "Xem Kết Quả";
            this.btnXemKQ.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXemKQ.Glyph")));
            this.btnXemKQ.Id = 2;
            this.btnXemKQ.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXemKQ.LargeGlyph")));
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemKQ_ItemClick);
            // 
            // btnDX
            // 
            this.btnDX.Caption = "Đăng Xuất";
            this.btnDX.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDX.Glyph")));
            this.btnDX.Id = 3;
            this.btnDX.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDX.LargeGlyph")));
            this.btnDX.Name = "btnDX";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.Glyph")));
            this.btnThoat.Id = 4;
            this.btnThoat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.LargeGlyph")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXemKQ);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 373);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1228, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maSV,
            this.mHoTen,
            this.mNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1228, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // maSV
            // 
            this.maSV.Name = "maSV";
            this.maSV.Size = new System.Drawing.Size(45, 17);
            this.maSV.Text = "MA SV:";
            // 
            // mHoTen
            // 
            this.mHoTen.Name = "mHoTen";
            this.mHoTen.Size = new System.Drawing.Size(53, 17);
            this.mHoTen.Text = "HO TEN:";
            // 
            // mNhom
            // 
            this.mNhom.Name = "mNhom";
            this.mNhom.Size = new System.Drawing.Size(48, 17);
            this.mNhom.Text = "NHOM:";
            // 
            // FormSV
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 404);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSV";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FormSV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnThi;
        private DevExpress.XtraBars.BarButtonItem btnXemKQ;
        private DevExpress.XtraBars.BarButtonItem btnDX;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel maSV;
        private System.Windows.Forms.ToolStripStatusLabel mHoTen;
        private System.Windows.Forms.ToolStripStatusLabel mNhom;
    }
}