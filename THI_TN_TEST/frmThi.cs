﻿using DevExpress.XtraReports.UI;
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
        private bool isStudent= true;
        public frmThi()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            layThongTinLop();
            init_MonThi();
            //initQuestion();
            setBtn();
        }
        private void setBtn()
        {
            btnBatDau.Enabled = false;
            btnNopBai.Enabled = false;
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
                
                Console.WriteLine("Không có dữ liệu trả về từ truy vấn.");
            }
            Program.myReader.Close();
        } 
        private void initQuestion()
        { 
                String strLenh = "EXECUTE SP_LayDeThi '"+Program.malop +" ', '" + Program.mlogin +"' , '" + cbBoxTenMH.SelectedValue +" ', " +cbBoxLan.Text ;
                DataTable cauhoidt = Program.ExecSqlDataTable(strLenh);
                lbTime.Visible = true;
                BindingSource bdsBaiThi = new BindingSource();
                bdsBaiThi.DataSource = cauhoidt;
                listCauHoi = new CauHoi[bdsBaiThi.Count];
                for (int i = 0; i < listCauHoi.Length; i++)
                   {
                    listCauHoi[i] = new CauHoi();
                    listCauHoi[i].Width = panelCauHoi.Width;
                    listCauHoi[i].Height = panelCauHoi.Height - 10;
                    listCauHoi[i].CauSo = i + 1;
                    listCauHoi[i].IDBaiThi = (int)((DataRowView)bdsBaiThi[i])["ID_BDIEM"];
                    Console.WriteLine("id cau hoi: " + listCauHoi[i].IDBaiThi);
                    listCauHoi[i].IDCauHoi = (int)((DataRowView)bdsBaiThi[i])["ID_CAUHOI"];
                    listCauHoi[i].NDCauHoi = ((DataRowView)bdsBaiThi[i])["NoiDung"].ToString();
                    listCauHoi[i].CauA = ((DataRowView)bdsBaiThi[i])["A"].ToString();
                    listCauHoi[i].CauB = ((DataRowView)bdsBaiThi[i])["B"].ToString();
                    listCauHoi[i].CauC = ((DataRowView)bdsBaiThi[i])["C"].ToString();
                    listCauHoi[i].CauD = ((DataRowView)bdsBaiThi[i])["D"].ToString();
                    listCauHoi[i].CauDapAn = ((DataRowView)bdsBaiThi[i])["Dap_An"].ToString();
                    listCauHoi[i].CauDaChon = "";
                    String[] arr = new string[2];
                    arr[0] = (i + 1).ToString();
                    arr[1] = listCauHoi[i].CauDaChon;

                    baiThi = new ListViewItem(arr);
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
            insertdiemsv(tinhdiem());
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
            initQuestion();
            btnBatDau.Enabled = false;
            btnXacNhan.Enabled = false;
            cbBoxLan.Enabled = false;
            cbBoxTenMH.Enabled = false;
            dTNgayThi.Enabled = false;
            timer1.Start();
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
            txtThoiGian.Text = (thoigianThi+1).ToString();
            edtSoCau.Value = soCau;
            dTNgayThi.Value = Program.myReader.GetDateTime(3);
            Program.myReader.Close();
        }
        private void kiemTraLanThi()
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
            {   layThongTinThi();
                btnBatDau.Enabled = true;
                btnNopBai.Enabled= true;
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
            txtEditMaSV.Text = maLop;
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
    }
    
}