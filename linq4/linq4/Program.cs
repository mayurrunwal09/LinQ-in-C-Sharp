using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    internal class Student
    {

        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }    
        static void Main(string[] args)
        {

            IList<Student> StudentList = new List<Student>()
            { 
                new Student() { id = 1, name = "Dinesh",age = 13},
                new Student() { id = 2, name = "Ramesh",age = 21},
                new Student() { id = 3, name = "Suresh",age = 18},
                new Student() { id = 4, name = "Ram",age = 20},
                new Student() { id = 5, name = "Shyam",age = 24},
            };
           
            //linq query syntax
            var teenagerstudent = from s in StudentList where s.age > 12 && s.age < 20  select s;
            Console.WriteLine("Teen Student Age");
             foreach(Student stud in teenagerstudent)
            {
                Console.WriteLine(stud.name);
            }


            var teen = from s in StudentList where s.id == 5 select s;
            var teen1 = from s in StudentList where s.id == 6 select s;
            Console.WriteLine("The Name is : ");
            foreach(Student std in teen)
            {
                Console.WriteLine(std.id);
                Console.WriteLine(std.name);
                Console.WriteLine(std.age);
            }
           

        }
    }
}
