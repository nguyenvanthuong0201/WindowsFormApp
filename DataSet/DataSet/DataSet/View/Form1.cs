﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataSet
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banHangDataSet.KhanhHang' table. You can move, or remove it, as needed.
            this.khanhHangTableAdapter.Fill(this.banHangDataSet.KhanhHang);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            khanhHangTableAdapter.Update(this.banHangDataSet.KhanhHang);
        }
    }
}
