namespace THITRACNGHIEM
{
    partial class FormMon
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarButtonItem();
            this.btnxoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnsua = new DevExpress.XtraBars.BarButtonItem();
            this.btnghi = new DevExpress.XtraBars.BarButtonItem();
            this.btnphuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnrefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnthoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new THITRACNGHIEM.DS();
            this.MON_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.mONTableAdapter = new THITRACNGHIEM.DSTableAdapters.MONTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.bODETableAdapter = new THITRACNGHIEM.DSTableAdapters.BODETableAdapter();
            this.dANGKYTHITableAdapter = new THITRACNGHIEM.DSTableAdapters.DANGKYTHITableAdapter();
            this.mONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmamh = new DevExpress.XtraEditors.TextEdit();
            this.txtstt = new DevExpress.XtraEditors.SpinEdit();
            this.txtmakh = new DevExpress.XtraEditors.TextEdit();
            this.txttenmh = new DevExpress.XtraEditors.TextEdit();
            this.DKT_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.BD_BDS = new System.Windows.Forms.BindingSource(this.components);
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MON_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmamh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenmh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DKT_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_BDS)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(96, 53);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(62, 19);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "MAMH:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(90, 143);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(67, 19);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "TENMH:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(511, 54);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(60, 19);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "MAKH:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(514, 143);
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
            this.btnxoa,
            this.btnsua,
            this.btnghi,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnxoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnphuchoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnrefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnthoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnthem
            // 
            this.btnthem.Caption = "Thêm";
            this.btnthem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnthem.Glyph")));
            this.btnthem.Id = 0;
            this.btnthem.Name = "btnthem";
            this.btnthem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Caption = "Xóa";
            this.btnxoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnxoa.Glyph")));
            this.btnxoa.Id = 1;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoa_ItemClick);
            // 
            // btnsua
            // 
            this.btnsua.Caption = "Sửa";
            this.btnsua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnsua.Glyph")));
            this.btnsua.Id = 2;
            this.btnsua.Name = "btnsua";
            this.btnsua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsua_ItemClick);
            // 
            // btnghi
            // 
            this.btnghi.Caption = "Ghi";
            this.btnghi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnghi.Glyph")));
            this.btnghi.Id = 3;
            this.btnghi.Name = "btnghi";
            this.btnghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnghi_ItemClick);
            // 
            // btnphuchoi
            // 
            this.btnphuchoi.Caption = "Phục Hồi";
            this.btnphuchoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnphuchoi.Glyph")));
            this.btnphuchoi.Id = 4;
            this.btnphuchoi.Name = "btnphuchoi";
            this.btnphuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnphuchoi_ItemClick);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Caption = "Refresh";
            this.btnrefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Glyph")));
            this.btnrefresh.Id = 5;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnrefresh_ItemClick);
            // 
            // btnthoat
            // 
            this.btnthoat.Caption = "Thoát";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1007, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 462);
            this.barDockControlBottom.Size = new System.Drawing.Size(1007, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 422);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1007, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 422);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 75);
            this.panel1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(335, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN CƠ SỞ";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MON_BDS
            // 
            this.MON_BDS.DataMember = "MON";
            this.MON_BDS.DataSource = this.dS;
            // 
            // mONTableAdapter
            // 
            this.mONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHILOPTableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTHITableAdapter = this.dANGKYTHITableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = this.mONTableAdapter;
            this.tableAdapterManager.NVGIAOVUTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // dANGKYTHITableAdapter
            // 
            this.dANGKYTHITableAdapter.ClearBeforeFill = true;
            // 
            // mONGridControl
            // 
            this.mONGridControl.DataSource = this.MON_BDS;
            this.mONGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mONGridControl.Location = new System.Drawing.Point(0, 115);
            this.mONGridControl.MainView = this.gridView1;
            this.mONGridControl.MenuManager = this.barManager1;
            this.mONGridControl.Name = "mONGridControl";
            this.mONGridControl.Size = new System.Drawing.Size(1007, 140);
            this.mONGridControl.TabIndex = 6;
            this.mONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAKH,
            this.MAMH,
            this.Status,
            this.TENMH});
            this.gridView1.GridControl = this.mONGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // MAKH
            // 
            this.MAKH.FieldName = "MAKH";
            this.MAKH.Name = "MAKH";
            this.MAKH.OptionsColumn.ReadOnly = true;
            this.MAKH.Visible = true;
            this.MAKH.VisibleIndex = 0;
            // 
            // MAMH
            // 
            this.MAMH.FieldName = "MAMH";
            this.MAMH.Name = "MAMH";
            this.MAMH.OptionsColumn.ReadOnly = true;
            this.MAMH.Visible = true;
            this.MAMH.VisibleIndex = 2;
            // 
            // Status
            // 
            this.Status.FieldName = "status";
            this.Status.Name = "Status";
            this.Status.OptionsColumn.ReadOnly = true;
            this.Status.Visible = true;
            this.Status.VisibleIndex = 3;
            // 
            // TENMH
            // 
            this.TENMH.FieldName = "TENMH";
            this.TENMH.Name = "TENMH";
            this.TENMH.OptionsColumn.ReadOnly = true;
            this.TENMH.Visible = true;
            this.TENMH.VisibleIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmamh);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.txtstt);
            this.groupBox1.Controls.Add(mAKHLabel);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(tENMHLabel);
            this.groupBox1.Controls.Add(this.txttenmh);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 207);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtmamh
            // 
            this.txtmamh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MON_BDS, "MAMH", true));
            this.txtmamh.Location = new System.Drawing.Point(164, 50);
            this.txtmamh.MenuManager = this.barManager1;
            this.txtmamh.Name = "txtmamh";
            this.txtmamh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmamh.Properties.Appearance.Options.UseFont = true;
            this.txtmamh.Size = new System.Drawing.Size(288, 26);
            this.txtmamh.TabIndex = 8;
            // 
            // txtstt
            // 
            this.txtstt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MON_BDS, "status", true));
            this.txtstt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtstt.Location = new System.Drawing.Point(577, 140);
            this.txtstt.MenuManager = this.barManager1;
            this.txtstt.Name = "txtstt";
            this.txtstt.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstt.Properties.Appearance.Options.UseFont = true;
            this.txtstt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtstt.Size = new System.Drawing.Size(288, 26);
            this.txtstt.TabIndex = 7;
            // 
            // txtmakh
            // 
            this.txtmakh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MON_BDS, "MAKH", true));
            this.txtmakh.Location = new System.Drawing.Point(577, 51);
            this.txtmakh.MenuManager = this.barManager1;
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.Properties.Appearance.Options.UseFont = true;
            this.txtmakh.Size = new System.Drawing.Size(288, 26);
            this.txtmakh.TabIndex = 5;
            // 
            // txttenmh
            // 
            this.txttenmh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MON_BDS, "TENMH", true));
            this.txttenmh.Location = new System.Drawing.Point(164, 140);
            this.txttenmh.MenuManager = this.barManager1;
            this.txttenmh.Name = "txttenmh";
            this.txttenmh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenmh.Properties.Appearance.Options.UseFont = true;
            this.txttenmh.Size = new System.Drawing.Size(288, 26);
            this.txttenmh.TabIndex = 3;
            // 
            // DKT_BDS
            // 
            this.DKT_BDS.DataMember = "DANGKYTHI";
            this.DKT_BDS.DataSource = this.dS;
            // 
            // BD_BDS
            // 
            this.BD_BDS.DataMember = "BODE";
            this.BD_BDS.DataSource = this.dS;
            // 
            // FormMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 485);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mONGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormMon";
            this.Text = "FormMon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MON_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmamh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenmh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DKT_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_BDS)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnxoa;
        private DevExpress.XtraBars.BarButtonItem btnsua;
        private DevExpress.XtraBars.BarButtonItem btnghi;
        private DevExpress.XtraBars.BarButtonItem btnphuchoi;
        private DevExpress.XtraBars.BarButtonItem btnrefresh;
        private DevExpress.XtraBars.BarButtonItem btnthoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource MON_BDS;
        private DS dS;
        private DSTableAdapters.MONTableAdapter mONTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl mONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAKH;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn TENMH;
        private DevExpress.XtraEditors.SpinEdit txtstt;
        private DevExpress.XtraEditors.TextEdit txtmakh;
        private DevExpress.XtraEditors.TextEdit txttenmh;
        private DSTableAdapters.DANGKYTHITableAdapter dANGKYTHITableAdapter;
        private System.Windows.Forms.BindingSource DKT_BDS;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource BD_BDS;
        private DevExpress.XtraEditors.TextEdit txtmamh;
    }
}