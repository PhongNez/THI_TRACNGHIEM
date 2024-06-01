using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace THI_TN_TEST
{
    public partial class Xrpt_In_DanhSachDK_2_Coso : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_In_DanhSachDK_2_Coso()
        {
            //InitializeComponent();
        }

        public Xrpt_In_DanhSachDK_2_Coso(DateTime tungay,DateTime denngay)
        {
            InitializeComponent();
            //Console.WriteLine("Hello" + tungay.ToString() + denngay.ToString());
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            Console.WriteLine("Program connstr: " + Program.connstr);
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tungay.ToString("yyyy-MM-dd");
            this.sqlDataSource1.Queries[0].Parameters[1].Value = denngay.ToString("yyyy-MM-dd");
            //Console.WriteLine("Hello" + tungay.ToString("yyyy-MM-dd") + denngay.ToString("yyyy-MM-dd"));
            this.sqlDataSource1.Fill();
        }

    }
}
