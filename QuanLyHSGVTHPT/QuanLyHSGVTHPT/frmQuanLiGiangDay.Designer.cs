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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvQuanLiGiangDay = new System.Windows.Forms.DataGridView();
            this.lblLichGiangDay = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiethoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diadiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiGiangDay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuanLiGiangDay
            // 
            this.dgvQuanLiGiangDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanLiGiangDay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuanLiGiangDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLiGiangDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamonhoc,
            this.magiaovien,
            this.ngaybatdau,
            this.ngayketthuc,
            this.hovaten,
            this.tenmonhoc,
            this.tenlop,
            this.tiethoc,
            this.diadiem});
            this.dgvQuanLiGiangDay.Location = new System.Drawing.Point(1, 38);
            this.dgvQuanLiGiangDay.MultiSelect = false;
            this.dgvQuanLiGiangDay.Name = "dgvQuanLiGiangDay";
            this.dgvQuanLiGiangDay.ReadOnly = true;
            this.dgvQuanLiGiangDay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvQuanLiGiangDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLiGiangDay.Size = new System.Drawing.Size(842, 393);
            this.dgvQuanLiGiangDay.TabIndex = 0;
            // 
            // lblLichGiangDay
            // 
            this.lblLichGiangDay.AutoSize = true;
            this.lblLichGiangDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichGiangDay.Location = new System.Drawing.Point(12, 17);
            this.lblLichGiangDay.Name = "lblLichGiangDay";
            this.lblLichGiangDay.Size = new System.Drawing.Size(95, 16);
            this.lblLichGiangDay.TabIndex = 1;
            this.lblLichGiangDay.Text = "Lịch giảng dạy";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(399, 488);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(134, 41);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(549, 488);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(134, 41);
            this.btnChinhSua.TabIndex = 3;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(698, 488);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 41);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // mamonhoc
            // 
            this.mamonhoc.DataPropertyName = "mamonhoc";
            this.mamonhoc.HeaderText = "mamonhoc";
            this.mamonhoc.Name = "mamonhoc";
            this.mamonhoc.ReadOnly = true;
            this.mamonhoc.Visible = false;
            // 
            // magiaovien
            // 
            this.magiaovien.DataPropertyName = "magiaovien";
            this.magiaovien.HeaderText = "magiaovien";
            this.magiaovien.Name = "magiaovien";
            this.magiaovien.ReadOnly = true;
            this.magiaovien.Visible = false;
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.DataPropertyName = "ngaybatdau";
            this.ngaybatdau.HeaderText = "ngaybatdau";
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.ReadOnly = true;
            this.ngaybatdau.Visible = false;
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.DataPropertyName = "ngayketthuc";
            this.ngayketthuc.HeaderText = "ngayketthuc";
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.ReadOnly = true;
            this.ngayketthuc.Visible = false;
            // 
            // hovaten
            // 
            this.hovaten.DataPropertyName = "hovaten";
            this.hovaten.HeaderText = "Họ và tên";
            this.hovaten.Name = "hovaten";
            this.hovaten.ReadOnly = true;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            // 
            // tenlop
            // 
            this.tenlop.DataPropertyName = "lopma";
            this.tenlop.HeaderText = "Tên lớp";
            this.tenlop.Name = "tenlop";
            this.tenlop.ReadOnly = true;
            // 
            // tiethoc
            // 
            this.tiethoc.DataPropertyName = "tiethoc";
            this.tiethoc.HeaderText = "Tiết học";
            this.tiethoc.Name = "tiethoc";
            this.tiethoc.ReadOnly = true;
            // 
            // diadiem
            // 
            this.diadiem.DataPropertyName = "diadiem";
            this.diadiem.HeaderText = "Địa điểm";
            this.diadiem.Name = "diadiem";
            this.diadiem.ReadOnly = true;
            // 
            // frmQuanLiGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 541);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.lblLichGiangDay);
            this.Controls.Add(this.dgvQuanLiGiangDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLiGiangDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Giảng Dạy";
            this.Load += new System.EventHandler(this.frmQuanLiGiangDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiGiangDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLiGiangDay;
        private System.Windows.Forms.Label lblLichGiangDay;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiethoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diadiem;
    }
}