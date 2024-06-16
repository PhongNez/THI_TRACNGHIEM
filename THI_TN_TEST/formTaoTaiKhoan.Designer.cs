
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
            System.Windows.Forms.Label hOTENLabel;
            this.dS = new THI_TN_TEST.DS();
            this.bds_HOTEN_GV = new System.Windows.Forms.BindingSource(this.components);
            this.hOTEN_GVTableAdapter = new THI_TN_TEST.DSTableAdapters.HOTEN_GVTableAdapter();
            this.tableAdapterManager = new THI_TN_TEST.DSTableAdapters.TableAdapterManager();
            this.hOTENComboBox = new System.Windows.Forms.ComboBox();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_HOTEN_GV)).BeginInit();
            this.SuspendLayout();
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
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(302, 263);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(82, 22);
            hOTENLabel.TabIndex = 1;
            hOTENLabel.Text = "HOTEN:";
            // 
            // hOTENComboBox
            // 
            this.hOTENComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_HOTEN_GV, "HOTEN", true));
            this.hOTENComboBox.DataSource = this.bds_HOTEN_GV;
            this.hOTENComboBox.DisplayMember = "HOTEN";
            this.hOTENComboBox.FormattingEnabled = true;
            this.hOTENComboBox.Location = new System.Drawing.Point(390, 260);
            this.hOTENComboBox.Name = "hOTENComboBox";
            this.hOTENComboBox.Size = new System.Drawing.Size(121, 30);
            this.hOTENComboBox.TabIndex = 2;
            this.hOTENComboBox.ValueMember = "MAGV";
            // 
            // formTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.hOTENComboBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formTaoTaiKhoan";
            this.Text = "formTaoTaiKhoan";
            this.Load += new System.EventHandler(this.formTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_HOTEN_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource bds_HOTEN_GV;
        private DSTableAdapters.HOTEN_GVTableAdapter hOTEN_GVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox hOTENComboBox;
    }
}