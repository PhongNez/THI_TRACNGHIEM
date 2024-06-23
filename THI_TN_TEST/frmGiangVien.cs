using System;
using System.Data;
using System.Windows.Forms;

namespace THI_TN_TEST
{
    public partial class frmGiangVien : Form
    {
        int vitri = 0;
        int checkAddEdit = 0;// 0 là thêm, 1 là sửa
        public frmGiangVien()
        {
            InitializeComponent();
        }


        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS_GV.KHOA' table. You can move, or remove it, as needed.
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'DS_GV.KHOA' table. You can move, or remove it, as needed.

            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
            // TODO: This line of code loads data into the 'DS_GV.BODE' table. You can move, or remove it, as needed.
            this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.BODETableAdapter.Fill(this.DS.BODE);
            // TODO: This line of code loads data into the 'DS_GV.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'ds1.GIAOVIEN' table. You can move, or remove it, as needed.

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
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled = false;
            }
            else
            {
                cmbCoso.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled = true;
            }
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
                this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOATableAdapter.Fill(this.DS.KHOA);

                this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkAddEdit = 0;
            txtMaGV.Enabled = true;
            vitri = bdsGV.Position;
            panelControl3.Enabled = true;
            gcKHOA.Enabled = false;
            GIAOVIENDataGridView.Enabled = false;
            bdsGV.AddNew();

            txtMaGV.Enabled = true;
            txtMaKhoa.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);//Mục đích xóa các ô thừa
            bdsGV.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsGV.Position = vitri;
            }
            gcKHOA.Enabled = true;
            panelControl3.Enabled = false;
            GIAOVIENDataGridView.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnGhi.Enabled) // nếu thông tin chưa được ghi
            {
                if (MessageBox.Show("Thông tin chưa được lưu. \n" +
                    "Bạn có thực sự muốn thoát ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
                return;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkAddEdit = 1;
            txtMaGV.Enabled = false;// Không cho sửa mã giảng viên
            gcKHOA.Enabled = false;
            panelControl3.Enabled = true;
            GIAOVIENDataGridView.Enabled = false;

            txtMaKhoa.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã Giảng Viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaGV.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Họ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Địa chỉ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }

            try
            {
                if (checkAddEdit == 0)
                {
                    //Kiểm tra mã giảng viên có trùng trên các site
                    string strLenh = "declare @result int " +
                        "EXEC @result = SP_KiemTraMaGiangVien '" + txtMaGV.Text + "'"
                        + " select @result";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int result = Program.myReader.GetInt32(0);
                    Program.myReader.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Mã GIẢNG VIÊN đã tồn tại trong hệ thống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }

                bdsGV.EndEdit();
                this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);
                bdsGV.ResetCurrentItem();
                MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giảng viên. \n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
                return;
            }
            gcKHOA.Enabled = true;
            GIAOVIENDataGridView.Enabled = true;
            panelControl3.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maGV = "";
            if (bdsBODE.Count > 0)
            {
                MessageBox.Show("Bạn không thể xóa vì GIẢNG VIÊN này đã tạo BỘ ĐỀ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bdsGIAOVIEN_DANGKY.Count > 0)
            {
                MessageBox.Show("Bạn không thể xóa vì GIẢNG VIÊN này đã ĐĂNG KÝ THI", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa GIẢNG VIÊN này ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    maGV = Convert.ToString(((DataRowView)bdsGV[bdsGV.Position])["MAGV"]);
                    MessageBox.Show("Bạn đã xóa thành công giảng viên" + maGV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bdsGV.RemoveCurrent();
                    this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.GIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    bdsGV.Position = bdsGV.Find("maGV", maGV);
                    return;
                }
            }
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
