namespace THITRACNGHIEM
{
    partial class FormInKQ
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
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new THITRACNGHIEM.DS();
            this.cmbMon = new System.Windows.Forms.ComboBox();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKQ = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lOPTableAdapter = new THITRACNGHIEM.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.dANGKYTHITableAdapter = new THITRACNGHIEM.DSTableAdapters.DANGKYTHITableAdapter();
            this.mONTableAdapter = new THITRACNGHIEM.DSTableAdapters.MONTableAdapter();
            this.dANGKYTHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYTHIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMon
            // 
            this.cmbMon.DataSource = this.mONBindingSource;
            this.cmbMon.DisplayMember = "TENMH";
            this.cmbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMon.FormattingEnabled = true;
            this.cmbMon.Location = new System.Drawing.Point(451, 108);
            this.cmbMon.Name = "cmbMon";
            this.cmbMon.Size = new System.Drawing.Size(261, 27);
            this.cmbMon.TabIndex = 1;
            this.cmbMon.ValueMember = "MAMH";
            // 
            // mONBindingSource
            // 
            this.mONBindingSource.DataMember = "MON";
            this.mONBindingSource.DataSource = this.dS;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Môn";
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(738, 111);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(96, 29);
            this.btnKQ.TabIndex = 4;
            this.btnKQ.Text = "Kết Quả";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(883, 111);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 29);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHILOPTableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTHITableAdapter = this.dANGKYTHITableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = this.mONTableAdapter;
            this.tableAdapterManager.NVGIAOVUTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dANGKYTHITableAdapter
            // 
            this.dANGKYTHITableAdapter.ClearBeforeFill = true;
            // 
            // mONTableAdapter
            // 
            this.mONTableAdapter.ClearBeforeFill = true;
            // 
            // dANGKYTHIBindingSource
            // 
            this.dANGKYTHIBindingSource.DataMember = "DANGKYTHI";
            this.dANGKYTHIBindingSource.DataSource = this.dS;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(171, 108);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(198, 26);
            this.txtLop.TabIndex = 6;
            // 
            // FormInKQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 475);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInKQ";
            this.Text = "FormInKQ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInKQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYTHIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKQ;
        private System.Windows.Forms.Button btnThoat;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONTableAdapter mONTableAdapter;
        private System.Windows.Forms.BindingSource mONBindingSource;
        private DSTableAdapters.DANGKYTHITableAdapter dANGKYTHITableAdapter;
        private System.Windows.Forms.BindingSource dANGKYTHIBindingSource;
        private System.Windows.Forms.TextBox txtLop;
    }
}