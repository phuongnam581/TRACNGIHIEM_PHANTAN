namespace THITRACNGHIEM
{
    partial class formDN
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
            System.Windows.Forms.Label tENCNLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoPGV = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.rdoSV = new System.Windows.Forms.RadioButton();
            this.rdoGV = new System.Windows.Forms.RadioButton();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.bdsDSPM = new System.Windows.Forms.BindingSource(this.components);
            this.tRAC_NGHIEMDataSet = new THITRACNGHIEM.TRAC_NGHIEMDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.v_DS_PHANMANHTableAdapter = new THITRACNGHIEM.TRAC_NGHIEMDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.TRAC_NGHIEMDataSetTableAdapters.TableAdapterManager();
            tENCNLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAC_NGHIEMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(175, 50);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(77, 19);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chi Nhánh:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPGV);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Controls.Add(this.rdoSV);
            this.groupBox1.Controls.Add(this.rdoGV);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.lblMK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(tENCNLabel);
            this.groupBox1.Controls.Add(this.cmbCoSo);
            this.groupBox1.Location = new System.Drawing.Point(95, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdoPGV
            // 
            this.rdoPGV.AutoSize = true;
            this.rdoPGV.Location = new System.Drawing.Point(485, 217);
            this.rdoPGV.Name = "rdoPGV";
            this.rdoPGV.Size = new System.Drawing.Size(120, 23);
            this.rdoPGV.TabIndex = 10;
            this.rdoPGV.TabStop = true;
            this.rdoPGV.Text = "Phòng Giáo Vụ";
            this.rdoPGV.UseVisualStyleBackColor = true;
            this.rdoPGV.CheckedChanged += new System.EventHandler(this.rdoPGV_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(391, 286);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 38);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(179, 286);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(111, 38);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // rdoSV
            // 
            this.rdoSV.AutoSize = true;
            this.rdoSV.Location = new System.Drawing.Point(328, 217);
            this.rdoSV.Name = "rdoSV";
            this.rdoSV.Size = new System.Drawing.Size(84, 23);
            this.rdoSV.TabIndex = 7;
            this.rdoSV.TabStop = true;
            this.rdoSV.Text = "Sinh Viên";
            this.rdoSV.UseVisualStyleBackColor = true;
            this.rdoSV.CheckedChanged += new System.EventHandler(this.rdoSV_CheckedChanged);
            // 
            // rdoGV
            // 
            this.rdoGV.AutoSize = true;
            this.rdoGV.Location = new System.Drawing.Point(159, 217);
            this.rdoGV.Name = "rdoGV";
            this.rdoGV.Size = new System.Drawing.Size(93, 23);
            this.rdoGV.TabIndex = 6;
            this.rdoGV.TabStop = true;
            this.rdoGV.Text = "Giảng Viên";
            this.rdoGV.UseVisualStyleBackColor = true;
            this.rdoGV.CheckedChanged += new System.EventHandler(this.rdoGV_CheckedChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(294, 161);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(265, 26);
            this.txtMatKhau.TabIndex = 5;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(294, 103);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(265, 26);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(175, 165);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(74, 19);
            this.lblMK.TabIndex = 3;
            this.lblMK.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Khoản:";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DataSource = this.bdsDSPM;
            this.cmbCoSo.DisplayMember = "TENCN";
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(294, 44);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(265, 27);
            this.cmbCoSo.TabIndex = 1;
            this.cmbCoSo.ValueMember = "TENSERVER";
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.tENCNComboBox_SelectedIndexChanged);
            // 
            // bdsDSPM
            // 
            this.bdsDSPM.DataMember = "V_DS_PHANMANH";
            this.bdsDSPM.DataSource = this.tRAC_NGHIEMDataSet;
            // 
            // tRAC_NGHIEMDataSet
            // 
            this.tRAC_NGHIEMDataSet.DataSetName = "TRAC_NGHIEMDataSet";
            this.tRAC_NGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.TRAC_NGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // formDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 560);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDN";
            this.Text = "formDN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formDN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAC_NGHIEMDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TRAC_NGHIEMDataSet tRAC_NGHIEMDataSet;
        private System.Windows.Forms.BindingSource bdsDSPM;
        private TRAC_NGHIEMDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private TRAC_NGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.RadioButton rdoSV;
        private System.Windows.Forms.RadioButton rdoGV;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoPGV;
    }
}