using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] args1 = { 1, "" };

            ArrayList arrayList = new ArrayList();
            Console.WriteLine(arrayList.Capacity);
            arrayList.Add("Raj");
            arrayList.Add(10);
            arrayList.Add(true);
            arrayList.Add(10.23f);
            arrayList.Add(90000);
            foreach (var item in arrayList)
            { 
                 Console.WriteLine(item);
            
            }
            arrayList.RemoveAt(0);
            arrayList.Insert(2, "Raj");
            Console.WriteLine("------------------------------\n");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(arrayList.Capacity);

            Console.ReadKey();
        }
    }
}
