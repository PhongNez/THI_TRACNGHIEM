using System;

using System.Data;

using System.Windows.Forms;
namespace THI_TN_TEST
{
    public partial class frmThi : DevExpress.XtraEditors.XtraForm
    {
        public static CauHoi[] listCauHoi;
        public static ListViewItem baiThi;
        private int thoigianThi = 0;
        private int s = 59;
        public Timer timer1;
        private string trinhDo;
        private int soCau;
        private string maLop="";
        private DateTime ngayThi;
        private bool hoanThanh = false;
        public frmThi()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            layThongTinLop();
            init_MonThi();
            //initQuestion();
        }
        private void init_MonThi()
        {
            String strLenh = "EXEC SP_LAYMONTHI '" + maLop +"'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return;
            }
            DataTable dt = new DataTable();
            BindingSource dsmh = new BindingSource();
            if (Program.myReader.HasRows)
            {
                // Khởi tạo DataTable

                // Thêm các cột vào DataTable dựa trên cấu trúc của SqlDataReader
                for (int i = 0; i < Program.myReader.FieldCount; i++)
                {
                    dt.Columns.Add(Program.myReader.GetName(i), Program.myReader.GetFieldType(i));
                }
                while (Program.myReader.Read())
                {
                    DataRow row = dt.NewRow();
                    for (int i = 0; i < Program.myReader.FieldCount; i++)
                    {
                        row[i] = Program.myReader[i];
                    }
                    dt.Rows.Add(row);
                }
                dsmh.DataSource = dt;
                cbBoxTenMH.DataSource = dsmh;
                cbBoxTenMH.DisplayMember = "TENMH";
                cbBoxTenMH.ValueMember = "MAMH";
                Console.WriteLine("Số hàng trong DataTable: " + dt.Rows.Count);
            }
            else
            {
                Console.WriteLine("Không có dữ liệu trả về từ truy vấn.");
            }
            Program.myReader.Close();
        } 
        private void initQuestion()
        { 
                String strLenh = "EXECUTE";
                DataTable cauhoidt = Program.ExecSqlDataTable(strLenh);
                lbTime.Visible = true;
                timer1.Start();
                listCauHoi = new CauHoi[20];
                BindingSource bdsBaiThi = new BindingSource();
                bdsBaiThi.DataSource = cauhoidt;
                    for (int i = 0; i < listCauHoi.Length; i++)
                   {
                    listCauHoi[i] = new CauHoi();
                    listCauHoi[i].Width = panelCauHoi.Width;
                    listCauHoi[i].Height = panelCauHoi.Height - 10;
                    listCauHoi[i].CauSo = i + 1;
                    listCauHoi[i].IDBaiThi = (int)((DataRowView)bdsBaiThi[i])["CauHoi"];
                    Console.WriteLine("id cau hoi: " + listCauHoi[i].IDBaiThi);
                    listCauHoi[i].IDDe = (int)((DataRowView)bdsBaiThi[i])["CAUHOI"];
                    listCauHoi[i].NDCauHoi = ((DataRowView)bdsBaiThi[i])["NoiDung"].ToString();
                    listCauHoi[i].CauA = ((DataRowView)bdsBaiThi[i])["A"].ToString();
                    listCauHoi[i].CauB = ((DataRowView)bdsBaiThi[i])["B"].ToString();
                    listCauHoi[i].CauC = ((DataRowView)bdsBaiThi[i])["C"].ToString();
                    listCauHoi[i].CauD = ((DataRowView)bdsBaiThi[i])["D"].ToString();
                    listCauHoi[i].CauDapAn = ((DataRowView)bdsBaiThi[i])["Dap_An"].ToString();
                    //listCauHoi[i].MaBangDiem = (int)((DataRowView)bdsBaiThi[i])["MaBD"];
                    listCauHoi[i].MaBangDiem = 0;
                    listCauHoi[i].CauDaChon = "";
                    String[] arr = new string[2];
                    arr[0] = (i + 1).ToString();
                    arr[1] = listCauHoi[i].CauDaChon;

                    baiThi = new ListViewItem(arr);
                    //Console.WriteLine("cau: " + (i + 1) + ":" + listCauHoi[i].CauDapAn);
                    this.listView1.Items.Add(baiThi);
                    if (panelCauHoi.Controls.Count < 0)
                    {
                        panelCauHoi.Controls.Clear();
                    }
                    else
                        panelCauHoi.Controls.Add(listCauHoi[i]);
                }
        }
        public void capNhapDaChon(int cauSo, String daChon)
        {
                String[] arr = new string[2];
                arr[0] = (cauSo).ToString();
                arr[1] = daChon;
                ListViewItem baiThi = new ListViewItem(arr);
                listView1.Items[cauSo - 1] = baiThi;
        }
        private void lbMaSV_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            if (s == 0)
            {
                if (thoigianThi != 0)
                {
                    thoigianThi--;
                    s = 59;
                }
            }
            lbTime.Text = thoigianThi.ToString() + " : " + s.ToString();
        }
        private void btnBatDau_Click_1(object sender, EventArgs e)
        {
            layThongTinThi();
            initQuestion(); 
        }
        private void layThongTinThi()
        {
            String strLenh = "EXEC SP_THONGTINLANTHI '" +Program.malop+ "','"+cbBoxTenMH.SelectedValue+ "',"+ cbBoxLan.Text;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return;
            }
            Program.myReader.Read();
            trinhDo = Program.myReader.GetString(0);
            soCau = Program.myReader.GetInt16(1);
            thoigianThi = Program.myReader.GetInt16(2)-1;
            edtTrinhDo.Text = trinhDo;
            lbTime.Text = thoigianThi.ToString() + " : " + s.ToString();
            txtThoiGian.Text = thoigianThi.ToString()+1;
            edtSoCau.Value = soCau;
            dTNgayThi.Value = Program.myReader.GetDateTime(3);
            Program.myReader.Close();
        }
        private void layThongTinLop()
        {
            String strLenh = "EXEC SP_GetInfoClassByStudent '" + Program.mlogin +"'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return;
            }
            Program.myReader.Read();
            maLop = Program.myReader.GetString(0);
            Program.myReader.Close();
            txtEditMaSV.Text = maLop;
            txtTenLop.Text = Program.myReader.GetString(1);
            txtEditHoTen.Text = Program.mHoten;
        }
    }
    
}