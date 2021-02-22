using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {  
            CustomerManager customerManager=new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            
            Customer customer = new Customer();
            customer.City = "Adana";
            customer.Id = 1;
            customer.FirstName = "Emre";
            customer.LastName = "Buyuran";

            Customer customer2 = new Customer
            {
                City = "istanbul", Id = 2, FirstName = "Mustafa", LastName = "Buyuran"
            };
            
            Console.WriteLine(customer2.FirstName);


            Console.ReadLine();
        }
    }

    
    

}
