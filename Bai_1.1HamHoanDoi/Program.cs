namespace Bai_1._1HamHoanDoi
{
    internal class Program
    {
        /*
          BTVN01:
          1. Viết một hàm HoanDoi(ref int a, ref int b) 
          để hoán đổi giá trị của hai biến và in kết quả trong Main
        */
        static void Main(string[] args)
        {
            int number_a = 100;
            int number_b = 200;
            Console.WriteLine("ban đầu : a = " + number_a);
            Console.WriteLine("ban đầu : b = " + number_b);
            HoanDoi(ref number_a, ref number_b);
            Console.WriteLine("a = "+number_a);
            Console.WriteLine("b = " + number_b);
        }
        
        public static void HoanDoi(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
