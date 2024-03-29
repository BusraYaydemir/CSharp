using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace D21_Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerDal customerDal = new CustomerDal();
            Customer customer = new Customer()
            {
                Id = 1, FirstName = "Name1", Age = 29
            };
            customerDal.Add(customer);

            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    [ToTable("tblCustomers")]
    class Customer
    {
        [RequiredProporty]
        public int Id { get; set; }
        [RequiredProporty]
        public string FirstName { get; set; }
        [RequiredProporty]
        public string LastName { get; set; }
        [RequiredProporty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("This is old method for Add, Use NewAdd Method...")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} Added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void NewAdd(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} Added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

    }
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    class RequiredProportyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
