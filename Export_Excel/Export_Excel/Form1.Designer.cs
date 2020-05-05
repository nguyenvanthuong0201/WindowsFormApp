namespace Export_Excel
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this._QL_BanHangDataSet = new Export_Excel._QL_BanHangDataSet();
            this.qLBanHangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khanhHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khanhHangTableAdapter = new Export_Excel._QL_BanHangDataSetTableAdapters.KhanhHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QL_BanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanHangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khanhHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(443, 46);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Xuất excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // _QL_BanHangDataSet
            // 
            this._QL_BanHangDataSet.DataSetName = "_QL_BanHangDataSet";
            this._QL_BanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBanHangDataSetBindingSource
            // 
            this.qLBanHangDataSetBindingSource.DataSource = this._QL_BanHangDataSet;
            this.qLBanHangDataSetBindingSource.Position = 0;
            // 
            // khanhHangBindingSource
            // 
            this.khanhHangBindingSource.DataMember = "KhanhHang";
            this.khanhHangBindingSource.DataSource = this.qLBanHangDataSetBindingSource;
            // 
            // khanhHangTableAdapter
            // 
            this.khanhHangTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QL_BanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanHangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khanhHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource qLBanHangDataSetBindingSource;
        private _QL_BanHangDataSet _QL_BanHangDataSet;
        private System.Windows.Forms.BindingSource khanhHangBindingSource;
        private _QL_BanHangDataSetTableAdapters.KhanhHangTableAdapter khanhHangTableAdapter;
    }
}

