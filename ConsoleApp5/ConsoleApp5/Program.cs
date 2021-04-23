using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input");
            var a=Console.ReadLine();
            int result;
                int.TryParse(a, out result);
                if (result==0)
           { Console.WriteLine("Integer"); }
            else
            { Console.WriteLine("Not an Integer"); }
            Console.ReadLine();
        }
    }
}
