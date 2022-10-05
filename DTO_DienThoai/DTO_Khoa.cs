using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DienThoai
{
    public class DTO_Khoa
    {
        public string MaKH { get; set; }
        public string TenKhoa { get; set; }

        public DTO_Khoa()
        {

        }

        public DTO_Khoa(string maKH, string tenKhoa)
        {
            MaKH = maKH;
            TenKhoa = tenKhoa;
        }
    }
}
