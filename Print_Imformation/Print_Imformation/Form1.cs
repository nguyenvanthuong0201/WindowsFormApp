using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word; /// dùng để triển file word
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Print_Imformation
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
        
        private void CreateWordDocument(object filename, object SaveAs)
        {
            string hocba= "";
            if(checkHocBa.Checked==true)
            {
                hocba = "x";
            }    
            else
            {
                hocba = "";
            }
            string giaychungnhan = "";
            if(checkGiaytrungnhantotnghiep.Checked==true)
            {
                giaychungnhan = "x";
            }    
            else
            {
                giaychungnhan = "";
            }    

            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
               this.FindAndReplace(wordApp, "<fullName>", txtFullName.Text);
               this.FindAndReplace(wordApp, "<birthday>", dateNgaySinh.Text);
               this.FindAndReplace(wordApp, "<phone>",txtPhone.Text);
                this.FindAndReplace(wordApp, "<Registeredindustry>", txtNganhDangKy.Text);
                this.FindAndReplace(wordApp, "<majors>", txtChuyenNganh.Text);
                this.FindAndReplace(wordApp, "<combination>", txtToHopXetTuyen.Text);
                this.FindAndReplace(wordApp, "<point>", txtDiemXetTuyen.Text);
                this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                this.FindAndReplace(wordApp, "<a>", hocba);
                this.FindAndReplace(wordApp, "<b>", giaychungnhan);

            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            CreateWordDocument(@"D:\Documents\GITHUB\WindowsFormApp\Print_Imformation\Print_Imformation\HoSoGDU.docx", @"C:\Users\Acer\OneDrive\Desktop\Sinhvien.docx");
            //OpenFileDialog open = new OpenFileDialog();
            // open.ShowDialog("@C: \Users\Acer\OneDrive\Desktop\Sinhvien.docx");
            string a = @"C:\Users\Acer\OneDrive\Desktop\Sinhvien.docx";
           //mở thằng vào file mình cần mở
            Process.Start(a);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
