using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class class1
    {
        void swap(int a, int b, int c)
        {

            int temp = a;
             a = b;
             b = c;
             c = temp;

            Console.WriteLine(+a);
            Console.WriteLine(+b);
            Console.WriteLine(+c);
            Console.ReadLine();

        }

        static void Main(string[] args)

        {
            class1 class1 = new class1();
            class1.swap(2,3,6);
            Console.ReadLine();
        }
    }
}
