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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quảnLýĐộiBóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void quảnLýCầuThủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dev không troll nên không có nút nào ở đây \n mời chọn 2 trường trên", "Cảnh Báo!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FQuanLyCauThu f1 = new FQuanLyCauThu();
            FQuanLyDoiBong F2 = new FQuanLyDoiBong();
            Close();
            f1.Close();
            F2.Close();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýĐộiBóngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FQuanLyDoiBong Fqldb = new FQuanLyDoiBong();
            Fqldb.Show();
            this.Hide();

        }

        private void quảnLýCầuThủToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FQuanLyCauThu Fqlct = new FQuanLyCauThu();
            Fqlct.Show();
            this.Hide();
        }
    }
}
