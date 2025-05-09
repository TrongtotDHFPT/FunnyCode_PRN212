namespace Bai_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //          2.Viết hàm PhanTichSo(int so, out int tram, out int chuc, out int donVi)\
            //          để tách một số có 3 chữ số thành hàng trăm, chục, đơn vị.
            int number = 953;
            int a, b, c;
            PhanTichSo(number, out a, out b, out c);
            Console.WriteLine("So : "+number);
            Console.WriteLine("tram : " + a);
            Console.WriteLine("chuc : " + b);
            Console.WriteLine("donVi : " + c);
        }
        public static void PhanTichSo(int so, out int tram, out int chuc, out int donVi)
        {
            donVi = so % 10;
            chuc = (so / 10) % 10;
            tram = so / 100;
        }
    }
}
