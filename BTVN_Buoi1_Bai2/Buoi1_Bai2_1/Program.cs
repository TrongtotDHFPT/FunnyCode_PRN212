using Buoi1_Bai2_1;

namespace BTVN_Buoi1_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //         BTVN02:
            //        1.Tạo lớp HinhChuNhat gồm:
            //        Thuộc tính(Properties): ChieuDai, ChieuRong 
            //        Phương thức(Method):
            //        TinhChuVi()
            //        TinhDienTich()
            //        HienThiThongTin()
            //        Trong Main, tạo đối tượng, gán giá trị và in ra chu vi, diện tích
            HinhChuNhat hcn = new HinhChuNhat(10, 20);
            Console.WriteLine("Chu vi Hinh Chu Nhat :"+ TinhChuVi(hcn));
            Console.WriteLine("Dien tich Hinh Chu Nhat :" + DienTich(hcn));
        }
        public static int TinhChuVi(HinhChuNhat hcn)
        {
            return 2 * (hcn.ChieuDai + hcn.ChieuRong);
        }
        public static int DienTich(HinhChuNhat hcn)
        {
            return (hcn.ChieuDai * hcn.ChieuRong);
        }
    }

}