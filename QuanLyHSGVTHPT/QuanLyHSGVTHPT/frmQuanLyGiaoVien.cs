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
    public partial class frmQuanLyGiaoVien : Form
    {

        bool mv;
        int x, y;
        private BUSGiaoVien bsGV = new BUSGiaoVien();


        private void GetAll()
        {
            dgvGiaoVien.DataSource = bsGV.SelectGiaoVien();
        }


        public frmQuanLyGiaoVien()
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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEdit fmAE = new frmAddEdit())
            {
                fmAE.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (frmAddEdit fmAE = new frmAddEdit())
            {
                fmAE.ShowDialog();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mv)
                SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }
    }
}
