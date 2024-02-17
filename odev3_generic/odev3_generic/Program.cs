using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3_generic
{
    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array= new T[_array.Length+1];
            for(int i=0;i<_tempArray.Length;i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length-1] = item;
        }
        public int Count
        {
            get { return _array.Length;}
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler= new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
            MyList<string> sehirler1= new MyList<string>();
            sehirler1.Add("İstanbul");
            Console.WriteLine(sehirler1.Count);



            Console.ReadKey();
        }
    }
}
