namespace THITRACNGHIEM
{
    partial class FormBD
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dS = new THITRACNGHIEM.DS();
            this.bODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new THITRACNGHIEM.DSTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.bODEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DAPAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lUACHONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lUACHONTableAdapter = new THITRACNGHIEM.DSTableAdapters.LUACHONTableAdapter();
            this.lUACHONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MACHON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THUTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONTableAdapter = new THITRACNGHIEM.DSTableAdapters.MONTableAdapter();
            this.cmbMHM = new System.Windows.Forms.ComboBox();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUACHONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUACHONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 0;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(999, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 670);
            this.barDockControlBottom.Size = new System.Drawing.Size(999, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 621);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(999, 49);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 621);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 68);
            this.panel1.TabIndex = 4;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bODEBindingSource
            // 
            this.bODEBindingSource.DataMember = "BODE";
            this.bODEBindingSource.DataSource = this.dS;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHILOPTableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = null;
            this.tableAdapterManager.NVGIAOVUTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bODEGridControl
            // 
            this.bODEGridControl.DataSource = this.bODEBindingSource;
            this.bODEGridControl.Location = new System.Drawing.Point(0, 113);
            this.bODEGridControl.MainView = this.gridView1;
            this.bODEGridControl.MenuManager = this.barManager1;
            this.bODEGridControl.Name = "bODEGridControl";
            this.bODEGridControl.Size = new System.Drawing.Size(853, 220);
            this.bODEGridControl.TabIndex = 11;
            this.bODEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CAUHOI,
            this.DAPAN,
            this.MAGV,
            this.MAMH,
            this.NOIDUNG,
            this.STATUS,
            this.TRINHDO});
            this.gridView1.GridControl = this.bODEGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // CAUHOI
            // 
            this.CAUHOI.FieldName = "CAUHOI";
            this.CAUHOI.Name = "CAUHOI";
            this.CAUHOI.Visible = true;
            this.CAUHOI.VisibleIndex = 0;
            // 
            // DAPAN
            // 
            this.DAPAN.FieldName = "DAPAN";
            this.DAPAN.Name = "DAPAN";
            this.DAPAN.Visible = true;
            this.DAPAN.VisibleIndex = 1;
            // 
            // MAGV
            // 
            this.MAGV.FieldName = "MAGV";
            this.MAGV.Name = "MAGV";
            this.MAGV.Visible = true;
            this.MAGV.VisibleIndex = 2;
            // 
            // MAMH
            // 
            this.MAMH.FieldName = "MAMH";
            this.MAMH.Name = "MAMH";
            this.MAMH.Visible = true;
            this.MAMH.VisibleIndex = 3;
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.FieldName = "NOIDUNG";
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.Visible = true;
            this.NOIDUNG.VisibleIndex = 4;
            // 
            // STATUS
            // 
            this.STATUS.FieldName = "status";
            this.STATUS.Name = "STATUS";
            this.STATUS.Visible = true;
            this.STATUS.VisibleIndex = 5;
            // 
            // TRINHDO
            // 
            this.TRINHDO.FieldName = "TRINHDO";
            this.TRINHDO.Name = "TRINHDO";
            this.TRINHDO.Visible = true;
            this.TRINHDO.VisibleIndex = 6;
            // 
            // lUACHONBindingSource
            // 
            this.lUACHONBindingSource.DataMember = "FK_LUACHON_BODE";
            this.lUACHONBindingSource.DataSource = this.bODEBindingSource;
            // 
            // lUACHONTableAdapter
            // 
            this.lUACHONTableAdapter.ClearBeforeFill = true;
            // 
            // lUACHONGridControl
            // 
            this.lUACHONGridControl.DataSource = this.lUACHONBindingSource;
            this.lUACHONGridControl.Location = new System.Drawing.Point(0, 329);
            this.lUACHONGridControl.MainView = this.gridView2;
            this.lUACHONGridControl.MenuManager = this.barManager1;
            this.lUACHONGridControl.Name = "lUACHONGridControl";
            this.lUACHONGridControl.Size = new System.Drawing.Size(853, 220);
            this.lUACHONGridControl.TabIndex = 15;
            this.lUACHONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CH,
            this.MACHON,
            this.MOTA,
            this.THUTU});
            this.gridView2.GridControl = this.lUACHONGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // CH
            // 
            this.CH.FieldName = "CAUHOI";
            this.CH.Name = "CH";
            this.CH.Visible = true;
            this.CH.VisibleIndex = 0;
            // 
            // MACHON
            // 
            this.MACHON.FieldName = "MALUACHON";
            this.MACHON.Name = "MACHON";
            this.MACHON.Visible = true;
            this.MACHON.VisibleIndex = 1;
            // 
            // MOTA
            // 
            this.MOTA.FieldName = "MOTA";
            this.MOTA.Name = "MOTA";
            this.MOTA.Visible = true;
            this.MOTA.VisibleIndex = 2;
            // 
            // THUTU
            // 
            this.THUTU.FieldName = "THUTU";
            this.THUTU.Name = "THUTU";
            this.THUTU.Visible = true;
            this.THUTU.VisibleIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // mONBindingSource
            // 
            this.mONBindingSource.DataMember = "MON";
            this.mONBindingSource.DataSource = this.dS;
            // 
            // mONTableAdapter
            // 
            this.mONTableAdapter.ClearBeforeFill = true;
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(431, 619);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(62, 19);
            mAMHLabel.TabIndex = 28;
            mAMHLabel.Text = "MAMH:";
            // 
            // cmbMHM
            // 
            this.cmbMHM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONBindingSource, "MAMH", true));
            this.cmbMHM.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mONBindingSource, "MAMH", true));
            this.cmbMHM.DataSource = this.mONBindingSource;
            this.cmbMHM.DisplayMember = "TENMH";
            this.cmbMHM.FormattingEnabled = true;
            this.cmbMHM.Location = new System.Drawing.Point(499, 616);
            this.cmbMHM.Name = "cmbMHM";
            this.cmbMHM.Size = new System.Drawing.Size(121, 27);
            this.cmbMHM.TabIndex = 29;
            this.cmbMHM.ValueMember = "MAMH";
            // 
            // FormBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 693);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.cmbMHM);
            this.Controls.Add(this.lUACHONGridControl);
            this.Controls.Add(this.bODEGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBD";
            this.Text = "FormBD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUACHONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUACHONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DS dS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl bODEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn DAPAN;
        private DevExpress.XtraGrid.Columns.GridColumn MAGV;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH;
        private DevExpress.XtraGrid.Columns.GridColumn NOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn TRINHDO;
        private System.Windows.Forms.BindingSource lUACHONBindingSource;
        private DSTableAdapters.LUACHONTableAdapter lUACHONTableAdapter;
        private DevExpress.XtraGrid.GridControl lUACHONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn CH;
        private DevExpress.XtraGrid.Columns.GridColumn MACHON;
        private DevExpress.XtraGrid.Columns.GridColumn MOTA;
        private DevExpress.XtraGrid.Columns.GridColumn THUTU;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.BindingSource mONBindingSource;
        private DSTableAdapters.MONTableAdapter mONTableAdapter;
        private System.Windows.Forms.ComboBox cmbMHM;
    }
}