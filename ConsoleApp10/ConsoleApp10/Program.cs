using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class class9
    {
        static void Main(string[] args)
        {
            object str = "hello";
            char[] values = { 'h', 'e', 'l', 'l', 'o' };
            object str2 = new string(values);
            Console.WriteLine("Using equality operator{0}",(str == str2));
            Console.WriteLine("Using equals operator{0}", str.Equals( str2));
            Console.ReadLine();
        }
    }
}
