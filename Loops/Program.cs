using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            //ForLoop();
            //ForEachLoop();
            if(IsPrimeNumber(1))
            {
                Console.WriteLine("This is a prime number !");

            }

            else
            {
                Console.WriteLine("This is not a prime number ! ");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0 || number==1)
                {
                    result = false;
                    i = number;
                }
            }

            return result;
        }

        private static void ForEachLoop()
        {
            string[] students = new string[3] {"Emre", "Merve", "Yusuf"};
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!");
        }

        private static void NewMethod()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}
