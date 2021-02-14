using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>();
            dictionary1.Add(02, "Adıyaman");
            dictionary1.Add(34, "İstanbul");
            Console.WriteLine("Dictionary");
            Console.WriteLine(dictionary1.Count);

            MyDict<int, string> dictionary2 = new MyDict<int, string>{ };
            dictionary2.Add(01, "Adana");
            dictionary2.Add(35, "İzmir");
            Console.WriteLine("MyDictionary");
            Console.WriteLine(dictionary2.Count);

        }

    }
}
