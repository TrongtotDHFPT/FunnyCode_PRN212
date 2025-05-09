namespace Bai_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  3.Viết hàm
            //TinhToan(int a, int b, out int tong, out int hieu, out int tich, out double thuong)
            //Sau đó hiển thị tất cả kết quả trong Main

            int a = 100;
            int b = 200;
            int tong, hieu, tich;
            double thuong;
            TinhToan(a, b, out tong, out hieu, out tich, out thuong);
            Console.WriteLine("Tổng của "+a+" + "+b+" = " +tong);
            Console.WriteLine("Hiệu của " + a + " - " + b + " = " + hieu);
            Console.WriteLine("Tích của " + a + " * " + b + " = " + tich);
            Console.WriteLine("Thương của " + a + " / " + b + " = " + thuong);

        }
        public static void TinhToan(int a, int b, out int tong, out int hieu, out int tich, out double thuong)
        {
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            thuong = (double)a / b;

        }
    }
}
