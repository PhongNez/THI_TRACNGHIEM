
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
            this.dTNgayThi = new System.Windows.Forms.DateTimePicker();
            this.gbSinhVien = new System.Windows.Forms.GroupBox();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoxTenLop = new System.Windows.Forms.ComboBox();
            this.txtEditMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtEditMaSV = new DevExpress.XtraEditors.TextEdit();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.txtEditTenLop = new DevExpress.XtraEditors.TextEdit();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.txtEditHoTen = new DevExpress.XtraEditors.TextEdit();
            this.lbHoTen = new System.Windows.Forms.Label();
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.CauHoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DapAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditHoTen.Properties)).BeginInit();
            this.gbBaiThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtSoCau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTrinhDo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dTNgayThi
            // 
            this.dTNgayThi.CalendarFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.dTNgayThi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.dTNgayThi.Location = new System.Drawing.Point(86, 77);
            this.dTNgayThi.MinDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dTNgayThi.Name = "dTNgayThi";
            this.dTNgayThi.Size = new System.Drawing.Size(176, 23);
            this.dTNgayThi.TabIndex = 9;
            // 
            // gbSinhVien
            // 
            this.gbSinhVien.BackColor = System.Drawing.Color.White;
            this.gbSinhVien.Controls.Add(this.txtTenLop);
            this.gbSinhVien.Controls.Add(this.label1);
            this.gbSinhVien.Controls.Add(this.cbBoxTenLop);
            this.gbSinhVien.Controls.Add(this.txtEditMaLop);
            this.gbSinhVien.Controls.Add(this.txtEditMaSV);
            this.gbSinhVien.Controls.Add(this.lbTenLop);
            this.gbSinhVien.Controls.Add(this.lbMaSV);
            this.gbSinhVien.Controls.Add(this.txtEditTenLop);
            this.gbSinhVien.Controls.Add(this.lbMaLop);
            this.gbSinhVien.Controls.Add(this.txtEditHoTen);
            this.gbSinhVien.Controls.Add(this.lbHoTen);
            this.gbSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSinhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbSinhVien.Location = new System.Drawing.Point(0, 0);
            this.gbSinhVien.Name = "gbSinhVien";
            this.gbSinhVien.Size = new System.Drawing.Size(1332, 152);
            this.gbSinhVien.TabIndex = 11;
            this.gbSinhVien.TabStop = false;
            this.gbSinhVien.Text = "Thông tin sinh viên";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(133, 75);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Properties.Appearance.Options.UseFont = true;
            this.txtTenLop.Size = new System.Drawing.Size(169, 24);
            this.txtTenLop.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên lớp:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbBoxTenLop
            // 
            this.cbBoxTenLop.DisplayMember = "TENLOP";
            this.cbBoxTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxTenLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxTenLop.FormattingEnabled = true;
            this.cbBoxTenLop.Location = new System.Drawing.Point(414, 32);
            this.cbBoxTenLop.Name = "cbBoxTenLop";
            this.cbBoxTenLop.Size = new System.Drawing.Size(171, 25);
            this.cbBoxTenLop.TabIndex = 9;
            this.cbBoxTenLop.ValueMember = "MALOP";
            // 
            // txtEditMaLop
            // 
            this.txtEditMaLop.Enabled = false;
            this.txtEditMaLop.Location = new System.Drawing.Point(414, 75);
            this.txtEditMaLop.Name = "txtEditMaLop";
            this.txtEditMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtEditMaLop.Size = new System.Drawing.Size(106, 24);
            this.txtEditMaLop.TabIndex = 5;
            // 
            // txtEditMaSV
            // 
            this.txtEditMaSV.Enabled = false;
            this.txtEditMaSV.Location = new System.Drawing.Point(133, 33);
            this.txtEditMaSV.Name = "txtEditMaSV";
            this.txtEditMaSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditMaSV.Properties.Appearance.Options.UseFont = true;
            this.txtEditMaSV.Size = new System.Drawing.Size(169, 24);
            this.txtEditMaSV.TabIndex = 7;
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLop.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTenLop.Location = new System.Drawing.Point(341, 35);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(67, 17);
            this.lbTenLop.TabIndex = 1;
            this.lbTenLop.Text = "Tên lớp :";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSV.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbMaSV.Location = new System.Drawing.Point(12, 40);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(63, 17);
            this.lbMaSV.TabIndex = 6;
            this.lbMaSV.Text = "Mã lớp :";
            this.lbMaSV.Click += new System.EventHandler(this.lbMaSV_Click);
            // 
            // txtEditTenLop
            // 
            this.txtEditTenLop.Enabled = false;
            this.txtEditTenLop.Location = new System.Drawing.Point(414, 33);
            this.txtEditTenLop.Name = "txtEditTenLop";
            this.txtEditTenLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTenLop.Properties.Appearance.Options.UseFont = true;
            this.txtEditTenLop.Size = new System.Drawing.Size(171, 24);
            this.txtEditTenLop.TabIndex = 3;
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbMaLop.Location = new System.Drawing.Point(345, 77);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(63, 17);
            this.lbMaLop.TabIndex = 4;
            this.lbMaLop.Text = "Mã lớp :";
            // 
            // txtEditHoTen
            // 
            this.txtEditHoTen.Enabled = false;
            this.txtEditHoTen.Location = new System.Drawing.Point(133, 118);
            this.txtEditHoTen.Name = "txtEditHoTen";
            this.txtEditHoTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtEditHoTen.Size = new System.Drawing.Size(169, 24);
            this.txtEditHoTen.TabIndex = 2;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbHoTen.Location = new System.Drawing.Point(6, 125);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(121, 17);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ tên sinh viên:";
            // 
            // gbBaiThi
            // 
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
            this.gbBaiThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBaiThi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbBaiThi.Location = new System.Drawing.Point(308, 0);
            this.gbBaiThi.Name = "gbBaiThi";
            this.gbBaiThi.Size = new System.Drawing.Size(1024, 152);
            this.gbBaiThi.TabIndex = 12;
            this.gbBaiThi.TabStop = false;
            this.gbBaiThi.Text = "Thông tin bài thi";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Location = new System.Drawing.Point(179, 113);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(98, 30);
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
            this.lbTime.Location = new System.Drawing.Point(700, 61);
            this.lbTime.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(118, 39);
            this.lbTime.TabIndex = 39;
            this.lbTime.Text = "00: 00";
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnBatDau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Location = new System.Drawing.Point(839, 15);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(125, 40);
            this.btnBatDau.TabIndex = 38;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(839, 99);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 43);
            this.btnThoat.TabIndex = 37;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnNopBai
            // 
            this.btnNopBai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNopBai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.Location = new System.Drawing.Point(839, 54);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(125, 46);
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
            this.lbLan.Location = new System.Drawing.Point(9, 120);
            this.lbLan.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbLan.Name = "lbLan";
            this.lbLan.Size = new System.Drawing.Size(63, 17);
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
            this.cbBoxLan.Location = new System.Drawing.Point(86, 117);
            this.cbBoxLan.Name = "cbBoxLan";
            this.cbBoxLan.Size = new System.Drawing.Size(70, 25);
            this.cbBoxLan.TabIndex = 33;
            this.cbBoxLan.ValueMember = "LAN";
            // 
            // lbTenMH
            // 
            this.lbTenMH.AutoSize = true;
            this.lbTenMH.BackColor = System.Drawing.Color.White;
            this.lbTenMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMH.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTenMH.Location = new System.Drawing.Point(8, 37);
            this.lbTenMH.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbTenMH.Name = "lbTenMH";
            this.lbTenMH.Size = new System.Drawing.Size(75, 17);
            this.lbTenMH.TabIndex = 32;
            this.lbTenMH.Text = "Tên môn :";
            // 
            // cbBoxTenMH
            // 
            this.cbBoxTenMH.DisplayMember = "TENMH";
            this.cbBoxTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxTenMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxTenMH.FormattingEnabled = true;
            this.cbBoxTenMH.Location = new System.Drawing.Point(86, 33);
            this.cbBoxTenMH.Name = "cbBoxTenMH";
            this.cbBoxTenMH.Size = new System.Drawing.Size(174, 25);
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
            this.edtSoCau.Location = new System.Drawing.Point(476, 76);
            this.edtSoCau.Margin = new System.Windows.Forms.Padding(1);
            this.edtSoCau.Name = "edtSoCau";
            this.edtSoCau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtSoCau.Properties.Appearance.Options.UseFont = true;
            this.edtSoCau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtSoCau.Size = new System.Drawing.Size(57, 24);
            this.edtSoCau.TabIndex = 30;
            // 
            // edtTrinhDo
            // 
            this.edtTrinhDo.Enabled = false;
            this.edtTrinhDo.Location = new System.Drawing.Point(476, 32);
            this.edtTrinhDo.Margin = new System.Windows.Forms.Padding(1);
            this.edtTrinhDo.Name = "edtTrinhDo";
            this.edtTrinhDo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTrinhDo.Properties.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.edtTrinhDo.Properties.Appearance.Options.UseFont = true;
            this.edtTrinhDo.Properties.Appearance.Options.UseForeColor = true;
            this.edtTrinhDo.Size = new System.Drawing.Size(70, 24);
            this.edtTrinhDo.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(509, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "phút";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.AutoSize = true;
            this.txtThoiGian.BackColor = System.Drawing.Color.White;
            this.txtThoiGian.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.ForeColor = System.Drawing.Color.Crimson;
            this.txtThoiGian.Location = new System.Drawing.Point(473, 121);
            this.txtThoiGian.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(24, 17);
            this.txtThoiGian.TabIndex = 27;
            this.txtThoiGian.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(389, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Thời gian :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(389, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Số câu :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(389, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Trình độ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(9, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày thi :";
            // 
            // panelCauHoi
            // 
            this.panelCauHoi.AutoScroll = true;
            this.panelCauHoi.AutoScrollMinSize = new System.Drawing.Size(0, 10);
            this.panelCauHoi.BackColor = System.Drawing.Color.White;
            this.panelCauHoi.CausesValidation = false;
            this.panelCauHoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCauHoi.Location = new System.Drawing.Point(0, 152);
            this.panelCauHoi.Name = "panelCauHoi";
            this.panelCauHoi.Size = new System.Drawing.Size(1149, 360);
            this.panelCauHoi.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CauHoi,
            this.DapAn});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1147, 152);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(185, 360);
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
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 512);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbBaiThi);
            this.Controls.Add(this.panelCauHoi);
            this.Controls.Add(this.gbSinhVien);
            this.Name = "frmThi";
            this.Text = "frmThi";
            this.gbSinhVien.ResumeLayout(false);
            this.gbSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditHoTen.Properties)).EndInit();
            this.gbBaiThi.ResumeLayout(false);
            this.gbBaiThi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtSoCau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTrinhDo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dTNgayThi;
        private System.Windows.Forms.GroupBox gbSinhVien;
        private System.Windows.Forms.ComboBox cbBoxTenLop;
        private DevExpress.XtraEditors.TextEdit txtEditMaLop;
        private DevExpress.XtraEditors.TextEdit txtEditMaSV;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Label lbMaSV;
        private DevExpress.XtraEditors.TextEdit txtEditTenLop;
        private System.Windows.Forms.Label lbMaLop;
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
    }
}