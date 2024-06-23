using System;
using System.Data;
using System.Windows.Forms;

namespace THI_TN_TEST
{
    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm
    {
        private int vitri = 0;
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DS.LOP);

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
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = false;
            }
            else
            {
                cmbCoso.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = true;
            }
        }

        private void mAKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsLopKhoa.AddNew();
            ((DataRowView)bdsLopKhoa[bdsLopKhoa.Position])["MaKH"] = txtMaKhoa.Text;
        }

        private void mAKHTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaKhoa.Focus();
            groupBox1.Enabled = true;
            vitri = Khoabds.Position;
            Khoabds.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã khoa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên khoa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhoa.Focus();
                return;
            }
            try
            {
                ((DataRowView)Khoabds[Khoabds.Position])["MaCS"] = ((DataRowView)Khoabds[Khoabds.Position - 1])["MaCS"].ToString();
                Khoabds.EndEdit();
                this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOATableAdapter.Update(this.DS.KHOA);
                Khoabds.ResetCurrentItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khoa. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void UpdateLop_Click(object sender, EventArgs e)
        {
            try
            {
                bdsLopKhoa.EndEdit();
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Update(this.DS.LOP);
                Khoabds.ResetCurrentItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

        }

        private void DeleteLop_Click(object sender, EventArgs e)
        {
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Bạn không thể xóa vì LỚP này đã có SINH VIÊN", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bdsLopKhoa.RemoveCurrent();
            this.LOPTableAdapter.Update(this.DS.LOP);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LOPTableAdapter.Fill(this.DS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LOPTableAdapter.Fill(this.DS.LOP); ;//Mục đích xóa các ô thừa
            Khoabds.CancelEdit();
            if (btnThem.Enabled == false)
            {
                Khoabds.Position = vitri;
            }
            gridControl1.Enabled = true;
            groupBox1.Enabled = false;
            dataGridView1.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maKhoa = "";
            if (bdsLopKhoa.Count > 0)
            {
                MessageBox.Show("Bạn không thể xóa vì KHOA này đã có LỚP", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa KHOA này ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    maKhoa = Convert.ToString(((DataRowView)Khoabds[Khoabds.Position])["MAKH"]);
                    MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Khoabds.RemoveCurrent();
                    this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KHOATableAdapter.Update(this.DS.KHOA);
                }
                catch (Exception ex)
                {
                    Khoabds.Position = Khoabds.Find("MAKH", maKhoa);
                    return;
                }
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

                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.DS.LOP);
            }
        }
    }
}