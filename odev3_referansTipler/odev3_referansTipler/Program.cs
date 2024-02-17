using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3_referansTipler
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeId { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //ornek1();



            Person person1= new Person();
            Person person2= new Person();
            person1.FirstName = "Can";
            person2 = person1;
            person1.FirstName = "Gorkem";
            Console.WriteLine(person2.FirstName);
            Customer customer = new Customer();
            customer.FirstName = "Ceyhan";
            customer.CreditCardNumber = "15452125";
            Employee employee= new Employee();
            Person person3 = customer;
            customer.FirstName = "Busra";
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            PersonManager personManager= new PersonManager();
            personManager.Add(employee);



            Console.ReadKey();
        }
        private static void ornek1()
        {
            //int,decimal,float,enum,boolean value types
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayi 1: " + sayi1);

            //arrays,class,interface referance types
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("sayilar1[0]: " + sayilar1[0]);
        }
    }
}
