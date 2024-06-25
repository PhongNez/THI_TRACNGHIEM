
namespace THI_TN_TEST
{
    partial class FrptBangDiemMonHoc
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label mAMHLabel;
            this.cmbCoso = new System.Windows.Forms.ComboBox();
            this.lbCoSo = new System.Windows.Forms.Label();
            this.DS = new THI_TN_TEST.DS();
            this.tableAdapterManager = new THI_TN_TEST.DSTableAdapters.TableAdapterManager();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTableAdapter = new THI_TN_TEST.DSTableAdapters.LOPTableAdapter();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.bdsBangDiem = new System.Windows.Forms.BindingSource(this.components);
            this.BANGDIEMTableAdapter = new THI_TN_TEST.DSTableAdapters.BANGDIEMTableAdapter();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOCTableAdapter = new THI_TN_TEST.DSTableAdapters.MONHOCTableAdapter();
            this.cmbLanThi = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            mALOPLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(70, 142);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(40, 17);
            mALOPLabel.TabIndex = 101;
            mALOPLabel.Text = "Lớp :";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(816, 141);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(64, 17);
            lANLabel.TabIndex = 103;
            lANLabel.Text = "Lần Thi :";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(437, 142);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(72, 17);
            mAMHLabel.TabIndex = 105;
            mAMHLabel.Text = "Môn Học :";
            // 
            // cmbCoso
            // 
            this.cmbCoso.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCoso.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbCoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoso.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbCoso.FormattingEnabled = true;
            this.cmbCoso.Location = new System.Drawing.Point(440, 26);
            this.cmbCoso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCoso.Name = "cmbCoso";
            this.cmbCoso.Size = new System.Drawing.Size(384, 30);
            this.cmbCoso.TabIndex = 101;
            this.cmbCoso.SelectedIndexChanged += new System.EventHandler(this.cmbCoso_SelectedIndexChanged);
            // 
            // lbCoSo
            // 
            this.lbCoSo.AutoSize = true;
            this.lbCoSo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoSo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCoSo.Location = new System.Drawing.Point(365, 29);
            this.lbCoSo.Name = "lbCoSo";
            this.lbCoSo.Size = new System.Drawing.Size(69, 22);
            this.lbCoSo.TabIndex = 100;
            this.lbCoSo.Text = "Cơ sở :";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THI_TN_TEST.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MALOP", true));
            this.cmbMaLop.DataSource = this.bdsLop;
            this.cmbMaLop.DisplayMember = "TENLOP";
            this.cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(136, 139);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(188, 24);
            this.cmbMaLop.TabIndex = 102;
            this.cmbMaLop.ValueMember = "MALOP";
            // 
            // bdsBangDiem
            // 
            this.bdsBangDiem.DataMember = "BANGDIEM";
            this.bdsBangDiem.DataSource = this.DS;
            // 
            // BANGDIEMTableAdapter
            // 
            this.BANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.DS;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // cmbLanThi
            // 
            this.cmbLanThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBangDiem, "LAN", true));
            this.cmbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanThi.FormattingEnabled = true;
            this.cmbLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbLanThi.Location = new System.Drawing.Point(886, 135);
            this.cmbLanThi.Name = "cmbLanThi";
            this.cmbLanThi.Size = new System.Drawing.Size(121, 24);
            this.cmbLanThi.TabIndex = 104;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(519, 217);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(114, 44);
            this.btnPreview.TabIndex = 105;
            this.btnPreview.Text = "Xem";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMonHoc, "MAMH", true));
            this.cmbMaMH.DataSource = this.bdsMonHoc;
            this.cmbMaMH.DisplayMember = "TENMH";
            this.cmbMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(515, 139);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(224, 24);
            this.cmbMaMH.TabIndex = 106;
            this.cmbMaMH.ValueMember = "MAMH";
            // 
            // FrptBangDiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 393);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.cmbMaMH);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(lANLabel);
            this.Controls.Add(this.cmbLanThi);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.cmbMaLop);
            this.Controls.Add(this.cmbCoso);
            this.Controls.Add(this.lbCoSo);
            this.Name = "FrptBangDiemMonHoc";
            this.Text = "Bảng Điểm Môn Học";
            this.Load += new System.EventHandler(this.FrptBangDiemMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCoso;
        private System.Windows.Forms.Label lbCoSo;
        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.BindingSource bdsBangDiem;
        private DSTableAdapters.BANGDIEMTableAdapter BANGDIEMTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DSTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.ComboBox cmbLanThi;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbMaMH;
    }
}