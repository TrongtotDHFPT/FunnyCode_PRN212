using ClassLibrary_Service;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is ConsoleApp to display!");
            StudentService.AddStudentWhenAgeIsValid(18); 
        }
    } 
}
