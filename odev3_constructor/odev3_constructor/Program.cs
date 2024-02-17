using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3_constructor
{
    class Customer
    {
        public Customer() { }
        public Customer(int id,string fisrtname,string lastname,string city) 
        {
            Id = id;
            FirstName= fisrtname;
            LastName = lastname;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Can",
                LastName = "Ceyhan", City = "İstanbul" };
            Customer customer2 = new Customer();
            customer2.Id = 2;
            Customer customer3 = new Customer(3, "Gorkem", "Ceyhan", "Diyarbakır");
            Console.WriteLine(customer3.FirstName);



            Console.ReadKey();
        }
    }
}
