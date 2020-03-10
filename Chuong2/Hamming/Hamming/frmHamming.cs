using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamming
{
    public partial class frmHamming : Form
    {
        public frmHamming()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        #region các phương thức
        private bool HexHopLe(char c)
        {
           return ((c >= '0' && c <= '9') || (c > 'A') || (c <= 'F'));
        }
        private bool HexStrHopLe(string s)
        {
            if (s.Length != 16)
                return false;
            for (int i = 0; i < s.Length; i++)
                if (!HexHopLe(s[i])) return false;
            return true;
        }
        private int HexToInt(char c)
        {
            return (c < 'A') ? c - 48 : c - 55;
        }
        private char IntToHex( int n)
        {
            return (n <= 9) ? (char)(n + 48) : (char)(n + 55);
        }
        private string HexToBinStr(char c)
        {
            int n = HexToInt(c);
            string s = "";
            for (int i = 0; i < 4; i++)
            {
                string d = (n % 2 == 1) ? "1" : "0";
                s = d + s; n /= 2;
            }
            return s;
        }
        private string HexStrToBinStr(string s)
        {
            string kq = "";
            for (int i = 0; i < s.Length; i++)
                kq += HexToBinStr(s[i]);
            return kq;
        }
        private char HexXorHex(char c1,char c2)
        {
            int n1 = HexToInt(c1);
            int n2 = HexToInt(c2);
            return IntToHex(n1 ^ n2); // ^ là Bitwise XOR
        }
        private string HexStrXorHexStr(string s1,string s2)
        {
            string s = "";
            for (int i = 0; i < s1.Length; i++)
                s += HexXorHex(s1[i], s2[i]);
            return s;
        }
        private int BinStrToTrongSoHamming(string s)
        {
            int count = 0; // Trọng s ố của dãy số nhị phân 
            for (int i = 0; i < s.Length; i++)
                if (s[i] == '1') count++;
            return count;
        }

        private int BinStrKhoangCachHamming(string s1,string s2)
        {
            int count = 0;// Khoảng cách Hamming giữa hai dãy nhị phân
            for (int i = 0; i < s1.Length; i++)
                if (s1[i] != s2[i])
                    count++;
            return count;
        }




        #endregion

        private void txtHexStr_TextChanged(object sender, EventArgs e)
        {
            btnTinhToan.Enabled = HexStrHopLe(txtAHexStr.Text) && HexStrHopLe(txtBHexStr.Text);
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            txtABinStr.Text = HexStrToBinStr(txtAHexStr.Text);
            txtATrongSo.Text = BinStrToTrongSoHamming(txtABinStr.Text).ToString();
            txtBBinStr.Text = HexStrToBinStr(txtBHexStr.Text);
            txtBTrongSo.Text = BinStrToTrongSoHamming(txtBBinStr.Text).ToString();
            txtAxorBHexStr.Text = HexStrXorHexStr(txtAHexStr.Text, txtBHexStr.Text);
            txtAxorBBinStr.Text = HexStrToBinStr(txtAxorBHexStr.Text);
            int TrongSoAxorB = BinStrToTrongSoHamming(txtAxorBBinStr.Text);
            int KhoangCachHammingAvaB = BinStrKhoangCachHamming(txtABinStr.Text, txtBBinStr.Text);
            txtKhoangCach.Text = KhoangCachHammingAvaB.ToString();
            if (TrongSoAxorB == KhoangCachHammingAvaB)
                MessageBox.Show("Chương trình Hamming tính đúng trọng sốvà khoảng cách", this.Text);
            else
                MessageBox.Show("Chương trình bị lỗi sai", this.Text);
        }

        private void btmDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
