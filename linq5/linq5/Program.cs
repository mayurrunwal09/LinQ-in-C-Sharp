using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq5
{
    internal class Program
    {
        //string collection
        static void Main(string[] args)
        {
            List<string> liststring = new List<string>()
            {
                "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
            };
            //linq method syntex
            var res = liststring.Where(s => s.Contains("Tutorials"));

            foreach(var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
