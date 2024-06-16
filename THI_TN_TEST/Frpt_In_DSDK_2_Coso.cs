using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace THI_TN_TEST
{
    public partial class Frpt_In_DSDK_2_Coso : Form
    {
        public Frpt_In_DSDK_2_Coso()
        {
            InitializeComponent();
        }

        private void Frpt_In_DSDK_2_Coso_Load(object sender, EventArgs e)
        {
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("dateedit: "+ dateEditTuNgay.DateTime.ToString() +" den ngay:  "+ dateEditDenNgay.DateTime.ToString("yyyy-MM-dd") + "Min value: "+DateTime.MinValue.ToString());
            Xrpt_In_DanhSachDK_2_Coso rpt = new Xrpt_In_DanhSachDK_2_Coso(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
            rpt.lblTuNgay.Text = dateEditTuNgay.DateTime.ToString("dd/MM/yyyy");
            rpt.lblDenNgay.Text = dateEditDenNgay.DateTime.ToString("dd/MM/yyyy");
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
