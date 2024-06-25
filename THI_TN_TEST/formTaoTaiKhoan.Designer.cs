
namespace THI_TN_TEST
{
    partial class formTaoTaiKhoan
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
            this.hOTENLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dS = new THI_TN_TEST.DS();
            this.bds_HOTEN_GV = new System.Windows.Forms.BindingSource(this.components);
            this.hOTEN_GVTableAdapter = new THI_TN_TEST.DSTableAdapters.HOTEN_GVTableAdapter();
            this.tableAdapterManager = new THI_TN_TEST.DSTableAdapters.TableAdapterManager();
            this.cmbHOTEN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTAIKHOAN = new DevExpress.XtraEditors.TextEdit();
            this.txtMATKHAU = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNHOMQUYEN = new System.Windows.Forms.ComboBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXOA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_HOTEN_GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTAIKHOAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMATKHAU.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            this.hOTENLabel.AutoSize = true;
            this.hOTENLabel.Location = new System.Drawing.Point(150, 225);
            this.hOTENLabel.Name = "hOTENLabel";
            this.hOTENLabel.Size = new System.Drawing.Size(87, 22);
            this.hOTENLabel.TabIndex = 1;
            this.hOTENLabel.Text = "HỌ TÊN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "NHÓM QUYỀN:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_HOTEN_GV
            // 
            this.bds_HOTEN_GV.DataMember = "HOTEN_GV";
            this.bds_HOTEN_GV.DataSource = this.dS;
            // 
            // hOTEN_GVTableAdapter
            // 
            this.hOTEN_GVTableAdapter.ClearBeforeFill = true;
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
            // cmbHOTEN
            // 
            this.cmbHOTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_HOTEN_GV, "HOTEN", true));
            this.cmbHOTEN.DataSource = this.bds_HOTEN_GV;
            this.cmbHOTEN.DisplayMember = "HOTEN";
            this.cmbHOTEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHOTEN.FormattingEnabled = true;
            this.cmbHOTEN.Location = new System.Drawing.Point(319, 217);
            this.cmbHOTEN.Name = "cmbHOTEN";
            this.cmbHOTEN.Size = new System.Drawing.Size(368, 30);
            this.cmbHOTEN.TabIndex = 2;
            this.cmbHOTEN.ValueMember = "MAGV";
            this.cmbHOTEN.SelectedIndexChanged += new System.EventHandler(this.cmbHOTEN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "MÃ GV:";
            // 
            // txtMAGV
            // 
            this.txtMAGV.Enabled = false;
            this.txtMAGV.Location = new System.Drawing.Point(859, 219);
            this.txtMAGV.Margin = new System.Windows.Forms.Padding(5);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAGV.Properties.Appearance.Options.UseFont = true;
            this.txtMAGV.Size = new System.Drawing.Size(156, 28);
            this.txtMAGV.TabIndex = 4;
            this.txtMAGV.EditValueChanged += new System.EventHandler(this.txtMAGV_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "TÀI KHOẢN:";
            // 
            // txtTAIKHOAN
            // 
            this.txtTAIKHOAN.Location = new System.Drawing.Point(319, 283);
            this.txtTAIKHOAN.Margin = new System.Windows.Forms.Padding(6);
            this.txtTAIKHOAN.Name = "txtTAIKHOAN";
            this.txtTAIKHOAN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTAIKHOAN.Properties.Appearance.Options.UseFont = true;
            this.txtTAIKHOAN.Size = new System.Drawing.Size(368, 28);
            this.txtTAIKHOAN.TabIndex = 6;
            // 
            // txtMATKHAU
            // 
            this.txtMATKHAU.Location = new System.Drawing.Point(319, 342);
            this.txtMATKHAU.Margin = new System.Windows.Forms.Padding(8);
            this.txtMATKHAU.Name = "txtMATKHAU";
            this.txtMATKHAU.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMATKHAU.Properties.Appearance.Options.UseFont = true;
            this.txtMATKHAU.Size = new System.Drawing.Size(368, 28);
            this.txtMATKHAU.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "MẬT KHẨU:";
            // 
            // cmbNHOMQUYEN
            // 
            this.cmbNHOMQUYEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNHOMQUYEN.FormattingEnabled = true;
            this.cmbNHOMQUYEN.Location = new System.Drawing.Point(319, 411);
            this.cmbNHOMQUYEN.Name = "cmbNHOMQUYEN";
            this.cmbNHOMQUYEN.Size = new System.Drawing.Size(368, 30);
            this.cmbNHOMQUYEN.TabIndex = 10;
            // 
            // btnTao
            // 
            this.btnTao.Enabled = false;
            this.btnTao.Location = new System.Drawing.Point(141, 535);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(209, 72);
            this.btnTao.TabIndex = 12;
            this.btnTao.Text = "TẠO TÀI KHOẢN";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(642, 535);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(209, 72);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(699, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "TẠO TÀI KHOẢN ĐĂNG NHẬP CHƯƠNG TRÌNH";
            // 
            // btnXOA
            // 
            this.btnXOA.Enabled = false;
            this.btnXOA.Location = new System.Drawing.Point(392, 535);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(209, 72);
            this.btnXOA.TabIndex = 15;
            this.btnXOA.Text = "XÓA TÀI KHOẢN";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // formTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 723);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbNHOMQUYEN);
            this.Controls.Add(this.txtMATKHAU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTAIKHOAN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMAGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hOTENLabel);
            this.Controls.Add(this.cmbHOTEN);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTaoTaiKhoan";
            this.Text = "Tạo Tài Khoản";
            this.Load += new System.EventHandler(this.formTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_HOTEN_GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTAIKHOAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMATKHAU.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource bds_HOTEN_GV;
        private DSTableAdapters.HOTEN_GVTableAdapter hOTEN_GVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbHOTEN;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMAGV;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTAIKHOAN;
        private DevExpress.XtraEditors.TextEdit txtMATKHAU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNHOMQUYEN;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Label hOTENLabel;
        private System.Windows.Forms.Label label4;
    }
}