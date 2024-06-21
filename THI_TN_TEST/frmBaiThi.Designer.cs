
namespace THI_TN_TEST
{
    partial class frmBaiThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label label1;
            this.dS = new THI_TN_TEST.DS();
            this.tableAdapterManager = new THI_TN_TEST.DSTableAdapters.TableAdapterManager();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sp_LayMonDaThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_LayMonDaThiTableAdapter = new THI_TN_TEST.DSTableAdapters.sp_LayMonDaThiTableAdapter();
            this.cbxTenMh = new System.Windows.Forms.ComboBox();
            this.ds1 = new THI_TN_TEST.DS();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayMonDaThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THI_TN_TEST.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(260, 181);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(121, 32);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Xác nhận";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // sp_LayMonDaThiBindingSource
            // 
            this.sp_LayMonDaThiBindingSource.DataMember = "sp_LayMonDaThi";
            this.sp_LayMonDaThiBindingSource.DataSource = this.dS;
            // 
            // sp_LayMonDaThiTableAdapter
            // 
            this.sp_LayMonDaThiTableAdapter.ClearBeforeFill = true;
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(163, 77);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(72, 13);
            tENMHLabel.TabIndex = 5;
            tENMHLabel.Text = "Tên môn học:";
            // 
            // cbxTenMh
            // 
            this.cbxTenMh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_LayMonDaThiBindingSource, "TENMH", true));
            this.cbxTenMh.DataSource = this.sp_LayMonDaThiBindingSource;
            this.cbxTenMh.DisplayMember = "TENMH";
            this.cbxTenMh.FormattingEnabled = true;
            this.cbxTenMh.Location = new System.Drawing.Point(260, 69);
            this.cbxTenMh.Name = "cbxTenMh";
            this.cbxTenMh.Size = new System.Drawing.Size(158, 21);
            this.cbxTenMh.TabIndex = 6;
            this.cbxTenMh.ValueMember = "MAMH";
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(260, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(163, 133);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(28, 13);
            label1.TabIndex = 8;
            label1.Text = "Lần:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chọn thông tin";
            // 
            // frmBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.cbxTenMh);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmBaiThi";
            this.Text = "frmBaiThi";
            this.Load += new System.EventHandler(this.frmBaiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayMonDaThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource sp_LayMonDaThiBindingSource;
        private DSTableAdapters.sp_LayMonDaThiTableAdapter sp_LayMonDaThiTableAdapter;
        private System.Windows.Forms.ComboBox cbxTenMh;
        private DS ds1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}