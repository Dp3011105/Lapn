namespace Lapn
{
    partial class FQuanLyCauThu
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_DanhSachCauThu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_QuocTich = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grb_CauThuTuDo = new System.Windows.Forms.GroupBox();
            this.rdo_Khong = new System.Windows.Forms.RadioButton();
            this.rdo_Co = new System.Windows.Forms.RadioButton();
            this.txt_SoAo = new System.Windows.Forms.TextBox();
            this.txt_ViTri = new System.Windows.Forms.TextBox();
            this.txt_TenCauThu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tamThanhLap = new System.Windows.Forms.Label();
            this.gdsfgs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachCauThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.grb_CauThuTuDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(652, 186);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(102, 29);
            this.btn_Thoat.TabIndex = 20;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(652, 132);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(102, 29);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(652, 78);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(102, 29);
            this.btn_Sua.TabIndex = 18;
            this.btn_Sua.Text = "Sửa ";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(652, 16);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(102, 29);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_DanhSachCauThu
            // 
            this.dgv_DanhSachCauThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachCauThu.Location = new System.Drawing.Point(46, 231);
            this.dgv_DanhSachCauThu.Name = "dgv_DanhSachCauThu";
            this.dgv_DanhSachCauThu.RowHeadersWidth = 51;
            this.dgv_DanhSachCauThu.RowTemplate.Height = 24;
            this.dgv_DanhSachCauThu.Size = new System.Drawing.Size(725, 207);
            this.dgv_DanhSachCauThu.TabIndex = 16;
            this.dgv_DanhSachCauThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachCauThu_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker_NgaySinh);
            this.panel1.Controls.Add(this.txt_QuocTich);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.grb_CauThuTuDo);
            this.panel1.Controls.Add(this.txt_SoAo);
            this.panel1.Controls.Add(this.txt_ViTri);
            this.panel1.Controls.Add(this.txt_TenCauThu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tamThanhLap);
            this.panel1.Controls.Add(this.gdsfgs);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 176);
            this.panel1.TabIndex = 15;
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(109, 67);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_NgaySinh.TabIndex = 13;
            // 
            // txt_QuocTich
            // 
            this.txt_QuocTich.Location = new System.Drawing.Point(396, 54);
            this.txt_QuocTich.Name = "txt_QuocTich";
            this.txt_QuocTich.Size = new System.Drawing.Size(149, 22);
            this.txt_QuocTich.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(315, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quốc Tịch";
            // 
            // grb_CauThuTuDo
            // 
            this.grb_CauThuTuDo.Controls.Add(this.rdo_Khong);
            this.grb_CauThuTuDo.Controls.Add(this.rdo_Co);
            this.grb_CauThuTuDo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grb_CauThuTuDo.Location = new System.Drawing.Point(322, 95);
            this.grb_CauThuTuDo.Name = "grb_CauThuTuDo";
            this.grb_CauThuTuDo.Size = new System.Drawing.Size(227, 78);
            this.grb_CauThuTuDo.TabIndex = 10;
            this.grb_CauThuTuDo.TabStop = false;
            this.grb_CauThuTuDo.Text = "Cầu thủ tự do";
            // 
            // rdo_Khong
            // 
            this.rdo_Khong.AutoSize = true;
            this.rdo_Khong.Location = new System.Drawing.Point(16, 47);
            this.rdo_Khong.Name = "rdo_Khong";
            this.rdo_Khong.Size = new System.Drawing.Size(66, 20);
            this.rdo_Khong.TabIndex = 1;
            this.rdo_Khong.TabStop = true;
            this.rdo_Khong.Text = "Không";
            this.rdo_Khong.UseVisualStyleBackColor = true;
            // 
            // rdo_Co
            // 
            this.rdo_Co.AutoSize = true;
            this.rdo_Co.Location = new System.Drawing.Point(16, 21);
            this.rdo_Co.Name = "rdo_Co";
            this.rdo_Co.Size = new System.Drawing.Size(45, 20);
            this.rdo_Co.TabIndex = 0;
            this.rdo_Co.TabStop = true;
            this.rdo_Co.Text = "Có";
            this.rdo_Co.UseVisualStyleBackColor = true;
            // 
            // txt_SoAo
            // 
            this.txt_SoAo.Location = new System.Drawing.Point(396, 17);
            this.txt_SoAo.Name = "txt_SoAo";
            this.txt_SoAo.Size = new System.Drawing.Size(149, 22);
            this.txt_SoAo.TabIndex = 8;
            // 
            // txt_ViTri
            // 
            this.txt_ViTri.Location = new System.Drawing.Point(122, 120);
            this.txt_ViTri.Name = "txt_ViTri";
            this.txt_ViTri.Size = new System.Drawing.Size(154, 22);
            this.txt_ViTri.TabIndex = 7;
            // 
            // txt_TenCauThu
            // 
            this.txt_TenCauThu.Location = new System.Drawing.Point(122, 14);
            this.txt_TenCauThu.Name = "txt_TenCauThu";
            this.txt_TenCauThu.Size = new System.Drawing.Size(154, 22);
            this.txt_TenCauThu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên cầu thủ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(315, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số áo";
            // 
            // tamThanhLap
            // 
            this.tamThanhLap.AutoSize = true;
            this.tamThanhLap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tamThanhLap.Location = new System.Drawing.Point(13, 123);
            this.tamThanhLap.Name = "tamThanhLap";
            this.tamThanhLap.Size = new System.Drawing.Size(35, 16);
            this.tamThanhLap.TabIndex = 2;
            this.tamThanhLap.Text = "Vị trí ";
            // 
            // gdsfgs
            // 
            this.gdsfgs.AutoSize = true;
            this.gdsfgs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gdsfgs.Location = new System.Drawing.Point(13, 72);
            this.gdsfgs.Name = "gdsfgs";
            this.gdsfgs.Size = new System.Drawing.Size(69, 16);
            this.gdsfgs.TabIndex = 1;
            this.gdsfgs.Text = "Ngày Sinh";
            // 
            // FQuanLyCauThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_DanhSachCauThu);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FQuanLyCauThu";
            this.Text = "Quản Lý Cầu thủ";
            this.Load += new System.EventHandler(this.FQuanLyCauThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachCauThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grb_CauThuTuDo.ResumeLayout(false);
            this.grb_CauThuTuDo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_DanhSachCauThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_QuocTich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grb_CauThuTuDo;
        private System.Windows.Forms.RadioButton rdo_Khong;
        private System.Windows.Forms.RadioButton rdo_Co;
        private System.Windows.Forms.TextBox txt_SoAo;
        private System.Windows.Forms.TextBox txt_ViTri;
        private System.Windows.Forms.TextBox txt_TenCauThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tamThanhLap;
        private System.Windows.Forms.Label gdsfgs;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh;
    }
}