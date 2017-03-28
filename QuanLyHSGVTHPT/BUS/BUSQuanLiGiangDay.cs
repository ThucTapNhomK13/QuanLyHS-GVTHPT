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
    class BUSQuanLiGiangDay
    {
        private DBConnect con = new DBConnect();

        public DataTable GetLichGiangDay()
        {
            string sql = "select * from QuanLiGiangDay";
            return con.Select(sql, false, null);
        }


    }
}
