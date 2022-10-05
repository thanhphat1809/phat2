using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DienThoai
{
    public class DTO_MonHoc
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string SoTC { get; set; }

        public DTO_MonHoc()
        {

        }
        public DTO_MonHoc(string maMH, string tenMH, string soTC)
        {
            MaMH = maMH;
            TenMH = tenMH;
            SoTC = soTC;
        }
    }
}
