using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Model
{
    public class Student
    {
        public Student()
        {
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string MSSV { get; set; }

        public Student(string name, int age, string mSSV)
        {
            Name = name;
            Age = age;
            MSSV = mSSV;
        }
    }
}
