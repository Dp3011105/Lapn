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
    public partial class FQuanLyCauThu : Form
    {
        DataTable dt = new DataTable();
        private static int demID = 1;
        private int dangChon = -1;
        public FQuanLyCauThu()
        {
            InitializeComponent();
        }

        private void FQuanLyCauThu_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("TenCauThu", typeof(string));
            dt.Columns.Add("NgaySinh", typeof(DateTime));
            dt.Columns.Add("ViTri", typeof(string));
            dt.Columns.Add("SoAo", typeof(int));
            dt.Columns.Add("QuocTich", typeof(string));
            dt.Columns.Add("CauThuTuDo", typeof(bool));
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            int ID = demID++;
            string TenCauThu = txt_TenCauThu.Text;
            DateTime NgaySinh = dateTimePicker_NgaySinh.Value;
            string ViTri = txt_ViTri.Text;
            int SoAo = int.Parse(txt_SoAo.Text);
            string QuocTich = txt_QuocTich.Text;
            bool CauThuTuDo = true;
            if (rdo_Co.Checked)
            {
                CauThuTuDo = true;
            }
            if (rdo_Khong.Checked)
            {
                CauThuTuDo = false;
            }

            DataRow Row = dt.NewRow();
            Row["ID"] = ID;
            Row["TenCauThu"] = TenCauThu;
            Row["NgaySinh"] = NgaySinh;
            Row["ViTri"] = ViTri;
            Row["SoAo"] = SoAo;
            Row["QuocTich"] = QuocTich;
            Row["CauThuTuDo"] = CauThuTuDo;
            dt.Rows.Add(Row);

            dgv_DanhSachCauThu.DataSource = dt;

            
        }

        private void dgv_DanhSachCauThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowDangChon = dgv_DanhSachCauThu.Rows[e.RowIndex];
            txt_TenCauThu.Text = rowDangChon.Cells[1].Value.ToString();
            dateTimePicker_NgaySinh.Text = rowDangChon.Cells[2].Value.ToString();
            txt_ViTri.Text = rowDangChon.Cells[3].Value.ToString();
            txt_SoAo.Text = rowDangChon.Cells[4].Value.ToString();
            txt_QuocTich.Text = rowDangChon.Cells[5].Value.ToString();
            if (Convert.ToBoolean(rowDangChon.Cells[6].Value) == true)
            {
                rdo_Co.Checked = true;
            }
            if (Convert.ToBoolean(rowDangChon.Cells[6].Value) == true)
            {
                rdo_Khong.Checked = false;
            }
            dangChon = e.RowIndex;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataRow RowDangChon = dt.Rows[dangChon];
            RowDangChon[1] = txt_TenCauThu.Text;
            RowDangChon[2] = dateTimePicker_NgaySinh.Text;
            RowDangChon[3] = txt_ViTri.Text;
            RowDangChon[4] = txt_SoAo.Text;
            RowDangChon[5] = txt_QuocTich.Text;
            if (rdo_Co.Checked == true)
            {
                RowDangChon[6] = true;
            }
            if (rdo_Khong.Checked == true)
            {
                RowDangChon[6] = false;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            dt.Rows.RemoveAt(dangChon);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
