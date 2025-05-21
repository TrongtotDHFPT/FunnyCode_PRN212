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

        public int Age { get; set; }
        public string  Name { get; set; }
        public string Address { get; set; }

        public Student(int age, string name, string address)
        {
            Age = age;
            Name = name;
            Address = address;
        }
    }
}
