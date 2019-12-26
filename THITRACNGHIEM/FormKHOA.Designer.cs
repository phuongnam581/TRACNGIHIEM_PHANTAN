namespace THITRACNGHIEM
{
    partial class FormKHOA
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKHOA));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarButtonItem();
            this.btnsua = new DevExpress.XtraBars.BarButtonItem();
            this.btnghi = new DevExpress.XtraBars.BarButtonItem();
            this.btnxoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnphuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnrefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnthoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbcoso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new THITRACNGHIEM.DS();
            this.KHOA_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new THITRACNGHIEM.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.gIANGVIENTableAdapter = new THITRACNGHIEM.DSTableAdapters.GIANGVIENTableAdapter();
            this.lOPTableAdapter = new THITRACNGHIEM.DSTableAdapters.LOPTableAdapter();
            this.mONTableAdapter = new THITRACNGHIEM.DSTableAdapters.MONTableAdapter();
            this.kHOAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtstt = new DevExpress.XtraEditors.SpinEdit();
            this.txtmacs = new DevExpress.XtraEditors.TextEdit();
            this.txttenkhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtmakh = new DevExpress.XtraEditors.TextEdit();
            this.MON_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.LOP_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.GV_BDS = new System.Windows.Forms.BindingSource(this.components);
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHOA_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtstt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MON_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDS)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(103, 64);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(60, 19);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "MAKH:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(98, 144);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(65, 19);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "TENKH:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(507, 64);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(57, 19);
            mACSLabel.TabIndex = 4;
            mACSLabel.Text = "MACS:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(515, 145);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(46, 19);
            statusLabel.TabIndex = 6;
            statusLabel.Text = "status:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnthem,
            this.btnsua,
            this.btnghi,
            this.btnxoa,
            this.btnphuchoi,
            this.btnrefresh,
            this.btnthoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnthem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnxoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnphuchoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnrefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnthoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnthem
            // 
            this.btnthem.Caption = "THÊM";
            this.btnthem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnthem.Glyph")));
            this.btnthem.Id = 0;
            this.btnthem.Name = "btnthem";
            this.btnthem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthem_ItemClick);
            // 
            // btnsua
            // 
            this.btnsua.Caption = "SỬA";
            this.btnsua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnsua.Glyph")));
            this.btnsua.Id = 1;
            this.btnsua.Name = "btnsua";
            this.btnsua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsua_ItemClick);
            // 
            // btnghi
            // 
            this.btnghi.Caption = "GHI";
            this.btnghi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnghi.Glyph")));
            this.btnghi.Id = 2;
            this.btnghi.Name = "btnghi";
            this.btnghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnghi_ItemClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Caption = "XÓA";
            this.btnxoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnxoa.Glyph")));
            this.btnxoa.Id = 3;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoa_ItemClick);
            // 
            // btnphuchoi
            // 
            this.btnphuchoi.Caption = "PHỤC HỒI";
            this.btnphuchoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnphuchoi.Glyph")));
            this.btnphuchoi.Id = 4;
            this.btnphuchoi.Name = "btnphuchoi";
            this.btnphuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnphuchoi_ItemClick);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Caption = "REFRESH";
            this.btnrefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Glyph")));
            this.btnrefresh.Id = 5;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnrefresh_ItemClick);
            // 
            // btnthoat
            // 
            this.btnthoat.Caption = "THOÁT";
            this.btnthoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnthoat.Glyph")));
            this.btnthoat.Id = 6;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1335, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 699);
            this.barDockControlBottom.Size = new System.Drawing.Size(1335, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 659);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1335, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 659);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbcoso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 73);
            this.panel1.TabIndex = 4;
            // 
            // cmbcoso
            // 
            this.cmbcoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcoso.FormattingEnabled = true;
            this.cmbcoso.Location = new System.Drawing.Point(326, 23);
            this.cmbcoso.Name = "cmbcoso";
            this.cmbcoso.Size = new System.Drawing.Size(297, 25);
            this.cmbcoso.TabIndex = 1;
            this.cmbcoso.SelectedIndexChanged += new System.EventHandler(this.cmbcoso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN CƠ SỞ :";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KHOA_BDS
            // 
            this.KHOA_BDS.DataMember = "KHOA";
            this.KHOA_BDS.DataSource = this.dS;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHILOPTableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = this.mONTableAdapter;
            this.tableAdapterManager.NVGIAOVUTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONTableAdapter
            // 
            this.mONTableAdapter.ClearBeforeFill = true;
            // 
            // kHOAGridControl
            // 
            this.kHOAGridControl.DataSource = this.KHOA_BDS;
            this.kHOAGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.kHOAGridControl.Location = new System.Drawing.Point(0, 113);
            this.kHOAGridControl.MainView = this.gridView1;
            this.kHOAGridControl.MenuManager = this.barManager1;
            this.kHOAGridControl.Name = "kHOAGridControl";
            this.kHOAGridControl.Size = new System.Drawing.Size(1335, 143);
            this.kHOAGridControl.TabIndex = 6;
            this.kHOAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MACS,
            this.MAKH,
            this.STATUS,
            this.TENKH});
            this.gridView1.GridControl = this.kHOAGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // MACS
            // 
            this.MACS.FieldName = "MACS";
            this.MACS.Name = "MACS";
            this.MACS.OptionsColumn.ReadOnly = true;
            this.MACS.Visible = true;
            this.MACS.VisibleIndex = 2;
            // 
            // MAKH
            // 
            this.MAKH.FieldName = "MAKH";
            this.MAKH.Name = "MAKH";
            this.MAKH.OptionsColumn.ReadOnly = true;
            this.MAKH.Visible = true;
            this.MAKH.VisibleIndex = 1;
            // 
            // STATUS
            // 
            this.STATUS.FieldName = "status";
            this.STATUS.Name = "STATUS";
            this.STATUS.OptionsColumn.ReadOnly = true;
            this.STATUS.Visible = true;
            this.STATUS.VisibleIndex = 3;
            // 
            // TENKH
            // 
            this.TENKH.FieldName = "TENKH";
            this.TENKH.Name = "TENKH";
            this.TENKH.OptionsColumn.ReadOnly = true;
            this.TENKH.Visible = true;
            this.TENKH.VisibleIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.txtstt);
            this.groupBox1.Controls.Add(mACSLabel);
            this.groupBox1.Controls.Add(this.txtmacs);
            this.groupBox1.Controls.Add(tENKHLabel);
            this.groupBox1.Controls.Add(this.txttenkhoa);
            this.groupBox1.Controls.Add(mAKHLabel);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1335, 443);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtstt
            // 
            this.txtstt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.KHOA_BDS, "status", true));
            this.txtstt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtstt.Location = new System.Drawing.Point(566, 142);
            this.txtstt.MenuManager = this.barManager1;
            this.txtstt.Name = "txtstt";
            this.txtstt.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstt.Properties.Appearance.Options.UseFont = true;
            this.txtstt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtstt.Size = new System.Drawing.Size(246, 26);
            this.txtstt.TabIndex = 7;
            // 
            // txtmacs
            // 
            this.txtmacs.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.KHOA_BDS, "MACS", true));
            this.txtmacs.Location = new System.Drawing.Point(566, 61);
            this.txtmacs.MenuManager = this.barManager1;
            this.txtmacs.Name = "txtmacs";
            this.txtmacs.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmacs.Properties.Appearance.Options.UseFont = true;
            this.txtmacs.Size = new System.Drawing.Size(246, 26);
            this.txtmacs.TabIndex = 5;
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.KHOA_BDS, "TENKH", true));
            this.txttenkhoa.Location = new System.Drawing.Point(166, 141);
            this.txttenkhoa.MenuManager = this.barManager1;
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkhoa.Properties.Appearance.Options.UseFont = true;
            this.txttenkhoa.Size = new System.Drawing.Size(246, 26);
            this.txttenkhoa.TabIndex = 3;
            // 
            // txtmakh
            // 
            this.txtmakh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.KHOA_BDS, "MAKH", true));
            this.txtmakh.Location = new System.Drawing.Point(166, 61);
            this.txtmakh.MenuManager = this.barManager1;
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.Properties.Appearance.Options.UseFont = true;
            this.txtmakh.Size = new System.Drawing.Size(246, 26);
            this.txtmakh.TabIndex = 1;
            // 
            // MON_BDS
            // 
            this.MON_BDS.DataMember = "MON";
            this.MON_BDS.DataSource = this.dS;
            // 
            // LOP_BDS
            // 
            this.LOP_BDS.DataMember = "LOP";
            this.LOP_BDS.DataSource = this.dS;
            // 
            // GV_BDS
            // 
            this.GV_BDS.DataMember = "GIANGVIEN";
            this.GV_BDS.DataSource = this.dS;
            // 
            // FormKHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 722);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kHOAGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKHOA";
            this.Text = "FormKHOA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKHOA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHOA_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtstt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MON_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnthem;
        private DevExpress.XtraBars.BarButtonItem btnsua;
        private DevExpress.XtraBars.BarButtonItem btnghi;
        private DevExpress.XtraBars.BarButtonItem btnxoa;
        private DevExpress.XtraBars.BarButtonItem btnphuchoi;
        private DevExpress.XtraBars.BarButtonItem btnrefresh;
        private DevExpress.XtraBars.BarButtonItem btnthoat;
        private System.Windows.Forms.BindingSource KHOA_BDS;
        private DS dS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbcoso;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl kHOAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MACS;
        private DevExpress.XtraGrid.Columns.GridColumn MAKH;
        private DevExpress.XtraGrid.Columns.GridColumn STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn TENKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SpinEdit txtstt;
        private DevExpress.XtraEditors.TextEdit txtmacs;
        private DevExpress.XtraEditors.TextEdit txttenkhoa;
        private DevExpress.XtraEditors.TextEdit txtmakh;
        private DSTableAdapters.MONTableAdapter mONTableAdapter;
        private System.Windows.Forms.BindingSource MON_BDS;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource LOP_BDS;
        private DSTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private System.Windows.Forms.BindingSource GV_BDS;
    }
}