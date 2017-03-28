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
            frmQuanLiGiaoVien qlgv = new frmQuanLiGiaoVien();
            qlgv.ShowDialog();
        }

        private void menuhuongdansudung_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }

        private void menuquanlygiangday_Click(object sender, EventArgs e)
        {
            frmQuanLiGiangDay ql = new frmQuanLiGiangDay();
            ql.ShowDialog();

        }
    }
}
