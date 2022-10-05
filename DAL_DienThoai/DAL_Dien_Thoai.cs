using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DienThoai
{
    public class DAL_Dien_Thoai : DBConnect
    {
        public DAL_Dien_Thoai()
        {

        }
        public DataTable getDienThoai()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SINHVIEN", _conn);
            DataTable dtThanhvien = new DataTable();
            
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable getMonHoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MONHOC", _conn);
            DataTable dtMonHoc = new DataTable();
            
            da.Fill(dtMonHoc);
            return dtMonHoc;
        }
        public DataTable getKhoa()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHOA", _conn);
            DataTable dtMonHoc = new DataTable();
            
            da.Fill(dtMonHoc);
            return dtMonHoc;
        } 
        public DataTable getLop()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOP", _conn);
            DataTable dtMonHoc = new DataTable();
            
            da.Fill(dtMonHoc);
            return dtMonHoc;
        }
    }
}
