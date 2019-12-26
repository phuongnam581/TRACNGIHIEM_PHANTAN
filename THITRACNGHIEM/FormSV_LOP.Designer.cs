namespace THITRACNGHIEM
{
    partial class FormSV_LOP
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label mALOPLabel1;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label statusLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSV_LOP));
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
            this.SV_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new THITRACNGHIEM.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.bODETableAdapter = new THITRACNGHIEM.DSTableAdapters.BODETableAdapter();
            this.cTBAITHITableAdapter = new THITRACNGHIEM.DSTableAdapters.CTBAITHITableAdapter();
            this.dANGKYTHITableAdapter = new THITRACNGHIEM.DSTableAdapters.DANGKYTHITableAdapter();
            this.lOPTableAdapter = new THITRACNGHIEM.DSTableAdapters.LOPTableAdapter();
            this.sINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtstt = new DevExpress.XtraEditors.SpinEdit();
            this.txtmalop = new DevExpress.XtraEditors.TextEdit();
            this.txtdc = new DevExpress.XtraEditors.TextEdit();
            this.txtngaysinh = new DevExpress.XtraEditors.DateEdit();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.txtho = new DevExpress.XtraEditors.TextEdit();
            this.txtmasv = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.LOP_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ML = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.txtstt1 = new DevExpress.XtraEditors.SpinEdit();
            this.txttenlop = new DevExpress.XtraEditors.TextEdit();
            this.txtmakh = new DevExpress.XtraEditors.TextEdit();
            this.txtmalop1 = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.CTBT_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.BD_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.DKT_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tHÊMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sỬAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xÓAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEFRESHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            mALOPLabel1 = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            statusLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtstt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaysinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaysinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmasv.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtstt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenlop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalop1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTBT_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DKT_BDS)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(14, 58);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(56, 19);
            mASVLabel.TabIndex = 1;
            mASVLabel.Text = "MASV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(34, 137);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(35, 19);
            hOLabel.TabIndex = 3;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(27, 213);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(42, 19);
            tENLabel.TabIndex = 5;
            tENLabel.Text = "TEN:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(309, 213);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(93, 19);
            nGAYSINHLabel.TabIndex = 7;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(333, 60);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(66, 19);
            dIACHILabel.TabIndex = 9;
            dIACHILabel.Text = "DIACHI:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(333, 141);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(67, 19);
            mALOPLabel.TabIndex = 11;
            mALOPLabel.Text = "MALOP:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(22, 293);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(46, 19);
            statusLabel.TabIndex = 13;
            statusLabel.Text = "status:";
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Location = new System.Drawing.Point(25, 58);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(64, 17);
            mALOPLabel1.TabIndex = 1;
            mALOPLabel1.Text = "MALOP:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(32, 137);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(57, 17);
            mAKHLabel.TabIndex = 3;
            mAKHLabel.Text = "MAKH:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(20, 219);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(69, 17);
            tENLOPLabel.TabIndex = 5;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // statusLabel1
            // 
            statusLabel1.AutoSize = true;
            statusLabel1.Location = new System.Drawing.Point(44, 304);
            statusLabel1.Name = "statusLabel1";
            statusLabel1.Size = new System.Drawing.Size(45, 17);
            statusLabel1.TabIndex = 7;
            statusLabel1.Text = "status:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1377, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 709);
            this.barDockControlBottom.Size = new System.Drawing.Size(1377, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 669);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1377, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 669);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbcoso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 76);
            this.panel1.TabIndex = 4;
            // 
            // cmbcoso
            // 
            this.cmbcoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcoso.FormattingEnabled = true;
            this.cmbcoso.Location = new System.Drawing.Point(269, 28);
            this.cmbcoso.Name = "cmbcoso";
            this.cmbcoso.Size = new System.Drawing.Size(293, 25);
            this.cmbcoso.TabIndex = 1;
            this.cmbcoso.SelectedIndexChanged += new System.EventHandler(this.cmbcoso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN CƠ SỞ :";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SV_BDS
            // 
            this.SV_BDS.DataMember = "SINHVIEN";
            this.SV_BDS.DataSource = this.dS;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHILOPTableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = this.cTBAITHITableAdapter;
            this.tableAdapterManager.DANGKYTHITableAdapter = this.dANGKYTHITableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = null;
            this.tableAdapterManager.NVGIAOVUTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // cTBAITHITableAdapter
            // 
            this.cTBAITHITableAdapter.ClearBeforeFill = true;
            // 
            // dANGKYTHITableAdapter
            // 
            this.dANGKYTHITableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENGridControl
            // 
            this.sINHVIENGridControl.DataSource = this.SV_BDS;
            this.sINHVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sINHVIENGridControl.Location = new System.Drawing.Point(0, 116);
            this.sINHVIENGridControl.MainView = this.gridView1;
            this.sINHVIENGridControl.MenuManager = this.barManager1;
            this.sINHVIENGridControl.Name = "sINHVIENGridControl";
            this.sINHVIENGridControl.Size = new System.Drawing.Size(1377, 159);
            this.sINHVIENGridControl.TabIndex = 6;
            this.sINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DIACHI,
            this.colHO,
            this.MALOP,
            this.MASV,
            this.NGAYSINH,
            this.STATUS,
            this.TEN});
            this.gridView1.GridControl = this.sINHVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // DIACHI
            // 
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.OptionsColumn.ReadOnly = true;
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 5;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 0;
            // 
            // MALOP
            // 
            this.MALOP.FieldName = "MALOP";
            this.MALOP.Name = "MALOP";
            this.MALOP.OptionsColumn.ReadOnly = true;
            this.MALOP.Visible = true;
            this.MALOP.VisibleIndex = 3;
            // 
            // MASV
            // 
            this.MASV.FieldName = "MASV";
            this.MASV.Name = "MASV";
            this.MASV.OptionsColumn.ReadOnly = true;
            this.MASV.Visible = true;
            this.MASV.VisibleIndex = 2;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.FieldName = "NGAYSINH";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.OptionsColumn.ReadOnly = true;
            this.NGAYSINH.Visible = true;
            this.NGAYSINH.VisibleIndex = 4;
            // 
            // STATUS
            // 
            this.STATUS.FieldName = "status";
            this.STATUS.Name = "STATUS";
            this.STATUS.OptionsColumn.ReadOnly = true;
            this.STATUS.Visible = true;
            this.STATUS.VisibleIndex = 6;
            // 
            // TEN
            // 
            this.TEN.FieldName = "TEN";
            this.TEN.Name = "TEN";
            this.TEN.OptionsColumn.ReadOnly = true;
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.txtstt);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(this.txtmalop);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.txtdc);
            this.groupBox1.Controls.Add(nGAYSINHLabel);
            this.groupBox1.Controls.Add(this.txtngaysinh);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.txtho);
            this.groupBox1.Controls.Add(mASVLabel);
            this.groupBox1.Controls.Add(this.txtmasv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 434);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtstt
            // 
            this.txtstt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SV_BDS, "status", true));
            this.txtstt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtstt.Location = new System.Drawing.Point(73, 290);
            this.txtstt.MenuManager = this.barManager1;
            this.txtstt.Name = "txtstt";
            this.txtstt.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstt.Properties.Appearance.Options.UseFont = true;
            this.txtstt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtstt.Size = new System.Drawing.Size(220, 26);
            this.txtstt.TabIndex = 14;
            // 
            // txtmalop
            // 
            this.txtmalop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SV_BDS, "MALOP", true));
            this.txtmalop.Location = new System.Drawing.Point(403, 138);
            this.txtmalop.MenuManager = this.barManager1;
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmalop.Properties.Appearance.Options.UseFont = true;
            this.txtmalop.Size = new System.Drawing.Size(215, 26);
            this.txtmalop.TabIndex = 12;
            // 
            // txtdc
            // 
            this.txtdc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SV_BDS, "DIACHI", true));
            this.txtdc.Location = new System.Drawing.Point(403, 57);
            this.txtdc.MenuManager = this.barManager1;
            this.txtdc.Name = "txtdc";
            this.txtdc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdc.Properties.Appearance.Options.UseFont = true;
            this.txtdc.Size = new System.Drawing.Size(215, 26);
            this.txtdc.TabIndex = 10;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SV_BDS, "NGAYSINH", true));
            this.txtngaysinh.EditValue = null;
            this.txtngaysinh.Location = new System.Drawing.Point(403, 210);
            this.txtngaysinh.MenuManager = this.barManager1;
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaysinh.Properties.Appearance.Options.UseFont = true;
            this.txtngaysinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngaysinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngaysinh.Size = new System.Drawing.Size(215, 26);
            this.txtngaysinh.TabIndex = 8;
            // 
            // txtten
            // 
            this.txtten.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SV_BDS, "TEN", true));
            this.txtten.Location = new System.Drawing.Point(73, 210);
            this.txtten.MenuManager = this.barManager1;
            this.txtten.Name = "txtten";
            this.txtten.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Properties.Appearance.Options.UseFont = true;
            this.txtten.Size = new System.Drawing.Size(220, 26);
            this.txtten.TabIndex = 6;
            // 
            // txtho
            // 
            this.txtho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SV_BDS, "HO", true));
            this.txtho.Location = new System.Drawing.Point(73, 134);
            this.txtho.MenuManager = this.barManager1;
            this.txtho.Name = "txtho";
            this.txtho.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtho.Properties.Appearance.Options.UseFont = true;
            this.txtho.Size = new System.Drawing.Size(220, 26);
            this.txtho.TabIndex = 4;
            // 
            // txtmasv
            // 
            this.txtmasv.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SV_BDS, "MASV", true));
            this.txtmasv.Location = new System.Drawing.Point(73, 55);
            this.txtmasv.MenuManager = this.barManager1;
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmasv.Properties.Appearance.Options.UseFont = true;
            this.txtmasv.Size = new System.Drawing.Size(220, 26);
            this.txtmasv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "HIỆU CHỈNH SV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lOPGridControl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(974, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 434);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.LOP_BDS;
            this.lOPGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lOPGridControl.Location = new System.Drawing.Point(3, 21);
            this.lOPGridControl.MainView = this.gridView2;
            this.lOPGridControl.MenuManager = this.barManager1;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(397, 410);
            this.lOPGridControl.TabIndex = 0;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // LOP_BDS
            // 
            this.LOP_BDS.DataMember = "LOP";
            this.LOP_BDS.DataSource = this.dS;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAKH,
            this.ML,
            this.STT,
            this.TL});
            this.gridView2.GridControl = this.lOPGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // MAKH
            // 
            this.MAKH.FieldName = "MAKH";
            this.MAKH.Name = "MAKH";
            this.MAKH.OptionsColumn.ReadOnly = true;
            this.MAKH.Visible = true;
            this.MAKH.VisibleIndex = 0;
            // 
            // ML
            // 
            this.ML.FieldName = "MALOP";
            this.ML.Name = "ML";
            this.ML.OptionsColumn.ReadOnly = true;
            this.ML.Visible = true;
            this.ML.VisibleIndex = 1;
            // 
            // STT
            // 
            this.STT.FieldName = "status";
            this.STT.Name = "STT";
            this.STT.OptionsColumn.ReadOnly = true;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 3;
            // 
            // TL
            // 
            this.TL.FieldName = "TENLOP";
            this.TL.Name = "TL";
            this.TL.OptionsColumn.ReadOnly = true;
            this.TL.Visible = true;
            this.TL.VisibleIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnluu);
            this.groupBox3.Controls.Add(statusLabel1);
            this.groupBox3.Controls.Add(this.txtstt1);
            this.groupBox3.Controls.Add(tENLOPLabel);
            this.groupBox3.Controls.Add(this.txttenlop);
            this.groupBox3.Controls.Add(mAKHLabel);
            this.groupBox3.Controls.Add(this.txtmakh);
            this.groupBox3.Controls.Add(mALOPLabel1);
            this.groupBox3.Controls.Add(this.txtmalop1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(624, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 420);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(227, 352);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 33);
            this.btnluu.TabIndex = 9;
            this.btnluu.Text = "LƯU";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // txtstt1
            // 
            this.txtstt1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LOP_BDS, "status", true));
            this.txtstt1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtstt1.Location = new System.Drawing.Point(95, 301);
            this.txtstt1.MenuManager = this.barManager1;
            this.txtstt1.Name = "txtstt1";
            this.txtstt1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstt1.Properties.Appearance.Options.UseFont = true;
            this.txtstt1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtstt1.Size = new System.Drawing.Size(207, 26);
            this.txtstt1.TabIndex = 8;
            // 
            // txttenlop
            // 
            this.txttenlop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LOP_BDS, "TENLOP", true));
            this.txttenlop.Location = new System.Drawing.Point(95, 216);
            this.txttenlop.MenuManager = this.barManager1;
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenlop.Properties.Appearance.Options.UseFont = true;
            this.txttenlop.Size = new System.Drawing.Size(207, 26);
            this.txttenlop.TabIndex = 6;
            // 
            // txtmakh
            // 
            this.txtmakh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LOP_BDS, "MAKH", true));
            this.txtmakh.Location = new System.Drawing.Point(95, 134);
            this.txtmakh.MenuManager = this.barManager1;
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.Properties.Appearance.Options.UseFont = true;
            this.txtmakh.Size = new System.Drawing.Size(207, 26);
            this.txtmakh.TabIndex = 4;
            // 
            // txtmalop1
            // 
            this.txtmalop1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LOP_BDS, "MALOP", true));
            this.txtmalop1.Location = new System.Drawing.Point(95, 55);
            this.txtmalop1.MenuManager = this.barManager1;
            this.txtmalop1.Name = "txtmalop1";
            this.txtmalop1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmalop1.Properties.Appearance.Options.UseFont = true;
            this.txtmalop1.Size = new System.Drawing.Size(207, 26);
            this.txtmalop1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "HIỆU CHỈNH LỚP";
            // 
            // CTBT_BDS
            // 
            this.CTBT_BDS.DataMember = "CTBAITHI";
            this.CTBT_BDS.DataSource = this.dS;
            // 
            // BD_BDS
            // 
            this.BD_BDS.DataMember = "BODE";
            this.BD_BDS.DataSource = this.dS;
            // 
            // DKT_BDS
            // 
            this.DKT_BDS.DataMember = "DANGKYTHI";
            this.DKT_BDS.DataSource = this.dS;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHÊMToolStripMenuItem,
            this.sỬAToolStripMenuItem,
            this.xÓAToolStripMenuItem,
            this.rEFRESHToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 92);
            // 
            // tHÊMToolStripMenuItem
            // 
            this.tHÊMToolStripMenuItem.Name = "tHÊMToolStripMenuItem";
            this.tHÊMToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.tHÊMToolStripMenuItem.Text = "THÊM";
            this.tHÊMToolStripMenuItem.Click += new System.EventHandler(this.tHÊMToolStripMenuItem_Click);
            // 
            // sỬAToolStripMenuItem
            // 
            this.sỬAToolStripMenuItem.Name = "sỬAToolStripMenuItem";
            this.sỬAToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sỬAToolStripMenuItem.Text = "SỬA";
            this.sỬAToolStripMenuItem.Click += new System.EventHandler(this.sỬAToolStripMenuItem_Click);
            // 
            // xÓAToolStripMenuItem
            // 
            this.xÓAToolStripMenuItem.Name = "xÓAToolStripMenuItem";
            this.xÓAToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.xÓAToolStripMenuItem.Text = "XÓA ";
            this.xÓAToolStripMenuItem.Click += new System.EventHandler(this.xÓAToolStripMenuItem_Click);
            // 
            // rEFRESHToolStripMenuItem
            // 
            this.rEFRESHToolStripMenuItem.Name = "rEFRESHToolStripMenuItem";
            this.rEFRESHToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.rEFRESHToolStripMenuItem.Text = "REFRESH";
            this.rEFRESHToolStripMenuItem.Click += new System.EventHandler(this.rEFRESHToolStripMenuItem_Click);
            // 
            // FormSV_LOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sINHVIENGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSV_LOP";
            this.Text = "FormSV_LOP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSV_LOP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtstt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaysinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaysinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmasv.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtstt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenlop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalop1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTBT_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DKT_BDS)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.BindingSource SV_BDS;
        private DS dS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbcoso;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sINHVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn MALOP;
        private DevExpress.XtraGrid.Columns.GridColumn MASV;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SpinEdit txtstt;
        private DevExpress.XtraEditors.TextEdit txtmalop;
        private DevExpress.XtraEditors.TextEdit txtdc;
        private DevExpress.XtraEditors.DateEdit txtngaysinh;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.TextEdit txtho;
        private DevExpress.XtraEditors.TextEdit txtmasv;
        private System.Windows.Forms.Label label2;
        private DSTableAdapters.CTBAITHITableAdapter cTBAITHITableAdapter;
        private System.Windows.Forms.BindingSource CTBT_BDS;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource BD_BDS;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource LOP_BDS;
        private DevExpress.XtraEditors.SpinEdit txtstt1;
        private DevExpress.XtraEditors.TextEdit txttenlop;
        private DevExpress.XtraEditors.TextEdit txtmakh;
        private DevExpress.XtraEditors.TextEdit txtmalop1;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn MAKH;
        private DevExpress.XtraGrid.Columns.GridColumn ML;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn TL;
        private DSTableAdapters.DANGKYTHITableAdapter dANGKYTHITableAdapter;
        private System.Windows.Forms.BindingSource DKT_BDS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tHÊMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sỬAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xÓAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEFRESHToolStripMenuItem;
        private System.Windows.Forms.Button btnluu;
    }
}