using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoaDonGian
{
    class MaHoa
    {
        CommonProcess cProcess = null; 
    }
    public MaHoa(int algorithm_number, frmMaHoaGiaiMa.ProgressEventHandler IncrementProgress, frmMaHoaGiaiMa.ProgressInitHandler InitProgress)
    {
        if (CacGiaiThuat.DES == algorithm_number || CacGiaiThuat.DES_File == algorithm_number)
        {
            cProcess = new DES.ProcessDES(IncrementProgress, InitProgress);
        }
        else
        {
            cProcess = new AES.ProcessAES(IncrementProgress, InitProgress);
        }
    }

}
