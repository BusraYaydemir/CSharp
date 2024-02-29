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

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void Create()
        {
            Console.WriteLine("Customer Created!");
        }

        public void Read()
        {
            Console.WriteLine("Customer Read!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Deleted!");
        }
    }


    public class ProductManager
    {
        public void Create()
        {
            Console.WriteLine("Product Created!");
        }

        public void Read()
        {
            Console.WriteLine("Product Read!");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }

        public void Delete()
        {
            Console.WriteLine("Product Deleted!");
        }
    }
}
