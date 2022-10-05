using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DienThoai
{
    public class DTO_SinhVien
    {
        public string MaSV { get; set; }

        public string HoSV { get; set; }
        public string TenSV { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool Phai { get; set; }
        public string MaLop { get; set; }
        public string MaKH { get; set; }

        public DTO_SinhVien()
        {       
        
        }
         public DTO_SinhVien(string maSV, string hoSV, string tenSV, DateTime ngaySing, bool phai, string maLop,string maKH)
        {
            MaSV = maSV;
            HoSV = hoSV;
            TenSV = tenSV;
            NgaySinh = ngaySing;
            Phai = phai;
            MaLop = maLop;
            MaKH = maKH;
        }



    }
}
