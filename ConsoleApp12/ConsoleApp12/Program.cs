using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
       public static void Main(string[] args)
        {
            string str=Console.ReadLine();
            int i,  Vowel_count;
            Console.WriteLine("Enter string");
            Vowel_count = 0;
            
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u'||str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U' )
            {
                Vowel_count++;
            }
            Console.WriteLine("vowel count", Vowel_count);
        }
            Console.ReadLine();

        }

            
                

        }
    }

