using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    
    internal class student
    {
        private int mssv;
        private string name;
        private int age;

        public int Mssv { get => mssv; set => mssv = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public student(int mssv, string name, int age)
        {
            this.Mssv = mssv;
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return "mssv = "+mssv + ", name= "+name+", age= "+age+"";
        }
    }
}
