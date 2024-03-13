using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();

            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");

            Product product1 = new Product(10, "Laptop");
            product1.Add();

            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");

            Product product2 = new Product()
            {
                Id = 11, Name = "Phone"
            };
            product2.Add();

            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");

            PersonManager personManager = new PersonManager("product");
            personManager.Add();

            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");

            Utilities.Validate();

            StaticAndNonStaticClass.StaticMethod();

            StaticAndNonStaticClass staticAndNonStaticClass = new StaticAndNonStaticClass();
            staticAndNonStaticClass.NonStaticMethod();

            Console.ReadLine();
        }
    }

    //! Singleton Design Pattern is important for understanding this topic clearly!!
    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done!");
        } 
    }

    class StaticAndNonStaticClass
    {
        static StaticAndNonStaticClass()
        {
            Console.WriteLine("This static constructor works only static methods!");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method!");
        }

        public void NonStaticMethod()
        {
            Console.WriteLine("Non-Static Method!");
        }
    }


    class BaseClass
    {
        private string _entity;

        public BaseClass (string entity)
        {
            _entity = entity;
        }

        public void Add ()
        {
            Console.WriteLine("{0} Added!", _entity);
        }
    }


    class PersonManager : BaseClass
    {
        public PersonManager (string entity) : base (entity)
        {

        }
    }


    class Product
    {
        private int _id;
        private string _name;
        public Product (int id, string name)
        {
            _id = id;
            _name = name;
        }

        public Product ()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void Add()
        {
            Console.WriteLine("Added!\nid : {0} \nname : {1}", Id, Name);
            Console.WriteLine("*****************************************");
            Console.WriteLine("Added!\nid : {0} \nname : {1}", _id, _name);
        }
    }


    class CustomerManager
    {
        private int _count;

        public CustomerManager(int count)
        {
            _count = count;
        }

        public void List()
        {
            Console.WriteLine("{0} Items Listed!", _count);
        }

        public void Add()
        {
            Console.WriteLine("{0} Items Added!", _count);
        }
    }
}
