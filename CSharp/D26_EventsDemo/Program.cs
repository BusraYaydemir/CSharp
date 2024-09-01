using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D26_EventsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShoppingCard card = new ShoppingCard();
            Product phone = new Product("Phone", 1000, 30);
            Product table = new Product("Table", 2500, 10);
            card.ProductControlEvent += Card_ProductControlEvent;

            Console.WriteLine("Add Phone!");
            card.addProductsList(phone);
            card.getProductsList();

            Console.WriteLine("Add Phone!");
            card.addProductsList(phone);
            card.getProductsList();

            Console.WriteLine("Add Phone!");
            card.addProductsList(phone);
            card.getProductsList();

            Console.WriteLine("Remove Table!");
            card.removeProductsList(table);
            card.getProductsList();

            Console.WriteLine("Remove Phone!");
            card.removeProductsList(phone);
            card.getProductsList();

            Console.WriteLine("Remove Phone!");
            card.removeProductsList(phone);
            card.getProductsList();

            Console.WriteLine("Remove Phone!");
            card.removeProductsList(phone);
            card.getProductsList();

            Console.WriteLine("Remove Phone!");
            card.removeProductsList(phone);
            card.getProductsList();
            Console.ReadLine();
        }

        private static void Card_ProductControlEvent()
        {
            Console.WriteLine("There is no this item in Shoppping Card");
        }
    }
}
