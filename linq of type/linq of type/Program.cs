using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace linq_of_type
{
    public class Program
    {
        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
        }
		static void Main(string[] args)
		{
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add(1);
            mixedList.Add("Two");
            mixedList.Add("Three");
            mixedList.Add(4);

            mixedList.Add(new Student() { StudentId = 1, StudentName = "RAM" });

            var stringres = from s in mixedList.OfType<string>() select s;
            var intres = from s in mixedList.OfType<int>() select s;
            var stdres = from s in mixedList.OfType<Student>() select s;

            foreach(var str in stringres)
            {
                Console.WriteLine(str); 
            }
            foreach(var i in intres)
            {
                Console.WriteLine(i);
            }
            foreach(var std in stdres)
            {
                Console.WriteLine(std.StudentName); 
            }



		}
    }
}
