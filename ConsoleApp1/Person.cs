using ConsoleApp1.Extending;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    public class Person
    {
        // public: The code used to create a particular parent class element is
        // accessible by any other class, even if that class hasn't inherited from
        // the parent class.

        // protected: The code is accessible by members of the same class and any
        // child classes.So, this code would be accessible by members of the
        // Vehicle class and the Car class, but not accessible by members of the
        // Road class, which doesn't inherit from the Vehicle class.

        // private: The code is accessible only by members of the same class. For
        // example, the code is accessible by any member of the Vehicle class, but
        // not accessible by members of the Car class.

        // internal: This is the super-secret code that is accessible only from
        // within a given assembly, but not within any other assembly.It means that
        // you can create code that is only accessible from your application and not
        // any other application, even if the other application uses classes from
        // your application.

        // protected internal => protected OR internal
        // a protected internal member is accessible from any class in the same
        // assembly, including derived classes.

        // default => if no access modifier is specified in a member declaration
        //  -enum: The default and only access modifier supported is public.
        //  -class: The default access for a class is private. It may be explicitly defined using any of the access modifiers.
        //  -interface: The default and only access modifier supported is public.
        //  -struct: The default access is private with public and internal supported as well.

        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string _country { get; set; }

        public Person() { } 
        public Person(int id, string name,
        string title, string description,
        string address, string city,
        string region, string postalCode)
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
