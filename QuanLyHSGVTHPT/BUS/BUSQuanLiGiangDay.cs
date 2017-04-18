using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using DAL;
using Obj;

namespace BUS
{
    public class BUSQuanLiGiangDay
    {
        private DBConnect con = new DBConnect();

        public DataTable GetLichGiangDay()
        {
            string sql = "select * from func_ThoiKhoaBieu()";
            return con.Select(sql, false, null);
        }

        public DataTable GetGiaoVien()
        {
            string sql = "select gv.magiaovien, gv.hovaten from GiaoVien gv";
            return con.Select(sql, false, null);
        }

        public DataTable GetMonHoc()
        {
            string sql = "select mh.mamonhoc, mh.tenmonhoc from MonHoc mh";
            return con.Select(sql, false, null);
        }

        public DataTable GetLop()
        {
            string sql = "select l.malop from Lop l";
            return con.Select(sql, false, null);
        }
    }
}
