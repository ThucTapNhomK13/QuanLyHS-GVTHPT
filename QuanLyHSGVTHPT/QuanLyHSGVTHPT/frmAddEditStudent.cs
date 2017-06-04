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
    public partial class frmAddEditStudent : Form
    {
        private BUSHocSinh bsGV = new BUSHocSinh();

        private bool mv;
        private int x, y;
        //private bool AorE;


        public string Id
        {
            get { return txtMa.Text; }
            set
            {
                if (value == null)
                {
                    //AorE = true;
                    this.txtMa.Clear();
                    this.txtHoTen.Clear();
                    this.txtQueQuan.Clear();
                    this.txtTonGiao.Clear();    
                    this.txtSDT.Clear();
                    this.txtDiaChi.Clear();
                    this.txtHotebo.Clear();
                    this.txtNgheghiepbo.Clear();
                    this.txtHotenme.Clear();
                    this.txtNghenghiepme.Clear();
                }
                else
                {
                    //AorE = false;
                    DataRow dr = bsGV.SelectHocSinhID(value);

                    this.txtMa.Text = dr["mahocsinh"].ToString();
                    this.txtMa.Enabled = false;

                    this.txtHoTen.Text = dr["hovaten"].ToString();
                    this.datNgaySinh.Text = dr["ngaysinh"].ToString();

                    this.cmdGioiTinh.Text = dr["gioitinh"].ToString();
                    this.txtLopma.Text = dr["lopma"].ToString();

                    this.txtTonGiao.Text = dr["tongiao"].ToString();
                    this.txtQueQuan.Text = dr["quequan"].ToString();
                    this.txtDiaChi.Text = dr["diachithuongtru"].ToString();
                    this.txtSDT.Text = dr["sodienthoai"].ToString();
                    this.txtHotebo.Text = dr["hotenbo"].ToString();
                    this.txtNgheghiepbo.Text = dr["nghenghiepbo"].ToString();
                    this.txtHotenme.Text = dr["hotenme"].ToString();
                    this.txtNghenghiepme.Text = dr["nghenghiepme"].ToString();
                }
            }
        }

        public HocSinh getHocSinh()
        {
            HocSinh hs = new HocSinh();
            hs.mahocsinh = txtMa.Text;
            hs.hocvaten = XuLyChuoi.VietHoaChuCaiDau(txtHoTen.Text);
            hs.ngaysinh = DateTime.Parse(datNgaySinh.Text);
            hs.gioitinh = XuLyChuoi.VietHoaChuCaiDau(cmdGioiTinh.Text);
            hs.tongiao = XuLyChuoi.VietHoaChuCaiDau(txtTonGiao.Text);
            hs.quequan = XuLyChuoi.VietHoaChuCaiDau(txtQueQuan.Text);
            hs.diachithuongtru = XuLyChuoi.VietHoaChuCaiDau(txtDiaChi.Text);
            hs.hotenbo = XuLyChuoi.VietHoaChuCaiDau(txtHotebo.Text);
            hs.nghenghiepbo = XuLyChuoi.VietHoa(txtNgheghiepbo.Text);
            hs.sodienthoai = txtSDT.Text;
            hs.hotenme = XuLyChuoi.VietHoa(txtHotenme.Text);
            hs.hotenbo = XuLyChuoi.VietHoa(txtHotebo.Text);
            hs.lopma = txtLopma.Text;
            return hs;
        }

        public frmAddEditStudent()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mv)
                SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmAddEdit_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mv = false;
        }
    }
}
