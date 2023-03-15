using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
                Dictionary<string, string> liste = new Dictionary<string, string>();
                liste.Add("Id", "1234");
                liste.Add("Adı", "İbrahim");
                liste.Add("Soyadı", "Albayrak");
            foreach (string item in liste.Values) ;
            foreach (KeyValuePair<string, string> item in liste)
            {
                Console.WriteLine(item.Key + " : " + item.Value.ToString());
            }

            Console.WriteLine("---------------- DICTIONARY STRING - STRING -------------------------------");


            Dictionary<string, int> liste2 = new Dictionary<string, int>();
            liste2.Add("Id", 12345);
            liste2.Add("Yaşı", 40);
            liste2.Add("Boyu", 180);
            foreach (int item in liste2.Values) ;
            foreach (KeyValuePair<string, int> item in liste2)
            {
                Console.WriteLine(item.Key + " : " + item.Value.ToString());
            }

            Console.WriteLine("---------------- DICTIONARY INT - STRING -------------------------------");

            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");

            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");

            Console.WriteLine(sehirler2.Count);

            Console.WriteLine("---------------- LIST -------------------------------"); ;

        }
    }
    class MyList<T>  //Generic class
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
            _array = new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }


}
