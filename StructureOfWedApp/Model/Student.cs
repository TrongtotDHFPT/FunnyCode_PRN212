using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        public int MSSV { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public  Student(int _mssv, int _age, string _name)
        {
            MSSV = _mssv;
            Age = _age;
            Name = _name;
        }
    }
}

    