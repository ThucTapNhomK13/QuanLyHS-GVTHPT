using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj
{
    public class HocSinh
    {
        public string mahocsinh { get; set; }
        public string hocvaten { get; set; }
        public DateTime ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string tongiao { get; set; }
        public string quequan { get; set; }
        public string diachithuongtru { get; set; }
        public string hotenbo { get; set; }
        public string nghenghiepbo { get; set; }
        public string hotenme { get; set; }
        public string nghenghiepme { get; set; }
        public string sodienthoai { get; set; }
        public string lopma { get; set; }
        public HocSinh(DataRow dr)
        {
            this.mahocsinh = dr["magiaovien"].ToString();
            this.hocvaten = dr["hovaten"].ToString();
            this.ngaysinh = DateTime.Parse(dr["ngaysinh"].ToString());
            this.gioitinh = dr["gioitinh"].ToString();
            this.tongiao = dr["tongiao"].ToString();
            this.quequan = dr["quequan"].ToString();
            this.diachithuongtru = dr["diachithuongtru"].ToString();
            this.hotenbo = dr["hotenbo"].ToString();
            this.nghenghiepbo = dr["nghenghiepbo"].ToString();                     
            this.hotenme = dr["hotenme"].ToString();           
            this.nghenghiepme = dr["nghenghiepme"].ToString();
            this.sodienthoai = dr["sodienthoai"].ToString();
            this.lopma = dr["lopma"].ToString();
        }

        public HocSinh() { }

        public HocSinh(HocSinh hs)
        {
            this.mahocsinh = hs.mahocsinh;
            this.hocvaten = hs.hocvaten;
            this.ngaysinh = hs.ngaysinh;
            this.gioitinh = hs.gioitinh;
            this.tongiao = hs.tongiao;
            this.quequan = hs.quequan;
            this.diachithuongtru = hs.diachithuongtru;
            this.hotenbo = hs.hotenbo;
            this.nghenghiepbo = hs.nghenghiepbo;
            this.hotenme = hs.hotenme;
            this.nghenghiepme = hs.nghenghiepme;
            this.sodienthoai = hs.sodienthoai;
            this.lopma = hs.lopma;
        }
    }
}
