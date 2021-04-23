using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7

{
    public struct person
    {
        public string name { get; set; }
        public person(string _name)
        {
            name = _name;
        }
    }
    public struct dog
    {
        public String Breed { get; set; }
        public dog(string _breed)
        {
            Breed = _breed;
        }
    }
    class Program
    {
        public static void showvalue(object o)

        {
            if(o is person p )
            {
                Console.WriteLine(p.name);
            }
            else if(o is dog d)
            {
                Console.WriteLine(d.Breed);
            }

        }
        static void Main()
        {
            object o = new person("Abd");
            showvalue(o);
            o = new dog("Tom");
            showvalue(o);
            Console.ReadLine();

        }
    }
}
