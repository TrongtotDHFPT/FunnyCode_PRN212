namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("phụ thuộc vào tầng service");
            // Tạo một đối tượng Student
            ClassLibrary_Model.Student student = new ClassLibrary_Model.Student(19, "John Doe", "123 Main St");
            // Gọi phương thức PrintInforIfValid từ tầng service
            ClassLibrary_Service.StudentService.PrintInforIfValid(student);
        }
    }
}
