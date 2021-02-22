using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] { "Emre", "Ozi", "Ahmet" };
                foreach (var student in students)
                {
                    Console.WriteLine(student);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            Console.ReadLine();


        }
    }
}
