namespace SecondProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student = new("Nguyễn Trọng Tốt",120);
            Console.WriteLine(student.Name);
            //student.Age = 100;
            Console.WriteLine(student.Age);

        }
    }
}
