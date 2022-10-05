using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_DienThoai;

namespace DAL_DienThoai
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-Q2JS3D3\\MSSQLSERVER01;Initial Catalog=qlsv;Integrated Security=True");
    }
}
