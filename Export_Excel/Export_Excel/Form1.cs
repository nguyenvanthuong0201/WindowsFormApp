using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraPrinting.Native.LayoutAdjustment;
using Export_Excel._QL_BanHangDataSetTableAdapters;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using excel=Microsoft.Office.Interop.Excel.Application;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace Export_Excel
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
 
        public Form1()
        {
            InitializeComponent();
            LinQDataContext linQData = new LinQDataContext();
            dataGridView1.DataSource = linQData.KhanhHangs.ToList();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QL_BanHangDataSet.KhanhHang' table. You can move, or remove it, as needed.
            this.khanhHangTableAdapter.Fill(this._QL_BanHangDataSet.KhanhHang);

        }
        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            excel obj = new excel();
            obj.Application.Workbooks.Add(Type.Missing);

            // width cột 
            obj.Columns.ColumnWidth = 25;
            //tieu đề excel
            for(int j =1; j < g.Columns.Count + 1 ; j++)
            {
                obj.Cells[1, j].Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                BorderAround(obj.Cells[1,j]);
            }
           
            //Đẩy dữ liệu vào Excel
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        /// <summary>
        /// /boder của khung
        /// </summary>
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            export2Excel(dataGridView1, @"D:\", "xuatfileExcel");
            string a = @"D:\xuatfileExcel.xlsx";
            Process.Start(a);  
            
        }
      
        
    }
}
