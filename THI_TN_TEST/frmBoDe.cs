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
    public partial class frmBoDe : Form
    {
        public frmBoDe()
        {
            InitializeComponent();
        }

        private void frmBoDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            DS_BODE.EnforceConstraints = false;
            this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.BODETableAdapter.Fill(this.DS_BODE.BODE);

        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBoDe.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_BODE);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nOIDUNGTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
