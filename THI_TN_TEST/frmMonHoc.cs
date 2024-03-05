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
            vitri = bdsMH.Position;
            groupBox1.Enabled = true;
            bdsMH.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcMonHoc.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMH.CancelEdit();
            if (btnThem.Enabled == true)
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
                    //this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    //this.MONHOCTableAdapter.Update(this.DS_MH.MONHOC);
                }
                catch (Exception ex)
                {
                    this.MONHOCTableAdapter.Fill(this.DS_MH.MONHOC);
                    bdsMH.Position = bdsMH.Find("mamh", mamh);
                    return;
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frmChinh.Close();
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
            try
            {
                bdsMH.EndEdit();
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Update(this.DS_MH.MONHOC);
                bdsMH.ResetCurrentItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcMonHoc.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;

        }
    }
}
