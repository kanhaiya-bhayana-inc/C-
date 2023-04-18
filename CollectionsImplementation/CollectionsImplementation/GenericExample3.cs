/*
    In this example,
         We created a class which contains the Customer fields,
        after that created a Generic List with User-defined type Cutomer and insert the values inside the list..
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsImplementation
{
    class Customer
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
    }
    internal class GenericExample3
    {
        static void Main()
        {
            List<Customer> list = new List<Customer>();
            Customer c1 = new Customer { Id = 1, Name = "Scott", City = "Hyderabad", Phone = "+91-1234567890" };
            Customer c2 = new Customer { Id = 2, Name = "Smith", City = "Chennai", Phone = "+91-1234567890" };
            Customer c3 = new Customer { Id = 3, Name = "Dave", City = "Pune", Phone = "+91-1234567890" };
            Customer c4 = new Customer { Id = 4, Name = "Devid", City = "Delhi", Phone = "+91-1234567890" };

            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);

            foreach(Customer c in list)
            {
                Console.WriteLine(c.Id + ", " + c.Name + ", " + c.City + ", " + c.Phone);
            }
        }
    }
}
