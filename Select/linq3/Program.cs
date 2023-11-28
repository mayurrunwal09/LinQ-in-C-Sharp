using System;
using System.Linq;
using System.Collections.Generic;


public class Program 
{
	public static void Main()
	{
		// Student collection
		IList<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
				new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
			};

		// LINQ Query Syntax to find out teenager students
		var teenAgerStudent = from s in studentList
							  where s.Age > 12 && s.Age < 20
							  select s;
		Console.WriteLine("Teen age Students:");

		foreach (Student std in teenAgerStudent)
		{
			Console.WriteLine(std.StudentName);
		}

		var selectres = from s in studentList select s.StudentName;
		foreach(var name in selectres)
        {
			Console.WriteLine(name);
        }
		var selectres1 = from s in studentList select s.Age;
		foreach(var age in selectres1)
        {
			Console.WriteLine(age);
        }

		var res2 = from s in studentList select new { Name = "Mr. " + s.StudentName, Age = s.Age };
		foreach(var res in res2)
        {
			Console.WriteLine("Student Name: {0} ,Age: {1} "+res.Name,res.Age);
        }
		


	}
	public class Student
	{

		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }

	}
}

