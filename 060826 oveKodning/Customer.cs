using System;
using System.Collections.Generic;
using System.Text;

namespace _060826_oveKodning
{
    public class Customer
    {
        public string Name;
        public string CustomerId;
        /// <summary>
        /// Constructor for Customer class, which initializes all properties for a new instance of the class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="customerId"></param>
        public Customer(string name, string customerId)
        {
            Name = name;
            CustomerId = customerId;
        }
    }
}
