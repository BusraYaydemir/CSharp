using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D26_EventsDemo
{
    public delegate void ProductControl();
    public  class ShoppingCard
    {
        public event ProductControl ProductControlEvent;

        private List<Product> ProductsList = new List<Product>();
        private double TotalPrice { get; set; }

        public void addProductsList(Product product)
        {
            ProductsList.Add(product);
            TotalPrice += product.Price;
        }

        public void removeProductsList(Product product)
        {
            if (ProductsList.Contains(product))
            {
                ProductsList.Remove(product);
                TotalPrice -= product.Price;
            } 
            else if (ProductControlEvent != null) 
            {
                ProductControlEvent();
            }
            
        }

        public void getProductsList() {
            Console.WriteLine("GET PRODUCTS LİST: ");
            foreach(var product in ProductsList)
            {
                Console.WriteLine("Name: {0}\nPrice: {1}\nStock: {2}", product.Name, product.Price, product.Stock);
            }
            Console.WriteLine("\n\n");
        }
    }
}
