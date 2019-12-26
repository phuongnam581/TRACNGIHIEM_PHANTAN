using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;
namespace THITRACNGHIEM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String database = "TRAC_NGHIEM";
        public static String remoteLogin = "HTKN";
        public static String remotepwd = "123";
        public static String connstr;
        public static String servername = "";
        public static SqlDataReader myReader;
        public static SqlCommand sqlcmd = new SqlCommand();

        public static String login = "";
        public static String username = "";
        public static String password = "";

        public static String loginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mCoso = 0;
        public static BindingSource bds_dspm = new BindingSource();
        public static FormGVQL formmain;
        public static FormSV formsv;
        public static FormLayDe formLayde;
        public static FormThi formThi;
        public static String control="";
        public static String maLop = "";
        public static String maMon = "";
       // public static formDN formdn;


        public static int ketNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.login + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                //MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK);
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n ", "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);

            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new formDN());
        }
    }
}
