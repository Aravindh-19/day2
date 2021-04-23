using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class class1
    {
        void checkoddeven(int a)
        {

            if (a % 2 == 0)

            { Console.WriteLine("Even"); }
            else
            { Console.WriteLine("odd"); }
        }
        
         static void Main(string[] args)

        {
            class1 class1= new class1();
            class1.checkoddeven(6);
        Console.ReadLine();
        }
    }
}
