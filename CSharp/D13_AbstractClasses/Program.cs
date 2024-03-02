using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Database[] database = new Database[2]
            {
                new SqlServer(), new Oracle()
            };

            foreach (var item in database)
            {
                item.Add();
                item.Delete();
            }

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default!");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
