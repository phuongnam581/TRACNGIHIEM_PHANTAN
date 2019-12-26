namespace THITRACNGHIEM
{
    partial class FormKQ
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblDung = new System.Windows.Forms.Label();
            this.lblSoCau = new System.Windows.Forms.Label();
            this.btnXN = new System.Windows.Forms.Button();
            this.dS = new THITRACNGHIEM.DS();
            this.bANGDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANGDIEMTableAdapter = new THITRACNGHIEM.DSTableAdapters.BANGDIEMTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDiem);
            this.groupBox1.Controls.Add(this.lblDung);
            this.groupBox1.Controls.Add(this.lblSoCau);
            this.groupBox1.Location = new System.Drawing.Point(56, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(380, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KẾT QUẢ";
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(47, 148);
            this.lblDiem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(48, 17);
            this.lblDiem.TabIndex = 2;
            this.lblDiem.Text = "Điểm:";
            // 
            // lblDung
            // 
            this.lblDung.AutoSize = true;
            this.lblDung.Location = new System.Drawing.Point(45, 106);
            this.lblDung.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDung.Name = "lblDung";
            this.lblDung.Size = new System.Drawing.Size(48, 17);
            this.lblDung.TabIndex = 1;
            this.lblDung.Text = "Đúng:";
            // 
            // lblSoCau
            // 
            this.lblSoCau.AutoSize = true;
            this.lblSoCau.Location = new System.Drawing.Point(45, 59);
            this.lblSoCau.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoCau.Name = "lblSoCau";
            this.lblSoCau.Size = new System.Drawing.Size(97, 17);
            this.lblSoCau.TabIndex = 0;
            this.lblSoCau.Text = "Tổng Số Câu:";
            this.lblSoCau.Click += new System.EventHandler(this.lblSoCau_Click);
            // 
            // btnXN
            // 
            this.btnXN.Location = new System.Drawing.Point(188, 254);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(92, 40);
            this.btnXN.TabIndex = 1;
            this.btnXN.Text = "Xác Nhận";
            this.btnXN.UseVisualStyleBackColor = true;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bANGDIEMBindingSource
            // 
            this.bANGDIEMBindingSource.DataMember = "BANGDIEM";
            this.bANGDIEMBindingSource.DataSource = this.dS;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHILOPTableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.bANGDIEMTableAdapter;
            this.tableAdapterManager.BODETableAdapter = null;
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
            // FormKQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 326);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormKQ";
            this.Text = "FormKQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKQ_FormClosing);
            this.Load += new System.EventHandler(this.FormKQ_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblDung;
        private System.Windows.Forms.Label lblSoCau;
        private System.Windows.Forms.Button btnXN;
        private DS dS;
        private System.Windows.Forms.BindingSource bANGDIEMBindingSource;
        private DSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}