using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapn
{
    internal class DoiBong
    {
        public int iD { get; set; }
        public string tenDoiBong { get; set; }
        public string quocGia { get; set; }
        public int namThanhLap { get; set; }
        public string huanLuyenVien { get; set; }
        public List<CauThu> danhSachCauThu { get; set; }
        public int ID { get; set; }
    }
}
