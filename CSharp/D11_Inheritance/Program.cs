using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[2]
            {
                new Person() {FirstName = "Person FirstName"}, new Customer() {FirstName = "Customer FirstName"}
            };
        }
    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person
    {

    }
}
