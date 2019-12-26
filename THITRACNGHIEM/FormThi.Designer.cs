namespace THITRACNGHIEM
{
    partial class FormThi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCau = new System.Windows.Forms.Label();
            this.lblTG = new System.Windows.Forms.Label();
            this.lblTD = new System.Windows.Forms.Label();
            this.lblMH = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSV = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdF = new System.Windows.Forms.RadioButton();
            this.rdE = new System.Windows.Forms.RadioButton();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.txtND = new System.Windows.Forms.TextBox();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dS = new THITRACNGHIEM.DS();
            this.bAITHILOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAITHILOPTableAdapter = new THITRACNGHIEM.DSTableAdapters.BAITHILOPTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.bODETableAdapter = new THITRACNGHIEM.DSTableAdapters.BODETableAdapter();
            this.lUACHONTableAdapter = new THITRACNGHIEM.DSTableAdapters.LUACHONTableAdapter();
            this.bODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lUACHONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTBAITHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTBAITHITableAdapter = new THITRACNGHIEM.DSTableAdapters.CTBAITHITableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITHILOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUACHONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTBAITHIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCau);
            this.panel1.Controls.Add(this.lblTG);
            this.panel1.Controls.Add(this.lblTD);
            this.panel1.Controls.Add(this.lblMH);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblSV);
            this.panel1.Controls.Add(this.lblMaLop);
            this.panel1.Controls.Add(this.lblHoTen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 136);
            this.panel1.TabIndex = 0;
            // 
            // lblCau
            // 
            this.lblCau.AutoSize = true;
            this.lblCau.Location = new System.Drawing.Point(557, 21);
            this.lblCau.Name = "lblCau";
            this.lblCau.Size = new System.Drawing.Size(53, 19);
            this.lblCau.TabIndex = 13;
            this.lblCau.Text = "label14";
            // 
            // lblTG
            // 
            this.lblTG.AutoSize = true;
            this.lblTG.Location = new System.Drawing.Point(347, 107);
            this.lblTG.Name = "lblTG";
            this.lblTG.Size = new System.Drawing.Size(53, 19);
            this.lblTG.TabIndex = 12;
            this.lblTG.Text = "label13";
            // 
            // lblTD
            // 
            this.lblTD.AutoSize = true;
            this.lblTD.Location = new System.Drawing.Point(347, 62);
            this.lblTD.Name = "lblTD";
            this.lblTD.Size = new System.Drawing.Size(53, 19);
            this.lblTD.TabIndex = 11;
            this.lblTD.Text = "label12";
            // 
            // lblMH
            // 
            this.lblMH.AutoSize = true;
            this.lblMH.Location = new System.Drawing.Point(348, 21);
            this.lblMH.Name = "lblMH";
            this.lblMH.Size = new System.Drawing.Size(52, 19);
            this.lblMH.TabIndex = 10;
            this.lblMH.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(492, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Số Câu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Thời Gian:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Trình Độ:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã Môn:";
            // 
            // lblSV
            // 
            this.lblSV.AutoSize = true;
            this.lblSV.Location = new System.Drawing.Point(76, 107);
            this.lblSV.Name = "lblSV";
            this.lblSV.Size = new System.Drawing.Size(45, 19);
            this.lblSV.TabIndex = 5;
            this.lblSV.Text = "label6";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(76, 62);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(45, 19);
            this.lblMaLop.TabIndex = 4;
            this.lblMaLop.Text = "label5";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(76, 21);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(45, 19);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnNopBai);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Location = new System.Drawing.Point(640, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 136);
            this.panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(381, 62);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 35);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNopBai
            // 
            this.btnNopBai.Location = new System.Drawing.Point(243, 62);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(105, 35);
            this.btnNopBai.TabIndex = 1;
            this.btnNopBai.Text = "Nộp Bài";
            this.btnNopBai.UseVisualStyleBackColor = true;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(52, 62);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 24);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "TIMER:";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(0, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1133, 24);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.rdF);
            this.panel4.Controls.Add(this.rdE);
            this.panel4.Controls.Add(this.rdD);
            this.panel4.Controls.Add(this.rdC);
            this.panel4.Controls.Add(this.rdB);
            this.panel4.Controls.Add(this.rdA);
            this.panel4.Controls.Add(this.txtND);
            this.panel4.Controls.Add(this.lblCauHoi);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1133, 463);
            this.panel4.TabIndex = 3;
            // 
            // rdF
            // 
            this.rdF.AutoSize = true;
            this.rdF.Location = new System.Drawing.Point(280, 420);
            this.rdF.Name = "rdF";
            this.rdF.Size = new System.Drawing.Size(106, 23);
            this.rdF.TabIndex = 8;
            this.rdF.TabStop = true;
            this.rdF.Text = "radioButton6";
            this.rdF.UseVisualStyleBackColor = true;
            this.rdF.CheckedChanged += new System.EventHandler(this.rdF_CheckedChanged);
            // 
            // rdE
            // 
            this.rdE.AutoSize = true;
            this.rdE.Location = new System.Drawing.Point(280, 372);
            this.rdE.Name = "rdE";
            this.rdE.Size = new System.Drawing.Size(106, 23);
            this.rdE.TabIndex = 7;
            this.rdE.TabStop = true;
            this.rdE.Text = "radioButton5";
            this.rdE.UseVisualStyleBackColor = true;
            this.rdE.CheckedChanged += new System.EventHandler(this.rdF_CheckedChanged);
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Location = new System.Drawing.Point(280, 320);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(106, 23);
            this.rdD.TabIndex = 6;
            this.rdD.TabStop = true;
            this.rdD.Text = "radioButton4";
            this.rdD.UseVisualStyleBackColor = true;
            this.rdD.CheckedChanged += new System.EventHandler(this.rdF_CheckedChanged);
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Location = new System.Drawing.Point(280, 277);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(106, 23);
            this.rdC.TabIndex = 5;
            this.rdC.TabStop = true;
            this.rdC.Text = "radioButton3";
            this.rdC.UseVisualStyleBackColor = true;
            this.rdC.CheckedChanged += new System.EventHandler(this.rdF_CheckedChanged);
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Location = new System.Drawing.Point(280, 232);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(106, 23);
            this.rdB.TabIndex = 4;
            this.rdB.TabStop = true;
            this.rdB.Text = "radioButton2";
            this.rdB.UseVisualStyleBackColor = true;
            this.rdB.CheckedChanged += new System.EventHandler(this.rdF_CheckedChanged);
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Location = new System.Drawing.Point(280, 185);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(106, 23);
            this.rdA.TabIndex = 3;
            this.rdA.TabStop = true;
            this.rdA.Text = "radioButton1";
            this.rdA.UseVisualStyleBackColor = true;
            this.rdA.CheckedChanged += new System.EventHandler(this.rdF_CheckedChanged);
            // 
            // txtND
            // 
            this.txtND.Location = new System.Drawing.Point(280, 48);
            this.txtND.Multiline = true;
            this.txtND.Name = "txtND";
            this.txtND.ReadOnly = true;
            this.txtND.Size = new System.Drawing.Size(505, 98);
            this.txtND.TabIndex = 2;
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.Location = new System.Drawing.Point(185, 84);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(64, 22);
            this.lblCauHoi.TabIndex = 1;
            this.lblCauHoi.Text = "Câu 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "CÂU HỎI";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSau);
            this.panel5.Controls.Add(this.btnTruoc);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 623);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1133, 76);
            this.panel5.TabIndex = 4;
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(665, 24);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(120, 45);
            this.btnSau.TabIndex = 1;
            this.btnSau.Text = "Câu Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(280, 24);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(120, 45);
            this.btnTruoc.TabIndex = 0;
            this.btnTruoc.Text = "Câu Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 699);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1133, 50);
            this.panel6.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(321, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lưu ý: Khi thời gian hết giờ hệ thống sẽ tự động nộp bài";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bAITHILOPBindingSource
            // 
            this.bAITHILOPBindingSource.DataMember = "BAITHILOP";
            this.bAITHILOPBindingSource.DataSource = this.dS;
            // 
            // bAITHILOPTableAdapter
            // 
            this.bAITHILOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHILOPTableAdapter = this.bAITHILOPTableAdapter;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = this.lUACHONTableAdapter;
            this.tableAdapterManager.MONTableAdapter = null;
            this.tableAdapterManager.NVGIAOVUTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // lUACHONTableAdapter
            // 
            this.lUACHONTableAdapter.ClearBeforeFill = true;
            // 
            // bODEBindingSource
            // 
            this.bODEBindingSource.DataMember = "BODE";
            this.bODEBindingSource.DataSource = this.dS;
            // 
            // lUACHONBindingSource
            // 
            this.lUACHONBindingSource.DataMember = "FK_LUACHON_BODE";
            this.lUACHONBindingSource.DataSource = this.bODEBindingSource;
            // 
            // cTBAITHIBindingSource
            // 
            this.cTBAITHIBindingSource.DataMember = "CTBAITHI";
            this.cTBAITHIBindingSource.DataSource = this.dS;
            // 
            // cTBAITHITableAdapter
            // 
            this.cTBAITHITableAdapter.ClearBeforeFill = true;
            // 
            // FormThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 749);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThi";
            this.Text = "FormThi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormThi_FormClosing);
            this.Load += new System.EventHandler(this.FormThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITHILOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUACHONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTBAITHIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSV;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTG;
        private System.Windows.Forms.Label lblTD;
        private System.Windows.Forms.Label lblMH;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private DS dS;
        private System.Windows.Forms.BindingSource bAITHILOPBindingSource;
        private DSTableAdapters.BAITHILOPTableAdapter bAITHILOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private DSTableAdapters.LUACHONTableAdapter lUACHONTableAdapter;
        private System.Windows.Forms.BindingSource lUACHONBindingSource;
        private System.Windows.Forms.RadioButton rdF;
        private System.Windows.Forms.RadioButton rdE;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.BindingSource cTBAITHIBindingSource;
        private DSTableAdapters.CTBAITHITableAdapter cTBAITHITableAdapter;
        public System.Windows.Forms.Label lblCau;
        public System.Windows.Forms.Button btnThoat;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
    }
}