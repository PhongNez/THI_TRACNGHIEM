
namespace THI_TN_TEST
{
    partial class frmThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThi));
            this.dTNgayThi = new System.Windows.Forms.DateTimePicker();
            this.gbSinhVien = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.txtEditHoTen = new DevExpress.XtraEditors.TextEdit();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.cbxTenLop = new System.Windows.Forms.ComboBox();
            this.lIST_LOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new THI_TN_TEST.DS();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.gbBaiThi = new System.Windows.Forms.GroupBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.lbLan = new System.Windows.Forms.Label();
            this.cbBoxLan = new System.Windows.Forms.ComboBox();
            this.lbTenMH = new System.Windows.Forms.Label();
            this.cbBoxTenMH = new System.Windows.Forms.ComboBox();
            this.edtSoCau = new DevExpress.XtraEditors.SpinEdit();
            this.edtTrinhDo = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThoiGian = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCauHoi = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CauHoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DapAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lIST_LOPTableAdapter = new THI_TN_TEST.DSTableAdapters.LIST_LOPTableAdapter();
            this.tableAdapterManager = new THI_TN_TEST.DSTableAdapters.TableAdapterManager();
            this.gbSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIST_LOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            this.gbBaiThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtSoCau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTrinhDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTNgayThi
            // 
            this.dTNgayThi.CalendarFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.dTNgayThi.Enabled = false;
            this.dTNgayThi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.dTNgayThi.Location = new System.Drawing.Point(100, 95);
            this.dTNgayThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dTNgayThi.MinDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dTNgayThi.Name = "dTNgayThi";
            this.dTNgayThi.Size = new System.Drawing.Size(269, 27);
            this.dTNgayThi.TabIndex = 9;
            // 
            // gbSinhVien
            // 
            this.gbSinhVien.BackColor = System.Drawing.Color.White;
            this.gbSinhVien.Controls.Add(this.label1);
            this.gbSinhVien.Controls.Add(this.txtMaLop);
            this.gbSinhVien.Controls.Add(this.lbMaSV);
            this.gbSinhVien.Controls.Add(this.txtEditHoTen);
            this.gbSinhVien.Controls.Add(this.lbHoTen);
            this.gbSinhVien.Controls.Add(this.cbxTenLop);
            this.gbSinhVien.Controls.Add(this.txtTenLop);
            this.gbSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSinhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbSinhVien.Location = new System.Drawing.Point(0, 0);
            this.gbSinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSinhVien.Name = "gbSinhVien";
            this.gbSinhVien.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSinhVien.Size = new System.Drawing.Size(484, 187);
            this.gbSinhVien.TabIndex = 11;
            this.gbSinhVien.TabStop = false;
            this.gbSinhVien.Text = "Thông tin sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(14, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên lớp:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(155, 41);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Size = new System.Drawing.Size(261, 28);
            this.txtMaLop.TabIndex = 7;
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSV.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbMaSV.Location = new System.Drawing.Point(14, 49);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(79, 22);
            this.lbMaSV.TabIndex = 6;
            this.lbMaSV.Text = "Mã lớp :";
            this.lbMaSV.Click += new System.EventHandler(this.lbMaSV_Click);
            // 
            // txtEditHoTen
            // 
            this.txtEditHoTen.Enabled = false;
            this.txtEditHoTen.Location = new System.Drawing.Point(155, 145);
            this.txtEditHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEditHoTen.Name = "txtEditHoTen";
            this.txtEditHoTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtEditHoTen.Size = new System.Drawing.Size(261, 28);
            this.txtEditHoTen.TabIndex = 2;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbHoTen.Location = new System.Drawing.Point(14, 154);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(145, 22);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ tên sinh viên:";
            // 
            // cbxTenLop
            // 
            this.cbxTenLop.DataSource = this.lIST_LOPBindingSource;
            this.cbxTenLop.DisplayMember = "TENLOP";
            this.cbxTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenLop.FormattingEnabled = true;
            this.cbxTenLop.Location = new System.Drawing.Point(155, 96);
            this.cbxTenLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTenLop.Name = "cbxTenLop";
            this.cbxTenLop.Size = new System.Drawing.Size(261, 31);
            this.cbxTenLop.TabIndex = 11;
            this.cbxTenLop.ValueMember = "MALOP";
            this.cbxTenLop.SelectedIndexChanged += new System.EventHandler(this.cbxTenLop_SelectedIndexChanged);
            // 
            // lIST_LOPBindingSource
            // 
            this.lIST_LOPBindingSource.DataMember = "LIST_LOP";
            this.lIST_LOPBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(155, 97);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Properties.Appearance.Options.UseFont = true;
            this.txtTenLop.Size = new System.Drawing.Size(261, 28);
            this.txtTenLop.TabIndex = 11;
            // 
            // gbBaiThi
            // 
            this.gbBaiThi.AutoSize = true;
            this.gbBaiThi.BackColor = System.Drawing.Color.White;
            this.gbBaiThi.Controls.Add(this.btnXacNhan);
            this.gbBaiThi.Controls.Add(this.lbTime);
            this.gbBaiThi.Controls.Add(this.btnBatDau);
            this.gbBaiThi.Controls.Add(this.btnThoat);
            this.gbBaiThi.Controls.Add(this.dTNgayThi);
            this.gbBaiThi.Controls.Add(this.btnNopBai);
            this.gbBaiThi.Controls.Add(this.lbLan);
            this.gbBaiThi.Controls.Add(this.cbBoxLan);
            this.gbBaiThi.Controls.Add(this.lbTenMH);
            this.gbBaiThi.Controls.Add(this.cbBoxTenMH);
            this.gbBaiThi.Controls.Add(this.edtSoCau);
            this.gbBaiThi.Controls.Add(this.edtTrinhDo);
            this.gbBaiThi.Controls.Add(this.label10);
            this.gbBaiThi.Controls.Add(this.txtThoiGian);
            this.gbBaiThi.Controls.Add(this.label9);
            this.gbBaiThi.Controls.Add(this.label8);
            this.gbBaiThi.Controls.Add(this.label7);
            this.gbBaiThi.Controls.Add(this.label5);
            this.gbBaiThi.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbBaiThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBaiThi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbBaiThi.Location = new System.Drawing.Point(484, 0);
            this.gbBaiThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBaiThi.Name = "gbBaiThi";
            this.gbBaiThi.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBaiThi.Size = new System.Drawing.Size(1131, 187);
            this.gbBaiThi.TabIndex = 12;
            this.gbBaiThi.TabStop = false;
            this.gbBaiThi.Text = "Thông tin bài thi";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Location = new System.Drawing.Point(205, 142);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(114, 33);
            this.btnXacNhan.TabIndex = 40;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTime.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbTime.Location = new System.Drawing.Point(734, 78);
            this.lbTime.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(147, 48);
            this.lbTime.TabIndex = 39;
            this.lbTime.Text = "00: 00";
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnBatDau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Location = new System.Drawing.Point(979, 18);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(146, 49);
            this.btnBatDau.TabIndex = 38;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(979, 122);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(146, 53);
            this.btnThoat.TabIndex = 37;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnNopBai
            // 
            this.btnNopBai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNopBai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.Location = new System.Drawing.Point(979, 66);
            this.btnNopBai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(146, 57);
            this.btnNopBai.TabIndex = 36;
            this.btnNopBai.Text = "Nộp bài";
            this.btnNopBai.UseVisualStyleBackColor = false;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // lbLan
            // 
            this.lbLan.AutoSize = true;
            this.lbLan.BackColor = System.Drawing.Color.White;
            this.lbLan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLan.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbLan.Location = new System.Drawing.Point(10, 148);
            this.lbLan.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbLan.Name = "lbLan";
            this.lbLan.Size = new System.Drawing.Size(78, 22);
            this.lbLan.TabIndex = 34;
            this.lbLan.Text = "Lần thi :";
            // 
            // cbBoxLan
            // 
            this.cbBoxLan.DisplayMember = "LAN";
            this.cbBoxLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxLan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxLan.FormattingEnabled = true;
            this.cbBoxLan.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbBoxLan.Location = new System.Drawing.Point(100, 144);
            this.cbBoxLan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBoxLan.Name = "cbBoxLan";
            this.cbBoxLan.Size = new System.Drawing.Size(81, 29);
            this.cbBoxLan.TabIndex = 33;
            this.cbBoxLan.ValueMember = "LAN";
            this.cbBoxLan.SelectedIndexChanged += new System.EventHandler(this.cbBoxLan_SelectedIndexChanged);
            // 
            // lbTenMH
            // 
            this.lbTenMH.AutoSize = true;
            this.lbTenMH.BackColor = System.Drawing.Color.White;
            this.lbTenMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMH.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTenMH.Location = new System.Drawing.Point(9, 46);
            this.lbTenMH.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbTenMH.Name = "lbTenMH";
            this.lbTenMH.Size = new System.Drawing.Size(92, 22);
            this.lbTenMH.TabIndex = 32;
            this.lbTenMH.Text = "Tên môn :";
            // 
            // cbBoxTenMH
            // 
            this.cbBoxTenMH.DisplayMember = "TENMH";
            this.cbBoxTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxTenMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxTenMH.FormattingEnabled = true;
            this.cbBoxTenMH.Location = new System.Drawing.Point(100, 41);
            this.cbBoxTenMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBoxTenMH.Name = "cbBoxTenMH";
            this.cbBoxTenMH.Size = new System.Drawing.Size(269, 29);
            this.cbBoxTenMH.TabIndex = 31;
            this.cbBoxTenMH.ValueMember = "MAMH";
            // 
            // edtSoCau
            // 
            this.edtSoCau.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edtSoCau.Enabled = false;
            this.edtSoCau.Location = new System.Drawing.Point(555, 94);
            this.edtSoCau.Margin = new System.Windows.Forms.Padding(1);
            this.edtSoCau.Name = "edtSoCau";
            this.edtSoCau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtSoCau.Properties.Appearance.Options.UseFont = true;
            this.edtSoCau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtSoCau.Size = new System.Drawing.Size(82, 28);
            this.edtSoCau.TabIndex = 30;
            // 
            // edtTrinhDo
            // 
            this.edtTrinhDo.Enabled = false;
            this.edtTrinhDo.Location = new System.Drawing.Point(555, 39);
            this.edtTrinhDo.Margin = new System.Windows.Forms.Padding(1);
            this.edtTrinhDo.Name = "edtTrinhDo";
            this.edtTrinhDo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTrinhDo.Properties.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.edtTrinhDo.Properties.Appearance.Options.UseFont = true;
            this.edtTrinhDo.Properties.Appearance.Options.UseForeColor = true;
            this.edtTrinhDo.Size = new System.Drawing.Size(82, 28);
            this.edtTrinhDo.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(584, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "phút";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.AutoSize = true;
            this.txtThoiGian.BackColor = System.Drawing.Color.White;
            this.txtThoiGian.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.ForeColor = System.Drawing.Color.Crimson;
            this.txtThoiGian.Location = new System.Drawing.Point(552, 149);
            this.txtThoiGian.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(30, 22);
            this.txtThoiGian.TabIndex = 27;
            this.txtThoiGian.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(454, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Thời gian :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(454, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Số câu :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(454, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Trình độ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(10, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày thi :";
            // 
            // panelCauHoi
            // 
            this.panelCauHoi.AutoScroll = true;
            this.panelCauHoi.AutoScrollMinSize = new System.Drawing.Size(0, 10);
            this.panelCauHoi.BackColor = System.Drawing.Color.White;
            this.panelCauHoi.CausesValidation = false;
            this.panelCauHoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCauHoi.Location = new System.Drawing.Point(0, 72);
            this.panelCauHoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCauHoi.Name = "panelCauHoi";
            this.panelCauHoi.Size = new System.Drawing.Size(1615, 558);
            this.panelCauHoi.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.gbSinhVien);
            this.groupControl1.Controls.Add(this.gbBaiThi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1615, 187);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "groupControl1";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CauHoi,
            this.DapAn});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1478, 194);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(136, 435);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CauHoi
            // 
            this.CauHoi.Text = "Câu hỏi";
            this.CauHoi.Width = 54;
            // 
            // DapAn
            // 
            this.DapAn.Text = "Đáp án";
            // 
            // lIST_LOPTableAdapter
            // 
            this.lIST_LOPTableAdapter.ClearBeforeFill = true;
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
            // frmThi
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 630);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panelCauHoi);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmThi.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThi";
            this.Text = "frmThi";
            this.Load += new System.EventHandler(this.frmThi_Load);
            this.gbSinhVien.ResumeLayout(false);
            this.gbSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIST_LOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            this.gbBaiThi.ResumeLayout(false);
            this.gbBaiThi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtSoCau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTrinhDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dTNgayThi;
        private System.Windows.Forms.GroupBox gbSinhVien;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.Label lbMaSV;
        private DevExpress.XtraEditors.TextEdit txtEditHoTen;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private System.Windows.Forms.GroupBox gbBaiThi;
        private System.Windows.Forms.Label lbLan;
        private System.Windows.Forms.ComboBox cbBoxLan;
        private System.Windows.Forms.Label lbTenMH;
        private System.Windows.Forms.ComboBox cbBoxTenMH;
        private DevExpress.XtraEditors.SpinEdit edtSoCau;
        private DevExpress.XtraEditors.TextEdit edtTrinhDo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtThoiGian;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.FlowLayoutPanel panelCauHoi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CauHoi;
        private System.Windows.Forms.ColumnHeader DapAn;
        private System.Windows.Forms.Button btnXacNhan;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DS dS;
        private System.Windows.Forms.BindingSource lIST_LOPBindingSource;
        private DSTableAdapters.LIST_LOPTableAdapter lIST_LOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbxTenLop;
    }
}