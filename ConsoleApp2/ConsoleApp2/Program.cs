using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some value");
            var x = Console.ReadLine();
            Console.WriteLine(x);
            Console.WriteLine(x.GetType());
            Console.ReadLine();

        }
    }
}
