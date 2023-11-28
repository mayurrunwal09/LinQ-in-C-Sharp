using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 10, 21, 30, 45, 50,60,77,80,99,100 };
            var totalelements = list.Count();
            Console.WriteLine("total elements "+totalelements);

            var evenelements = list.Count(i => i % 2 == 0);
            Console.WriteLine("even elements are "+evenelements);

            var oddelements = list.Count(i => i % 2 == 1);
            Console.WriteLine("odd elements are "+oddelements);
        }
    }
}
