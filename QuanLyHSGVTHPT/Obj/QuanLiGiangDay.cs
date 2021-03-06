﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj
{
    public class QuanLiGiangDay
    {
        private string _magiaovien;
        private string _mamonhoc;
        private string _malop;
        private string _tiethoc;
        private string _diadiem;
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

        public string TietHoc
        {
            get
            {
                return _tiethoc;
            }

            set
            {
                _tiethoc = value;
            }
        }

        public string DiaDiem
        {
            get
            {
                return _diadiem;
            }

            set
            {
                _diadiem = value;
            }
        }

        public DateTime NgayBatDau
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
