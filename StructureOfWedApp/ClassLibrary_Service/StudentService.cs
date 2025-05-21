using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Model;
using ClassLibrary_Repositories;

namespace ClassLibrary_Service
{
    public class StudentService
    {   
        public static void AddStudentWhenAgeIsValid(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new ArgumentOutOfRangeException("Age must be between 0 and 120.");
            }
            // Call the repository method to add the student
            Student student = new Student
            {
                Name = "John Doe",
                Age = age,
                MSSV = "A"
            };
            StudentRepo.AddStudent(student);
        }
    }
}
