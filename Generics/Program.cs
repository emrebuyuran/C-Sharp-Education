using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilites utilites = new Utilites();
            List<string> result = utilites.BuildList<string> ("İstanbul", "İzmir", "Ankara");
            foreach (var items in result)

            {
                Console.WriteLine(items);
                
            }

            List<Customer> result2 = utilites.BuildList<Customer>(new Customer {FirstName = ("Emre")}, new Customer{FirstName = ("Buyuran")});
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Utilites
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
        
    }
    class Product : IEntity
    {

    }

    class Customer : IEntity
    {
        public string FirstName { get; set; }
        
    }

    class Student : IEntity
    {

    }

    interface IStudentDal : IRepository<Student>
    {
        
    }
    interface ICustomerDal : IRepository<Customer>
    {

    }





    interface IProductDal : IRepository<Product>
    {

    }

    interface IEntity
    {
        
    }
    
    interface IRepository<T> where T: class,IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
