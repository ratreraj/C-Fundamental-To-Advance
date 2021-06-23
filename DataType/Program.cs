using System;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Size of method 
            Console.WriteLine("Size of int: {0} data type",sizeof(int));
            Console.WriteLine("Size of double: {0} data type", sizeof(double));
            Console.WriteLine("Size of float: {0} data type", sizeof(float));
            Console.WriteLine("Size of decimal: {0} data type", sizeof(decimal));
            Console.WriteLine("Size of bool: {0} data type", sizeof(bool));
            Console.WriteLine("Size of char: {0} data type", sizeof(char));
            Console.ReadKey();
        }
    }
}
