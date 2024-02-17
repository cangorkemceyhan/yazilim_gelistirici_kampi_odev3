using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3_interface
{
    interface IPersonManager
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add() { Console.WriteLine("Musteri eklendi!"); }
        public void Update() { Console.WriteLine("Musteri guncellendi!"); }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add() { Console.WriteLine("Personel eklendi!"); }
        public void Update() { Console.WriteLine("Personel guncellendi!"); }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectManager projectManager= new ProjectManager();
            projectManager.Add(new EmployeeManager());



            Console.ReadKey();
        }
    }
}
