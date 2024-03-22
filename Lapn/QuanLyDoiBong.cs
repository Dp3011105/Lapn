using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lapn
{
    public partial class FQuanLyDoiBong : Form
    {
        DataTable dt =new DataTable();
        private static int demID = 1;
        private int dangChon = -1;
        
        public FQuanLyDoiBong()
        {
            InitializeComponent();
        }

        private void FQuanLyDoiBong_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("TenDoiBong", typeof(string));
            dt.Columns.Add("QuocGia", typeof(string));
            dt.Columns.Add("NamThanhLap", typeof(int));
            dt.Columns.Add("HuanLuyenVien", typeof(string));
            dt.Columns.Add("HoatDong", typeof(bool));
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int ID = demID ++ ;
           
            string TenDoiBong = txt_TenDoiBong.Text;           
            string QuocGia = txt_QuocGia.Text;
            int NamThanhLap = int .Parse(txt_NamThanhLap.Text);
            string HuanLuyenVien = txt_HuanLuyenVien.Text;
            bool HoatDong = true;
            if (rdo_DangHoatDong.Checked)
            {
                HoatDong = true;
            }
            if (rdo_DungHoatDong.Checked)
            {
                HoatDong = false;
            }

            DataRow Row = dt.NewRow();
            Row["ID"] = ID; 
            Row["TenDoiBong"] = TenDoiBong; 
            Row["QuocGia"] = QuocGia; 
            Row["NamThanhLap"] = NamThanhLap; 
            Row["HuanLuyenVien"] = HuanLuyenVien; 
            Row["HoatDong"] = HoatDong; 
            dt.Rows.Add(Row);

            dgv_DanhSachDoiBong.DataSource = dt;

           
        }

        private void dgv_DanhSachDoiBong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowDangChon = dgv_DanhSachDoiBong.Rows[e.RowIndex];
            txt_TenDoiBong.Text = rowDangChon.Cells[1].Value.ToString();
            txt_QuocGia.Text = rowDangChon.Cells[2].Value.ToString();
            txt_NamThanhLap.Text = rowDangChon.Cells[3].Value.ToString();
            txt_HuanLuyenVien.Text = rowDangChon.Cells[4].Value.ToString();
            if (Convert.ToBoolean(rowDangChon.Cells[5].Value) == true)
            {
                rdo_DangHoatDong.Checked = true;
            }
            if (Convert.ToBoolean(rowDangChon.Cells[5].Value) == true)
            {
                rdo_DungHoatDong.Checked = false;
            }
            dangChon = e.RowIndex;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataRow RowDangChon = dt.Rows[dangChon];
            RowDangChon[1] = txt_TenDoiBong.Text;
            RowDangChon[2] = txt_QuocGia.Text;
            RowDangChon[3] = txt_NamThanhLap.Text;
            RowDangChon[4] = txt_HuanLuyenVien.Text;
            if( rdo_DangHoatDong.Checked == true )
            {
                RowDangChon[5] = true;
            }
            if (rdo_DungHoatDong.Checked == true)
            {
                RowDangChon[5] = false;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            dt.Rows.RemoveAt(dangChon);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

       
    }
}
