using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace where_in_linq
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> students = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 },
                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
            };
            var tennager = from s in students orderby s.Age > 12 && s.Age < 20 select s;
            Console.WriteLine("Teen age student");

            var descending = from s in students orderby s.StudentName descending select s;

            var ascending = from s in students orderby s.Age ascending select s;

            foreach(Student student in descending)
            {
                Console.WriteLine("in descending order"+student.StudentName);
            }
            foreach(Student student in ascending)
            {
                Console.WriteLine("in ascending order" + student.StudentName);
            }
               
        }
    }
}