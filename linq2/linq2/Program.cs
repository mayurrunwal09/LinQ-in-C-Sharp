using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringlist = new List<string>()
           {
               "c# Tutorials",
               "vb.net Tutorials",
               "Java Tutorials",
               "MVC",
               "Delegate",
           };

            var result = from show in stringlist where show.Contains("a") select show;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        //    List<int> intlist = new List<int>()
        //    {
        //        10,20,30,31,32,
        //    };
        //
        //    var res = from display in intlist where display.Contains(20) select display;
        //    foreach(var item in res)
        //    {
        //        Console.WriteLine(item);
        //    }
        }

    }
}   
