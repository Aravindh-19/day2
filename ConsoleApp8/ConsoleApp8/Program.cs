using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Dog
    {
        public void speak()
        {
            Console.WriteLine("Bark !");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            object o = new Dog();
            Dog dog = o as Dog;
            if (dog != null)
                dog.speak();
            Console.ReadLine();
        }
    }
}
