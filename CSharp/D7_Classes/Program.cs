using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Create();
            customerManager.Read();
            customerManager.Update();
            customerManager.Delete();

            Console.WriteLine("\n\n-------------------\n\n");

            ProductManager productManager = new ProductManager();
            productManager.Create();
            productManager.Read();
            productManager.Update();
            productManager.Delete();

            Console.WriteLine("\n\n-------------------\n\n");

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "FirstName 1";
            customer1.LastName = "LastName 1";
            customer1.City = "City 1";
            Console.WriteLine(customer1.FirstName);

            Console.WriteLine("\n\n-------------------\n\n");

            Customer customer2 = new Customer()
            {
                Id = 2,FirstName = "FirstName 2", LastName = "LastName 2", City = "City 2"
            };
            Console.WriteLine(customer2.FirstName);


            Console.ReadLine();
        }
    }
}
