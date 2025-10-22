using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class MovieSale
    {
        public string TenPhim { get; set; }
        public int GiaVeChuan { get; set; }
        public int SoVeBanRa { get; set; }
        public int TongSoGhe { get; set; } 
    }

    public class MovieStat
    {
        public string TenPhim { get; set; }
        public int VeBanRa { get; set; }
        public int VeTon { get; set; }
        public double TiLeVeBanRa { get; set; }
        public double DoanhThu { get; set; }
    }
}
