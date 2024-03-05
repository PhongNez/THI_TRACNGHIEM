using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace THI_TN_TEST
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SqlConnection conn = new SqlConnection();

        public static String connstr = "";
        public static String database="TN_CSDLPT";
        public static String servername = "";
        public static String mlogin = "";
        public static String password = "";
        public static SqlDataReader myReader;
        public static String username;
        public static String mHoten;
        public static String mGroup;
        public static frmMain frmChinh;

        public static String connstr_publisher = @"Data Source=DESKTOP-82REPVE\MAIN;Initial Catalog=TN_CSDLPT;Integrated Security=True";

        public static BindingSource bds_dspm = new BindingSource();

        public static int KetNoi()
        {
            if(Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" +
                    Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString=Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch(Exception e)
            {
                Console.WriteLine("heloo: " + Program.connstr);
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại user name và password. \n" , "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;

            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }

            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch(SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
