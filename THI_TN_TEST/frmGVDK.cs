using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;//Sử dụng Regex =>Bắt kí tự nhập

namespace THI_TN_TEST
{
    public partial class frmGVDK : Form
    {
        int vitri = 0;
        int checkThemSua = 0;//0 là đang thêm, 1 là đang sửa
        public frmGVDK()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmGVDK_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.LIST_MON' table. You can move, or remove it, as needed.
            this.lIST_MONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lIST_MONTableAdapter.Fill(this.DS.LIST_MON);
            // TODO: This line of code loads data into the 'DS.LIST_LOP' table. You can move, or remove it, as needed.

            this.lIST_LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lIST_LOPTableAdapter.Fill(this.DS.LIST_LOP);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            cmbCoso.DataSource = Program.bds_dspm;//Sao chép bds_dspm đã load ở form đăng nhập
            cmbCoso.DisplayMember = "TENCN";
            cmbCoso.ValueMember = "TENSERVER";
            cmbCoso.SelectedIndex = Program.mCoso;
            //Phân quyền
            //Nếu mà quyền TRUONG chỉ mới cho xài combobox
            if (Program.mGroup == "TRUONG")
            {
                cmbCoso.Enabled = true;
                //Cập nhật from sinh viên
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled = false;

            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGVDK.Position;
            groupBox1.Enabled = true;
            bdsGVDK.AddNew();
            gIAOVIEN_DANGKYGridControl.Enabled = false;//không cho chọn lung tung

            //Chỉ cho ghi và phục hồi
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled= true;

            cmbLAN.SelectedIndex = -1;
            cmbTRINHDO.SelectedIndex = -1;
            checkThemSua = 0;
            txtMAGV.Text = Program.username;//Gán mã gv khỏi cần nhập

            cmbMONHOC.Enabled = cmbLop.Enabled = cmbLAN.Enabled = true;//Cho thêm
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAGV.Text.Trim()=="")
            {
                MessageBox.Show("Tên giáo viên chưa có", "Thông báo", MessageBoxButtons.OK);
                txtMAGV.Focus();
                return;
            }
            if (cmbLop.SelectedIndex == -1)//Không có chọn mục nào
            {
                MessageBox.Show("Vui lòng chọn lớp", "Thông báo", MessageBoxButtons.OK);
                cmbLop.Focus();
                return;
            }
            //if(string.IsNullOrEmpty(cmbLAN.Text))//Kiểm tra chuỗi null hoặc rỗng
            if (cmbLAN.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lần", "Thông báo", MessageBoxButtons.OK);
                cmbLAN.Focus();
                return;
            }
            if (cmbMONHOC.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn môn học", "Thông báo", MessageBoxButtons.OK);
                cmbMONHOC.Focus();
                return;
            }
            //if (string.IsNullOrEmpty(cmbTRINHDO.Text))
            if (cmbTRINHDO.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trình độ", "Thông báo", MessageBoxButtons.OK);
                cmbTRINHDO.Focus();
                return;
            }
            if (txtSOCAUTHI.Text.Trim() == "")
            {
                MessageBox.Show("Số câu thi chưa nhập", "Thông báo", MessageBoxButtons.OK);
                txtSOCAUTHI.Focus();
                return;
            }
            if (Regex.IsMatch(txtSOCAUTHI.Text.Trim(), "^[0-9]+$") == false)//Khác các ký tự trong đoạn => false
            {
                MessageBox.Show("Số câu thi chỉ được nhập số", "Thông báo", MessageBoxButtons.OK);
                txtSOCAUTHI.Focus();
                return;
            }
            int socauthi = int.Parse(txtSOCAUTHI.Text.Trim());
            if ( socauthi < 10 || socauthi > 100)
            {
                MessageBox.Show("Số câu thi không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                txtSOCAUTHI.Focus();
                return;
            }
            if (txtTHOIGIAN.Text.Trim() == "")
            {
                MessageBox.Show("Thời gian thi chưa nhập", "Thông báo", MessageBoxButtons.OK);
                txtTHOIGIAN.Focus();
                return;
            }
            if (Regex.IsMatch(txtTHOIGIAN.Text.Trim(),"^[0-9]+$") == false)
            {
                MessageBox.Show("Thời gian thi chỉ được nhập số", "Thông báo", MessageBoxButtons.OK);
                txtTHOIGIAN.Focus();
                return;
            }
            int thoigian = int.Parse(txtTHOIGIAN.Text.Trim());
            if (thoigian < 2 || thoigian > 60)
            {
                MessageBox.Show("Thời gian thi không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                txtTHOIGIAN.Focus();
                return;
            }
            if (dateEditNgayThi.DateTime.Equals(DateTime.MinValue))
            {
                MessageBox.Show("Ngày thi chưa chọn", "Thông báo", MessageBoxButtons.OK);
                dateEditNgayThi.Focus();
                return;
            }

            try
            {
                if (checkThemSua == 0)//Thêm mới kiểm tra
                {
                    if(dateEditNgayThi.DateTime< DateTime.Today)
                    {
                        MessageBox.Show("Không thể đăng ký thi cho ngày trong quá khứ");
                        dateEditNgayThi.Focus();
                        return;
                    }
                    //Kiểm tra khóa chính giaovien_dangky
                    int lan = int.Parse(cmbLAN.Text);
                    string strLenh = "declare @result int "
                        + "EXEC @result = sp_KiemTra_KhoaChinh_GVDK '" + cmbMONHOC.SelectedValue.ToString() + "','"
                        + cmbLop.SelectedValue.ToString() + "'," + lan
                        + " select @result";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);//Thực thi lệnh và trả về 1 obj sqldatareader
                    Program.myReader.Read();
                    int result = Program.myReader.GetInt32(0);//Lấy cột đầu dòng hiện tại
                    Program.myReader.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Đã có giảng viên đăng ký lớp, môn, lần hoặc chưa đăng ký lần 1", "", MessageBoxButtons.OK);
                        return;
                    }
                    string strLenh2 = "declare @result int "
                      + "EXEC @result = SP_KiemTraSoLuongCau '" + cmbMONHOC.SelectedValue.ToString() + "','"
                      + cmbTRINHDO.Text + "'," + txtSOCAUTHI.Text
                      + " select @result";
                    Program.myReader = Program.ExecSqlDataReader(strLenh2);//Thực thi lệnh và trả về 1 obj sqldatareader
                    Program.myReader.Read();
                    int result2 = Program.myReader.GetInt32(0);//Lấy cột đầu dòng hiện tại
                    Program.myReader.Close();
                    if (result2 == 0)
                    {
                        MessageBox.Show("Môn Học chưa có câu hỏi nên không thể đăng ký thi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
               
                bdsGVDK.EndEdit();//Kết thúc hiệu chỉnh và lưu thay đổi vào dataset
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Update(this.DS.GIAOVIEN_DANGKY);
                bdsGVDK.ResetCurrentItem();//Cập nhật giao diện

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            groupBox1.Enabled = false;
            gIAOVIEN_DANGKYGridControl.Enabled = true;//được phép chọn row
            //Không cho ghi và phục hồi
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGVDK.CancelEdit();//Hủy bỏ quá trình hiệu chỉnh
            try
            {
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            if (btnThem.Enabled == false)
            {
                bdsGVDK.Position = vitri;
            }

            gIAOVIEN_DANGKYGridControl.Enabled = true;
            groupBox1.Enabled = false;
            //Không cho ghi và phục hồi
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;

            cmbMONHOC.Enabled = cmbLop.Enabled = cmbLAN.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGVDK.Position;
            groupBox1.Enabled = true;
            gIAOVIEN_DANGKYGridControl.Enabled = false;
            //Không cho sửa khóa chính
            cmbMONHOC.Enabled = cmbLop.Enabled = cmbLAN.Enabled = false;

            //Cho ghi và phục hồi
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            checkThemSua = 1;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Kiểm tra sinh viên đã thi chưa
                //Thi rồi không cho xóa
                int lan = int.Parse(cmbLAN.Text);
                string strLenh = "declare @result int "
                    + "EXEC @result = sp_KiemTra_TRUOC_XOA_GVDK '" + cmbLop.SelectedValue.ToString() + "','"
                    + cmbMONHOC.SelectedValue.ToString() + "'," + lan
                    + " select @result";
                Program.myReader = Program.ExecSqlDataReader(strLenh);//Thực thi lệnh và trả về 1 obj sqldatareader
                Program.myReader.Read();
                int result = Program.myReader.GetInt32(0);//Lấy cột đầu dòng hiện tại
                Program.myReader.Close();
                if (result == 1)
                {
                    MessageBox.Show("Không thể xóa vì đã có sinh viên thi", "", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa lịch đăng ký thi?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show("Xóa lịch đăng ký thi thành công", "", MessageBoxButtons.OK);
                    bdsGVDK.RemoveCurrent();
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Update(this.DS.GIAOVIEN_DANGKY);
                }
                catch (Exception ex)
                {
                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
                    return;
                }
               
            
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoso.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;//SelectedValue chưa có giá trị => nếu tiếp tục chạy đoạn code bên dưới sẽ lỗi
            }
            Program.servername = cmbCoso.SelectedValue.ToString();//Gán server
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
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            }
        }

        private void gIAOVIEN_DANGKYGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
