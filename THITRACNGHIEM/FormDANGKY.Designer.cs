namespace THITRACNGHIEM
{
    partial class FormDANGKY
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbltk = new System.Windows.Forms.ComboBox();
            this.txtlgn = new System.Windows.Forms.TextBox();
            this.txtusn = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.btndk = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOAI TAI KHOAN\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "USERNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "PASSWORD";
            // 
            // cmbltk
            // 
            this.cmbltk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbltk.FormattingEnabled = true;
            this.cmbltk.Location = new System.Drawing.Point(286, 84);
            this.cmbltk.Name = "cmbltk";
            this.cmbltk.Size = new System.Drawing.Size(309, 27);
            this.cmbltk.TabIndex = 4;
            this.cmbltk.SelectedIndexChanged += new System.EventHandler(this.cmbltk_SelectedIndexChanged);
            // 
            // txtlgn
            // 
            this.txtlgn.Location = new System.Drawing.Point(286, 185);
            this.txtlgn.Name = "txtlgn";
            this.txtlgn.Size = new System.Drawing.Size(309, 26);
            this.txtlgn.TabIndex = 5;
            // 
            // txtusn
            // 
            this.txtusn.Location = new System.Drawing.Point(286, 280);
            this.txtusn.Name = "txtusn";
            this.txtusn.Size = new System.Drawing.Size(309, 26);
            this.txtusn.TabIndex = 6;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(286, 371);
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '-';
            this.txtpw.Size = new System.Drawing.Size(309, 26);
            this.txtpw.TabIndex = 7;
            // 
            // btndk
            // 
            this.btndk.Location = new System.Drawing.Point(286, 467);
            this.btndk.Name = "btndk";
            this.btndk.Size = new System.Drawing.Size(99, 46);
            this.btndk.TabIndex = 8;
            this.btndk.Text = "DANG KY";
            this.btndk.UseVisualStyleBackColor = true;
            this.btndk.Click += new System.EventHandler(this.btndk_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(496, 467);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(99, 46);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "THOAT";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FormDANGKY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 749);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndk);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtusn);
            this.Controls.Add(this.txtlgn);
            this.Controls.Add(this.cmbltk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDANGKY";
            this.Text = "FormDANGKY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDANGKY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbltk;
        private System.Windows.Forms.TextBox txtlgn;
        private System.Windows.Forms.TextBox txtusn;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Button btndk;
        private System.Windows.Forms.Button btnthoat;
    }
}