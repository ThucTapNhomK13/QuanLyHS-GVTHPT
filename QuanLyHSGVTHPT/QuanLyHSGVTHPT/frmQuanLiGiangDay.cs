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
    public partial class frmQuanLiGiangDay : Form
    {
        private BUSQuanLiGiangDay ql = new BUSQuanLiGiangDay();
        public frmQuanLiGiangDay()
        {
            InitializeComponent();
        }

        public void GetThongTinGiangDay()
        {
            dgvQuanLiGiangDay.DataSource = ql.GetLichGiangDay();
        }
        private void frmQuanLiGiangDay_Load(object sender, EventArgs e)
        {
            GetThongTinGiangDay();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
