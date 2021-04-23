using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Author
    {
        public string Name1;
        public int rank1;
    }
    class class1
    {
        public string Name2;
        public int rank2;
        static void Main(string[] args)
        {
            class1 class1 = new class1();
            Author author = new Author();
            bool result;
            result = class1 is Author;
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
