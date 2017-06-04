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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void menuquanlygiaovien_Click(object sender, EventArgs e)
        {
           
        }

        private void menuhuongdansudung_Click(object sender, EventArgs e)
        {
            
        }

        private void menuquanlygiangday_Click(object sender, EventArgs e)
        {
            

        }

        private void itemthemhocsinh_Click(object sender, EventArgs e)
        {
            frmQuanLiHocSinh ql = new frmQuanLiHocSinh();
            ql.ShowDialog();
        }

        private void quảnLíGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiGiaoVien qlgv = new frmQuanLiGiaoVien();
            qlgv.ShowDialog();
        }

        private void quảnLiGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiGiangDay ql = new frmQuanLiGiangDay();
            ql.ShowDialog();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }
    }
}
