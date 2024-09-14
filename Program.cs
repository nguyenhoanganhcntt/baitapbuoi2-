using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(101, "Anh ", 10);
            student s2 = new student(102, "Long ", 20);
            student s3 = new student(103, "Vuong ", 28);
            student s4 = new student(104, "Hien ", 15);
            student s5 = new student(105, "Hung ", 17);
            List<student> students = new List<student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            foreach(var x in students) { Console.WriteLine(x.ToString()); };
            Console.WriteLine("=====================================");

            var st = students.Where(x=>x.Age >= 15 && x.Age <= 18);
            Console.WriteLine("Danh sach hoc sinh co tuoi tu 15 -18");
            foreach (var x in st) { Console.WriteLine(x.ToString()); };
            Console.WriteLine("=====================================");

            var stA = students.Where(x => x.Name.StartsWith("A"));
            Console.WriteLine("Danh sach hoc sinh bat dau bang chu A:");
            foreach (var x in stA) { Console.WriteLine(x.ToString()); };
            Console.WriteLine("=====================================");

            int TT = students.Sum(x => x.Age);
            Console.WriteLine("Tong so tuoi cua student la : " + TT);
            Console.WriteLine("=====================================");

            var maxAge = students.Where(x => x.Age == students.Max(y => y.Age));
            Console.WriteLine("Danh sach tuoi lon nhat:");
            foreach (var x in maxAge) { Console.WriteLine(x.ToString()); };
            Console.WriteLine("=====================================");

            Console.WriteLine("Danh sach sap xep theo tuoi :");
            var stSort = students.OrderBy(x=>x.Age).ThenBy(n=>n);
            foreach (var x in stSort) { Console.WriteLine(x.ToString()); };


        }
    }

    
}
