using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAX
{
    public class Program
    { 
    public class Student 
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

            public int Compareto(Student other)
            {
                if(this.StudentName.Length >= other.StudentName.Length) 
                    return 1;
                return 0;
            }
    }
        static void Main(string[] args)
        {
            // max value
            List<int> list = new List<int>() { 10, 20, 3, 4, 60, 34, 33, 44, 121, 100 };
            var maxelements = list.Max();
            Console.WriteLine("Max element is " + maxelements);

            // min value
            var minelements = list.Min();
            Console.WriteLine("min element is " + minelements);

            //even element
            var evenelement = list.Count(i => i % 2 == 0);
            Console.WriteLine("Even element is " + evenelement);

            //odd element
            var oddelement = list.Count(i => i % 2 == 1);
            Console.WriteLine("Odd element is " + oddelement);

            //total of int
            var total = list.Sum();
            Console.WriteLine("The total is " + total);

            //sum of element
            var sumofelements = list.Sum(i => { if(i%2==0) return i; return 0; });     
            Console.WriteLine("sum of elements is "+sumofelements);

           


            List<Student> liststring = new List<Student>
            {
                new Student() { StudentId = 1, StudentName = "Mayur", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Pankaj",  Age = 15 } ,
                new Student() { StudentId = 3, StudentName = "Ratik",  Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Davan" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Aman" , Age = 19 }
            };

            // order by acsending and decsending 
            var OrderBy = from s in liststring orderby s.StudentName select s;
            var acsending =  from s in liststring orderby s.StudentName ascending select s;
            Console.WriteLine("In Ascending Order");
            foreach(var std in acsending)
            {
                Console.WriteLine(std.StudentName);
            }

            var decsending = from s in liststring orderby s.StudentName descending select s;
            Console.WriteLine("In Decsending order");
            foreach(var std in decsending)
            {
                Console.WriteLine(std.StudentName);
            }

            //max value
            var old = liststring.Max(s => s.Age);
            Console.WriteLine("oldest student age " + old);
            //min value
            var younger = liststring.Min(s => s.Age);
            Console.WriteLine("youngest student is "+younger);

            //sum of value
            var totaladult = liststring.Sum(s => { if (s.Age >= 18) return 1; else return 0; });
            Console.WriteLine("total adults are " + totaladult);



        }

    }
}
