
#region Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Application = Autodesk.Revit.ApplicationServices.Application;

#endregion

namespace AlphaBIM
{
    [Transaction(TransactionMode.Manual)]
    public class Lesson02Cmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // code here

            string ten;
            ten = "Quan";


            string ho = "Dang";
            double tuoiA = 20; // Ctrl + D
            double tuoiB = 21;
            bool dungSai = true;


            // Các phép toán số học: +, -, *, /, Math.Abs()

            double tuoi2 = tuoiA - 100; // -80
            // tuoiA = tuoiA / 20;
            tuoi2 = Math.Abs(tuoi2); // 80
            ho = ho + " Le";
            ho = string.Concat(ho, " Le");

            // Phép So sánh: >, <, <=, <=, ==, !=

            bool b1 = tuoiA > tuoiB; // tuoiA = 20, tuoiB = 21
            bool b2 = tuoiA < tuoiB;
            bool b3 = tuoiA + 1 >= tuoiB;
            bool b4 = tuoiA - 2 == tuoiB;

            // Phép Logic: kết hợp 2 điều kiện, trả về kiểu bool, bao gồm:
            // 1. Và:           &&
            // 2. Hoặc:         ||
            // 3. Phủ định:     !

            double chieuCao = 100;

            var b5 = chieuCao < 90;
            var b6 = chieuCao < 150;

            bool b = b5 && b6;
            bool b7 = b5 || b6;
            bool b8 = !b7;


            #region CẤU TRÚC ĐIỀU KIỆN

            #region If else

            bool b9 = chieuCao > 200;

            if (b9) // nếu điều kiện đúng thì thực hiện code 1 bên dưới
            {
                // code 1
                // MessageBox.Show("Chiều cao nhỏ hơn 200");
            }
            else
            {
                // code 2\
                // MessageBox.Show("Chiều cao lớn hơn 200");
            }


            if (chieuCao < 90)
            {
                // code 1
            }
            else if (chieuCao >= 100)
            {
                // code 2
            }
            else
            {
                // code 2
            }

            #endregion

            #region 2.Switch case

            string hocLuc_CuaBanA = "Trung Binh"; // Yeu - Trung Binh - Kha - Gioi
            switch (hocLuc_CuaBanA)
            {
                case "Yeu":
                    //MessageBox.Show("Học dở quá");
                    break;
                case "Trung Binh":
                   // MessageBox.Show("Học trung bình");
                    break;
                case "Kha":
                   // MessageBox.Show("Học trung Khá");
                    break;
                case "Gioi":
                   // MessageBox.Show("Học trung Giỏi");
                    break;
            }

            #endregion

            #endregion


            #region CẤU TRÚC LẶP

            #region Vòng lặp for

            double giaBitcoin = 10000;
            for (int x = 5; x <= 10; x++)
            {
                giaBitcoin = giaBitcoin * x;
            }

            // MessageBox.Show(giaBitcoin.ToString());


            #endregion


            #region Vòng lặp for each

            string hocSinh = "DLQ";
            List<string> danhSachHocVien = new List<string>();

            var hocSinh2 = "DLQ";
            var danhSachHocVien2 = new List<string>();

            danhSachHocVien.Add("DLQ");
            danhSachHocVien.Add("Thang");
            danhSachHocVien.Add("Tam");
            danhSachHocVien.Add("Cao");

            danhSachHocVien.RemoveAt(0);

            foreach (var i in danhSachHocVien)
            {
               // MessageBox.Show(i);
            }


            #endregion


            #region Vòng lặp while true



            #endregion

            #endregion


            #region GIỚI THIỆU LINQ

            List<double> giaIphone = new List<double>();

            giaIphone.Add(5);
            giaIphone.Add(3);
            giaIphone.Add(10);
            giaIphone.Add(11);
            giaIphone.Add(12);

            // Cach thong thuong
            //double giaMax = 0;
            //foreach (double gia in giaIphone)
            //{
            //    if (gia > giaMax)
            //    {
            //        giaMax = gia;
            //    }
            //}
            //MessageBox.Show(giaMax.ToString());

            // LINQ
            //double giaMax = giaIphone.Max();
            MessageBox.Show(giaIphone.Max().ToString());


            #endregion


            // GIỚI THIỆU VỀ CLASS

            LoaiDoge dogeNau = new LoaiDoge();

            dogeNau.MauLong = "Màu Nâu";
            dogeNau.CanNang = 100;
            dogeNau.MauMat = "Xanh";

            string thongTin = string.Concat("Màu lông: ", dogeNau.MauLong, "\n",
               "Cân nặng: ", dogeNau.CanNang, "\n",
               "Màu mắt: ", dogeNau.MauMat, "\n",
               "Đu Đỉnh: ", dogeNau.TocDoChay(10)
               );

            //MessageBox.Show(thongTin);

            double cao = LoaiDoge.ChieuCaoMax;
            MessageBox.Show(cao.ToString());

            return Result.Succeeded;
        }
    }
}
