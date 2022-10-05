using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DienThoai
{
    public class DTO_KetQua
    {
        public string MaSV { get; set; }
        public string MaMh { get; set; }
        public float Diem { get; set; }

        public int LanThi { get; set; }
        public int HocKi { get; set; }

        public string NamHoc { get; set; }


        public DTO_KetQua()
        {

        }
        public DTO_KetQua(string maSV, string maMh, float diem, int lanThi, int hocKi, string namHoc)
        {
            MaSV = maSV;
            MaMh = maMh;
            Diem = diem;
            LanThi = lanThi;
            HocKi = hocKi;
            NamHoc = namHoc;
        }
    }
}
