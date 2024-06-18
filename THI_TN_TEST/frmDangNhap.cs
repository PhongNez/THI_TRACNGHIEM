using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace THI_TN_TEST
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
    
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) { conn_publisher.Open();}
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            Program.bds_dspm.Sort="TENCN";
            //Program.bds_dspm.RemoveAt(2);
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";

        }

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc.\nBạn xem lại tên Server của pushlisher, và tên CSDL trong chuỗi kết nối.\n"+ e.Message);
                return 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) { return; }
            LayDSPM("select * from Get_Subscribes");
            cmbChiNhanh.SelectedIndex = 1; cmbChiNhanh.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Tên server: " + cmbChiNhanh.SelectedValue+ "Tên tài khoản: "+ txtTaiKhoan.Text + " Mật khẩu: " + txtMatKhau.Text);

            if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu", "", MessageBoxButtons.OK);
                return;
            }
            // thiếu
            Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;
           
            //MessageBox.Show("Kết nối thành công ", "", MessageBoxButtons.OK);
            string strLenh = "";
            if (radiobtnGV.Checked == true)
            {

                if (Program.KetNoi() == 0)
                { return; }
                Program.mCoso = cmbChiNhanh.SelectedIndex;//Lấy index của item  đang được chọn để hỗ trợ rẽ cơ sở
                
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                strLenh = "EXEC SP_Lay_Thong_Tin_GV_Tu_Login '" + Program.mlogin + "'";
            }
            else if (radiobtnSV.Checked == true)
            {
                if (Program.KetNoiSinhVien() == 0)
                {
                    return;
                }
                strLenh = "EXEC SP_LOGIN_SV '" + Program.mlogin + "'," + "'" + Program.password + "'"; 
            }
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return;
            }
            else
            {
                Program.myReader.Read();
                Program.malop =  radiobtnSV.Checked ?  Program.myReader.GetString(3): "";
                //Program.malop = Program.myReader.GetString(3);
                Program.username = Program.myReader.GetString(0);//username
            }
           
           
            //MessageBox.Show(Program.malop);

            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập database./nBạn xem lại username,password", "", MessageBoxButtons.OK);
                return;
            }


            if (Program.myReader.IsDBNull(1))
            {
                MessageBox.Show("Tài khoản của bạn không hợp lệ.\nBạn xem lại lựa chọn", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MANV.Text = "Mã NV = " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ tên = " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm = " + Program.mGroup;
            //Program.frmChinh.ribbonPage2
            if (Program.mGroup == "SINHVIEN")
            {
                Program.frmChinh.HienThiMenu(false);
            }
            else
            {
                Program.frmChinh.HienThiMenu(true);
            }
            if(Program.mGroup == "TRUONG")
            {
                Program.frmChinh.HienThiMenuTruong(true);
            }

        }
    }
}
