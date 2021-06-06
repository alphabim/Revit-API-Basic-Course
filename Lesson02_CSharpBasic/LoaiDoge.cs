using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaBIM
{
    // public - internal
    public class LoaiDoge
    {
        // khai bao Field
        public string MauLong;

        // khai bao Property
        internal string MauMat { get; set; }

        // khai bao Property
        internal static double ChieuCaoMax { get; set; } = 100;

        // khai bao Property
        internal double CanNang { get; set; }

        // Khai bao Method
        public double TocDoChay()
        {
            return 1000;
        }

        // Khai bao Method có truyền vô tham số
        public double TocDoChay(double tuoi)
        {
            if (tuoi < 3)
            {
                return 1000;
            }
            else
            {
                return 3000;
            }
        }


        public void GetCanNang(double tuoi, string boygirl)
        {
            CanNang = 100;
        }
    }
}
