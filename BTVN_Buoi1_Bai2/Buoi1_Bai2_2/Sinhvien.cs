using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai2_2
{
    internal class Sinhvien
    {
        public string MaSv { get; set; }
        public string TenSv { get; set; }
        public double DiemTB { get; set; }

        public Sinhvien(string maSv, string tenSv, double diemTB)
        {
            MaSv = maSv;
            TenSv = tenSv;
            DiemTB = diemTB;
        }
        public Sinhvien()
        {

        }

        
    }
}
