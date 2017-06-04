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
            dgvQuanLiGiangDay.ClearSelection();
        }
        private void frmQuanLiGiangDay_Load(object sender, EventArgs e)
        {
            GetThongTinGiangDay();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmThemQuanLiGiangDay frmThem = new frmThemQuanLiGiangDay();
            frmThem.ShowDialog();
            GetThongTinGiangDay();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {            
            DataGridViewRow dgr = dgvQuanLiGiangDay.CurrentRow;
            if (dgvQuanLiGiangDay.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chọn bản ghi cần sửa!");
            }
            else
            {
                QuanLiGiangDay ql = new QuanLiGiangDay();
                ql.MaGiaoVien = dgr.Cells["magiaovien"].Value.ToString();
                ql.MaMonHoc = dgr.Cells["mamonhoc"].Value.ToString();
                ql.MaLop = dgr.Cells["tenlop"].Value.ToString();
                ql.TietHoc = dgr.Cells["tiethoc"].Value.ToString();
                ql.DiaDiem = dgr.Cells["diadiem"].Value.ToString();
                ql.NgayBatDau = DateTime.Parse(dgr.Cells["ngaybatdau"].Value.ToString());
                ql.NgayKetThuc = DateTime.Parse(dgr.Cells["ngayketthuc"].Value.ToString());
                frmThemQuanLiGiangDay frmThem = new frmThemQuanLiGiangDay(ql, true);
                frmThem.ShowDialog();
                GetThongTinGiangDay();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuanLiGiangDay quanli = new QuanLiGiangDay();
            DataGridViewRow dgr = dgvQuanLiGiangDay.CurrentRow;
            if (dgr == null)
            {
                MessageBox.Show("Chọn bản ghi cần xóa!");
            }
            else
            {
                DialogResult res = MessageBox.Show("Bản ghi này sẽ bị xóa!", "Cảnh báo", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    quanli.MaGiaoVien = dgr.Cells["magiaovien"].Value.ToString();
                    quanli.MaMonHoc = dgr.Cells["mamonhoc"].Value.ToString();
                    quanli.MaLop = dgr.Cells["tenlop"].Value.ToString();
                    quanli.TietHoc = dgr.Cells["tiethoc"].Value.ToString();
                    quanli.DiaDiem = dgr.Cells["diadiem"].Value.ToString();
                    quanli.NgayBatDau = DateTime.Parse(dgr.Cells["ngaybatdau"].Value.ToString());
                    quanli.NgayKetThuc = DateTime.Parse(dgr.Cells["ngayketthuc"].Value.ToString());
                    if(ql.Delete(quanli.MaGiaoVien, quanli.MaMonHoc, quanli.MaLop))
                    {
                        MessageBox.Show("Xóa thành công!");
                        GetThongTinGiangDay();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!");
                    }
                }                
            }            
        }
    }
}
