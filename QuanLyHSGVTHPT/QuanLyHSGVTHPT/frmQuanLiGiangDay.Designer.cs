namespace QuanLyHSGVTHPT
{
    partial class frmQuanLiGiangDay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvQuanLiGiangDay = new System.Windows.Forms.DataGridView();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLichGiangDay = new System.Windows.Forms.Label();
            this.dgvDanhSachGiaoVien = new System.Windows.Forms.DataGridView();
            this.lblDanhSachGiaoVien = new System.Windows.Forms.Label();
            this.magiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiGiangDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuanLiGiangDay
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanLiGiangDay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuanLiGiangDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLiGiangDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malop,
            this.mamonhoc,
            this.tenmonhoc,
            this.tenlop,
            this.ngaybatdau,
            this.ngayketthuc});
            this.dgvQuanLiGiangDay.Location = new System.Drawing.Point(1, 331);
            this.dgvQuanLiGiangDay.Name = "dgvQuanLiGiangDay";
            this.dgvQuanLiGiangDay.Size = new System.Drawing.Size(688, 210);
            this.dgvQuanLiGiangDay.TabIndex = 0;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "malop";
            this.malop.Name = "malop";
            this.malop.Visible = false;
            // 
            // mamonhoc
            // 
            this.mamonhoc.DataPropertyName = "mamonhoc";
            this.mamonhoc.HeaderText = "mamonhoc";
            this.mamonhoc.Name = "mamonhoc";
            this.mamonhoc.Visible = false;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.Width = 200;
            // 
            // tenlop
            // 
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Tên lớp";
            this.tenlop.Name = "tenlop";
            this.tenlop.Width = 150;
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.DataPropertyName = "ngaybatdau";
            this.ngaybatdau.HeaderText = "Ngày bắt đầu";
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.Width = 150;
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.DataPropertyName = "ngayketthuc";
            this.ngayketthuc.HeaderText = "Ngày kết thúc";
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.Width = 150;
            // 
            // lblLichGiangDay
            // 
            this.lblLichGiangDay.AutoSize = true;
            this.lblLichGiangDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichGiangDay.Location = new System.Drawing.Point(4, 312);
            this.lblLichGiangDay.Name = "lblLichGiangDay";
            this.lblLichGiangDay.Size = new System.Drawing.Size(95, 16);
            this.lblLichGiangDay.TabIndex = 1;
            this.lblLichGiangDay.Text = "Lịch giảng dạy";
            // 
            // dgvDanhSachGiaoVien
            // 
            this.dgvDanhSachGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magiaovien,
            this.tengiaovien,
            this.ngaysinh,
            this.gioitinh});
            this.dgvDanhSachGiaoVien.Location = new System.Drawing.Point(1, 33);
            this.dgvDanhSachGiaoVien.Name = "dgvDanhSachGiaoVien";
            this.dgvDanhSachGiaoVien.Size = new System.Drawing.Size(688, 235);
            this.dgvDanhSachGiaoVien.TabIndex = 2;
            // 
            // lblDanhSachGiaoVien
            // 
            this.lblDanhSachGiaoVien.AutoSize = true;
            this.lblDanhSachGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachGiaoVien.Location = new System.Drawing.Point(4, 15);
            this.lblDanhSachGiaoVien.Name = "lblDanhSachGiaoVien";
            this.lblDanhSachGiaoVien.Size = new System.Drawing.Size(130, 16);
            this.lblDanhSachGiaoVien.TabIndex = 3;
            this.lblDanhSachGiaoVien.Text = "Danh sách giáo viên";
            // 
            // magiaovien
            // 
            this.magiaovien.HeaderText = "Mã giáo viên";
            this.magiaovien.Name = "magiaovien";
            this.magiaovien.ReadOnly = true;
            this.magiaovien.Width = 200;
            // 
            // tengiaovien
            // 
            this.tengiaovien.DataPropertyName = "hovaten";
            this.tengiaovien.HeaderText = "Họ và tên";
            this.tengiaovien.Name = "tengiaovien";
            this.tengiaovien.Width = 150;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 150;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 150;
            // 
            // frmQuanLiGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 542);
            this.Controls.Add(this.lblDanhSachGiaoVien);
            this.Controls.Add(this.dgvDanhSachGiaoVien);
            this.Controls.Add(this.lblLichGiangDay);
            this.Controls.Add(this.dgvQuanLiGiangDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLiGiangDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Giảng Dạy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiGiangDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLiGiangDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.Label lblLichGiangDay;
        private System.Windows.Forms.DataGridView dgvDanhSachGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.Label lblDanhSachGiaoVien;
    }
}