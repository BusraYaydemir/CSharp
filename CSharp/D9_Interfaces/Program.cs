using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo1();


            //Demo2();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo2()
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void Demo1()
        {
            PersonManager personManager = new PersonManager();

            // personManager for Customer:
            personManager.Add(new Customer() { Id = 1, FirstName = "FirstName 1", LastName = "LastName 2", Address = "Address" });

            // personManager for Student:
            Student student = new Student()
            {
                Id = 2,
                FirstName = "FirstName 2",
                LastName = "LastName 2",
                Department = "Department"
            };

            personManager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName + " is Added!");
        }
    }
}
