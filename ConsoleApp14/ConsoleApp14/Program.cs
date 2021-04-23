using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        public static void addstring(string s1, string s2,string s3)
        {
            Console.WriteLine(s1 + s2+s3);
        }
        static void Main(string[] args)
        {
            addstring(s1: "Dev", s2: "Virat", s3: "Abd");
            Console.ReadLine();
        }
    }
}
