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
    public partial class frmThi : DevExpress.XtraEditors.XtraForm
    {
        public frmThi()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            comboBox2.Items.Add('A');
            comboBox2.Items.Add('B');
            comboBox2.Items.Add('C');
            comboBox2.SelectedIndex = 0;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}