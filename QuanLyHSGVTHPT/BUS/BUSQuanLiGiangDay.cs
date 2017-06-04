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

        public bool Insert(QuanLiGiangDay ql)
        {
            string sql = "if not exists(select * from QuanLiGiangDay where giaovienma = @giaovienma and monhocma = @monhocma and lopma = @lopma) insert into QuanLiGiangDay values(@giaovienma, @monhocma, @lopma, @ngaybatdau, @ngayketthuc, @tiethoc, @diadiem)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@giaovienma", ql.MaGiaoVien);
            parameters.Add("@monhocma", ql.MaMonHoc);
            parameters.Add("@lopma", ql.MaLop);
            parameters.Add("@ngaybatdau", ql.NgayBatDau);
            parameters.Add("@ngayketthuc", ql.NgayKetThuc);
            parameters.Add("@tiethoc", ql.TietHoc);
            parameters.Add("@diadiem", ql.DiaDiem);

            return con.InsertUpdateDelete(sql, false, parameters);
        }

        public bool Update(QuanLiGiangDay ql)
        {
            string sql = "update QuanLiGiangDay set giaovienma = @giaovienma, monhocma = @monhocma, lopma = @lopma, ngaybatdau=@ngaybatdau, ngayketthuc=@ngayketthuc, tiethoc=@tiethoc, diadiem=@diadiem where giaovienma = @giaovienma and monhocma = @monhocma and lopma = @lopma";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@giaovienma", ql.MaGiaoVien);
            parameters.Add("@monhocma", ql.MaMonHoc);
            parameters.Add("@lopma", ql.MaLop);
            parameters.Add("@ngaybatdau", ql.NgayBatDau);
            parameters.Add("@ngayketthuc", ql.NgayKetThuc);
            parameters.Add("@tiethoc", ql.TietHoc);
            parameters.Add("@diadiem", ql.DiaDiem);

            return con.InsertUpdateDelete(sql, false, parameters);
        }

        public bool Delete(string giaovienma, string monhocma, string lopma)
        {
            string sql = "delete from QuanLiGiangDay where giaovienma = @giaovienma and monhocma = @monhocma and lopma = @lopma";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@giaovienma", giaovienma);
            parameters.Add("@monhocma", monhocma);
            parameters.Add("@lopma", lopma);

            return con.InsertUpdateDelete(sql, false, parameters);
        }
    }
}
