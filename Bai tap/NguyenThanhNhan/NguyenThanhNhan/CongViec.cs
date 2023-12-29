using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhNhan
{
    internal class CongViec
    {
        public string TenCV { get; set; }
        public int DoUuTien { get; set; }
        public string ThongTinCV { get; set; }
        public string TrangThaiCV { get; set; }
        public CongViec() { }
        public CongViec(string tenCV, int doUuTien, string thongTinCV, string trangThaiCV)
        {
            TenCV = tenCV;
            DoUuTien = doUuTien;
            ThongTinCV = thongTinCV;
            TrangThaiCV = trangThaiCV;
        }
    }
}
