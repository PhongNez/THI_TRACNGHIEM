using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
namespace THI_TN_TEST
{
    public partial class frmThi : DevExpress.XtraEditors.XtraForm
    {
        IOverlaySplashScreenHandle ShowProgressPanel()
        {
            return SplashScreenManager.ShowOverlayForm(this);
        }
        void CloseProgressPanel(IOverlaySplashScreenHandle handle)
        {
            if (handle != null)
                SplashScreenManager.CloseOverlayForm(handle);
        }
        IOverlaySplashScreenHandle handle = null;
        public static CauHoi[] listCauHoi;
        private DateTime ngayThi;
        private int thoigianThi = 0;
        private int s = 59;
        public Timer timer1;
        private string trinhDo;
        private int soCau;
        private string maLop="";
        private bool isStudent = true;
        BackgroundWorker worker = new BackgroundWorker();
        public frmThi()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            layThongTinLop();
            init_MonThi();
            isStudent = true;
            cbxTenLop.Visible = false;
            txtTenLop.Visible = true;
            setBtn();
        }
        public frmThi(bool isGV)
        {
            InitializeComponent();
            timer1 = new Timer();
            isStudent = false;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            cbxTenLop.Visible = true;
            //layThongTinLop();
            //init_MonThi();
            //initQuestion();
            setBtn();
            //gbSinhVien.Visible = false;
            txtTenLop.Visible = false;
        }
        private void setBtn()
        {
            btnBatDau.Enabled = false;
            btnNopBai.Enabled = false;
            btnXacNhan.Enabled = false;
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
               // Console.WriteLine("Số hàng trong DataTable: " + dt.Rows.Count);
            }
            else
            {
                DataTable dtEmpty = new DataTable();
                cbBoxTenMH.SelectedIndex = -1;
                BindingSource bindingEmpty = new BindingSource();
                bindingEmpty.DataSource = dtEmpty;
                cbBoxTenMH.DataSource = null;
                Console.WriteLine("Không có dữ liệu trả về từ truy vấn.");
            }
            Program.myReader.Close();
        }
        //private void initQuestion()
        //{       
        //        string strLenh = isStudent ?  "EXECUTE SP_LayDeThi '"+Program.malop +" ', '" + Program.mlogin +"' , '" + cbBoxTenMH.SelectedValue +" ', " +cbBoxLan.Text:
        //        "EXEC SP_ThiThu '"+cbxTenLop.SelectedValue +" ', '"+cbBoxTenMH.SelectedValue +"', "+ cbBoxLan.Text;
        //        //Console.WriteLine(strLenh);
        //        DataTable cauhoidt = Program.ExecSqlDataTable(strLenh);
        //        lbTime.Visible = true;
        //        BindingSource bdsBaiThi = new BindingSource();
        //        bdsBaiThi.DataSource = cauhoidt;
        //        listCauHoi = new CauHoi[bdsBaiThi.Count];
        //    worker.DoWork += (sender, e) =>
        //    {
        //        for (int i = 0; i < listCauHoi.Length; i++)
        //        {
        //            listCauHoi[i] = new CauHoi();
        //            listCauHoi[i].Height = panelCauHoi.Height - 10;
        //            listCauHoi[i].CauSo = i + 1;
        //            listCauHoi[i].IDBaiThi = isStudent ? (int)((DataRowView)bdsBaiThi[i])["ID_BDIEM"] : 0;
        //            Console.WriteLine("id cau hoi: " + listCauHoi[i].IDBaiThi);
        //            listCauHoi[i].IDCauHoi = isStudent ? (int)((DataRowView)bdsBaiThi[i])["ID_CAUHOI"] : (int)((DataRowView)bdsBaiThi[i])["CAUHOI"];
        //            listCauHoi[i].NDCauHoi = ((DataRowView)bdsBaiThi[i])["NoiDung"].ToString();
        //            listCauHoi[i].CauA = ((DataRowView)bdsBaiThi[i])["A"].ToString();
        //            listCauHoi[i].CauB = ((DataRowView)bdsBaiThi[i])["B"].ToString();
        //            listCauHoi[i].CauC = ((DataRowView)bdsBaiThi[i])["C"].ToString();
        //            listCauHoi[i].CauD = ((DataRowView)bdsBaiThi[i])["D"].ToString();
        //            listCauHoi[i].CauDapAn = ((DataRowView)bdsBaiThi[i])["Dap_An"].ToString();
        //            listCauHoi[i].CauDaChon = "";
        //            String[] arr = new string[2];
        //            arr[0] = (i + 1).ToString();
        //            arr[1] = listCauHoi[i].CauDaChon;

        //            baiThi = new ListViewItem(arr);
        //            // this.listView1.Items.Add(baiThi);
        //            listView1.Invoke(new Action(() =>
        //            {
        //                this.listView1.Items.Add(baiThi);
        //            }));
        //            if (panelCauHoi.Controls.Count < 0)
        //            {
        //                panelCauHoi.Controls.Clear();
        //            }
        //            else
        //                //panelCauHoi.Controls.Add(listCauHoi[i]);   
        //                listCauHoi[i].Invoke(new Action(() =>
        //                {
        //                    panelCauHoi.Controls.Add(listCauHoi[i]);
        //                }));
        //        }

        //    };
        //    worker.RunWorkerAsync();
        //}
        private void initQuestion()
        {
            string strLenh;
            handle = ShowProgressPanel();
            if (isStudent)
            {
                strLenh = "EXECUTE SP_LayDeThi '" + Program.malop + "', '" + Program.mlogin + "', '" + cbBoxTenMH.SelectedValue + "', " + cbBoxLan.Text;
            }
            else
            {
                strLenh = "EXEC SP_ThiThu '" + cbxTenLop.SelectedValue + "', '" + cbBoxTenMH.SelectedValue + "', " + cbBoxLan.Text;
            }

            // Console.WriteLine(strLenh); // Optional for debugging

            DataTable cauhoidt = Program.ExecSqlDataTable(strLenh);

            lbTime.Visible = true;

            BindingSource bdsBaiThi = new BindingSource();
            bdsBaiThi.DataSource = cauhoidt;

            // More efficient list creation (consider using a custom List<CauHoi>)
            listCauHoi = new CauHoi[bdsBaiThi.Count];

            worker.DoWork += (sender, e) =>
            {
                for (int i = 0; i < bdsBaiThi.Count; i++)
                {
                    DataRowView dataRow = (DataRowView)bdsBaiThi[i];

                    CauHoi cauHoi = new CauHoi();
                    cauHoi.Height = panelCauHoi.Height - 10;
                    cauHoi.CauSo = i + 1;

                    // Set properties based on data row
                    cauHoi.IDBaiThi = isStudent ? (int)dataRow["ID_BDIEM"] : 0;
                    cauHoi.IDCauHoi = isStudent ? (int)dataRow["ID_CAUHOI"] : (int)dataRow["CAUHOI"];
                    cauHoi.NDCauHoi = dataRow["NoiDung"].ToString();
                    cauHoi.CauA = dataRow["A"].ToString();
                    cauHoi.CauB = dataRow["B"].ToString();
                    cauHoi.CauC = dataRow["C"].ToString();
                    cauHoi.CauD = dataRow["D"].ToString();
                    cauHoi.CauDapAn = dataRow["Dap_An"].ToString();
                    cauHoi.CauDaChon = "";

                    // Add CauHoi object to the list
                    listCauHoi[i] = cauHoi;

                    // Update ListView item (consider using a custom ListViewItem class)
                    string[] arr = new string[2];
                    arr[0] = (i + 1).ToString();
                    arr[1] = cauHoi.CauDaChon;
                    ListViewItem baiThi = new ListViewItem(arr);
                    // Thread-safe update using Invoke or BeginInvoke
                    listView1.Invoke(new Action(() =>
                    {
                        listView1.Items.Add(baiThi);
                    }));
                }
            };

            worker.RunWorkerCompleted += (sender, e) =>
            {
                // Optional: Handle worker completion (e.Error for exceptions)
                if (e.Error != null)
                {
                    // Handle background worker error
                }
                else
                {
                    // Add all CauHoi objects to panel in a single thread-safe call
                    panelCauHoi.Invoke(new Action(() =>
                    {
                        panelCauHoi.Controls.AddRange(listCauHoi);
                    }));
                    CloseProgressPanel(handle);
                    timer1.Start();
                }
            };
            worker.RunWorkerAsync();
        }

        public void capNhapDaChon(int cauSo, String daChon)
        {
                String[] arr = new string[2];
                arr[0] = (cauSo).ToString();
                arr[1] = daChon;
                ListViewItem baiThi = new ListViewItem(arr);
                listView1.Items[cauSo - 1] = baiThi;
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
                else
                {
                    ketThuc();
                }
            }
            lbTime.Text = thoigianThi.ToString() + " : " + s.ToString();
        }
        private void ketThuc()
        {
            //Tính điểm
            timer1.Stop();
            lbTime.Text = "00:00";
            if(isStudent)
                insertdiemsv(tinhdiem());
            else
            {
                tinhdiem();
            }
            //insert
            // tạo form 
        }
        private float tinhdiem()
        {
            int caudung = 0;
            int soCauThi = listCauHoi.Length;
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                if (listCauHoi[i].CauDaChon.Trim().CompareTo(listCauHoi[i].CauDapAn.Trim()) == 0)
                    caudung++;
            }
            float diem;
            if (caudung == 0) diem = 0;
            else diem = (float)Math.Round((double)(10 * caudung) / soCauThi, 2);
            MessageBox.Show("Số câu đúng: " + caudung + "/" + soCauThi + "\nĐiểm: " + diem, "Kết Quả", MessageBoxButtons.OK);
            btnNopBai.Enabled = false;
            return diem;
        }
        private void insertdiemsv(float diem)
        {
            String sql = "EXEC sp_UpdateBangDiem " + listCauHoi[0].IDBaiThi +" , " + diem.ToString();
            try
            {
                int kq = Program.ExecSqlNonQuery(sql);
                Program.conn.Close();
                ghiDapAn();
                showReport();
                //if (kq == 1)
                //{
                //    ghiDapAn();
                //}
                //else
                //{
                //    MessageBox.Show("Lỗi ghi điểm thi", "", MessageBoxButtons.OK);
                //    return;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi điểm thi " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void showReport()
        {
            XtraReport2 rpt = new XtraReport2(Program.mlogin,Int32.Parse(cbBoxLan.Text), cbBoxTenMH.SelectedValue.ToString());
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
        private void ghiDapAn()
        {
            string sqlUpdate = "";
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                sqlUpdate += "EXEC spUpdateChiTietThi " +listCauHoi[i].IDCauHoi+ ", "+ listCauHoi[i].IDBaiThi+ ", "+ (i+1) + ", '" +listCauHoi[i].CauDaChon +"'"
                    +"; ";
            }
            Console.WriteLine(sqlUpdate);
            try
            {
                Program.ExecSqlNonQuery(sqlUpdate);
                Program.conn.Close(); 
                //if (kq != 0)
                //{
                //    MessageBox.Show("Ghi kết quả thành công ", "Thông báo", MessageBoxButtons.OK);
                //    return;
                //}
                //else
                //{
                //    MessageBox.Show("Lỗi ghi đáp án thi", "", MessageBoxButtons.OK);
                //    return;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đáp án thi " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void btnBatDau_Click_1(object sender, EventArgs e)
        {
            btnBatDau.Enabled = false;
            btnXacNhan.Enabled = false;
            cbBoxLan.Enabled = false;
            cbBoxTenMH.Enabled = false;
            dTNgayThi.Enabled = false;
            DateTime today = DateTime.Today;
            if (today.CompareTo(ngayThi.Date) != 0 && isStudent)
            {
                Console.WriteLine("Ngày thi : " + ngayThi + ", ngày hiện tại: " + today);
                MessageBox.Show("Chưa đến ngày thi", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            initQuestion(); 
        }
        private void layThongTinThi()
        {
            String strLenh = "EXEC SP_THONGTINLANTHI '" +  (isStudent ? Program.malop: maLop) + "','"+cbBoxTenMH.SelectedValue+ "',"+ cbBoxLan.Text;
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
            txtThoiGian.Text = (thoigianThi+1).ToString();
            edtSoCau.Value = soCau;
            dTNgayThi.Value = Program.myReader.GetDateTime(3);
            ngayThi = Program.myReader.GetDateTime(3);
            Program.myReader.Close();
        }
        private void kiemTraLanThi()
        {
            if (isStudent)
            {
                int dathi = 0;
                String strLenh = "EXEC SP_KTLANTHI '" + Program.mlogin + "','" + cbBoxTenMH.SelectedValue + "'," + cbBoxLan.Text;
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null)
                {
                    return;
                }
                Program.myReader.Read();
                dathi = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (dathi == 1)
                {
                    MessageBox.Show("Bạn đã thi môn này, vui lòng chọn lại!", "", MessageBoxButtons.OK);
                }
                else
                {
                    layThongTinThi();
                    btnBatDau.Enabled = true;
                    btnNopBai.Enabled = true;
                }
            }
            else
            {
                layThongTinThi();
                btnBatDau.Enabled = true;
                btnNopBai.Enabled = true;
            }
           
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
            txtMaLop.Text = maLop;
            txtTenLop.Text = Program.myReader.GetString(1);
            Program.myReader.Close();
            txtEditHoTen.Text = Program.mHoten;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            kiemTraLanThi();
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            ketThuc();
        }

        private void cbBoxLan_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = true;
        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            if (!isStudent)
            {
                this.lIST_LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lIST_LOPTableAdapter.Fill(this.dS.LIST_LOP);
            }
        }
        private void cbxTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTenLop.SelectedValue == null)
            {
                return;//SelectedValue chưa có giá trị => nếu tiếp tục chạy đoạn code bên dưới sẽ lỗi
            }
            maLop = cbxTenLop.SelectedValue.ToString();
            txtMaLop.Text = maLop;
            init_MonThi();
        }
    }
}