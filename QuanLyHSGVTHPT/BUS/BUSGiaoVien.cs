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
    public class BUSGiaoVien
    {
        private DBConnect con = new DBConnect();

        public DataTable SelectGiaoVien ()
        {
            string sqlQuery = @"select * from GiaoVien ";

            DataTable dt = new DataTable();

            return con.Select(sqlQuery, false, null);
        }

        public DataRow SelectGiaoVienID (string id)
        {
            string sqlQuery = @"select * from GiaoVien ";
            sqlQuery += " where magiaovien = @ma";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ma", id);

            return con.Select(sqlQuery, false, parameters).AsEnumerable().First();
        }

        public bool InsertGiaoVien (GiaoVien gv)
        {
            string sqlQuery = @" if not exists ";
            sqlQuery += " ( select * from GiaoVien where magiaovien = @ma) ";
            sqlQuery += " insert into GiaoVien ";
            sqlQuery += " values ";
            sqlQuery += " ( @ma, @hoten, @ngaysinh, @gioitinh, @tongiao, @quequan, ";
            sqlQuery += " @diachi, @sdt, @hocvi, @chucvu, @chuyenmon, @tinhtrang, @luong ) ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@ma", gv.Ma);
            parameters.Add("@hoten", gv.HoTen);
            parameters.Add("@ngaysinh", gv.NgaySinh);
            parameters.Add("@gioitinh", gv.GioiTinh);
            parameters.Add("@tongiao", gv.TonGiao);
            parameters.Add("@quequan", gv.QueQuan);
            parameters.Add("@diachi", gv.DiaChiThuongChu);
            parameters.Add("@sdt", gv.SoDienThoai);
            parameters.Add("@hocvi", gv.HocVi);
            parameters.Add("@chucvu", gv.ChucVu);
            parameters.Add("@chuyenmon", gv.ChuyenMon);
            parameters.Add("@tinhtrang", gv.TinhTrang);
            parameters.Add("@luong", gv.Luong);

            return con.InsertUpdateDelete(sqlQuery, false, parameters);
        }

        public bool UpdateGiaoVien (GiaoVien gv)
        {
            string sqlQuery = @"UPDATE GiaoVien ";
            sqlQuery += " SET ";
            sqlQuery += " hovaten = @hoten ";
            sqlQuery += ", ngaysinh = @ngaysinh ";
            sqlQuery += ", gioitinh = @gioitinh ";
            sqlQuery += ", tongiao = @tongiao ";
            sqlQuery += ", quequan = @quequan";
            sqlQuery += ", diachithuongtru = @diachi";
            sqlQuery += ", sodienthoai = @sdt";
            sqlQuery += ", hocvi = @hocvi";
            sqlQuery += ", chucvu = @chucvu";
            sqlQuery += ", chuyenmon = @chuyenmon";
            sqlQuery += ", tinhtrang = @tinhtrang";
            sqlQuery += ", luong = @luong";
            sqlQuery += " WHERE magiaovien = @ma ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@ma", gv.Ma);
            parameters.Add("@hoten", gv.HoTen);
            parameters.Add("@ngaysinh", gv.NgaySinh);
            parameters.Add("@gioitinh", gv.GioiTinh);
            parameters.Add("@tongiao", gv.TonGiao);
            parameters.Add("@quequan", gv.QueQuan);
            parameters.Add("@diachi", gv.DiaChiThuongChu);
            parameters.Add("@sdt", gv.SoDienThoai);
            parameters.Add("@hocvi", gv.HocVi);
            parameters.Add("@chucvu", gv.ChucVu);
            parameters.Add("@chuyenmon", gv.ChuyenMon);
            parameters.Add("@tinhtrang", gv.TinhTrang);
            parameters.Add("@luong", gv.Luong);

            return con.InsertUpdateDelete(sqlQuery, false, parameters);
        }

        public bool DeleteGiaoVien (string id)
        {
            string sqlQuery = " delete GiaoVien ";
            sqlQuery += " where magiaovien = @ma";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@ma", id);

            return con.InsertUpdateDelete(sqlQuery, false, para);
        }

        public DataTable Search (string txt)
        {
            string sqlQuery = " select * from GiaoVien ";
            sqlQuery += " where ";
            sqlQuery += " magiaovien like '%'+@ma+'%' ";
            sqlQuery += " union ";
            sqlQuery += " select * from GiaoVien ";
            sqlQuery += " where ";
            sqlQuery += " hovaten like '%'+@hoten+'%' ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ma", txt);
            parameters.Add("@hoten", txt);

            return con.Select(sqlQuery, false, parameters);
        }



    }
}
