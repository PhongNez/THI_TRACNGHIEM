
namespace THI_TN_TEST
{
    partial class frmNhapDe
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label cAUHOILabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDe));
            System.Windows.Forms.Label dLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dS_MH = new THI_TN_TEST.DS_MH();
            this.bds_sp_lay_BODE = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Lay_BODE_THEO_MAGVTableAdapter = new THI_TN_TEST.DS_MHTableAdapters.sp_Lay_BODE_THEO_MAGVTableAdapter();
            this.tableAdapterManager = new THI_TN_TEST.DS_MHTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new THI_TN_TEST.DS_MHTableAdapters.MONHOCTableAdapter();
            this.sp_Lay_BODE_THEO_MAGVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtC = new System.Windows.Forms.RichTextBox();
            this.txtB = new System.Windows.Forms.RichTextBox();
            this.txtA = new System.Windows.Forms.RichTextBox();
            this.txtNOIDUNG = new System.Windows.Forms.RichTextBox();
            this.cmbDAPAN = new System.Windows.Forms.ComboBox();
            this.cmbTRINHDO = new System.Windows.Forms.ComboBox();
            this.cmbMONHOC = new System.Windows.Forms.ComboBox();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.txtCAUHOI = new DevExpress.XtraEditors.TextEdit();
            this.txtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.txtD = new System.Windows.Forms.RichTextBox();
            mAGVLabel = new System.Windows.Forms.Label();
            cAUHOILabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_lay_BODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Lay_BODE_THEO_MAGVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAUHOI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(47, 214);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(150, 22);
            mAGVLabel.TabIndex = 16;
            mAGVLabel.Text = "MÃ GIÁO VIÊN:";
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Location = new System.Drawing.Point(47, 268);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(125, 22);
            cAUHOILabel.TabIndex = 18;
            cAUHOILabel.Text = "CÂU HỎI SỐ:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(47, 48);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(104, 22);
            tENMHLabel.TabIndex = 19;
            tENMHLabel.Text = "TÊN MÔN:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(47, 102);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(109, 22);
            tRINHDOLabel.TabIndex = 20;
            tRINHDOLabel.Text = "TRÌNH ĐỘ:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Location = new System.Drawing.Point(47, 157);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(87, 22);
            dAP_ANLabel.TabIndex = 21;
            dAP_ANLabel.Text = "ĐÁP ÁN:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(532, 51);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(110, 22);
            nOIDUNGLabel.TabIndex = 22;
            nOIDUNGLabel.Text = "NỘI DUNG:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Location = new System.Drawing.Point(612, 162);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(30, 22);
            aLabel.TabIndex = 23;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(613, 262);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(29, 22);
            bLabel.TabIndex = 24;
            bLabel.Text = "B:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Location = new System.Drawing.Point(1109, 162);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(29, 22);
            cLabel.TabIndex = 25;
            cLabel.Text = "C:";
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
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnUndo,
            this.btnReload,
            this.btnThoat});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Hiệu chỉnh";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1647, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 836);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1647, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 785);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1647, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 785);
            // 
            // dS_MH
            // 
            this.dS_MH.DataSetName = "DS_MH";
            this.dS_MH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_sp_lay_BODE
            // 
            this.bds_sp_lay_BODE.DataMember = "sp_Lay_BODE_THEO_MAGV";
            this.bds_sp_lay_BODE.DataSource = this.dS_MH;
            // 
            // sp_Lay_BODE_THEO_MAGVTableAdapter
            // 
            this.sp_Lay_BODE_THEO_MAGVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.sp_Lay_BODE_THEO_MAGVTableAdapter = this.sp_Lay_BODE_THEO_MAGVTableAdapter;
            this.tableAdapterManager.UpdateOrder = THI_TN_TEST.DS_MHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // sp_Lay_BODE_THEO_MAGVGridControl
            // 
            this.sp_Lay_BODE_THEO_MAGVGridControl.DataSource = this.bds_sp_lay_BODE;
            this.sp_Lay_BODE_THEO_MAGVGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sp_Lay_BODE_THEO_MAGVGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(30);
            this.sp_Lay_BODE_THEO_MAGVGridControl.Location = new System.Drawing.Point(0, 51);
            this.sp_Lay_BODE_THEO_MAGVGridControl.MainView = this.gridView1;
            this.sp_Lay_BODE_THEO_MAGVGridControl.Margin = new System.Windows.Forms.Padding(30);
            this.sp_Lay_BODE_THEO_MAGVGridControl.MenuManager = this.barManager1;
            this.sp_Lay_BODE_THEO_MAGVGridControl.Name = "sp_Lay_BODE_THEO_MAGVGridControl";
            this.sp_Lay_BODE_THEO_MAGVGridControl.Size = new System.Drawing.Size(1647, 209);
            this.sp_Lay_BODE_THEO_MAGVGridControl.TabIndex = 6;
            this.sp_Lay_BODE_THEO_MAGVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUHOI,
            this.colMAMH,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colMAGV});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.sp_Lay_BODE_THEO_MAGVGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.MinWidth = 25;
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Width = 70;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 70;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 25;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.OptionsColumn.ReadOnly = true;
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 1;
            this.colTRINHDO.Width = 70;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 25;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.OptionsColumn.ReadOnly = true;
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 2;
            this.colNOIDUNG.Width = 118;
            // 
            // colA
            // 
            this.colA.FieldName = "A";
            this.colA.MinWidth = 25;
            this.colA.Name = "colA";
            this.colA.OptionsColumn.ReadOnly = true;
            this.colA.Visible = true;
            this.colA.VisibleIndex = 3;
            this.colA.Width = 118;
            // 
            // colB
            // 
            this.colB.FieldName = "B";
            this.colB.MinWidth = 25;
            this.colB.Name = "colB";
            this.colB.OptionsColumn.ReadOnly = true;
            this.colB.Visible = true;
            this.colB.VisibleIndex = 4;
            this.colB.Width = 118;
            // 
            // colC
            // 
            this.colC.FieldName = "C";
            this.colC.MinWidth = 25;
            this.colC.Name = "colC";
            this.colC.OptionsColumn.ReadOnly = true;
            this.colC.Visible = true;
            this.colC.VisibleIndex = 5;
            this.colC.Width = 118;
            // 
            // colD
            // 
            this.colD.FieldName = "D";
            this.colD.MinWidth = 25;
            this.colD.Name = "colD";
            this.colD.OptionsColumn.ReadOnly = true;
            this.colD.Visible = true;
            this.colD.VisibleIndex = 6;
            this.colD.Width = 118;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 25;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.OptionsColumn.ReadOnly = true;
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 7;
            this.colDAP_AN.Width = 118;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Width = 152;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(dLabel);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(cLabel);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(bLabel);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(aLabel);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(nOIDUNGLabel);
            this.groupBox1.Controls.Add(this.txtNOIDUNG);
            this.groupBox1.Controls.Add(dAP_ANLabel);
            this.groupBox1.Controls.Add(this.cmbDAPAN);
            this.groupBox1.Controls.Add(tRINHDOLabel);
            this.groupBox1.Controls.Add(this.cmbTRINHDO);
            this.groupBox1.Controls.Add(tENMHLabel);
            this.groupBox1.Controls.Add(this.cmbMONHOC);
            this.groupBox1.Controls.Add(cAUHOILabel);
            this.groupBox1.Controls.Add(this.txtCAUHOI);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Controls.Add(this.txtMAGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1647, 576);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtC
            // 
            this.txtC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_sp_lay_BODE, "C", true));
            this.txtC.Location = new System.Drawing.Point(1172, 157);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(391, 59);
            this.txtC.TabIndex = 26;
            this.txtC.Text = "";
            // 
            // txtB
            // 
            this.txtB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_sp_lay_BODE, "B", true));
            this.txtB.Location = new System.Drawing.Point(676, 259);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(373, 67);
            this.txtB.TabIndex = 25;
            this.txtB.Text = "";
            // 
            // txtA
            // 
            this.txtA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_sp_lay_BODE, "A", true));
            this.txtA.Location = new System.Drawing.Point(676, 154);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(373, 62);
            this.txtA.TabIndex = 24;
            this.txtA.Text = "";
            // 
            // txtNOIDUNG
            // 
            this.txtNOIDUNG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_sp_lay_BODE, "NOIDUNG", true));
            this.txtNOIDUNG.Location = new System.Drawing.Point(676, 45);
            this.txtNOIDUNG.Name = "txtNOIDUNG";
            this.txtNOIDUNG.Size = new System.Drawing.Size(887, 65);
            this.txtNOIDUNG.TabIndex = 23;
            this.txtNOIDUNG.Text = "";
            // 
            // cmbDAPAN
            // 
            this.cmbDAPAN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_sp_lay_BODE, "DAP_AN", true));
            this.cmbDAPAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDAPAN.FormattingEnabled = true;
            this.cmbDAPAN.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbDAPAN.Location = new System.Drawing.Point(223, 157);
            this.cmbDAPAN.Name = "cmbDAPAN";
            this.cmbDAPAN.Size = new System.Drawing.Size(231, 30);
            this.cmbDAPAN.TabIndex = 22;
            // 
            // cmbTRINHDO
            // 
            this.cmbTRINHDO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_sp_lay_BODE, "TRINHDO", true));
            this.cmbTRINHDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTRINHDO.FormattingEnabled = true;
            this.cmbTRINHDO.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbTRINHDO.Location = new System.Drawing.Point(223, 102);
            this.cmbTRINHDO.Name = "cmbTRINHDO";
            this.cmbTRINHDO.Size = new System.Drawing.Size(231, 30);
            this.cmbTRINHDO.TabIndex = 21;
            // 
            // cmbMONHOC
            // 
            this.cmbMONHOC.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bds_sp_lay_BODE, "MAMH", true));
            this.cmbMONHOC.DataSource = this.bdsMONHOC;
            this.cmbMONHOC.DisplayMember = "TENMH";
            this.cmbMONHOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMONHOC.FormattingEnabled = true;
            this.cmbMONHOC.Location = new System.Drawing.Point(223, 48);
            this.cmbMONHOC.Name = "cmbMONHOC";
            this.cmbMONHOC.Size = new System.Drawing.Size(231, 30);
            this.cmbMONHOC.TabIndex = 20;
            this.cmbMONHOC.ValueMember = "MAMH";
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.dS_MH;
            // 
            // txtCAUHOI
            // 
            this.txtCAUHOI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sp_lay_BODE, "CAUHOI", true));
            this.txtCAUHOI.EditValue = "null";
            this.txtCAUHOI.Enabled = false;
            this.txtCAUHOI.Location = new System.Drawing.Point(223, 268);
            this.txtCAUHOI.MenuManager = this.barManager1;
            this.txtCAUHOI.Name = "txtCAUHOI";
            this.txtCAUHOI.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCAUHOI.Properties.Appearance.Options.UseFont = true;
            this.txtCAUHOI.Size = new System.Drawing.Size(231, 26);
            this.txtCAUHOI.TabIndex = 19;
            this.txtCAUHOI.EditValueChanged += new System.EventHandler(this.txtCAUHOI_EditValueChanged);
            // 
            // txtMAGV
            // 
            this.txtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sp_lay_BODE, "MAGV", true));
            this.txtMAGV.Enabled = false;
            this.txtMAGV.Location = new System.Drawing.Point(223, 211);
            this.txtMAGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMAGV.MenuManager = this.barManager1;
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAGV.Properties.Appearance.Options.UseFont = true;
            this.txtMAGV.Size = new System.Drawing.Size(231, 28);
            this.txtMAGV.TabIndex = 17;
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new System.Drawing.Point(1108, 268);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(30, 22);
            dLabel.TabIndex = 26;
            dLabel.Text = "D:";
            // 
            // txtD
            // 
            this.txtD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_sp_lay_BODE, "D", true));
            this.txtD.Location = new System.Drawing.Point(1172, 259);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(391, 67);
            this.txtD.TabIndex = 27;
            this.txtD.Text = "";
            // 
            // frmNhapDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 856);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sp_Lay_BODE_THEO_MAGVGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapDe";
            this.Text = "frmNhapDe";
            this.Load += new System.EventHandler(this.frmNhapDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_lay_BODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Lay_BODE_THEO_MAGVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAUHOI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bds_sp_lay_BODE;
        private DS_MH dS_MH;
        private DS_MHTableAdapters.sp_Lay_BODE_THEO_MAGVTableAdapter sp_Lay_BODE_THEO_MAGVTableAdapter;
        private DS_MHTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sp_Lay_BODE_THEO_MAGVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DS_MHTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraEditors.TextEdit txtMAGV;
        private DevExpress.XtraEditors.TextEdit txtCAUHOI;
        private System.Windows.Forms.ComboBox cmbTRINHDO;
        private System.Windows.Forms.ComboBox cmbMONHOC;
        private System.Windows.Forms.ComboBox cmbDAPAN;
        private System.Windows.Forms.RichTextBox txtC;
        private System.Windows.Forms.RichTextBox txtB;
        private System.Windows.Forms.RichTextBox txtA;
        private System.Windows.Forms.RichTextBox txtNOIDUNG;
        private System.Windows.Forms.RichTextBox txtD;
    }
}