namespace Bai13.BaiTapTongKetChuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài tập 1: Viết chương trình tính tổng 2 số nguyên được nhập vào từ người dùng sau đó in ra dòng chữ:
            //"Sum of <a> and <b> is: <total>".Trong đó giá trị của a, b và total là giá trị của biến.
            Console.WriteLine("Bai 1 : Tinh tong 2 so");
            int choice = 0;
            Console.WriteLine("1.Tinh Tong 2 so");
            Console.WriteLine("2.Nhap thong tin");
            Console.WriteLine("3.Tinh dien tich hinh tron");
            Console.Write("Enter choice : ");
            choice = int.Parse(Console.ReadLine());
            switch (choice) {
                case 1:
                    Console.WriteLine("1.Tinh Tong 2 so");
                    Console.WriteLine(TinhTong());
                    break;
                case 2:
                    Console.WriteLine("2.Nhap thong tin");
                    Console.WriteLine(PrintInfor());
                    break;
                case 3:
                    Console.WriteLine("3.Tinh dien tich hinh tron");
                    Console.WriteLine(TinhBanKinhHinhTron());
                    break;
                default:
                    Console.WriteLine("Out");
                    break;
            }

            //Bài tập 2: Viết chương trình nhập vào họ tên, số điện thoại và giới tính để in ra thông tin người đó.

            //Bài tập 3: Viết chương trình tính diện tích hình tròn với bán kính được nhập vào từ bàn phím.
        }
        public static string TinhTong()
        {
            Console.Write("Nhap a : " );
            int a = int.Parse( Console.ReadLine() );
            Console.Write("Nhap b : ");
            int b = int.Parse(Console.ReadLine());

            return  "Sum of "+a+" and "+b+" : "+(a+b);
            
        }

        public static string PrintInfor()
        {
            Console.WriteLine("Bai2 : in thong tin ");
            Console.Write(" HoVaTen :");
            string hoVaTen = Console.ReadLine();
            Console.Write(" So DienThoai :");
            string soDT = Console.ReadLine();
            Console.Write(" GioiTinh :");
            string  gioiTinh = Console.ReadLine();

            return "Thong tin nguoi dung : " + hoVaTen + " SoDT : " + soDT + " gioiTinh " + gioiTinh;
        }
        public static double TinhBanKinhHinhTron()
        {
            Console.Write("Nhap ban kinh : ");
            double banKinh = double.Parse( Console.ReadLine());
            return 3.14 * banKinh * banKinh;
        }
    }
}
