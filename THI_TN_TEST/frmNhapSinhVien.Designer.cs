
namespace THI_TN_TEST
{
    partial class frmNhapSinhVien
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapSinhVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatSV = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCoso = new System.Windows.Forms.ComboBox();
            this.DS = new THI_TN_TEST.DS();
            this.tableAdapterManager = new THI_TN_TEST.DSTableAdapters.TableAdapterManager();
            this.LOPTableAdapter = new THI_TN_TEST.DSTableAdapters.LOPTableAdapter();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.gcLOP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SINHVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.mASVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.SINHVIENTableAdapter = new THI_TN_TEST.DSTableAdapters.SINHVIENTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPASSWORD = new DevExpress.XtraEditors.TextEdit();
            this.txtDIACHI = new DevExpress.XtraEditors.TextEdit();
            this.mALOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dateNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.txtMASV = new DevExpress.XtraEditors.TextEdit();
            this.bdsBANGDIEM = new System.Windows.Forms.BindingSource(this.components);
            this.BANGDIEMTableAdapter = new THI_TN_TEST.DSTableAdapters.BANGDIEMTableAdapter();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SINHVIENDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPASSWORD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBANGDIEM)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(26, 52);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(71, 21);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MÃ SV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(27, 96);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(82, 21);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HỌ TÊN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(26, 198);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(83, 21);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "ĐỊA CHỈ:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(417, 52);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(84, 21);
            mALOPLabel.TabIndex = 8;
            mALOPLabel.Text = "MÃ LỚP:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(27, 153);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(114, 21);
            nGAYSINHLabel.TabIndex = 12;
            nGAYSINHLabel.Text = "NGÀY SINH:";
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Location = new System.Drawing.Point(26, 246);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(116, 21);
            pASSWORDLabel.TabIndex = 20;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Hiệu chỉnh";
            this.btnSua.Id = 1;
            this.btnSua.Name = "btnSua";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 2;
            this.btnGhi.Name = "btnGhi";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1605, 51);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 984);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemSV,
            this.btnSuaSV,
            this.btnGhiSV,
            this.btnXoaSV,
            this.btnUndoSV,
            this.btnReloadSV,
            this.btnThoatSV});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndoSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReloadSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemSV
            // 
            this.btnThemSV.Caption = "Thêm";
            this.btnThemSV.Id = 0;
            this.btnThemSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSV.ImageOptions.Image")));
            this.btnThemSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemSV.ImageOptions.LargeImage")));
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemSV_ItemClick);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Caption = "Hiệu chỉnh";
            this.btnSuaSV.Id = 1;
            this.btnSuaSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSV.ImageOptions.Image")));
            this.btnSuaSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaSV.ImageOptions.LargeImage")));
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaSV_ItemClick);
            // 
            // btnGhiSV
            // 
            this.btnGhiSV.Caption = "Ghi";
            this.btnGhiSV.Enabled = false;
            this.btnGhiSV.Id = 2;
            this.btnGhiSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiSV.ImageOptions.Image")));
            this.btnGhiSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiSV.ImageOptions.LargeImage")));
            this.btnGhiSV.Name = "btnGhiSV";
            this.btnGhiSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiSV_ItemClick);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Caption = "Xóa";
            this.btnXoaSV.Id = 3;
            this.btnXoaSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSV.ImageOptions.Image")));
            this.btnXoaSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaSV.ImageOptions.LargeImage")));
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaSV_ItemClick);
            // 
            // btnUndoSV
            // 
            this.btnUndoSV.Caption = "Phục hồi";
            this.btnUndoSV.Enabled = false;
            this.btnUndoSV.Id = 4;
            this.btnUndoSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoSV.ImageOptions.Image")));
            this.btnUndoSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndoSV.ImageOptions.LargeImage")));
            this.btnUndoSV.Name = "btnUndoSV";
            this.btnUndoSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoSV_ItemClick);
            // 
            // btnReloadSV
            // 
            this.btnReloadSV.Caption = "Reload";
            this.btnReloadSV.Id = 5;
            this.btnReloadSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadSV.ImageOptions.Image")));
            this.btnReloadSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReloadSV.ImageOptions.LargeImage")));
            this.btnReloadSV.Name = "btnReloadSV";
            this.btnReloadSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadSV_ItemClick);
            // 
            // btnThoatSV
            // 
            this.btnThoatSV.Caption = "Thoát";
            this.btnThoatSV.Id = 6;
            this.btnThoatSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatSV.ImageOptions.Image")));
            this.btnThoatSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoatSV.ImageOptions.LargeImage")));
            this.btnThoatSV.Name = "btnThoatSV";
            this.btnThoatSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatSV_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1605, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1035);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1605, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 984);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1605, 51);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl1.Size = new System.Drawing.Size(0, 984);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbCoso);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1605, 96);
            this.panelControl1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cơ sở:";
            // 
            // cmbCoso
            // 
            this.cmbCoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoso.Enabled = false;
            this.cmbCoso.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoso.FormattingEnabled = true;
            this.cmbCoso.Location = new System.Drawing.Point(135, 31);
            this.cmbCoso.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbCoso.Name = "cmbCoso";
            this.cmbCoso.Size = new System.Drawing.Size(1075, 28);
            this.cmbCoso.TabIndex = 0;
            this.cmbCoso.SelectedIndexChanged += new System.EventHandler(this.cmbCoso_SelectedIndexChanged);
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
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THI_TN_TEST.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.DS;
            // 
            // gcLOP
            // 
            this.gcLOP.DataSource = this.bdsLOP;
            this.gcLOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLOP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcLOP.Location = new System.Drawing.Point(0, 147);
            this.gcLOP.MainView = this.gridView1;
            this.gcLOP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcLOP.MenuManager = this.barManager1;
            this.gcLOP.Name = "gcLOP";
            this.gcLOP.Size = new System.Drawing.Size(1605, 275);
            this.gcLOP.TabIndex = 15;
            this.gcLOP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gridView1.GridControl = this.gcLOP;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "MÃ LỚP";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "TÊN LỚP";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.ReadOnly = true;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "MÃ KHOA";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.ReadOnly = true;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 94;
            // 
            // SINHVIENDataGridView
            // 
            this.SINHVIENDataGridView.AutoGenerateColumns = false;
            this.SINHVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SINHVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASVDataGridViewTextBoxColumn,
            this.hODataGridViewTextBoxColumn,
            this.tENDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.mALOPDataGridViewTextBoxColumn,
            this.pASSWORDDataGridViewTextBoxColumn});
            this.SINHVIENDataGridView.DataSource = this.bdsSV;
            this.SINHVIENDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SINHVIENDataGridView.Location = new System.Drawing.Point(756, 422);
            this.SINHVIENDataGridView.Name = "SINHVIENDataGridView";
            this.SINHVIENDataGridView.RowHeadersWidth = 51;
            this.SINHVIENDataGridView.RowTemplate.Height = 24;
            this.SINHVIENDataGridView.Size = new System.Drawing.Size(849, 613);
            this.SINHVIENDataGridView.TabIndex = 16;
            // 
            // mASVDataGridViewTextBoxColumn
            // 
            this.mASVDataGridViewTextBoxColumn.DataPropertyName = "MASV";
            this.mASVDataGridViewTextBoxColumn.HeaderText = "MASV";
            this.mASVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mASVDataGridViewTextBoxColumn.Name = "mASVDataGridViewTextBoxColumn";
            this.mASVDataGridViewTextBoxColumn.ReadOnly = true;
            this.mASVDataGridViewTextBoxColumn.Width = 125;
            // 
            // hODataGridViewTextBoxColumn
            // 
            this.hODataGridViewTextBoxColumn.DataPropertyName = "HO";
            this.hODataGridViewTextBoxColumn.HeaderText = "HO";
            this.hODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hODataGridViewTextBoxColumn.Name = "hODataGridViewTextBoxColumn";
            this.hODataGridViewTextBoxColumn.ReadOnly = true;
            this.hODataGridViewTextBoxColumn.Width = 125;
            // 
            // tENDataGridViewTextBoxColumn
            // 
            this.tENDataGridViewTextBoxColumn.DataPropertyName = "TEN";
            this.tENDataGridViewTextBoxColumn.HeaderText = "TEN";
            this.tENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENDataGridViewTextBoxColumn.Name = "tENDataGridViewTextBoxColumn";
            this.tENDataGridViewTextBoxColumn.ReadOnly = true;
            this.tENDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.nGAYSINHDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            this.nGAYSINHDataGridViewTextBoxColumn.ReadOnly = true;
            this.nGAYSINHDataGridViewTextBoxColumn.Width = 125;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIACHIDataGridViewTextBoxColumn.Width = 125;
            // 
            // mALOPDataGridViewTextBoxColumn
            // 
            this.mALOPDataGridViewTextBoxColumn.DataPropertyName = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.HeaderText = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mALOPDataGridViewTextBoxColumn.Name = "mALOPDataGridViewTextBoxColumn";
            this.mALOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.mALOPDataGridViewTextBoxColumn.Width = 125;
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            this.pASSWORDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pASSWORDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLOP;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPASSWORD);
            this.groupBox1.Controls.Add(pASSWORDLabel);
            this.groupBox1.Controls.Add(this.txtDIACHI);
            this.groupBox1.Controls.Add(this.mALOPTextEdit);
            this.groupBox1.Controls.Add(this.dateNGAYSINH);
            this.groupBox1.Controls.Add(this.txtTEN);
            this.groupBox1.Controls.Add(this.txtHO);
            this.groupBox1.Controls.Add(this.txtMASV);
            this.groupBox1.Controls.Add(nGAYSINHLabel);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(mASVLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 613);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "PASSWORD", true));
            this.txtPASSWORD.Location = new System.Drawing.Point(160, 246);
            this.txtPASSWORD.MenuManager = this.barManager1;
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(189, 22);
            this.txtPASSWORD.TabIndex = 21;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(160, 198);
            this.txtDIACHI.MenuManager = this.barManager1;
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(189, 22);
            this.txtDIACHI.TabIndex = 19;
            // 
            // mALOPTextEdit
            // 
            this.mALOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MALOP", true));
            this.mALOPTextEdit.Enabled = false;
            this.mALOPTextEdit.Location = new System.Drawing.Point(517, 52);
            this.mALOPTextEdit.MenuManager = this.barManager1;
            this.mALOPTextEdit.Name = "mALOPTextEdit";
            this.mALOPTextEdit.Size = new System.Drawing.Size(125, 22);
            this.mALOPTextEdit.TabIndex = 18;
            // 
            // dateNGAYSINH
            // 
            this.dateNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGAYSINH", true));
            this.dateNGAYSINH.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateNGAYSINH.Location = new System.Drawing.Point(160, 153);
            this.dateNGAYSINH.MenuManager = this.barManager1;
            this.dateNGAYSINH.Name = "dateNGAYSINH";
            this.dateNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYSINH.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNGAYSINH.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateNGAYSINH.Size = new System.Drawing.Size(189, 22);
            this.dateNGAYSINH.TabIndex = 16;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(376, 96);
            this.txtTEN.MenuManager = this.barManager1;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(125, 22);
            this.txtTEN.TabIndex = 15;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(160, 96);
            this.txtHO.MenuManager = this.barManager1;
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(189, 22);
            this.txtHO.TabIndex = 14;
            // 
            // txtMASV
            // 
            this.txtMASV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MASV", true));
            this.txtMASV.Location = new System.Drawing.Point(160, 52);
            this.txtMASV.MenuManager = this.barManager1;
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Properties.MaxLength = 8;
            this.txtMASV.Size = new System.Drawing.Size(189, 22);
            this.txtMASV.TabIndex = 13;
            // 
            // bdsBANGDIEM
            // 
            this.bdsBANGDIEM.DataMember = "FK_BANGDIEM_SINHVIEN1";
            this.bdsBANGDIEM.DataSource = this.bdsSV;
            // 
            // BANGDIEMTableAdapter
            // 
            this.BANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 1055);
            this.Controls.Add(this.SINHVIENDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcLOP);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapSinhVien";
            this.Text = "frmNhapSinhVien";
            this.Load += new System.EventHandler(this.frmNhapSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SINHVIENDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPASSWORD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBANGDIEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemSV;
        private DevExpress.XtraBars.BarButtonItem btnSuaSV;
        private DevExpress.XtraBars.BarButtonItem btnGhiSV;
        private DevExpress.XtraBars.BarButtonItem btnXoaSV;
        private DevExpress.XtraBars.BarButtonItem btnUndoSV;
        private DevExpress.XtraBars.BarButtonItem btnReloadSV;
        private DevExpress.XtraBars.BarButtonItem btnThoatSV;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DS DS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCoso;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsLOP;
        private System.Windows.Forms.DataGridView SINHVIENDataGridView;
        private DevExpress.XtraGrid.GridControl gcLOP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtDIACHI;
        private DevExpress.XtraEditors.TextEdit mALOPTextEdit;
        private DevExpress.XtraEditors.DateEdit dateNGAYSINH;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.TextEdit txtHO;
        private DevExpress.XtraEditors.TextEdit txtMASV;
        private System.Windows.Forms.BindingSource bdsBANGDIEM;
        private DSTableAdapters.BANGDIEMTableAdapter BANGDIEMTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtPASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
    }
}