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
    }
}