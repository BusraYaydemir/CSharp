using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace D25_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product hardDisk = new Product("Hard Disk", 50);
            Product gsm = new Product("GSM", 50);
            gsm.StockControlEvent += Gsm_StockControlEvent;

            while (hardDisk.Stock > 0 && gsm.Stock > 0)
            {
                hardDisk.Sell(5);
                gsm.Sell(5);
                Thread.Sleep(1000);
            }

            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Gsm is about the finish!");
        }
    }
}
