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
    public partial class frmNhapDe : Form
    {
        int vitri = 0;
        int checkThemSua = 0;//0 là đang thêm, 1 là đang sửa
        public frmNhapDe()
        {
            InitializeComponent();
        }

        private void sp_Lay_BODE_THEO_MAGVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_sp_lay_BODE.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_MH);

        }

     

        private void frmNhapDe_Load(object sender, EventArgs e)
        {

            string magv = Program.username.Trim();
            // TODO: This line of code loads data into the 'dS_MH.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS_MH.MONHOC);
            try
            {
                this.sp_Lay_BODE_THEO_MAGVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_Lay_BODE_THEO_MAGVTableAdapter.Fill(this.dS_MH.sp_Lay_BODE_THEO_MAGV, magv);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bds_sp_lay_BODE.Position;
            
            groupBox1.Enabled = true;
            bds_sp_lay_BODE.AddNew();
            sp_Lay_BODE_THEO_MAGVGridControl.Enabled = false;//không cho chọn lung tung

            string magv = Program.username.Trim();
            txtMAGV.Text = magv;

            //Chỉ cho ghi và phục hồi
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            checkThemSua = 0;

            cmbDAPAN.SelectedIndex = -1;
            cmbTRINHDO.SelectedIndex = -1;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbMONHOC.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn môn học", "Thông báo", MessageBoxButtons.OK);
                cmbMONHOC.Focus();
                return;
            }

            if (cmbTRINHDO.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trình độ", "Thông báo", MessageBoxButtons.OK);
                cmbTRINHDO.Focus();
                return;
            }

            if (cmbDAPAN.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đáp án", "Thông báo", MessageBoxButtons.OK);
                cmbDAPAN.Focus();
                return;
            }

            if (txtNOIDUNG.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung", "Thông báo", MessageBoxButtons.OK);
                txtNOIDUNG.Focus();
                return;
            }
            if (txtA.Text == "")
            {
                MessageBox.Show("Vui lòng nhập câu A", "Thông báo", MessageBoxButtons.OK);
                txtA.Focus();
                return;
            }

            if (txtB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập câu B", "Thông báo", MessageBoxButtons.OK);
                txtB.Focus();
                return;
            }

            if (txtC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập câu C", "Thông báo", MessageBoxButtons.OK);
                txtC.Focus();
                return;
            }

            if (txtD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập câu D", "Thông báo", MessageBoxButtons.OK);
                txtD.Focus();
                return;
            }

            try
            {
                bds_sp_lay_BODE.EndEdit();//Kết thúc hiệu chỉnh và lưu thay đổi vào dataset
                string cmd = "";
                string mamh = cmbMONHOC.SelectedValue.ToString();
                string trinhdo = cmbTRINHDO.Text;
                string dapan = cmbDAPAN.Text;

                if (checkThemSua == 0)//Thêm
                {
                   
                    cmd = $"exec sp_INSERT_BODE '{mamh}', '{trinhdo}', N'{txtNOIDUNG.Text}', N'{txtA.Text}', N'{txtB.Text}', N'{txtC.Text}', N'{txtD.Text}', '{dapan}','{txtMAGV.Text}'";
                }
                else if (checkThemSua == 1)//Sửa
                {
                    //int cauhoi = int.Parse(txtCAUHOI.Text);
                    cmd = $"exec sp_UPDATE_BODE {txtCAUHOI.Text},'{mamh}', '{trinhdo}', N'{txtNOIDUNG.Text}', N'{txtA.Text}', N'{txtB.Text}', N'{txtC.Text}', N'{txtD.Text}', '{dapan}'";
                }
                Program.ExecSqlNonQuery(cmd);
                  bds_sp_lay_BODE.ResetCurrentItem();//Cập nhật giao diện
               
                string magv = Program.username.Trim();
                this.sp_Lay_BODE_THEO_MAGVTableAdapter.Fill(this.dS_MH.sp_Lay_BODE_THEO_MAGV, magv);
                if (checkThemSua == 1)//nếu sửa trả về câu đã sửa
                { bds_sp_lay_BODE.Position = vitri; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            groupBox1.Enabled = false;
            sp_Lay_BODE_THEO_MAGVGridControl.Enabled = true;//được phép chọn row
            //Không cho ghi và phục hồi
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string magv = Program.username.Trim();
                this.sp_Lay_BODE_THEO_MAGVTableAdapter.Fill(this.dS_MH.sp_Lay_BODE_THEO_MAGV,magv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_sp_lay_BODE.CancelEdit();//Hủy bỏ quá trình hiệu chỉnh
            try
            {
                string magv = Program.username.Trim();
                this.sp_Lay_BODE_THEO_MAGVTableAdapter.Fill(this.dS_MH.sp_Lay_BODE_THEO_MAGV, magv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            if (btnThem.Enabled == false)
            {
                bds_sp_lay_BODE.Position = vitri;
            }

            sp_Lay_BODE_THEO_MAGVGridControl.Enabled = true;
            groupBox1.Enabled = false;
            //Không cho ghi và phục hồi
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bds_sp_lay_BODE.Position;
            groupBox1.Enabled = true;
            sp_Lay_BODE_THEO_MAGVGridControl.Enabled = false;
            

            //Cho ghi và phục hồi
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            checkThemSua = 1;
        }

        private void txtCAUHOI_EditValueChanged(object sender, EventArgs e)
        {
            if (txtCAUHOI.Text=="")
            {
                return;
            }
            int cauhoi = int.Parse(txtCAUHOI.Text);
            if(cauhoi < 0)
            {
                txtCAUHOI.Text = null;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCAUHOI.Text == "")
            {
                MessageBox.Show("Không có câu hỏi nào để xóa", "Thông báo", MessageBoxButtons.OK);
                txtCAUHOI.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa câu hỏi này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show("Xóa câu hỏi thành công", "", MessageBoxButtons.OK);
                    int cauhoi = int.Parse(txtCAUHOI.Text);

                    bds_sp_lay_BODE.RemoveCurrent();
                    string cmd = "EXEC sp_DELETE_BODE "+ cauhoi;
                    Program.ExecSqlNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    string magv = Program.username.Trim();
                    this.sp_Lay_BODE_THEO_MAGVTableAdapter.Fill(this.dS_MH.sp_Lay_BODE_THEO_MAGV, magv);
                    return;
                }


            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

     
    }
}
