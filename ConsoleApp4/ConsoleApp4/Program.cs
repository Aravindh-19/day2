using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class class1
    {
        void Swap(ref int a,ref int b)
        {



            Console.WriteLine("Swap");
            Console.WriteLine(+a);
            Console.WriteLine(+b);
            
            Console.ReadLine();

        }

        static void Main()

        {
            class1 class1 = new class1();
            int a = 5;
             int   b = 6;
            
            Console.WriteLine("Main");
            Console.WriteLine(+a);
            Console.WriteLine(+b);
            class1.Swap(ref a, ref b);
            Console.ReadLine();
        }
    }
}

