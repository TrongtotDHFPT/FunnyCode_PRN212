using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Model;
using ClassLibrary_Reposities;

namespace ClassLibrary_Service
{
    public class StudentService
    {
        public static void PrintInforIfValid(Student student)
        {
            if (student.Age >= 20)
            {
                StudentRepo.PrintInfor(student);
            }
            else
            {
                Console.WriteLine("Student is null");
            }
        }
    }
}
