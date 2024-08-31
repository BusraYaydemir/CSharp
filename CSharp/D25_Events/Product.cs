using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D25_Events
{

    public delegate void StockControl();
    public class Product
    {
        public event StockControl StockControlEvent;

        private string _name;
        private int _stock;

        public Product(string name, int stock)
        {
            _name = name;
            _stock = stock;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public int Stock { 
            get { 
                return _stock; 
            } set {
                _stock = value;
                if (_stock <= 15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            } 
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{0} stock : {1}", Name, Stock);
        }
    }
}
