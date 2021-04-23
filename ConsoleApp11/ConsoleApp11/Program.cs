using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter string");
            string inp = Console.ReadLine();
            char[] rev = new char[inp.Length];
            for(int i=inp.Length-1;i>=0;i--)
            {
                rev[i] = inp[i];
            }
            string rev1 = new string(rev);
            if (rev1==inp)
            
            
            { Console.WriteLine("palindrome"); }
            else
            { Console.WriteLine("Not palindrome"); }
            Console.ReadLine();
        }
    }
}
