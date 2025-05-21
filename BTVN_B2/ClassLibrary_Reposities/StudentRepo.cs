using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Model;

namespace ClassLibrary_Reposities
{
    public class StudentRepo
    {
        public static void PrintInfor(Student student)
        {
            Console.WriteLine(student.Name + " " + student.Age);
        }
    }
}
