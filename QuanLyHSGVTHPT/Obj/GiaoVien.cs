using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Obj
{
    public class GiaoVien
    {
        private string ma;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string tonGiao;
        private string queQuan;
        private string diaChiThuongChu;
        private string soDienThoai;
        private string hocVi;
        private string chucVu;
        private string chuyenMon;
        private string tinhTrang;
        private string luong;

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string TonGiao
        {
            get
            {
                return tonGiao;
            }

            set
            {
                tonGiao = value;
            }
        }

        public string QueQuan
        {
            get
            {
                return queQuan;
            }

            set
            {
                queQuan = value;
            }
        }

        public string DiaChiThuongChu
        {
            get
            {
                return diaChiThuongChu;
            }

            set
            {
                diaChiThuongChu = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string HocVi
        {
            get
            {
                return hocVi;
            }

            set
            {
                hocVi = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return chucVu;
            }

            set
            {
                chucVu = value;
            }
        }

        public string ChuyenMon
        {
            get
            {
                return chuyenMon;
            }

            set
            {
                chuyenMon = value;
            }
        }

        public string TinhTrang
        {
            get
            {
                return tinhTrang;
            }

            set
            {
                tinhTrang = value;
            }
        }

        public string Luong
        {
            get
            {
                return luong;
            }

            set
            {
                luong = value;
            }
        }


        public GiaoVien(DataRow dr)
        {
            Ma = dr["magiaovien"].ToString();
            HoTen = dr["hovaten"].ToString();
            NgaySinh = DateTime.Parse(dr["ngaysinh"].ToString());
            TonGiao = dr["tongiao"].ToString();
            QueQuan = dr["quequan"].ToString();
            DiaChiThuongChu = dr["diachithuongtru"].ToString();
            SoDienThoai = dr["sodienthoai"].ToString();
            HocVi = dr["hocvi"].ToString();
            ChucVu = dr["chucvu"].ToString();
            ChuyenMon = dr["chuyenmon"].ToString();
            TinhTrang = dr["tinhtrang"].ToString();
            Luong = dr["luong"].ToString();
        }

        public GiaoVien() { }

        public GiaoVien  (GiaoVien gv)
        {
            Ma = gv.Ma;
            HoTen = gv.HoTen;
            NgaySinh = gv.NgaySinh;
            GioiTinh = gv.GioiTinh;
            TonGiao = gv.TonGiao;
            QueQuan = gv.QueQuan;
            DiaChiThuongChu = gv.DiaChiThuongChu;
            SoDienThoai = gv.SoDienThoai;
            HocVi = gv.HocVi;
            ChucVu = gv.ChucVu;
            ChuyenMon = gv.ChuyenMon;
            TinhTrang = gv.TinhTrang;
            Luong = gv.Luong;
        }


    }
}
