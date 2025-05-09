namespace Buoi1_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        BTVN02:
            //          1.Tạo lớp HinhChuNhat gồm:
            //          Thuộc tính(Properties): ChieuDai, ChieuRong
            //          Phương thức(Method):
            //        TinhChuVi()
            //        TinhDienTich()
            //        HienThiThongTin()
            //        Trong Main, tạo đối tượng, gán giá trị và in ra chu vi, diện tích
            HinhChuNhat hcn = new(10, 20);
            Console.WriteLine(HienThiThongTin(hcn));
            Console.WriteLine("chu vi HCN :" + ChuVi(hcn));
            Console.WriteLine("dien tich HCN :" + DienTich(hcn));
        }
        public static int ChuVi(HinhChuNhat hcn)
        {
            return 2 * (hcn.ChieuDai + hcn.ChieuRong);
        }
        public static int DienTich(HinhChuNhat hcn)
        {
            return (hcn.ChieuDai * hcn.ChieuRong);
        }
        public static string HienThiThongTin(HinhChuNhat hcn)
        {
            return "Hinh chu nhat co chieu dai :" + hcn.ChieuDai + " va chieu rong :" + hcn.ChieuRong;
        }
    }
}
