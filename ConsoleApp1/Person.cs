using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public Person(int id, string name, 
            string title, string description, 
            string address, string city, 
            string region, string postalCode, 
            string country)
        {
            Id = id;
            Name = name;
            Title = title;
            Description = description;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
        }
    }
}
