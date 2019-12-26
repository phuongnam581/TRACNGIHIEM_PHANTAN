using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITRACNGHIEM
{
    public partial class FormThi : Form
    {
       public static int maDangKy = 0;
        int vitri = 0;
       public static int caudung = 0;
       public static float diem = 0;
       public static String soCau = "";
       public static bool demThoat = true;
       public static bool check = false;
        int thoigian;
        int s=0;

        Boolean status = false;
        int[] dsMaBaiThi = new int[50];
       
        List<String> chon = new List<String>();
   
        public FormThi()
        {
            InitializeComponent();
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bAITHILOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bAITHILOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.CTBAITHI' table. You can move, or remove it, as needed.
            caudung = 0;
            demThoat = true;
            // TODO: This line of code loads data into the 'dS.BAITHILOP' table. You can move, or remove it, as needed.
            this.bAITHILOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bAITHILOPTableAdapter.Fill(this.dS.BAITHILOP);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            // TODO: This line of code loads data into the 'dS.LUACHON' table. You can move, or remove it, as needed.
            this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lUACHONTableAdapter.Fill(this.dS.LUACHON);

            this.cTBAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTBAITHITableAdapter.Fill(this.dS.CTBAITHI);
            Program.myReader = null;
            if (Program.ketNoi() == 0) return;
            try
            {
                String strlenh = "EXEC SP_LAYTHONGTINDANGKY N'" + Program.maLop.Trim() + "',N'" + Program.maMon.Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                Program.myReader.Read();
                do
                {

                    lblTD.Text = Program.myReader.GetString(5);
                    lblTG.Text = Program.myReader.GetInt32(8).ToString();
                    soCau=lblCau.Text = Program.myReader.GetInt32(7).ToString();
                    maDangKy = Program.myReader.GetInt32(0);
                } while (Program.myReader.Read());
                Program.myReader.Close();
            }
            catch (Exception ex)
            {
                return;
            }
            if (Program.mGroup == "Sinhvien")
            {
                lblHoTen.Text = Program.mHoten;
                lblSV.Text = Program.username;
            }
            else if(Program.mGroup=="Giangvien" || Program.mGroup == "KHOA")
            {
                lblHoTen.Text = "";
                lblSV.Text = "";
            }
            lblMaLop.Text = Program.maLop;
            lblMH.Text = Program.maMon;
            bODEBindingSource.Filter = "CAUHOI IN (" + danhSachCH() + ")";
            bAITHILOPBindingSource.Filter= "CAUHOI IN (" + danhSachCH() + ")";
            thoigian = Int32.Parse(lblTG.Text);
            //   btnThoat.Enabled = false;
           
            timer1.Start();
            loadCauThi();
            for (int j = 0; j < bODEBindingSource.Count; j++)
            {
                chon.Add(" ");
            }
         
          
          
         
        }


        private string danhSachCH()
        {

            String ds = "";
            int i = 0;
            Program.myReader = null;
            if (Program.ketNoi() == 0) return "NO CONNECT";
            String strlenh = "EXEC dbo.SP_LAYCAUHOIBAITHILOP N'" + maDangKy + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            while (Program.myReader.Read())
            {
                ds += "'" + Program.myReader.GetInt32(1) + "',";
                dsMaBaiThi[i] = Program.myReader.GetInt32(0);
                i++;
            }
            Program.myReader.Close();
            return ds.Substring(0, ds.Length - 1);


        }


        private void loadCauThi()
        {
            rdA.Visible = rdB.Visible = rdC.Visible = rdD.Visible = rdE.Visible = rdF.Visible = true;

            int i = 0, soluachon = 0,cau=vitri+1;
            if (vitri >= 0 && vitri < bODEBindingSource.Count)
            {
                int pos = bAITHILOPBindingSource.Find("MACAUHOIBAITHI", dsMaBaiThi[vitri]);
                Console.WriteLine(dsMaBaiThi[vitri]);
                lblCauHoi.Text = "Câu " + (cau).ToString();
                txtND.Text = ((DataRowView)bODEBindingSource[pos])["NOIDUNG"].ToString();
                if (LuaChon.danhSachLuaChon != null)
                {
                    LuaChon.danhSachLuaChon.Clear();
                }
                Program.myReader = null;
                if (Program.ketNoi() == 0) return;
                try
                {
                    String strlenh = "EXEC SP_LAYLUACHON N'" + ((DataRowView)bODEBindingSource[pos])["CAUHOI"] + "'";
                    Program.myReader = Program.ExecSqlDataReader(strlenh);
                    Program.myReader.Read();
                    do
                    {
                        int maLuaChon = Program.myReader.GetInt32(0);
                        int cauHoi = Program.myReader.GetInt32(1);
                        String moTa = Program.myReader.GetString(2);
                        String thuTu = Program.myReader.GetString(3);
                        LuaChon l = new LuaChon(maLuaChon, cauHoi, moTa, thuTu);
                        LuaChon.danhSachLuaChon.Add(l);
                    } while (Program.myReader.Read());
                    Program.myReader.Close();
                }
                catch (Exception ex)
                {
                    return;
                }
                //    Console.WriteLine(LuaChon.danhSachLuaChon.Count);
                switch (LuaChon.danhSachLuaChon.Count)
                {

                    case 2:
                        {
                            LuaChon l = (LuaChon)LuaChon.danhSachLuaChon[i];
                            LuaChon l1 = (LuaChon)LuaChon.danhSachLuaChon[i + 1];
                            rdA.Text = l.getThuTu() + ". " + l.getMoTa();
                            rdB.Text = l1.getThuTu() + ". " + l1.getMoTa();
                            rdC.Visible = rdD.Visible = rdE.Visible = rdF.Visible = false;
                            break;
                        }
                    case 3:
                        {
                            LuaChon l = (LuaChon)LuaChon.danhSachLuaChon[i];
                            LuaChon l1 = (LuaChon)LuaChon.danhSachLuaChon[i + 1];
                            LuaChon l2 = (LuaChon)LuaChon.danhSachLuaChon[i + 2];
                            rdA.Text = l.getThuTu() + ". " + l.getMoTa();
                            rdB.Text = l1.getThuTu() + ". " + l1.getMoTa();
                            rdC.Text = l2.getThuTu() + ". " + l2.getMoTa();
                            rdD.Visible = rdE.Visible = rdF.Visible = false;
                            break;
                        }
                    case 4:
                        {
                            LuaChon l = (LuaChon)LuaChon.danhSachLuaChon[i];
                            LuaChon l1 = (LuaChon)LuaChon.danhSachLuaChon[i + 1];
                            LuaChon l2 = (LuaChon)LuaChon.danhSachLuaChon[i + 2];
                            LuaChon l3 = (LuaChon)LuaChon.danhSachLuaChon[i + 3];
                            rdA.Text = l.getThuTu() + ". " + l.getMoTa();
                            rdB.Text = l1.getThuTu() + ". " + l1.getMoTa();
                            rdC.Text = l2.getThuTu() + ". " + l2.getMoTa();
                            rdD.Text = l3.getThuTu() + ". " + l3.getMoTa();
                            rdE.Visible = rdF.Visible = false;
                            break;
                        }
                    case 5:
                        {
                            LuaChon l = (LuaChon)LuaChon.danhSachLuaChon[i];
                            LuaChon l1 = (LuaChon)LuaChon.danhSachLuaChon[i + 1];
                            LuaChon l2 = (LuaChon)LuaChon.danhSachLuaChon[i + 2];
                            LuaChon l3 = (LuaChon)LuaChon.danhSachLuaChon[i + 3];
                            LuaChon l4 = (LuaChon)LuaChon.danhSachLuaChon[i + 4];
                            rdA.Text = l.getThuTu() + ". " + l.getMoTa();
                            rdB.Text = l1.getThuTu() + ". " + l1.getMoTa();
                            rdC.Text = l2.getThuTu() + ". " + l2.getMoTa();
                            rdD.Text = l3.getThuTu() + ". " + l3.getMoTa();
                            rdE.Text = l4.getThuTu() + ". " + l4.getMoTa();
                            rdF.Visible = false;
                            break;
                        }
                    case 6:
                        {
                            LuaChon l = (LuaChon)LuaChon.danhSachLuaChon[i];
                            LuaChon l1 = (LuaChon)LuaChon.danhSachLuaChon[i + 1];
                            LuaChon l2 = (LuaChon)LuaChon.danhSachLuaChon[i + 2];
                            LuaChon l3 = (LuaChon)LuaChon.danhSachLuaChon[i + 3];
                            LuaChon l4 = (LuaChon)LuaChon.danhSachLuaChon[i + 4];
                            LuaChon l5 = (LuaChon)LuaChon.danhSachLuaChon[i + 5];
                            rdA.Text = l.getThuTu() + ". " + l.getMoTa();
                            rdB.Text = l1.getThuTu() + ". " + l1.getMoTa();
                            rdC.Text = l2.getThuTu() + ". " + l2.getMoTa();
                            rdD.Text = l3.getThuTu() + ". " + l3.getMoTa();
                            rdE.Text = l4.getThuTu() + ". " + l4.getMoTa();
                            rdF.Text = l5.getThuTu() + ". " + l5.getMoTa();
                            break;
                        }
                }
            }
        }



        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (vitri > 0)
            {
                xoaCheck();
                vitri--;
                checkRadio();
                loadCauThi();
             
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (vitri < bODEBindingSource.Count -1)
            {
                xoaCheck();
                vitri++;
                checkRadio();
                loadCauThi();
                
            }

        }

        private void rdF_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = sender as RadioButton;
            if (rad.Checked)
            {
                if (rdA.Checked == true)
                {
                    chon[vitri] = "A";
                }
                else if (rdB.Checked == true)
                {
                    chon[vitri] = "B";
                }
                else if (rdC.Checked == true)
                {
                    chon[vitri] = "C";
                }
                else if (rdD.Checked == true)
                {
                    chon[vitri] = "D";
                }
                else if (rdF.Checked == true)
                {
                    chon[vitri] = "E";
                }
                else
                {
                    chon[vitri] = "F";
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           


            if (s == 0)
            {
                thoigian--;
                s = 59;
            }
            else
            {
                s--;
            }

            if (thoigian < 10)
            {
                if (s < 10)
                {
                    lblTime.Text = "0" + thoigian.ToString() + ":0" + s.ToString();
                }
                else
                {
                    lblTime.Text = "0" + thoigian.ToString() + ":" + s.ToString();
                }
            }
            else
            {
                if (s < 10)
                {
                    lblTime.Text = thoigian.ToString() + ":0" + s.ToString();
                }
                else
                {
                    lblTime.Text = thoigian.ToString() + ":" + s.ToString();
                }
            }


            if (thoigian == 0)
            {
                if (s == 0)
                {
                    timer1.Stop(); status = false;
                    MessageBox.Show("Đã hết thời gian!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                     tinhDiem();
                    
                    btnNopBai.Enabled = false;
                    btnThoat.Enabled = true;
                }

            }
        }
        private void xoaCheck()
        {
            rdA.Checked = rdB.Checked = rdC.Checked = rdD.Checked = rdD.Checked = rdE.Checked = rdF.Checked = false;
        }
        private void checkRadio()
        {
            if (chon[vitri].Equals("A")) rdA.Checked = true;
            else if (chon[vitri].Equals("B")) rdB.Checked = true;
            else if (chon[vitri].Equals("C")) rdC.Checked = true;
            else if (chon[vitri].Equals("D")) rdD.Checked = true;
            else if (chon[vitri].Equals("E")) rdE.Checked = true;
            else if (chon[vitri].Equals("F")) rdF.Checked = true;
            else if (chon[vitri].Equals(" ")) xoaCheck();

        }
        private void tinhDiem()
        {
            // caudung = 0;
         
            for (int i = 0; i < bODEBindingSource.Count; i++)
            {
                // if (chon[i].Equals(((DataRowView)bODEBindingSource[i])["DAPAN"]).ToString()) caudung++;
                // if(String.Equals(chon[i], ((DataRowView)bODEBindingSource[i])["DAPAN"])); caudung++;
                //    Console.WriteLine(chon[i]);
                //     Console.WriteLine((((DataRowView)bODEBindingSource[i])["DAPAN"]).ToString());
                //     Console.WriteLine((((DataRowView)bODEBindingSource[i])["CAUHOI"]).ToString());
                //     Console.WriteLine(chon[i]);
                //    Console.WriteLine("----------------------");
                //  int pos = bODEBindingSource.Find("CAUHOI", dsMaBaiThi[i]);
                
                int pos = bAITHILOPBindingSource.Find("MACAUHOIBAITHI", dsMaBaiThi[i]);
                if (chon[i] == (((DataRowView)bODEBindingSource[pos])["DAPAN"]).ToString()) caudung++;
                Console.WriteLine(chon[i]);
                Console.WriteLine((((DataRowView)bODEBindingSource[pos])["DAPAN"]).ToString());
                Console.WriteLine((((DataRowView)bODEBindingSource[pos])["CAUHOI"]).ToString());
            }
            Console.WriteLine(caudung);
            if (caudung == 0) diem = 0;
            else diem = (float)Math.Round((double)(10 * caudung) / bODEBindingSource.Count, 2);
            if (Program.mGroup == "Sinhvien")
            {

                luuCTBaiThi();
            }
            FormKQ frmKetQua = new FormKQ();
            frmKetQua.ShowDialog();
            check = true;
        }

        private void luuCTBaiThi()
        {
            for(int i = 0; i < bODEBindingSource.Count; i++)
            {

                cTBAITHIBindingSource.AddNew();
                ((DataRowView)cTBAITHIBindingSource[cTBAITHIBindingSource.Position])["MACAUHOIBAITHI"] = dsMaBaiThi[i];
                ((DataRowView)cTBAITHIBindingSource[cTBAITHIBindingSource.Position])["MASV"] =Program.username;
                ((DataRowView)cTBAITHIBindingSource[cTBAITHIBindingSource.Position])["SVCHON"] = chon[i];
                cTBAITHIBindingSource.EndEdit();
            }
            try
            {
                cTBAITHITableAdapter.Update(this.dS.CTBAITHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void btnNopBai_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("Bạn có muốn nộp bài?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {       
                tinhDiem();
                btnNopBai.Enabled = false;
            }else 
            {
                timer1.Start();
                btnNopBai.Enabled = true;
            }
            
            
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (Program.mGroup == "Sinhvien")
            {
             //   demThoat++;
               if (demThoat)
                {
                    timer1.Stop();
                    if (MessageBox.Show("Bạn có muốn nộp bài?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                       
                        tinhDiem();
                        btnNopBai.Enabled = false;
                    }
                    else
                    {
                        timer1.Start();
                        btnNopBai.Enabled = true;
                    }
                }
                else
                {
                    check = true;
                    this.Close();
                    FormSV formsv = new FormSV();
                    formsv.Activate();
                    formsv.Show();
                }
            }else if(Program.mGroup=="Giangvien" || Program.mGroup == "KHOA")
            {
                  //  demThoat++;
                    if (demThoat)
                 {
                    timer1.Stop();
                    if (MessageBox.Show("Bạn có muốn nộp bài?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                           
                            tinhDiem();
                        btnNopBai.Enabled = false;
                    }
                    else
                    {
                        timer1.Start();
                        btnNopBai.Enabled = true;
                    }
                }
                else
                {
                    check = true;
                    this.Close();
                    FormGVQL formgv = new FormGVQL();
                    formgv.Activate();
                    formgv.Show();
                }
               
            }
           
            
        }

        private void FormThi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.mGroup == "Sinhvien"|| Program.mGroup=="KHOA"|| Program.mGroup=="Giangvien")
            {
                if (check)
                {
                    return;
                }

                if (MessageBox.Show("Bạn có muốn nộp bài?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    timer1.Stop();
                    tinhDiem();
                }
                else
                {
                    e.Cancel = true;
                }
            }

            
        }
        //private void button2_Click(object sender, EventArgs e)
        //{

        //}
    }
}
