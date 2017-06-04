using BUS;
using Obj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHSGVTHPT
{
    public partial class frmQuanLiHocSinh : Form
    {

        bool mv;
        int x, y;
        private BUSHocSinh bsHs = new BUSHocSinh();

        private void GetAll()
        {
            dgvHocSinh.DataSource = bsHs.SelectHocSinh();
        }

        //private void GetSearch ()
        //{
        //    dgvHocSinh.DataSource = bsHs.Search(txtTimKiem.Text);
        //}

        public frmQuanLiHocSinh()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mv = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mv = false;
        }

        private void frmQuanLyHocSinh_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = bsHs.Search(txtTimKiem.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEditStudent fmAE = new frmAddEditStudent())
            {
                fmAE.Id = null;
                if (fmAE.ShowDialog() == DialogResult.OK)
                {
                    HocSinh hs = fmAE.getHocSinh();
                    if (bsHs.InsertHocSinh(hs))
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    return;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (frmAddEditStudent fmAE = new frmAddEditStudent())
            {
                int selectIndex = dgvHocSinh.SelectedRows[0].Index;
                string id = dgvHocSinh[0, selectIndex].Value.ToString();

                fmAE.Id = id;
                if (fmAE.ShowDialog() == DialogResult.OK)
                {
                    HocSinh gv = fmAE.getHocSinh();
                    if (bsHs.UpdateHocSinh(gv))
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectIndex = dgvHocSinh.SelectedRows[0].Index;
            string id = dgvHocSinh[0, selectIndex].Value.ToString();

            if (bsHs.DeleteHocSinh(id))
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Black;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            using (frmAddEditStudent fmAE = new frmAddEditStudent())
            {
                fmAE.Id = null;
                if (fmAE.ShowDialog() == DialogResult.OK)
                {
                    HocSinh gv = fmAE.getHocSinh();
                    if (bsHs.InsertHocSinh(gv))
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    return;

            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            using (frmAddEditStudent fmAE = new frmAddEditStudent())
            {
                int selectIndex = dgvHocSinh.CurrentRow.Index;

                if (selectIndex < 0)
                {
                    MessageBox.Show("Chọn bản ghi cần sửa!");
                }
                else
                {
                    string id = dgvHocSinh[0, selectIndex].Value.ToString();
                    fmAE.Id = id;
                    if (fmAE.ShowDialog() == DialogResult.OK)
                    {
                        HocSinh hs = fmAE.getHocSinh();
                        if (bsHs.UpdateHocSinh(hs))
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        return;
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int selectIndex = dgvHocSinh.CurrentRow.Index;       
            string id = dgvHocSinh[0, selectIndex].Value.ToString();

            if (bsHs.DeleteHocSinh(id))
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            GetAll();
        }

        private void frmQuanLiHocSinh_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = bsHs.Search(txtTimKiem.Text);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mv)
                SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}