using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3]{"Emre", "Merve", "Yusuf"};
            //string[] students2 = {"Emre", "Merve", "Yusuf"};

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.ReadLine();
            string[,] regions = new string[5, 3]
            {
                {"İstanbul", "Kocaeli", "Yalova"},
                {"Ankara", "Konya", "Aksaray"},
                {"Adana", "Antalya", "Mersin"},
                {"Trabzon", "Rize", "Ordu"},
                {"İzmir", "Muğla", "Manisa"}
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("------");
            }

            Console.ReadLine();
        }


    }
}
