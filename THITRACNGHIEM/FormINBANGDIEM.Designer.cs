namespace THITRACNGHIEM
{
    partial class FormINBANGDIEM
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dS = new THITRACNGHIEM.DS();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new THITRACNGHIEM.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.mONTableAdapter = new THITRACNGHIEM.DSTableAdapters.MONTableAdapter();
            this.cmbtenlop = new System.Windows.Forms.ComboBox();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbtenmh = new System.Windows.Forms.ComboBox();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(213, 180);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(69, 17);
            tENLOPLabel.TabIndex = 4;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(218, 257);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(64, 17);
            tENMHLabel.TabIndex = 5;
            tENMHLabel.Text = "TENMH:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCoSo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 100);
            this.panel1.TabIndex = 0;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(288, 46);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(357, 25);
            this.cmbCoSo.TabIndex = 1;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEN CO SO :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "PREVIEW\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "THOAT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
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
            this.tableAdapterManager.DANGKYTHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = this.mONTableAdapter;
            this.tableAdapterManager.NVGIAOVUTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONTableAdapter
            // 
            this.mONTableAdapter.ClearBeforeFill = true;
            // 
            // cmbtenlop
            // 
            this.cmbtenlop.DataSource = this.lOPBindingSource;
            this.cmbtenlop.DisplayMember = "TENLOP";
            this.cmbtenlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtenlop.FormattingEnabled = true;
            this.cmbtenlop.Location = new System.Drawing.Point(288, 177);
            this.cmbtenlop.Name = "cmbtenlop";
            this.cmbtenlop.Size = new System.Drawing.Size(336, 25);
            this.cmbtenlop.TabIndex = 5;
            this.cmbtenlop.ValueMember = "MALOP";
            // 
            // mONBindingSource
            // 
            this.mONBindingSource.DataMember = "MON";
            this.mONBindingSource.DataSource = this.dS;
            // 
            // cmbtenmh
            // 
            this.cmbtenmh.DataSource = this.mONBindingSource;
            this.cmbtenmh.DisplayMember = "TENMH";
            this.cmbtenmh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtenmh.FormattingEnabled = true;
            this.cmbtenmh.Location = new System.Drawing.Point(288, 254);
            this.cmbtenmh.Name = "cmbtenmh";
            this.cmbtenmh.Size = new System.Drawing.Size(336, 25);
            this.cmbtenmh.TabIndex = 6;
            this.cmbtenmh.ValueMember = "MAMH";
            // 
            // FormINBANGDIEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 749);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.cmbtenmh);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.cmbtenlop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormINBANGDIEM";
            this.Text = "FormINBANGDIEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormINBANGDIEM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONTableAdapter mONTableAdapter;
        private System.Windows.Forms.ComboBox cmbtenlop;
        private System.Windows.Forms.BindingSource mONBindingSource;
        private System.Windows.Forms.ComboBox cmbtenmh;
    }
}