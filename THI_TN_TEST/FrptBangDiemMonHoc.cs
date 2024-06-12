using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace THI_TN_TEST
{
    public partial class FrptBangDiemMonHoc : Form
    {
        string MaLop, MaMH;
        public FrptBangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void FrptBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.

            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);

            // TODO: This line of code loads data into the 'dS.BANGDIEM' table. You can move, or remove it, as needed.
            this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);

            phanQuyen();
        }

        private void phanQuyen()
        {
            cmbCoso.DataSource = Program.bds_dspm;//Sao chép bds_dspm đã load ở form đăng nhập
            cmbCoso.DisplayMember = "TENCN";
            cmbCoso.ValueMember = "TENSERVER";
            cmbCoso.SelectedIndex = Program.mCoso;

            if (Program.mGroup.Trim() == "TRUONG")
            {
                cmbCoso.Enabled = true;
            }
            else cmbCoso.Enabled = false;
        }


        private void cmbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoso.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;//SelectedValue chưa có giá trị => nếu tiếp tục chạy đoạn code bên dưới sẽ lỗi
            }
            Program.servername = cmbCoso.SelectedValue.ToString();
            if (cmbCoso.SelectedIndex != Program.mCoso)//Nếu mà chi nhánh đang chọn khác với chi nhánh đăng nhập
            {
                //Dùng tài khoản HTKN
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu mới", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.DS.LOP);

                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Fill(this.DS.MONHOC);

                this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.BANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);
            }
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            Xrpt_BangDiemMonHoc rpt = new Xrpt_BangDiemMonHoc(cmbMaLop.SelectedValue.ToString(),cmbMaMH.SelectedValue.ToString(), int.Parse(cmbLanThi.Text));
            rpt.lblTitle.Text = "BẢNG ĐIỂM MÔN " + cmbMaMH.Text.ToUpper() + " LỚP " + cmbMaLop.Text.ToUpper() + " THI LẦN " + cmbLanThi.Text;
            rpt.lblLop.Text = cmbMaLop.Text;
            rpt.lblMonThi.Text = cmbMaMH.Text;
            rpt.lblLanThi.Text = cmbLanThi.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        //private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        MaMH = cmbMaMH.SelectedValue.ToString();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        MaLop = cmbMaLop.SelectedValue.ToString();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
    }
}
