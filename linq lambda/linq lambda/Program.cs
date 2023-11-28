using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_lambda
{
    public class Program
    {


        delegate bool IsTeenageer(Student student);

        public class Student
        {
            public int id { get; set; }
            public string name { get; set; }
            public int age { get; set; }
        }

        public static void Main(string[] args)
        {
            IsTeenageer teen = delegate(Student s) {  return s.age > 12 && s.age<20; };
            Student stud = new Student() { age = 19 };
            Console.WriteLine(teen(stud));
        }
    }
}
