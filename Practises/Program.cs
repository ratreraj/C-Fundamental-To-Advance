using System;

namespace Practises
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 10;
            int num2 = 20;
            int temp = num1;
            Console.WriteLine("Num1 {0} Num2 {1}", num1, num2);
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Num1 {0} Num2 {1}", num1, num2);
            Console.ReadKey();
        }
    }
}
