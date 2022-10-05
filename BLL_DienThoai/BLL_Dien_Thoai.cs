using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DienThoai;
using DTO_DienThoai;

namespace BLL_DienThoai
{
    public class BLL_Dien_Thoai
    {
        public DAL_Dien_Thoai dal_DienThoai { get; set; }

        public BLL_Dien_Thoai()
        {
            this.dal_DienThoai = new DAL_Dien_Thoai();
        }

        public DataTable getDienThoai()
        {
            return this.dal_DienThoai.getDienThoai();
        }
        public DataTable getMonHoc()
        {
            return this.dal_DienThoai.getMonHoc();
        }
        public DataTable getKhoa()
        {
            return this.dal_DienThoai.getKhoa();
        } 
        public DataTable getLop()
        {
            return this.dal_DienThoai.getLop();
        }
    }
}
