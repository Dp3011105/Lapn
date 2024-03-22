namespace Lapn
{
    partial class FQuanLyDoiBong
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
            this.label1 = new System.Windows.Forms.Label();
            this.gdsfgs = new System.Windows.Forms.Label();
            this.tamThanhLap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grb_HoatDong = new System.Windows.Forms.GroupBox();
            this.rdo_DungHoatDong = new System.Windows.Forms.RadioButton();
            this.rdo_DangHoatDong = new System.Windows.Forms.RadioButton();
            this.txt_HuanLuyenVien = new System.Windows.Forms.TextBox();
            this.txt_NamThanhLap = new System.Windows.Forms.TextBox();
            this.txt_QuocGia = new System.Windows.Forms.TextBox();
            this.txt_TenDoiBong = new System.Windows.Forms.TextBox();
            this.dgv_DanhSachDoiBong = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grb_HoatDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDoiBong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đội bóng";
            // 
            // gdsfgs
            // 
            this.gdsfgs.AutoSize = true;
            this.gdsfgs.Location = new System.Drawing.Point(13, 72);
            this.gdsfgs.Name = "gdsfgs";
            this.gdsfgs.Size = new System.Drawing.Size(63, 16);
            this.gdsfgs.TabIndex = 1;
            this.gdsfgs.Text = "Quốc Gia";
            // 
            // tamThanhLap
            // 
            this.tamThanhLap.AutoSize = true;
            this.tamThanhLap.Location = new System.Drawing.Point(13, 123);
            this.tamThanhLap.Name = "tamThanhLap";
            this.tamThanhLap.Size = new System.Drawing.Size(103, 16);
            this.tamThanhLap.TabIndex = 2;
            this.tamThanhLap.Text = "Năm Thành Lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Huấn Luyện Viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grb_HoatDong);
            this.panel1.Controls.Add(this.txt_HuanLuyenVien);
            this.panel1.Controls.Add(this.txt_NamThanhLap);
            this.panel1.Controls.Add(this.txt_QuocGia);
            this.panel1.Controls.Add(this.txt_TenDoiBong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tamThanhLap);
            this.panel1.Controls.Add(this.gdsfgs);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 176);
            this.panel1.TabIndex = 5;
            // 
            // grb_HoatDong
            // 
            this.grb_HoatDong.Controls.Add(this.rdo_DungHoatDong);
            this.grb_HoatDong.Controls.Add(this.rdo_DangHoatDong);
            this.grb_HoatDong.Location = new System.Drawing.Point(318, 59);
            this.grb_HoatDong.Name = "grb_HoatDong";
            this.grb_HoatDong.Size = new System.Drawing.Size(216, 100);
            this.grb_HoatDong.TabIndex = 10;
            this.grb_HoatDong.TabStop = false;
            this.grb_HoatDong.Text = "Hoạt Động";
            // 
            // rdo_DungHoatDong
            // 
            this.rdo_DungHoatDong.AutoSize = true;
            this.rdo_DungHoatDong.Location = new System.Drawing.Point(16, 60);
            this.rdo_DungHoatDong.Name = "rdo_DungHoatDong";
            this.rdo_DungHoatDong.Size = new System.Drawing.Size(127, 20);
            this.rdo_DungHoatDong.TabIndex = 1;
            this.rdo_DungHoatDong.TabStop = true;
            this.rdo_DungHoatDong.Text = "Dừng Hoạt Đông";
            this.rdo_DungHoatDong.UseVisualStyleBackColor = true;
            // 
            // rdo_DangHoatDong
            // 
            this.rdo_DangHoatDong.AutoSize = true;
            this.rdo_DangHoatDong.Location = new System.Drawing.Point(16, 21);
            this.rdo_DangHoatDong.Name = "rdo_DangHoatDong";
            this.rdo_DangHoatDong.Size = new System.Drawing.Size(127, 20);
            this.rdo_DangHoatDong.TabIndex = 0;
            this.rdo_DangHoatDong.TabStop = true;
            this.rdo_DangHoatDong.Text = "Đang Hoạt Động";
            this.rdo_DangHoatDong.UseVisualStyleBackColor = true;
            // 
            // txt_HuanLuyenVien
            // 
            this.txt_HuanLuyenVien.Location = new System.Drawing.Point(396, 17);
            this.txt_HuanLuyenVien.Name = "txt_HuanLuyenVien";
            this.txt_HuanLuyenVien.Size = new System.Drawing.Size(149, 22);
            this.txt_HuanLuyenVien.TabIndex = 8;
            // 
            // txt_NamThanhLap
            // 
            this.txt_NamThanhLap.Location = new System.Drawing.Point(122, 120);
            this.txt_NamThanhLap.Name = "txt_NamThanhLap";
            this.txt_NamThanhLap.Size = new System.Drawing.Size(154, 22);
            this.txt_NamThanhLap.TabIndex = 7;
            // 
            // txt_QuocGia
            // 
            this.txt_QuocGia.Location = new System.Drawing.Point(122, 69);
            this.txt_QuocGia.Name = "txt_QuocGia";
            this.txt_QuocGia.Size = new System.Drawing.Size(154, 22);
            this.txt_QuocGia.TabIndex = 6;
            // 
            // txt_TenDoiBong
            // 
            this.txt_TenDoiBong.Location = new System.Drawing.Point(122, 14);
            this.txt_TenDoiBong.Name = "txt_TenDoiBong";
            this.txt_TenDoiBong.Size = new System.Drawing.Size(154, 22);
            this.txt_TenDoiBong.TabIndex = 5;
            // 
            // dgv_DanhSachDoiBong
            // 
            this.dgv_DanhSachDoiBong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachDoiBong.Location = new System.Drawing.Point(28, 231);
            this.dgv_DanhSachDoiBong.Name = "dgv_DanhSachDoiBong";
            this.dgv_DanhSachDoiBong.RowHeadersWidth = 51;
            this.dgv_DanhSachDoiBong.RowTemplate.Height = 24;
            this.dgv_DanhSachDoiBong.Size = new System.Drawing.Size(725, 207);
            this.dgv_DanhSachDoiBong.TabIndex = 10;
            this.dgv_DanhSachDoiBong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachDoiBong_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(634, 16);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(102, 29);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(634, 78);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(102, 29);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa ";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(634, 132);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(102, 29);
            this.btn_Xoa.TabIndex = 13;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(634, 186);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(102, 29);
            this.btn_Thoat.TabIndex = 14;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click_1);
            // 
            // FQuanLyDoiBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_DanhSachDoiBong);
            this.Controls.Add(this.panel1);
            this.Name = "FQuanLyDoiBong";
            this.Text = "Quản Lý Đội Bóng";
            this.Load += new System.EventHandler(this.FQuanLyDoiBong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grb_HoatDong.ResumeLayout(false);
            this.grb_HoatDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDoiBong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gdsfgs;
        private System.Windows.Forms.Label tamThanhLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_HuanLuyenVien;
        private System.Windows.Forms.TextBox txt_NamThanhLap;
        private System.Windows.Forms.TextBox txt_QuocGia;
        private System.Windows.Forms.TextBox txt_TenDoiBong;
        private System.Windows.Forms.DataGridView dgv_DanhSachDoiBong;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox grb_HoatDong;
        private System.Windows.Forms.RadioButton rdo_DungHoatDong;
        private System.Windows.Forms.RadioButton rdo_DangHoatDong;
        private System.Windows.Forms.Button btn_Thoat;
    }
}