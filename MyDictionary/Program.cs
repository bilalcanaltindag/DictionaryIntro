using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> notes = new Dictionary<string, int>();

            notes.Add("Bilal", 95);
            notes.Add("Efe", 100);
            notes.Add("Ali", 80);
            notes.Add("Kemal", 50);
            

            foreach (var item in notes)
            {
                Console.WriteLine("Key: " + item.Key + " Value : " + item.Value);
            }

            foreach (var item in notes)
            {
                Console.WriteLine("2. foreach: " + item);
            }

            Console.WriteLine("1. eklenen kişi: " + notes["Bilal"]);


            Dictionary<int, string> musteriler = new Dictionary<int, string>(10)  // capacity : 10
            {
                {10, "Ali Ömercik" },
                {11, "Tamer Çetin" },
                {12, "Efe Altındağ" }
            };

            musteriler.Add(13, "Bilal Can Altındağ");
            Console.WriteLine("13. Müşteri : " + musteriler[13]);

            musteriler[13] = "Hasan Altındağ";
            Console.WriteLine("13. Müşteri : " + musteriler[13]);

            Console.WriteLine("Musteriler dictionary ve sonrası: " + musteriler[10]);

            bool a = musteriler.ContainsKey(11); // just key control
            bool b = musteriler.ContainsValue("Efe Altındağ"); // just value control
            bool c = musteriler.Contains(new KeyValuePair<int, string>(11, "Tamer Çetin")); // key and value control

            Console.WriteLine("key control: " + a);
            Console.WriteLine("value control: " + b);
            Console.WriteLine("key & value control: " + c);

            string value;
            bool result = musteriler.TryGetValue(5, out value);   // customer control
            Console.WriteLine("Müşteri var mı: " + result);

            bool result1 = musteriler.TryGetValue(11, out value);  // customer control
            Console.WriteLine("Müşteri var mı2: " + result1);
        }
    }
}
