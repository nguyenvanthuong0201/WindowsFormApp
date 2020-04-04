namespace MaHoaDonGian
{
    partial class StartUp
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
            this.lblDeAn = new System.Windows.Forms.Label();
            this.lblDienDai = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeAn
            // 
            this.lblDeAn.AutoSize = true;
            this.lblDeAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeAn.Location = new System.Drawing.Point(70, 34);
            this.lblDeAn.Name = "lblDeAn";
            this.lblDeAn.Size = new System.Drawing.Size(309, 29);
            this.lblDeAn.TabIndex = 0;
            this.lblDeAn.Text = "Mã hóa đơn giản V3.141592";
            // 
            // lblDienDai
            // 
            this.lblDienDai.AutoSize = true;
            this.lblDienDai.Location = new System.Drawing.Point(70, 80);
            this.lblDienDai.Name = "lblDienDai";
            this.lblDienDai.Size = new System.Drawing.Size(168, 13);
            this.lblDienDai.TabIndex = 1;
            this.lblDienDai.Text = "Các giải thuật mã hóa - DES, AES";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.Location = new System.Drawing.Point(300, 117);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(116, 20);
            this.lblTacGia.TabIndex = 2;
            this.lblTacGia.Text = "Theo Mr. Darcy";
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 187);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblDienDai);
            this.Controls.Add(this.lblDeAn);
            this.Name = "StartUp";
            this.Text = "StartUp";
            this.Load += new System.EventHandler(this.StartUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeAn;
        private System.Windows.Forms.Label lblDienDai;
        private System.Windows.Forms.Label lblTacGia;
    }
}