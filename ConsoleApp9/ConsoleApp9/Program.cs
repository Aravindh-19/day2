using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class emp
    {
        public int empID { get; set; }
        public string name { get; set; }
    }
    class class8
    {
        static void Main(string[] args)
        {
            emp emp1 = new emp();
            emp1.empID = 101;
            emp1.name = "Dev";
            emp emp2 = new emp();
            emp2.empID = 102;
            emp2.name = "Abd";
            Console.WriteLine(emp1.Equals(emp2));
            Console.WriteLine(Equals(emp1,emp2));
            Console.ReadLine();


        }
    }
}
