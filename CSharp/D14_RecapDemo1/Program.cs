using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14_RecapDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new JsonLogger();
            customerManager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public Logger logger;
        public void Add()
        {
            logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }


    interface Logger
    {
        void Log();
    }

    class DatabaseLogger : Logger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!");
        }
    }

    class SmsLogger : Logger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms!");
        }
    }

    class JsonLogger : Logger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Json!");
        }
    }
}
