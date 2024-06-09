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
    public partial class frmNhapSinhVien : Form
    {
        int vitri = 0;
        int checkThemSua = 0;//0 là đang thêm, 1 là đang sửa
        public frmNhapSinhVien()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhapSinhVien_Load(object sender, EventArgs e)
        {
            
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            // TODO: This line of code loads data into the 'DS.BANGDIEM' table. You can move, or remove it, as needed
              this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);

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
                btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = btnUndoSV.Enabled = btnGhiSV.Enabled = false;
           
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            vitri = bdsSV.Position;
            groupBox1.Enabled = true;
            bdsSV.AddNew();
            gcLOP.Enabled = false;
            SINHVIENDataGridView.Enabled=false;

            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = btnReloadSV.Enabled = btnThoatSV.Enabled = false;
            btnUndoSV.Enabled = btnGhiSV.Enabled = true;

            txtMASV.Enabled = true;
            checkThemSua = 0;
            dateNGAYSINH.DateTime = new DateTime(2000, 01, 01);// xét ngày mặc định
        }

        private void btnUndoSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();//Hủy bỏ và khôi phục
            if (btnThemSV.Enabled == false)
            {
                bdsSV.Position = vitri;
            }
            groupBox1.Enabled = false;
            gcLOP.Enabled = true;
            SINHVIENDataGridView.Enabled = true;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = btnReloadSV.Enabled = btnThoatSV.Enabled = true;
            btnUndoSV.Enabled = btnGhiSV.Enabled = false;
        }

        private void btnReloadSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            }
           catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

        }

        private void btnXoaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string masv = "";
            if (bdsBANGDIEM.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên vì đã có bảng điểm","",MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa mã sinh viên?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
                    //MessageBox.Show("Mã sinh viên thử: " + masv, "", MessageBoxButtons.OK);
                    MessageBox.Show("Bạn đã xóa thành công sinh viên", "", MessageBoxButtons.OK);
                    bdsSV.RemoveCurrent();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                }
                catch(Exception ex)
                {
                    this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                    bdsSV.Position = bdsSV.Find("MASV", masv);
                    return;
                }
            }
        }

        private void btnGhiSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMASV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên chưa nhập", "Thông báo", MessageBoxButtons.OK);
                txtMASV.Focus();
                return;
            }
            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ sinh viên chưa nhập", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return;
            }
            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên sinh viên chưa nhập", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }
            if (txtDIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ sinh viên chưa nhập", "Thông báo", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return;
            }
            if (txtPASSWORD.Text.Trim() == "")
            {
                MessageBox.Show("PASSWORD sinh viên chưa nhập", "Thông báo", MessageBoxButtons.OK);
                txtPASSWORD.Focus();
                return;
            }
            if (Regex.IsMatch(txtMASV.Text.Trim(), @"^[a-zA-Z0-9]+$") == false)//.Trim() để pattern nó khỏi kiểm tra khoảng cách
            {
                MessageBox.Show("Mã sinh viên chỉ cho nhập chữ và số", "Thông báo");
                txtMASV.Focus();
                return;
            }
            if (Regex.IsMatch(txtHO.Text, @"^[a-zA-Z ]+$") == false)
            {
                MessageBox.Show("Vui lòng nhập họ không dấu và chỉ nhập chữ", "Thông báo");
                txtHO.Focus();
                return;
            }
            if (Regex.IsMatch(txtTEN.Text.Trim(), @"^[a-zA-Z]+$") == false)//.Trim() để pattern nó khỏi kiểm tra khoảng cách
            {
                MessageBox.Show("Vui lòng nhập tên không dấu và chỉ nhập chữ", "Thông báo");
                txtTEN.Focus();
                return;
            }

            if (Regex.IsMatch(txtPASSWORD.Text, @"^[a-zA-Z0-9 ]+$") == false)
            {
                MessageBox.Show("Password chỉ cho nhập chữ và số", "Thông báo");
                txtPASSWORD.Focus();
                return;
            }
          
            if(dateNGAYSINH.DateTime.Equals(DateTime.MinValue))
            {
                MessageBox.Show("Ngày sinh của sinh viên chưa nhập", "Thông báo", MessageBoxButtons.OK);
                dateNGAYSINH.Focus();
                return;
            }
            int currentYear = DateTime.Now.Year;
            int birthYear= dateNGAYSINH.DateTime.Year;
            int age = currentYear - birthYear;
            if (age <18)
            {
                MessageBox.Show("Tuổi của bạn nhỏ hơn 18", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            txtMASV.Text = txtMASV.Text.Trim();
            txtHO.Text = txtHO.Text.Trim();
            txtTEN.Text = txtTEN.Text.Trim();
            txtPASSWORD.Text = txtPASSWORD.Text.Trim();
            try
            {
                if (checkThemSua == 0)//đang thêm mới kiểm tra
                {
                    //Kiểm tra mã sinh viên có trùng trên các site
                    string strLenh = "declare @result int "
                        + " EXEC @result = sp_KiemTraMaSinhVien '" + txtMASV.Text + "'"
                        + " select @result";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int result = Program.myReader.GetInt32(0);
                    Program.myReader.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Mã sinh viên của bạn đã tồn tại", "", MessageBoxButtons.OK);
                        return;
                    }

                }

                bdsSV.EndEdit();//Kết thúc chỉnh sửa và cập nhật dữ liệu
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                bdsSV.ResetCurrentItem();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcLOP.Enabled = true;
            SINHVIENDataGridView.Enabled = true;
            groupBox1.Enabled = false;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = btnReloadSV.Enabled = btnThoatSV.Enabled = true;
            btnUndoSV.Enabled = btnGhiSV.Enabled = false;
        }

        private void btnThoatSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCoso.SelectedValue.ToString()== "System.Data.DataRowView")
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
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.DS.LOP);

                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            }
        }

        private void btnSuaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            gcLOP.Enabled = false;
            SINHVIENDataGridView.Enabled = false;
            btnSuaSV.Enabled = btnThemSV.Enabled = btnXoaSV.Enabled = btnThoatSV.Enabled = btnReloadSV.Enabled = false;
            btnUndoSV.Enabled = btnGhiSV.Enabled = true;

            txtMASV.Enabled = false;
            checkThemSua = 1;
        }
    }
}
