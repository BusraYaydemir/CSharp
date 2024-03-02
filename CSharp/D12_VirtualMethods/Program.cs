using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace D12_VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();

            Console.ReadLine();
        }
    }


    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default!");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted by default!");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SqlServer!");

            base.Add(); // Runs the method in parent class
        }

    }
}
