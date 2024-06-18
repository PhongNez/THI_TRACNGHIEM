using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THI_TN_TEST
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            ribbonPage3.Visible = false;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    Console.WriteLine("f: "+ f.GetType());
                    Console.WriteLine("ftype: "+ ftype);
                    return f;
                }
            }

                return null;
        }

       

        public void HienThiMenu(bool check)
        {

            ribbonPage2.Visible = check;
            ribbonPage3.Visible = !check;
            
        }

        public void HienThiMenuTruong(bool check)
        {
            ribbonBaocao.Visible = check;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            //frmThi f = new frmThi();
            //f.MdiParent = this;
            f.Show();
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMONHOC));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMONHOC f = new frmMONHOC();
                f.MdiParent = this;
                f.Show();
            }
        }

       
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoa f = new frmKhoa();
            f.MdiParent = this;
            f.Show();
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapSinhVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhapSinhVien f = new frmNhapSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmThi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmThi f = new frmThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInDSDK2COSO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_In_DSDK_2_Coso));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Frpt_In_DSDK_2_Coso f = new Frpt_In_DSDK_2_Coso();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGVDK));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmGVDK f = new frmGVDK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDe));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhapDe f = new frmNhapDe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTAOTAIKHOAN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formTaoTaiKhoan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                formTaoTaiKhoan f = new formTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
