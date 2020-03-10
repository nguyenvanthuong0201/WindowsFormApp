namespace Hamming
{
    partial class frmHamming
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
            this.lbl16KySoHex = new System.Windows.Forms.Label();
            this.lblSoHex = new System.Windows.Forms.Label();
            this.lblSoNhiPhan = new System.Windows.Forms.Label();
            this.lblTrongSoHamming = new System.Windows.Forms.Label();
            this.lblSoThuNhat = new System.Windows.Forms.Label();
            this.lblSoThuHai = new System.Windows.Forms.Label();
            this.lblKhoangCach = new System.Windows.Forms.Label();
            this.txtAHexStr = new System.Windows.Forms.TextBox();
            this.txtBHexStr = new System.Windows.Forms.TextBox();
            this.txtABinStr = new System.Windows.Forms.TextBox();
            this.txtBBinStr = new System.Windows.Forms.TextBox();
            this.txtATrongSo = new System.Windows.Forms.TextBox();
            this.txtBTrongSo = new System.Windows.Forms.TextBox();
            this.txtAxorBHexStr = new System.Windows.Forms.TextBox();
            this.txtAxorBBinStr = new System.Windows.Forms.TextBox();
            this.txtKhoangCach = new System.Windows.Forms.TextBox();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.btmDong = new System.Windows.Forms.Button();
            this.picAxorB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAxorB)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl16KySoHex
            // 
            this.lbl16KySoHex.AutoSize = true;
            this.lbl16KySoHex.Location = new System.Drawing.Point(26, 23);
            this.lbl16KySoHex.Name = "lbl16KySoHex";
            this.lbl16KySoHex.Size = new System.Drawing.Size(69, 13);
            this.lbl16KySoHex.TabIndex = 0;
            this.lbl16KySoHex.Text = "16 ký số Hex";
            // 
            // lblSoHex
            // 
            this.lblSoHex.AutoSize = true;
            this.lblSoHex.Location = new System.Drawing.Point(123, 23);
            this.lblSoHex.Name = "lblSoHex";
            this.lblSoHex.Size = new System.Drawing.Size(84, 13);
            this.lblSoHex.TabIndex = 1;
            this.lblSoHex.Text = "Số Hexadecimal";
            // 
            // lblSoNhiPhan
            // 
            this.lblSoNhiPhan.AutoSize = true;
            this.lblSoNhiPhan.Location = new System.Drawing.Point(260, 23);
            this.lblSoNhiPhan.Name = "lblSoNhiPhan";
            this.lblSoNhiPhan.Size = new System.Drawing.Size(64, 13);
            this.lblSoNhiPhan.TabIndex = 2;
            this.lblSoNhiPhan.Text = "Số nhị phân";
            // 
            // lblTrongSoHamming
            // 
            this.lblTrongSoHamming.AutoSize = true;
            this.lblTrongSoHamming.Location = new System.Drawing.Point(578, 23);
            this.lblTrongSoHamming.Name = "lblTrongSoHamming";
            this.lblTrongSoHamming.Size = new System.Drawing.Size(98, 13);
            this.lblTrongSoHamming.TabIndex = 3;
            this.lblTrongSoHamming.Text = "Trọng Số Hamming";
            // 
            // lblSoThuNhat
            // 
            this.lblSoThuNhat.AutoSize = true;
            this.lblSoThuNhat.Location = new System.Drawing.Point(26, 73);
            this.lblSoThuNhat.Name = "lblSoThuNhat";
            this.lblSoThuNhat.Size = new System.Drawing.Size(14, 13);
            this.lblSoThuNhat.TabIndex = 4;
            this.lblSoThuNhat.Text = "A";
            // 
            // lblSoThuHai
            // 
            this.lblSoThuHai.AutoSize = true;
            this.lblSoThuHai.Location = new System.Drawing.Point(26, 121);
            this.lblSoThuHai.Name = "lblSoThuHai";
            this.lblSoThuHai.Size = new System.Drawing.Size(14, 13);
            this.lblSoThuHai.TabIndex = 5;
            this.lblSoThuHai.Text = "B";
            // 
            // lblKhoangCach
            // 
            this.lblKhoangCach.AutoSize = true;
            this.lblKhoangCach.Location = new System.Drawing.Point(578, 151);
            this.lblKhoangCach.Name = "lblKhoangCach";
            this.lblKhoangCach.Size = new System.Drawing.Size(119, 13);
            this.lblKhoangCach.TabIndex = 6;
            this.lblKhoangCach.Text = "Khoảng Cách Hamming";
            this.lblKhoangCach.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtAHexStr
            // 
            this.txtAHexStr.Location = new System.Drawing.Point(126, 70);
            this.txtAHexStr.Name = "txtAHexStr";
            this.txtAHexStr.Size = new System.Drawing.Size(100, 20);
            this.txtAHexStr.TabIndex = 7;
            this.txtAHexStr.TextChanged += new System.EventHandler(this.txtHexStr_TextChanged);
            // 
            // txtBHexStr
            // 
            this.txtBHexStr.Location = new System.Drawing.Point(126, 114);
            this.txtBHexStr.Name = "txtBHexStr";
            this.txtBHexStr.Size = new System.Drawing.Size(100, 20);
            this.txtBHexStr.TabIndex = 8;
            this.txtBHexStr.TextChanged += new System.EventHandler(this.txtHexStr_TextChanged);
            // 
            // txtABinStr
            // 
            this.txtABinStr.Location = new System.Drawing.Point(263, 70);
            this.txtABinStr.Name = "txtABinStr";
            this.txtABinStr.ReadOnly = true;
            this.txtABinStr.Size = new System.Drawing.Size(290, 20);
            this.txtABinStr.TabIndex = 9;
            // 
            // txtBBinStr
            // 
            this.txtBBinStr.Location = new System.Drawing.Point(263, 114);
            this.txtBBinStr.Name = "txtBBinStr";
            this.txtBBinStr.ReadOnly = true;
            this.txtBBinStr.Size = new System.Drawing.Size(290, 20);
            this.txtBBinStr.TabIndex = 10;
            // 
            // txtATrongSo
            // 
            this.txtATrongSo.Location = new System.Drawing.Point(581, 70);
            this.txtATrongSo.Name = "txtATrongSo";
            this.txtATrongSo.ReadOnly = true;
            this.txtATrongSo.Size = new System.Drawing.Size(100, 20);
            this.txtATrongSo.TabIndex = 11;
            // 
            // txtBTrongSo
            // 
            this.txtBTrongSo.Location = new System.Drawing.Point(581, 114);
            this.txtBTrongSo.Name = "txtBTrongSo";
            this.txtBTrongSo.ReadOnly = true;
            this.txtBTrongSo.Size = new System.Drawing.Size(100, 20);
            this.txtBTrongSo.TabIndex = 12;
            // 
            // txtAxorBHexStr
            // 
            this.txtAxorBHexStr.Location = new System.Drawing.Point(126, 181);
            this.txtAxorBHexStr.Name = "txtAxorBHexStr";
            this.txtAxorBHexStr.ReadOnly = true;
            this.txtAxorBHexStr.Size = new System.Drawing.Size(100, 20);
            this.txtAxorBHexStr.TabIndex = 13;
            // 
            // txtAxorBBinStr
            // 
            this.txtAxorBBinStr.Location = new System.Drawing.Point(263, 181);
            this.txtAxorBBinStr.Name = "txtAxorBBinStr";
            this.txtAxorBBinStr.ReadOnly = true;
            this.txtAxorBBinStr.Size = new System.Drawing.Size(290, 20);
            this.txtAxorBBinStr.TabIndex = 14;
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.Enabled = false;
            this.txtKhoangCach.Location = new System.Drawing.Point(581, 181);
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.Size = new System.Drawing.Size(100, 20);
            this.txtKhoangCach.TabIndex = 15;
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Location = new System.Drawing.Point(135, 238);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(75, 23);
            this.btnTinhToan.TabIndex = 16;
            this.btnTinhToan.Text = "Tính Toán";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // btmDong
            // 
            this.btmDong.Location = new System.Drawing.Point(263, 238);
            this.btmDong.Name = "btmDong";
            this.btmDong.Size = new System.Drawing.Size(75, 23);
            this.btmDong.TabIndex = 17;
            this.btmDong.Text = "Đóng";
            this.btmDong.UseVisualStyleBackColor = true;
            this.btmDong.Click += new System.EventHandler(this.btmDong_Click);
            // 
            // picAxorB
            // 
            this.picAxorB.Image = global::Hamming.Properties.Resources.AxorB;
            this.picAxorB.Location = new System.Drawing.Point(12, 172);
            this.picAxorB.Name = "picAxorB";
            this.picAxorB.Size = new System.Drawing.Size(60, 29);
            this.picAxorB.TabIndex = 18;
            this.picAxorB.TabStop = false;
            this.picAxorB.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmHamming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.picAxorB);
            this.Controls.Add(this.btmDong);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.txtKhoangCach);
            this.Controls.Add(this.txtAxorBBinStr);
            this.Controls.Add(this.txtAxorBHexStr);
            this.Controls.Add(this.txtBTrongSo);
            this.Controls.Add(this.txtATrongSo);
            this.Controls.Add(this.txtBBinStr);
            this.Controls.Add(this.txtABinStr);
            this.Controls.Add(this.txtBHexStr);
            this.Controls.Add(this.txtAHexStr);
            this.Controls.Add(this.lblKhoangCach);
            this.Controls.Add(this.lblSoThuHai);
            this.Controls.Add(this.lblSoThuNhat);
            this.Controls.Add(this.lblTrongSoHamming);
            this.Controls.Add(this.lblSoNhiPhan);
            this.Controls.Add(this.lblSoHex);
            this.Controls.Add(this.lbl16KySoHex);
            this.Name = "frmHamming";
            this.Text = "Bài toán Hamming";
            ((System.ComponentModel.ISupportInitialize)(this.picAxorB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl16KySoHex;
        private System.Windows.Forms.Label lblSoHex;
        private System.Windows.Forms.Label lblSoNhiPhan;
        private System.Windows.Forms.Label lblTrongSoHamming;
        private System.Windows.Forms.Label lblSoThuNhat;
        private System.Windows.Forms.Label lblSoThuHai;
        private System.Windows.Forms.Label lblKhoangCach;
        private System.Windows.Forms.TextBox txtAHexStr;
        private System.Windows.Forms.TextBox txtBHexStr;
        private System.Windows.Forms.TextBox txtABinStr;
        private System.Windows.Forms.TextBox txtBBinStr;
        private System.Windows.Forms.TextBox txtATrongSo;
        private System.Windows.Forms.TextBox txtBTrongSo;
        private System.Windows.Forms.TextBox txtAxorBHexStr;
        private System.Windows.Forms.TextBox txtAxorBBinStr;
        private System.Windows.Forms.TextBox txtKhoangCach;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.Button btmDong;
        private System.Windows.Forms.PictureBox picAxorB;
    }
}

