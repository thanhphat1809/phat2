using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DienThoai
{
    public class DTO_Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaKH { get; set; }

        public DTO_Lop()
        {

        }
        public DTO_Lop(string maLop, string tenLop, string maKH) 
        {
            MaKH = maLop;
                TenLop = tenLop;
                MaLop = maLop;
        }
    }
}
