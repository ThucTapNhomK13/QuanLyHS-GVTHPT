using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Obj;
using BUS;


namespace QuanLyHSGVTHPT
{
    public partial class frmAddEdit : Form
    {
        private BUSGiaoVien bsGV = new BUSGiaoVien();

        private bool mv;
        private int x, y;
        //private GiaoVien gv;

        public string Id
        {
            get { return txtMa.Text; }
            set
            {
                if (value == null)
                {
                    this.txtMa.Clear();
                    this.txtHoTen.Clear();
                    this.txtQueQuan.Clear();
                    this.txtSDT.Clear();
                    this.txtDiaChi.Clear();
                    this.txtChucVu.Clear();
                    this.txtChuyenMon.Clear();
                    this.txtTonGiao.Clear();
                    this.txtLuong.Clear();
                }
                else
                {
                    DataRow dr = bsGV.SelectGiaoVienID(value);
                    this.txtMa.Text = dr["magiaovien"].ToString();
                    this.txtHoTen.Text = dr["hovaten"].ToString();
                    this.datNgaySinh.Text = dr["ngaysinh"].ToString();

                    this.cmdGioiTinh.Text = dr["gioitinh"].ToString();
                    this.cmdTinhTrang.Text = dr["tinhtrang"].ToString();
                   
                    this.txtTonGiao.Text = dr["tongiao"].ToString();
                    this.txtQueQuan.Text = dr["quequan"].ToString();
                    this.txtDiaChi.Text = dr["diachithuongtru"].ToString();
                    this.txtSDT.Text = dr["sodienthoai"].ToString();
                    this.txtHocVi.Text = dr["hocvi"].ToString();
                    this.txtChucVu.Text = dr["chucvu"].ToString();
                    this.txtChuyenMon.Text = dr["chuyenmon"].ToString();
                    this.txtLuong.Text = dr["luong"].ToString();
                }
            }
        }

        public GiaoVien getGiaoVien ()
        {
            GiaoVien gv = new GiaoVien();
            gv.Ma = txtMa.Text;
            gv.HoTen = txtHoTen.Text ;
            gv.NgaySinh = DateTime.Parse( datNgaySinh.Text) ;

            gv.GioiTinh = cmdGioiTinh.Text ;
            gv.TinhTrang = cmdTinhTrang.Text ;

            gv.TonGiao = txtTonGiao.Text;
            gv.QueQuan = txtQueQuan.Text;
            gv.DiaChiThuongChu = txtDiaChi.Text ;
            gv.SoDienThoai = txtSDT.Text ;
            gv.HocVi = txtHocVi.Text ;
            gv.ChucVu = txtChucVu.Text;
            gv.ChuyenMon = txtChuyenMon.Text;
            gv.Luong = txtLuong.Text ;

            return gv;
        }

        public frmAddEdit()
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
