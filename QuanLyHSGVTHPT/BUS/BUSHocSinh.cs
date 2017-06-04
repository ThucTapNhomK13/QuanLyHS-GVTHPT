using DAL;
using Obj;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSHocSinh
    {
        private DBConnect con = new DBConnect();

        public DataTable SelectHocSinh()
        {
            string sqlQuery = @"select * from HocSinh ";

            DataTable dt = new DataTable();

            return con.Select(sqlQuery, false, null);
        }

        public DataRow SelectHocSinhID(string id)
        {
            string sqlQuery = @"select * from HocSinh ";
            sqlQuery += " where mahocsinh = @ma";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ma", id);

            return con.Select(sqlQuery, false, parameters).AsEnumerable().First();
        }

        public bool InsertHocSinh(HocSinh gv)
        {
            string sqlQuery = @" if not exists ";
            sqlQuery += " ( select * from HocSinh where mahocsinh = @ma) ";
            sqlQuery += " insert into HocSinh ";
            sqlQuery += " values ";
            sqlQuery += " ( @mahocsinh, @hocvaten, @ngaysinh, @gioitinh, @tongiao, @quequan, ";
            sqlQuery += " @diachithuongtru, @hotenbo, @nghenghiepbo, @hotenme, @nghenghiepme, @sodienthoai, @lopma ) ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@mahocsinh", gv.mahocsinh);
            parameters.Add("@hocvaten", gv.hocvaten);
            parameters.Add("@ngaysinh", gv.ngaysinh);
            parameters.Add("@gioitinh", gv.gioitinh);
            parameters.Add("@tongiao", gv.tongiao);
            parameters.Add("@quequan", gv.quequan);
            parameters.Add("@diachithuongtru", gv.diachithuongtru);
            parameters.Add("@hotenbo", gv.hotenbo);
            parameters.Add("@nghenghiepbo", gv.nghenghiepbo);
            parameters.Add("@hotenme", gv.hotenme);
            parameters.Add("@nghenghiepme", gv.nghenghiepme);
            parameters.Add("@sodienthoai", gv.sodienthoai);
            parameters.Add("@lopma", gv.lopma);

            return con.InsertUpdateDelete(sqlQuery, false, parameters);
        }

        public bool UpdateHocSinh(HocSinh gv)
        {
            string sqlQuery = @"UPDATE HocSinh ";
            sqlQuery += " SET ";
            sqlQuery += " hocvaten = @hocvaten ";
            sqlQuery += ", ngaysinh = @ngaysinh ";
            sqlQuery += ", gioitinh = @gioitinh ";
            sqlQuery += ", tongiao = @tongiao ";
            sqlQuery += ", quequan = @quequan";
            sqlQuery += ", diachithuongtru = @diachithuongtru";
            sqlQuery += ", hotenbo = @hotenbo";
            sqlQuery += ", nghenghiepbo = @nghenghiepbo";
            sqlQuery += ", hotenme = @hotenme";
            sqlQuery += ", nghenghiepme = @nghenghiepme";
            sqlQuery += ", sodienthoai = @sodienthoai";
            sqlQuery += ", lopma = @lopma";
            sqlQuery += " WHERE mahocsinh = @mahocsinh ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@mahocsinh", gv.mahocsinh);
            parameters.Add("@hocvaten", gv.hocvaten);
            parameters.Add("@ngaysinh", gv.ngaysinh);
            parameters.Add("@gioitinh", gv.gioitinh);
            parameters.Add("@tongiao", gv.tongiao);
            parameters.Add("@quequan", gv.quequan);
            parameters.Add("@diachithuongtru", gv.diachithuongtru);
            parameters.Add("@hotenbo", gv.hotenbo);
            parameters.Add("@nghenghiepbo", gv.nghenghiepbo);
            parameters.Add("@hotenme", gv.hotenme);
            parameters.Add("@nghenghiepme", gv.nghenghiepme);
            parameters.Add("@sodienthoai", gv.sodienthoai);
            parameters.Add("@lopma", gv.lopma);

            return con.InsertUpdateDelete(sqlQuery, false, parameters);
        }

        public bool DeleteHocSinh(string id)
        {
            string sqlQuery = " delete HocSinh ";
            sqlQuery += " where mahocsinh = @mahocsinh";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@mahocsinh", id);

            return con.InsertUpdateDelete(sqlQuery, false, para);
        }

        public DataTable Search(string txt)
        {
            string sqlQuery = " select * from HocSinh ";
            sqlQuery += " where ";
            sqlQuery += " mahocsinh like '%'+@ma+'%' ";
            sqlQuery += " union ";
            sqlQuery += " select * from HocSinh ";
            sqlQuery += " where ";
            sqlQuery += " hocvaten like '%'+@hoten+'%' ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ma", txt);
            parameters.Add("@hoten", txt);

            return con.Select(sqlQuery, false, parameters);
        }



    }
}
