using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7_Classes
{
    internal class Customer
    {
        //! Field
        //public int Id;
        //public string FirstName;
        //public string LastName;
        //public string City;

        //! Proporty
        public int Id { get; set; }
        private string _firstName { get; set; }
        public string FirstName
        {
            get 
            {
                return "Mr. " + _firstName;
            }
            set 
            { 
                _firstName = value;
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
