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
        private DataTable dtgiaovien = new DataTable();
        private DataTable dtmonhoc = new DataTable();
        private DataTable dtlop = new DataTable();
        public frmThemQuanLiGiangDay()
        {
            InitializeComponent();
        }

        public void GetThongTinGiangDay()
        {
            dtgiaovien = ql.GetGiaoVien();
            cmbTenGiaoVien.DataSource = dtgiaovien;
            cmbTenGiaoVien.DisplayMember = "hovaten";
            cmbTenGiaoVien.ValueMember = "hovaten";
            
            dtmonhoc = ql.GetMonHoc();
            cmbMonHoc.DataSource = dtmonhoc;
            cmbMonHoc.DisplayMember = "tenmonhoc";
            cmbMonHoc.ValueMember = "tenmonhoc";

            dtlop = ql.GetLop();
            cmbTenLop.DataSource = dtlop;
            cmbTenLop.DisplayMember = "malop";
            cmbTenLop.ValueMember = "malop";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

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
