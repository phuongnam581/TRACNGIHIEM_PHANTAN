namespace THITRACNGHIEM
{
    partial class FormLayDe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBD = new System.Windows.Forms.Button();
            this.cmbMaMon = new System.Windows.Forms.ComboBox();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new THITRACNGHIEM.DS();
            this.mONTableAdapter = new THITRACNGHIEM.DSTableAdapters.MONTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dANGKYTHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTHITableAdapter = new THITRACNGHIEM.DSTableAdapters.DANGKYTHITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYTHIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN MÔN THI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Môn Thi:";
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(195, 223);
            this.btnBD.Margin = new System.Windows.Forms.Padding(4);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(82, 34);
            this.btnBD.TabIndex = 6;
            this.btnBD.Text = "Bắt Đầu";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // cmbMaMon
            // 
            this.cmbMaMon.DataSource = this.mONBindingSource;
            this.cmbMaMon.DisplayMember = "TENMH";
            this.cmbMaMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaMon.FormattingEnabled = true;
            this.cmbMaMon.Location = new System.Drawing.Point(195, 170);
            this.cmbMaMon.Name = "cmbMaMon";
            this.cmbMaMon.Size = new System.Drawing.Size(243, 27);
            this.cmbMaMon.TabIndex = 9;
            this.cmbMaMon.ValueMember = "MAMH";
            // 
            // mONBindingSource
            // 
            this.mONBindingSource.DataMember = "MON";
            this.mONBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = this.mONTableAdapter;
            this.tableAdapterManager.NVGIAOVUTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(195, 98);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(243, 26);
            this.txtMaLop.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dANGKYTHIBindingSource
            // 
            this.dANGKYTHIBindingSource.DataMember = "DANGKYTHI";
            this.dANGKYTHIBindingSource.DataSource = this.dS;
            // 
            // dANGKYTHITableAdapter
            // 
            this.dANGKYTHITableAdapter.ClearBeforeFill = true;
            // 
            // FormLayDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.cmbMaMon);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLayDe";
            this.Text = "FormLayDe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLayDe_FormClosing);
            this.Load += new System.EventHandler(this.FormLayDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYTHIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.ComboBox cmbMaMon;
        private DS dS;
        private System.Windows.Forms.BindingSource mONBindingSource;
        private DSTableAdapters.MONTableAdapter mONTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dANGKYTHIBindingSource;
        private DSTableAdapters.DANGKYTHITableAdapter dANGKYTHITableAdapter;
    }
}