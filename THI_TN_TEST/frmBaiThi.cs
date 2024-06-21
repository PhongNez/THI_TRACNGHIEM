using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frmBaiThi : DevExpress.XtraEditors.XtraForm
    {
        public frmBaiThi()
        {
            InitializeComponent();
        }

        private void frmBaiThi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.sp_LayMonDaThiTableAdapter.Connection.ConnectionString = Program.connstr;        
            this.sp_LayMonDaThiTableAdapter.Fill(this.dS.sp_LayMonDaThi, Program.mlogin);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int dathi = 0;
            String strLenh = "EXEC SP_KTLANTHI '" + Program.mlogin + "','" + cbxTenMh.SelectedValue + "'," + comboBox1.Text;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return;
            }
            Program.myReader.Read();
            dathi = Program.myReader.GetInt32(0);
            Program.myReader.Close();
            if (dathi == 1)
            {
                XtraReport2 rpt = new XtraReport2(Program.mlogin, Int32.Parse(comboBox1.Text), cbxTenMh.SelectedValue.ToString());
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            else MessageBox.Show("Bạn chưa thi lần này, hãy chọn lại!", "", MessageBoxButtons.OK);

        }

       
    }
}