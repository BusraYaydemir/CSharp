using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utilities utilities = new Utilities();
            List<Product> products = utilities.BuildList<Product>(new Product { Name = "Tablet"}, new Product { Name = "Laptop"});

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }

            List<Customer> customers = utilities.BuildList<Customer>(new Customer { FirstName = "Name1" }, new Customer { FirstName = "Name2" });

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();

        }
    }

    class Utilities
    {
        public List<T> BuildList<T> (params T[] values)
        {
            return new List<T> (values);
        }
    }


    class Product : IEntity
    {
        public string Name;
    }

    interface IProductDal : IReporstory<Product>
    {
        /*
        List<Product> GetAll();
        Product Get();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        */
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

        public Product Get()
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

    class Customer : IEntity
    {
        public string FirstName;
    }


    interface ICustomerDal : IReporstory<Customer>
    {
        /*
        List<Customer> GetAll();
        Customer Get();
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        */
    }


    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    interface IEntity
    {

    }

    /*todo
     * Generic Constraints : 
     * 
     * class: T should be referance type
     * struct: T should be value type
     * interfaceName : T should be inherit in that interface, for example IEntity
     * new() : T should be able to new() and new should be in the end of the contraints
     */

    interface IReporstory<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

}
