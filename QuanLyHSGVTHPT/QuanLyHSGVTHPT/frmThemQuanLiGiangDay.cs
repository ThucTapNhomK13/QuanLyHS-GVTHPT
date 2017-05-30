using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using Obj;

namespace QuanLyHSGVTHPT
{
    public partial class frmThemQuanLiGiangDay : Form
    {
        private BUSQuanLiGiangDay ql = new BUSQuanLiGiangDay();
        QuanLiGiangDay quanli = new QuanLiGiangDay();
        private DataTable dtgiaovien = new DataTable();
        private DataTable dtmonhoc = new DataTable();
        private DataTable dtlop = new DataTable();
        private bool isupdate = false;
        public frmThemQuanLiGiangDay()
        {
            InitializeComponent();
        }
        public frmThemQuanLiGiangDay(QuanLiGiangDay ql, bool update)
        {
            quanli.MaGiaoVien = ql.MaGiaoVien;
            quanli.MaMonHoc = ql.MaMonHoc;
            quanli.MaLop = ql.MaLop;
            quanli.TietHoc = ql.TietHoc;
            quanli.DiaDiem = ql.DiaDiem;
            quanli.NgayBatDau = ql.NgayBatDau;
            quanli.NgayKetThuc = ql.NgayKetThuc;
            isupdate = update;
            InitializeComponent();
        }

        public void GetThongTinGiangDay()
        {
            dtgiaovien = ql.GetGiaoVien();
            cmbTenGiaoVien.DataSource = dtgiaovien;
            cmbTenGiaoVien.DisplayMember = "hovaten";
            cmbTenGiaoVien.ValueMember = "magiaovien";
            
            dtmonhoc = ql.GetMonHoc();
            cmbMonHoc.DataSource = dtmonhoc;
            cmbMonHoc.DisplayMember = "tenmonhoc";
            cmbMonHoc.ValueMember = "mamonhoc";

            dtlop = ql.GetLop();
            cmbTenLop.DataSource = dtlop;
            cmbTenLop.DisplayMember = "malop";
            cmbTenLop.ValueMember = "malop";
        }

        public QuanLiGiangDay getQuanLiGiangDay()
        {
            QuanLiGiangDay ql = new QuanLiGiangDay();
            ql.MaGiaoVien = cmbTenGiaoVien.SelectedItem.ToString();
            ql.MaMonHoc = cmbMonHoc.SelectedItem.ToString();
            ql.MaLop = cmbTenLop.SelectedValue.ToString();
            ql.NgayBatDau = datNgayBatDau.Value;
            ql.NgayKetThuc = datNgayKetThuc.Value;
            ql.TietHoc = txtTietHoc.Text;
            ql.DiaDiem = txtDiaDiem.Text;
            return ql;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLiGiangDay quanli = getQuanLiGiangDay();
            if(isupdate)
            {

                if(ql.Update(quanli))
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ql.Insert(quanli))
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemQuanLiGiangDay_Load(object sender, EventArgs e)
        {
            GetThongTinGiangDay();
        }
    }
}
