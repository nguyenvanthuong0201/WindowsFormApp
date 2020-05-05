namespace Print_Imformation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtChuyenNganh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtToHopXetTuyen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtNganhDangKy = new DevExpress.XtraEditors.TextEdit();
            this.txtDiemXetTuyen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.checkHocBa = new DevExpress.XtraEditors.CheckEdit();
            this.checkGiaytrungnhantotnghiep = new DevExpress.XtraEditors.CheckEdit();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuyenNganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToHopXetTuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNganhDangKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemXetTuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkHocBa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGiaytrungnhantotnghiep.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(438, 238);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Họ và tên";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(117, 20);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(197, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(117, 61);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(197, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Số điện thoại";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Ngành đăng kí";
            // 
            // txtChuyenNganh
            // 
            this.txtChuyenNganh.Location = new System.Drawing.Point(410, 102);
            this.txtChuyenNganh.Name = "txtChuyenNganh";
            this.txtChuyenNganh.Size = new System.Drawing.Size(197, 20);
            this.txtChuyenNganh.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(318, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Chuyên ngành ";
            // 
            // txtToHopXetTuyen
            // 
            this.txtToHopXetTuyen.Location = new System.Drawing.Point(117, 141);
            this.txtToHopXetTuyen.Name = "txtToHopXetTuyen";
            this.txtToHopXetTuyen.Size = new System.Drawing.Size(197, 20);
            this.txtToHopXetTuyen.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(25, 144);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Tổ hợp xét tuyển";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(320, 19);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Ngày sinh";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.EditValue = null;
            this.dateNgaySinh.Location = new System.Drawing.Point(412, 16);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Size = new System.Drawing.Size(195, 20);
            this.dateNgaySinh.TabIndex = 15;
            // 
            // txtNganhDangKy
            // 
            this.txtNganhDangKy.Location = new System.Drawing.Point(117, 102);
            this.txtNganhDangKy.Name = "txtNganhDangKy";
            this.txtNganhDangKy.Size = new System.Drawing.Size(197, 20);
            this.txtNganhDangKy.TabIndex = 16;
            // 
            // txtDiemXetTuyen
            // 
            this.txtDiemXetTuyen.Location = new System.Drawing.Point(410, 141);
            this.txtDiemXetTuyen.Name = "txtDiemXetTuyen";
            this.txtDiemXetTuyen.Size = new System.Drawing.Size(197, 20);
            this.txtDiemXetTuyen.TabIndex = 18;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(318, 144);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(74, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Điểm xét tuyển";
            // 
            // checkHocBa
            // 
            this.checkHocBa.Location = new System.Drawing.Point(117, 192);
            this.checkHocBa.Name = "checkHocBa";
            this.checkHocBa.Properties.Caption = "Học Bạ";
            this.checkHocBa.Size = new System.Drawing.Size(93, 19);
            this.checkHocBa.TabIndex = 19;
            // 
            // checkGiaytrungnhantotnghiep
            // 
            this.checkGiaytrungnhantotnghiep.Location = new System.Drawing.Point(253, 192);
            this.checkGiaytrungnhantotnghiep.Name = "checkGiaytrungnhantotnghiep";
            this.checkGiaytrungnhantotnghiep.Properties.Caption = "Giấy trứng nhận tốt nghiệp";
            this.checkGiaytrungnhantotnghiep.Size = new System.Drawing.Size(170, 19);
            this.checkGiaytrungnhantotnghiep.TabIndex = 20;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 302);
            this.Controls.Add(this.checkGiaytrungnhantotnghiep);
            this.Controls.Add(this.checkHocBa);
            this.Controls.Add(this.txtDiemXetTuyen);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtNganhDangKy);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtToHopXetTuyen);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtChuyenNganh);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnPrint);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuyenNganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToHopXetTuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNganhDangKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemXetTuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkHocBa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGiaytrungnhantotnghiep.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtChuyenNganh;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtToHopXetTuyen;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtNganhDangKy;
        private DevExpress.XtraEditors.TextEdit txtDiemXetTuyen;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CheckEdit checkHocBa;
        private DevExpress.XtraEditors.CheckEdit checkGiaytrungnhantotnghiep;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

