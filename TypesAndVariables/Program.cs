using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {   //Value Types
            //Console.WriteLine("Hello World!");
            int number1 = 10;
            long number2 = 2147483648;
            short number3 = 32767;
            byte number4 = 0;
            bool condition = false;
            char character = 'A';
            double number5 = 10.4;
            decimal number6 = 11.4494384324324232m;
            var number7 = 10;
            //number7 = 'A';

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3); //32767 max
            Console.WriteLine("Number4 is {0}", number4); //0-255 arasi
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday = 10, Tuesday = 20, Wednesday = 30, Thursday, Friday, Saturday, Sunday
    }
}
