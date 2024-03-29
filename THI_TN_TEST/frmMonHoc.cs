using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THI_TN_TEST
{
    public partial class frmMONHOC : Form
    {
        int vitri = 0;
        int checkThemSua = 0;// 0 là thêm, 1 là sửa
        public frmMONHOC()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_MH);

        }

        private void frmMONHOC_Load(object sender, EventArgs e)
        {
            DS_MH.EnforceConstraints = false;
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.DS_MH.MONHOC);

            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.DS_MH.BANGDIEM);

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.DS_MH.BODE);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS_MH.GIAOVIEN_DANGKY);
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkThemSua = 0;
            txtMAMH.Enabled = true;
            vitri = bdsMH.Position;
            groupBox1.Enabled = true;
            bdsMH.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcMonHoc.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.MONHOCTableAdapter.Fill(this.DS_MH.MONHOC);//Mục đích xóa các ô thừa
            bdsMH.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsMH.Position = vitri;
            }
            gcMonHoc.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.MONHOCTableAdapter.Fill(this.DS_MH.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message,"",MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mamh = "";
            if (bdsBANGDIEM.Count>0)
            {
                MessageBox.Show("Bạn không thể xóa vì mã đã có trong bảng Bảng Điểm", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsBODE.Count > 0)
            {
                MessageBox.Show("Bạn không thể xóa vì mã đã có trong bảng Bộ Đề", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Bạn không thể xóa vì mã đã có trong bảng Giáo Viên Đăng Ký", "", MessageBoxButtons.OK);
                return;
            }

            if(MessageBox.Show("Bạn có muốn xóa mã môn học?","Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    mamh = Convert.ToString(((DataRowView)bdsMH[bdsMH.Position])["MAMH"]);
                    MessageBox.Show("Bạn đã xóa thành công " + mamh, "", MessageBoxButtons.OK);
                    bdsMH.RemoveCurrent();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MONHOCTableAdapter.Update(this.DS_MH.MONHOC);
                }
                catch (Exception ex)
                {
                    bdsMH.Position = bdsMH.Find("mamh", mamh);
                    return;
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học bạn chưa nhập.", "Thông báo");
                txtMAMH.Focus();
                return;
            }
            if (txtTENMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học bạn chưa nhập.", "Thông báo");
                txtTENMH.Focus();
                return;
            }

            txtMAMH.Text = txtMAMH.Text.Trim();
            txtTENMH.Text = txtTENMH.Text.Trim();
           
            try
            {
                if (checkThemSua == 0) {
                    //Kiểm tra mã môn có trùng trên các site
                    string strLenh = "EXEC sp_KiemTraMaMonHoc '" + txtMAMH.Text + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int result = Program.myReader.GetInt32(0);
                    Program.myReader.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Mã MÔN HỌC đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
              
 }
                //Kiểm tra tên trùng
                string strTenMonHoc = "EXEC sp_KiemTraTenMonHoc N'" + txtTENMH.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strTenMonHoc);
                Program.myReader.Read();
                int resultTen = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (resultTen == 1)
                {
                    MessageBox.Show("Tên MÔN HỌC đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                bdsMH.EndEdit();
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Update(this.DS_MH.MONHOC);
                bdsMH.ResetCurrentItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học. \n" + ex.Message, "", MessageBoxButtons.OK);
                this.MONHOCTableAdapter.Fill(this.DS_MH.MONHOC);
                return;
            }
            gcMonHoc.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkThemSua = 1;
            txtMAMH.Enabled = false;// Không cho sửa mã môn học
            gcMonHoc.Enabled = false;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =btnReload.Enabled=btnThoat.Enabled= false;
            btnGhi.Enabled = btnUndo.Enabled = true;
        }
    }
}
