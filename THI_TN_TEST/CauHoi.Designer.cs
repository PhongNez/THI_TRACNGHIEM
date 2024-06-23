
namespace THI_TN_TEST
{
    partial class CauHoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CauHoi));
            this.lbCauSo = new DevExpress.XtraEditors.LabelControl();
            this.lbNoiDung = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCauSo
            // 
            this.lbCauSo.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.lbCauSo.Appearance.Options.UseFont = true;
            this.lbCauSo.Location = new System.Drawing.Point(3, 0);
            this.lbCauSo.Name = "lbCauSo";
            this.lbCauSo.Size = new System.Drawing.Size(59, 19);
            this.lbCauSo.TabIndex = 0;
            this.lbCauSo.Text = "Câu số 1";
            this.lbCauSo.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDung.Appearance.Options.UseFont = true;
            this.lbNoiDung.AutoEllipsis = true;
            this.lbNoiDung.Location = new System.Drawing.Point(3, 32);
            this.lbNoiDung.MaximumSize = new System.Drawing.Size(100, 100);
            this.lbNoiDung.MinimumSize = new System.Drawing.Size(0, 20);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(0, 20);
            this.lbNoiDung.TabIndex = 1;
            this.lbNoiDung.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(14, 23);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "A";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(24, 156);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(14, 23);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "B";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(24, 206);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(14, 23);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "C";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(24, 254);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(15, 23);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "D";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(3, 97);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Size = new System.Drawing.Size(711, 208);
            this.radioGroup1.TabIndex = 6;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(70, 118);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(69, 17);
            this.rbA.TabIndex = 7;
            this.rbA.TabStop = true;
            this.rbA.Text = "Đáp án a";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.rbA_CheckedChanged_1);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(70, 161);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(87, 17);
            this.rbB.TabIndex = 8;
            this.rbB.TabStop = true;
            this.rbB.Text = "radioButton2";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.rbB_CheckedChanged_1);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(70, 206);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(87, 17);
            this.rbC.TabIndex = 9;
            this.rbC.TabStop = true;
            this.rbC.Text = "radioButton3";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged_1);
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(70, 260);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(87, 17);
            this.rbD.TabIndex = 10;
            this.rbD.TabStop = true;
            this.rbD.Text = "radioButton4";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.CheckedChanged += new System.EventHandler(this.rbD_CheckedChanged);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoiDung.Enabled = false;
            this.txtNoiDung.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtNoiDung.Location = new System.Drawing.Point(68, 0);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ReadOnly = true;
            this.txtNoiDung.Size = new System.Drawing.Size(646, 98);
            this.txtNoiDung.TabIndex = 11;
            this.txtNoiDung.Text = resources.GetString("txtNoiDung.Text");
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CauHoi
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lbNoiDung);
            this.Controls.Add(this.lbCauSo);
            this.Controls.Add(this.radioGroup1);
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.Name = "CauHoi";
            this.Size = new System.Drawing.Size(719, 310);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbCauSo;
        private DevExpress.XtraEditors.LabelControl lbNoiDung;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
