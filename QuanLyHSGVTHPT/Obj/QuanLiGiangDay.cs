using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj
{
    class QuanLiGiangDay
    {
        private string _magiaovien;
        private string _mamonhoc;
        private string _malop;
        private DateTime _ngaybatdau;
        private DateTime _ngayketthuc;

        public string MaGiaoVien
        {
            get
            {
                return _magiaovien;
            }
            set
            {
                _magiaovien = value;
            }
        }

        public string MaMonHoc
        {
            get
            {
                return _mamonhoc;
            }

            set
            {
                _mamonhoc = value;
            }
        }

        public string MaLop
        {
            get
            {
                return _malop;
            }

            set
            {
                _malop = value;
            }
        }

        public DateTime NgayBatdau
        {
            get
            {
                return _ngaybatdau;
            }

            set
            {
                _ngaybatdau = value;
            }
        }

        public DateTime NgayKetThuc
        {
            get
            {
                return _ngayketthuc;
            }

            set
            {
                _ngayketthuc = value;
            }
        }
    }
}
