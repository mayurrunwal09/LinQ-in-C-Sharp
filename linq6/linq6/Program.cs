using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq6
{
    internal class Program
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        static void Main(string[] args)
        {
            List<Program> list = new List<Program>()
            {
            new Program() { id = 1, name = "Jay",age = 25},
            new Program() { id = 2, name = "Shree", age = 24},

            };

            var emp = from e in list where  e.id == 1 select e;
            var emp1 = from e in list where e.name == "Jay" select e;
            Console.WriteLine("Emp name is ");
            foreach (Program p in list)
            {
                Console.WriteLine(p.name);
                Console.WriteLine(p.age);
            }
    } }
}
