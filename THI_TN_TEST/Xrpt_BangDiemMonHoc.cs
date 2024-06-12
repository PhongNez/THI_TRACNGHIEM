using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace THI_TN_TEST
{
    public partial class Xrpt_BangDiemMonHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemMonHoc()
        {
            //InitializeComponent();
        }

        public Xrpt_BangDiemMonHoc(string MaLop,string MaMH,int LanThi)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            Console.WriteLine("Program connstr: " + Program.connstr);
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MaLop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = MaMH;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = LanThi;
            this.sqlDataSource1.Fill();
        }
    }
}
