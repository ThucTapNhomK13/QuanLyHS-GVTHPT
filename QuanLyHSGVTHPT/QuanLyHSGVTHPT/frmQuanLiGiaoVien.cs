using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using Obj;

namespace QuanLyHSGVTHPT
{
    public partial class frmQuanLiGiaoVien : Form
    {

        bool mv;
        int x, y;
        private BUSGiaoVien bsGV = new BUSGiaoVien();


        private void GetAll()
        {
            dgvGiaoVien.DataSource = bsGV.SelectGiaoVien();
        }

        //private void GetSearch ()
        //{
        //    dgvGiaoVien.DataSource = bsGV.Search(txtTimKiem.Text);
        //}


        public frmQuanLiGiaoVien()
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

        private void frmQuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvGiaoVien.DataSource = bsGV.Search(txtTimKiem.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEdit fmAE = new frmAddEdit())
            {
                fmAE.Id = null;
                if (fmAE.ShowDialog() == DialogResult.OK)
                {
                    GiaoVien gv = fmAE.getGiaoVien();
                    if (bsGV.InsertGiaoVien(gv))
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
            using (frmAddEdit fmAE = new frmAddEdit())
            {
                int selectIndex = dgvGiaoVien.SelectedRows[0].Index;
                
                if(selectIndex < 0)
                {
                    MessageBox.Show("Chọn bản ghi cần sửa!");
                }
                else
                {
                    string id = dgvGiaoVien[0, selectIndex].Value.ToString();
                    fmAE.Id = id;
                    if (fmAE.ShowDialog() == DialogResult.OK)
                    {
                        GiaoVien gv = fmAE.getGiaoVien();
                        if (bsGV.UpdateGiaoVien(gv))
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        return;
                }               
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectIndex = dgvGiaoVien.SelectedRows[0].Index;
            string id = dgvGiaoVien[0, selectIndex].Value.ToString();

            if (bsGV.DeleteGiaoVien(id))
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mv)
                SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }
    }
}
