using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace THI_TN_TEST
{
    public partial class CauHoi : DevExpress.XtraEditors.XtraUserControl
    {
        private int idBaiThi;
        private int idCauHoi;
        private int cauSo;
        private string ndCauHoi;
        private string cauA;
        private string cauB;
        private string cauC;
        private string cauD;
        private string daChon = "";
        private string dapAn = "";
        public CauHoi()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        [Category("Custom Props")]
        public int IDBaiThi
        {
            get { return idBaiThi; }
            set { idBaiThi = value; }
        }

        [Category("Custom Props")]
        public int IDCauHoi
        {
            get { return idCauHoi; }
            set { idCauHoi = value; }
        }

        [Category("Custom Props")]
        public int CauSo
        {
            get { return cauSo; }
            set
            {
                cauSo = value;
                lbCauSo.Text = "Câu " + cauSo + ": ";
            }
        }
        //câu hỏi
        [Category("Custom Props")]
        public string NDCauHoi
        {
            get { return ndCauHoi; }
            set
            {
                ndCauHoi = value;
                txtNoiDung.Text = ndCauHoi;
                //"Nếu tài khoản của bạn không có quyền truy cập database 'TN_CSDLPT', hãy yêu cầu quản trị viên database cấp quyền truy cập bằng cách sử dụng câu lệnh SQL sau:";
            }
        }

        //câu A
        [Category("Custom Props")]
        public string CauA
        {
            get { return cauA; }
            set
            {
                cauA = value;
                rbA.Text = cauA;
            }
        }
        //câu B
        [Category("Custom Props")]
        public string CauB
        {
            get { return cauB; }
            set
            {
                cauB = value;
                rbB.Text = cauB;
            }
        }
        //câu C
        [Category("Custom Props")]
        public string CauC
        {
            get { return cauC; }
            set
            {
                cauC = value;
                rbC.Text = cauC;
            }
        }
        //câu D
        [Category("Custom Props")]
        public string CauD
        {
            get { return cauD; }
            set
            {
                cauD = value;
                rbD.Text = cauD;
            }
        }

        //câu đã chọn
        [Category("Custom Props")]
        public string CauDaChon
        {
            get { return daChon; }
            set { daChon = value; }
        }

        //câu đáp án
        [Category("Custom Props")]
        public string CauDapAn
        {
            get { return dapAn; }
            set { dapAn = value; }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void rbA_CheckedChanged_1(object sender, EventArgs e)
        {
            daChon = "A";
            var principalForm = Application.OpenForms.OfType<frmThi>().Single();
            principalForm.capNhapDaChon(cauSo, "A");
        }

        private void rbB_CheckedChanged_1(object sender, EventArgs e)
        {
            daChon = "B";
            var principalForm = Application.OpenForms.OfType<frmThi>().Single();
            principalForm.capNhapDaChon(cauSo, "B");
        }

        private void rbC_CheckedChanged_1(object sender, EventArgs e)
        {
            daChon = "C";
            var principalForm = Application.OpenForms.OfType<frmThi>().Single();
            principalForm.capNhapDaChon(cauSo, "C");
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "D";
            var principalForm = Application.OpenForms.OfType<frmThi>().Single();
            principalForm.capNhapDaChon(cauSo, "D");
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
