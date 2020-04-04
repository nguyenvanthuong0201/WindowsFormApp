using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmBaiToan1 : Form
    {
        public frmBaiToan1()
        {
            InitializeComponent();
        }
        
       private bool KiemTraHopLe(string s )///Khai báo kiểm tra kí tự viết HOA mới hợp lệ////
        {
            
            bool HopLe = true;
            for (int i = 0; i <s.Length; i++)
            {
                char c = s[i];
                if (c < 'A' || c > 'Z')
                {
                    HopLe = false;
                    break;
                }
       
            }
            return HopLe;

        }

        private void txtBanTinRo_TextChanged(object sender, EventArgs e) ///Kiểm Tra TEXTBOX có hợp lệ không
        {
            btnMaHoa.Enabled = KiemTraHopLe(txtBanTinRo.Text);
        }

        private void txtBanTinDuocMaHoa_TextChanged(object sender, EventArgs e)///Kiểm Tra TEXTBOX có hợp lệ không
        {
            btnGiaiMa.Enabled = KiemTraHopLe(txtBanTinDuocMaHoa.Text);
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < txtBanTinRo.Text.Length; i++)
            {
                char c = txtBanTinRo.Text[i];
                int n = (int)c;
                // MessageBox.Show((nudSoViTri.Value).ToString());
                c = (Char)((n-65 + (int)(nudSoViTri.Value))%26 + 65);
                s += c; // s = s + c     
            } txtBanTinDuocMaHoa.Text= s;
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            string s = ""; for (int i = 0; i < txtBanTinDuocMaHoa.Text.Length; i++)
            {
                char c = txtBanTinDuocMaHoa.Text[i]; int n = (int)c;// MessageBox.Show((nudSoViTri.Value).ToString());
                c = (Char)((n - 65 -(int)(nudSoViTri.Value)+26) % 26 + 65);s += c; // s = s + c   
            } txtBanTinDuocGiaiMa.Text = s;
        }

        private void frmBaiToan1_Load(object sender, EventArgs e)
        {

        }
    }
}
       
