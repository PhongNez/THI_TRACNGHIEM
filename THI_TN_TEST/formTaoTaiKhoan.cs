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
            this.hOTEN_GVTableAdapter.Fill(this.dS.HOTEN_GV);

        }
    }
}
