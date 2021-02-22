using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = 11;
            if (number1 != 10)
            {
                Console.WriteLine("Number is not 10");
            }
            else
            {
                Console.WriteLine("Number1 is {0}", number1);
            }

            Console.ReadLine();
        }
    }
}
