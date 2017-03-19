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
            frmQuanLyGiaoVien qlgv = new frmQuanLyGiaoVien();
            qlgv.ShowDialog();
        }
    }
}
