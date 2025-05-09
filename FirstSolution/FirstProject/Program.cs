using System;

namespace FirstProject     // package như JAVA
{
    internal class Program   //internal : cục bộ
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //String str = Console.ReadLine();
            //Console.WriteLine(str);

            //Integer.parseInt()     : bên java
            //int num1 = int.Parse(Console.ReadLine());


            //TryParse()
            //string num1_raw = Console.ReadLine();
            //int num1 = 0; 
            //bool isNumber =int.TryParse(num1_raw, out num1);//nếu chuỗi parse được thì num1 = value đó

            //if (isNumber)
            //{
            //    Console.WriteLine(num1); 
            //}

            //============================================================
            //Vòng For-each
            int[] array = { 1, 2, 3, 4, 5 };
            foreach (int tay in array)
            {
                Console.WriteLine(tay);
            }

        }

        //============================================================
        //ref & out : tham chiếu như con trỏ


        

        



    }
}