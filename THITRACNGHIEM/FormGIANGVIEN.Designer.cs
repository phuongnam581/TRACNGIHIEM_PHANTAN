namespace THITRACNGHIEM
{
    partial class FormGIANGVIEN
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOCVILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGIANGVIEN));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarButtonItem();
            this.btnsua = new DevExpress.XtraBars.BarButtonItem();
            this.btnxoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnphuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnghi = new DevExpress.XtraBars.BarButtonItem();
            this.btnrefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnthoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new THITRACNGHIEM.DS();
            this.GVBDS = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new THITRACNGHIEM.DSTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.gIANGVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtstt = new DevExpress.XtraEditors.SpinEdit();
            this.txtmakh = new DevExpress.XtraEditors.TextEdit();
            this.txtdc = new DevExpress.XtraEditors.TextEdit();
            this.txthocvi = new DevExpress.XtraEditors.TextEdit();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.txtho = new DevExpress.XtraEditors.TextEdit();
            this.txtmagv = new DevExpress.XtraEditors.TextEdit();
            this.DKT_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTHITableAdapter = new THITRACNGHIEM.DSTableAdapters.DANGKYTHITableAdapter();
            this.BD_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new THITRACNGHIEM.DSTableAdapters.BODETableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOCVILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtstt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthocvi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmagv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DKT_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_BDS)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(77, 36);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(58, 19);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MAGV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(99, 108);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(35, 19);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(92, 171);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(42, 19);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // hOCVILabel
            // 
            hOCVILabel.AutoSize = true;
            hOCVILabel.Location = new System.Drawing.Point(480, 95);
            hOCVILabel.Name = "hOCVILabel";
            hOCVILabel.Size = new System.Drawing.Size(62, 19);
            hOCVILabel.TabIndex = 6;
            hOCVILabel.Text = "HOCVI:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(475, 167);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(66, 19);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(482, 34);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(60, 19);
            mAKHLabel.TabIndex = 10;
            mAKHLabel.Text = "MAKH:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(314, 228);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(46, 19);
            statusLabel.TabIndex = 12;
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
            this.btnxoa,
            this.btnphuchoi,
            this.btnghi,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnxoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnphuchoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnxoa
            // 
            this.btnxoa.Caption = "XÓA";
            this.btnxoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnxoa.Glyph")));
            this.btnxoa.Id = 2;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoa_ItemClick);
            // 
            // btnphuchoi
            // 
            this.btnphuchoi.Caption = "PHỤC HỒI";
            this.btnphuchoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnphuchoi.Glyph")));
            this.btnphuchoi.Id = 3;
            this.btnphuchoi.Name = "btnphuchoi";
            this.btnphuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnphuchoi_ItemClick);
            // 
            // btnghi
            // 
            this.btnghi.Caption = "GHI";
            this.btnghi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnghi.Glyph")));
            this.btnghi.Id = 4;
            this.btnghi.Name = "btnghi";
            this.btnghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnghi_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(922, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 533);
            this.barDockControlBottom.Size = new System.Drawing.Size(922, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 493);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(922, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 493);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCoSo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 70);
            this.panel1.TabIndex = 4;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(233, 26);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(334, 25);
            this.cmbCoSo.TabIndex = 1;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 29);
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
            // GVBDS
            // 
            this.GVBDS.DataMember = "GIANGVIEN";
            this.GVBDS.DataSource = this.dS;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = null;
            this.tableAdapterManager.NVGIAOVUTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIANGVIENGridControl
            // 
            this.gIANGVIENGridControl.DataSource = this.GVBDS;
            this.gIANGVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gIANGVIENGridControl.Location = new System.Drawing.Point(0, 110);
            this.gIANGVIENGridControl.MainView = this.gridView1;
            this.gIANGVIENGridControl.MenuManager = this.barManager1;
            this.gIANGVIENGridControl.Name = "gIANGVIENGridControl";
            this.gIANGVIENGridControl.Size = new System.Drawing.Size(922, 151);
            this.gIANGVIENGridControl.TabIndex = 6;
            this.gIANGVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TEN,
            this.STATUS,
            this.MAKH,
            this.MAGV,
            this.HOCVI,
            this.HO,
            this.DIACHI});
            this.gridView1.GridControl = this.gIANGVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // TEN
            // 
            this.TEN.FieldName = "TEN";
            this.TEN.Name = "TEN";
            this.TEN.OptionsColumn.ReadOnly = true;
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 1;
            // 
            // STATUS
            // 
            this.STATUS.FieldName = "status";
            this.STATUS.Name = "STATUS";
            this.STATUS.OptionsColumn.ReadOnly = true;
            this.STATUS.Visible = true;
            this.STATUS.VisibleIndex = 6;
            // 
            // MAKH
            // 
            this.MAKH.FieldName = "MAKH";
            this.MAKH.Name = "MAKH";
            this.MAKH.OptionsColumn.ReadOnly = true;
            this.MAKH.Visible = true;
            this.MAKH.VisibleIndex = 3;
            // 
            // MAGV
            // 
            this.MAGV.FieldName = "MAGV";
            this.MAGV.Name = "MAGV";
            this.MAGV.OptionsColumn.ReadOnly = true;
            this.MAGV.Visible = true;
            this.MAGV.VisibleIndex = 2;
            // 
            // HOCVI
            // 
            this.HOCVI.FieldName = "HOCVI";
            this.HOCVI.Name = "HOCVI";
            this.HOCVI.OptionsColumn.ReadOnly = true;
            this.HOCVI.Visible = true;
            this.HOCVI.VisibleIndex = 5;
            // 
            // HO
            // 
            this.HO.FieldName = "HO";
            this.HO.Name = "HO";
            this.HO.OptionsColumn.ReadOnly = true;
            this.HO.Visible = true;
            this.HO.VisibleIndex = 0;
            // 
            // DIACHI
            // 
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.OptionsColumn.ReadOnly = true;
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.txtstt);
            this.groupBox1.Controls.Add(mAKHLabel);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.txtdc);
            this.groupBox1.Controls.Add(hOCVILabel);
            this.groupBox1.Controls.Add(this.txthocvi);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.txtho);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Controls.Add(this.txtmagv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 272);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtstt
            // 
            this.txtstt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.GVBDS, "status", true));
            this.txtstt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtstt.Location = new System.Drawing.Point(366, 225);
            this.txtstt.MenuManager = this.barManager1;
            this.txtstt.Name = "txtstt";
            this.txtstt.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstt.Properties.Appearance.Options.UseFont = true;
            this.txtstt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtstt.Size = new System.Drawing.Size(224, 26);
            this.txtstt.TabIndex = 13;
            // 
            // txtmakh
            // 
            this.txtmakh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.GVBDS, "MAKH", true));
            this.txtmakh.Location = new System.Drawing.Point(545, 31);
            this.txtmakh.MenuManager = this.barManager1;
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.Properties.Appearance.Options.UseFont = true;
            this.txtmakh.Size = new System.Drawing.Size(221, 26);
            this.txtmakh.TabIndex = 11;
            // 
            // txtdc
            // 
            this.txtdc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.GVBDS, "DIACHI", true));
            this.txtdc.Location = new System.Drawing.Point(545, 164);
            this.txtdc.MenuManager = this.barManager1;
            this.txtdc.Name = "txtdc";
            this.txtdc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdc.Properties.Appearance.Options.UseFont = true;
            this.txtdc.Size = new System.Drawing.Size(221, 26);
            this.txtdc.TabIndex = 9;
            // 
            // txthocvi
            // 
            this.txthocvi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.GVBDS, "HOCVI", true));
            this.txthocvi.Location = new System.Drawing.Point(545, 92);
            this.txthocvi.MenuManager = this.barManager1;
            this.txthocvi.Name = "txthocvi";
            this.txthocvi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthocvi.Properties.Appearance.Options.UseFont = true;
            this.txthocvi.Size = new System.Drawing.Size(221, 26);
            this.txthocvi.TabIndex = 7;
            // 
            // txtten
            // 
            this.txtten.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.GVBDS, "TEN", true));
            this.txtten.Location = new System.Drawing.Point(138, 168);
            this.txtten.MenuManager = this.barManager1;
            this.txtten.Name = "txtten";
            this.txtten.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Properties.Appearance.Options.UseFont = true;
            this.txtten.Size = new System.Drawing.Size(224, 26);
            this.txtten.TabIndex = 5;
            // 
            // txtho
            // 
            this.txtho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.GVBDS, "HO", true));
            this.txtho.Location = new System.Drawing.Point(138, 105);
            this.txtho.MenuManager = this.barManager1;
            this.txtho.Name = "txtho";
            this.txtho.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtho.Properties.Appearance.Options.UseFont = true;
            this.txtho.Size = new System.Drawing.Size(224, 26);
            this.txtho.TabIndex = 3;
            // 
            // txtmagv
            // 
            this.txtmagv.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.GVBDS, "MAGV", true));
            this.txtmagv.Location = new System.Drawing.Point(138, 33);
            this.txtmagv.MenuManager = this.barManager1;
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmagv.Properties.Appearance.Options.UseFont = true;
            this.txtmagv.Size = new System.Drawing.Size(224, 26);
            this.txtmagv.TabIndex = 1;
            // 
            // DKT_BDS
            // 
            this.DKT_BDS.DataMember = "DANGKYTHI";
            this.DKT_BDS.DataSource = this.dS;
            // 
            // dANGKYTHITableAdapter
            // 
            this.dANGKYTHITableAdapter.ClearBeforeFill = true;
            // 
            // BD_BDS
            // 
            this.BD_BDS.DataMember = "BODE";
            this.BD_BDS.DataSource = this.dS;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // FormGIANGVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 556);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gIANGVIENGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGIANGVIEN";
            this.Text = "FormGIANGVIEN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGIANGVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtstt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthocvi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmagv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DKT_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_BDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnthem;
        private DevExpress.XtraBars.BarButtonItem btnsua;
        private DevExpress.XtraBars.BarButtonItem btnxoa;
        private DevExpress.XtraBars.BarButtonItem btnphuchoi;
        private DevExpress.XtraBars.BarButtonItem btnghi;
        private DevExpress.XtraBars.BarButtonItem btnrefresh;
        private DevExpress.XtraBars.BarButtonItem btnthoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource GVBDS;
        private DS dS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIANGVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtmakh;
        private DevExpress.XtraEditors.TextEdit txtdc;
        private DevExpress.XtraEditors.TextEdit txthocvi;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.TextEdit txtho;
        private DevExpress.XtraEditors.TextEdit txtmagv;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn MAKH;
        private DevExpress.XtraGrid.Columns.GridColumn MAGV;
        private DevExpress.XtraGrid.Columns.GridColumn HOCVI;
        private DevExpress.XtraGrid.Columns.GridColumn HO;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraEditors.SpinEdit txtstt;
        private System.Windows.Forms.BindingSource DKT_BDS;
        private DSTableAdapters.DANGKYTHITableAdapter dANGKYTHITableAdapter;
        private System.Windows.Forms.BindingSource BD_BDS;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
    }
}