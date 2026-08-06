using System;
using System.Collections.Generic;
using System.Text;

namespace _060826_oveKodning
{
    public class Location
    {
        public string Address;
        public int AdressNumber;
        public int ZipCode;
        public string City;
        public string Country;
        public int PhoneNumber;
        public int EmployeeCount;
        /// <summary>
        /// Constructor for lokations klassen, som initialiserer alle egenskaberne for en ny instans af klassen.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="adressNumber"></param>
        /// <param name="zipCode"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="employeeCount"></param>
        public Location(string address, int adressNumber, int zipCode, string city, string country, int phoneNumber, int employeeCount)
        {
            Address = address;
            AdressNumber = adressNumber;
            ZipCode = zipCode;
            City = city;
            Country = country;
            PhoneNumber = phoneNumber;
            EmployeeCount = employeeCount;
        }
    }
}
