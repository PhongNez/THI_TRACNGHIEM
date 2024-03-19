using DevExpress.XtraEditors;
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
    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm
    {
        private int vitri = 0;
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            tN_CSDLPTDataSet.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.tN_CSDLPTDataSet.KHOA);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDataSet.LOP);


        }

        private void mAKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKLOPKHOABindingSource.AddNew();
            ((DataRowView)fKLOPKHOABindingSource[fKLOPKHOABindingSource.Position])["MaKH"] = txtMaKhoa.Text;
        }

        private void mAKHTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaKhoa.Focus();
            btnHieuChinh.Enabled = false;
            vitri = Khoabds.Position;
            Khoabds.AddNew();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã khoa.", "Thông báo");
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên khoa.", "Thông báo");
                txtTenKhoa.Focus();
                return;
            }
            try
            {
                ((DataRowView)Khoabds[Khoabds.Position])["MaCS"] = ((DataRowView)Khoabds[Khoabds.Position-1])["MaCS"].ToString();
                Khoabds.EndEdit();
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Update(this.tN_CSDLPTDataSet.KHOA);
                Khoabds.ResetCurrentItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khoa. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
           
        }

        private void UpdateLop_Click(object sender, EventArgs e)
        {
            try
            {
                fKLOPKHOABindingSource.EndEdit();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.tN_CSDLPTDataSet.LOP);
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
            fKLOPKHOABindingSource.RemoveCurrent();
            this.lOPTableAdapter.Update(this.tN_CSDLPTDataSet.LOP);
        }
    }
}