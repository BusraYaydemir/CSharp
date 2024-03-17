using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList();
            List<string> cities;
            List<Customer> customers;
            List(out cities, out customers);
            Methods(cities, customers);
            Dictionary();

            Console.ReadLine();
        }

        private static void Dictionary()
        {
            /*
              * Dictionary : includes key and value 
              */

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Computer", "Bilgisayar");

            Console.WriteLine(dictionary["Table"]); // Tablo
            //Console.WriteLine(dictionary["Glass"]); // gives the System.Collections.Generic.KeyNotFoundException error

            Console.WriteLine(dictionary.ContainsKey("Book")); // True
            Console.WriteLine(dictionary.ContainsKey("Glass")); // False

            Console.WriteLine(dictionary.ContainsValue("Kitap")); // True
            Console.WriteLine(dictionary.ContainsValue("Gözlük")); // False
        }

        private static void Methods(List<string> cities, List<Customer> customers)
        {
            /*!
              * Count() : gives the amount of the item 
              * Add() : adds an element
              * AddRange() : adds multiple elements for example an array.
              * Clear() : deletes all elemests from collection.
              * Contains() : returns true or false, depend on searching item is inside on the collection
              * IndexOf() : find the index of the item from beginning
              * LastIndexOf() : find the index of the item from end 
              * ForEach() : apply an action to all elements of the collection
              * Insert() : add an element to a specific index
              * Remove() : remove the element that finding first available item
              * RemoveAll() : remove all the element that finding available items
              */

            Console.WriteLine("\n------------------------------\n");

            //! Count()
            var count = customers.Count();
            Console.WriteLine(count);

            Console.WriteLine("\n------------------------------\n");

            //! Add()
            Customer customer = new Customer()
            {
                Id = 3,
                Name = "Name3"
            };
            customers.Add(customer);
            Console.WriteLine(customers[2].Id + " " + customers[2].Name);

            Console.WriteLine("\n------------------------------\n");

            //! AddRange()
            customers.AddRange(new Customer[2] {
                new Customer() {Id = 4, Name = "Name4"},
                new Customer() {Id = 5, Name = "Name5"}
            });

            foreach (var item in customers)
            {
                Console.WriteLine(item.Id + " : " + item.Name);
            }

            Console.WriteLine("\n------------------------------\n");

            //! Contains()

            Console.WriteLine(cities.Contains("İstanbul"));
            Console.WriteLine(cities.Contains("Yozgat"));
            Console.WriteLine(customers.Contains(new Customer() { Id = 1, Name = "Name1" }));
            Console.WriteLine(customers.Contains(customer));

            Console.WriteLine("\n------------------------------\n");

            //! IndexOf()
            Console.WriteLine(customers.IndexOf(customer));

            Console.WriteLine("\n------------------------------\n");

            //! ForEach()
            customers.ForEach(item =>
            {
                Console.WriteLine(item.Name);
            });

            Console.WriteLine("\n------------------------------\n");

            //! LastIndexOf()
            Console.WriteLine(customers.LastIndexOf(customer));

            Console.WriteLine("\n------------------------------\n");

            //! Insert()

            customers.Insert(0, customer);
            customers.ForEach(item =>
            {
                Console.WriteLine(item.Name);
            });

            Console.WriteLine("\n------------------------------\n");

            //! Remove();
            customers.Remove(customer);
            customers.ForEach(item =>
            {
                Console.WriteLine(item.Name);
            });

            Console.WriteLine("\n------------------------------\n");

            //! Remove();

            customers.RemoveAll(item => item.Name == "Name3");
            customers.ForEach(item =>
            {
                Console.WriteLine(item.Name);
            });

            Console.WriteLine("\n------------------------------\n");

            //! Clear()
            customers.Clear();
            foreach (var item in customers)
            {
                Console.WriteLine(item.Id + " : " + item.Name);
            }
            Console.WriteLine("Count : " + customers.Count());

            Console.WriteLine("\n------------------------------\n");
        }

        private static void List(out List<string> cities, out List<Customer> customers)
        {
            /*!
              * List : Is a type-safe collection so Generic. So we can not add all types inside one collection, only we can add in one type.
              */

            cities = new List<string>();
            cities.Add("İstanbul");
            cities.Add("Ankara");
            cities.Add("İzmir");

            foreach (Object item in cities)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n------------------------------\n");

            customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Name1"},
                new Customer {Id = 2, Name = "Name2"},
            };
            Console.WriteLine(customers[0]);
            Console.WriteLine(customers[1].Id + " " + customers[1].Name);


            Console.WriteLine("\n------------------------------\n");
        }

        private static void ArrayList()
        {
            /*!
              * ArrayList : Is not a type-safe collection. So we can add all types inside one collection.
              */

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add('a');
            arrayList.Add("İstanbul");
            arrayList.Add(9.78);
            arrayList.Add(true);

            foreach (Object item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("item in 3 index : " + arrayList[3]);

            Console.WriteLine("\n------------------------------\n");
        }
    }


    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
