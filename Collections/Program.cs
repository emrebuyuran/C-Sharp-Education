using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary= new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer","bilgisayar");

            foreach (var item in dictionary)
            {
                    Console.WriteLine(item.Value);
            }

           

            Console.WriteLine(dictionary["table"]);
            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>(); //Tip güvenli çalışmak.
            cities.Add("İstanbul");
            cities.Add("Adana");

            //Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer{ID = 1, FirstName = "Emre"});
            //customers.Add(new Customer{ID = 2, FirstName = "Mustafa"});

            List<Customer> customers;
            customers = new List<Customer>
            {
                new Customer {ID = 1, FirstName = "Emre"},
                new Customer {ID = 2, FirstName = "Mustafa"}
            };


            var customer1 = new Customer
            {
                ID = 3, FirstName = "Salih"
            };

            customers.Add(customer1);

            customers.AddRange(new Customer[2]
            {
                new Customer {ID = 4, FirstName = "Merve"},
                new Customer {ID = 5, FirstName = "Yusuf"}
            });

            //customers.Clear();

            Console.WriteLine(customers.Contains(customer1));

            var index = customers.IndexOf(customer1);
            Console.WriteLine("Index : {0}", index);

            customers.Add(customer1);

            var lastIndex = customers.LastIndexOf(customer1);
            Console.WriteLine("Index : {0}", lastIndex);

            customers.Insert(0, customer1);

            customers.Remove(customer1);
            customers.Remove(customer1);
            customers.Remove(customer1);
            customers.RemoveAll(c => c.FirstName == "Emre");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count;
            Console.WriteLine("Count : {0}", count);
        }


        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
    }
}
