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
    public partial class formTaoTaiKhoan : Form
    {
        public formTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void formTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.HOTEN_GV' table. You can move, or remove it, as needed.
            this.hOTEN_GVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOTEN_GVTableAdapter.Fill(this.dS.HOTEN_GV);
            cmbNHOMQUYEN.Items.Clear();
            
            if (Program.mGroup == "TRUONG")
            {
                cmbNHOMQUYEN.Items.Add("TRUONG");
            }
            if (Program.mGroup == "COSO")
            {
                cmbNHOMQUYEN.Items.Add("COSO");
                cmbNHOMQUYEN.Items.Add("GIAOVIEN");
            }
            cmbHOTEN.SelectedIndex = -1;
            cmbNHOMQUYEN.SelectedIndex = -1;
        }

        private void txtMAGV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbHOTEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHOTEN.SelectedIndex == -1)
            {
                return;
            }
            txtMAGV.Text = cmbHOTEN.SelectedValue.ToString();
            string strLenh = "EXEC sp_lay_loginname_tu_user '" + txtMAGV.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();

            if (Program.myReader.IsDBNull(0))//Kiểm tra cột đầu tiên có null
            {
                txtTAIKHOAN.Text = "";
                btnTao.Enabled = true;btnXOA.Enabled = false;
                txtTAIKHOAN.Enabled = txtMATKHAU.Enabled = cmbNHOMQUYEN.Enabled = true;
                Program.myReader.Close();
                return;
            }
            //Do không null nên lấy
            string result = Program.myReader.GetString(0);//Lấy cột đầu dòng hiện tại

            if (Program.myReader.IsDBNull(1))//Kiểm tra cột thứ 2 có null
            {
                btnTao.Enabled = true;btnXOA.Enabled = false;
                Program.myReader.Close();
                return;
            }
            //Do không null nên lấy
            string result2 = Program.myReader.GetString(1);//Lấy cột thứ 2

            Program.myReader.Close();

            txtTAIKHOAN.Text = result;
            cmbNHOMQUYEN.Text = result2;
            txtTAIKHOAN.Enabled = txtMATKHAU.Enabled = cmbNHOMQUYEN.Enabled = false;
            MessageBox.Show("Mã GV đã có tài khoản đăng nhập. Vui lòng chọn giáo viên khác", "", MessageBoxButtons.OK);
            btnTao.Enabled = false;
            btnXOA.Enabled = true;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {

            if (txtTAIKHOAN.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản chưa nhập", "Thông báo", MessageBoxButtons.OK);
                txtTAIKHOAN.Focus();
                return;
            }
            if (txtMATKHAU.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu chưa nhập", "Thông báo", MessageBoxButtons.OK);
                txtMATKHAU.Focus();
                return;
            }
            if (cmbNHOMQUYEN.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhóm quyền", "Thông báo", MessageBoxButtons.OK);
                cmbNHOMQUYEN.Focus();
                return;
            }
            if (cmbHOTEN.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tên giáo viên", "Thông báo", MessageBoxButtons.OK);
                cmbHOTEN.Focus();
                return;
            }
            try
            {
                string cmd = $"EXEC SP_TAOTAIKHOAN '{txtTAIKHOAN.Text}','{txtMATKHAU.Text}','{txtMAGV.Text}','{cmbNHOMQUYEN.Text}'";
                Program.ExecSqlNonQuery(cmd);
                MessageBox.Show("Tạo tài khoản thành công", "", MessageBoxButtons.OK);
                cmbHOTEN.SelectedIndex = -1;
                cmbNHOMQUYEN.SelectedIndex = -1;
                txtMAGV.Text = "";
                txtMATKHAU.Text = "";
                txtTAIKHOAN.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo tài khoản: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    string cmd = $"EXEC SP_XOATAIKHOAN '{txtTAIKHOAN.Text}','{txtMAGV.Text}','{cmbNHOMQUYEN.Text}'";
                    Program.ExecSqlNonQuery(cmd);
                    MessageBox.Show("Xóa tài khoản thành công", "", MessageBoxButtons.OK);
                    cmbHOTEN.SelectedIndex = -1;
                    cmbNHOMQUYEN.SelectedIndex = -1;
                    txtMAGV.Text = "";
                    txtMATKHAU.Text = "";
                    txtTAIKHOAN.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tài khoản: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}
