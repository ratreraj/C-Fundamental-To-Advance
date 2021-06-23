using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Output: {0} + {1} = {2}", num1, num2, (num1 + num2));
            Console.WriteLine("Output: {0} - {1} = {2}", num1, num2, (num1 - num2));
            Console.WriteLine("Output: {0} * {1} = {2}", num1, num2, (num1 * num2));
            Console.WriteLine("Output: {0} / {1} = {2}", num1, num2, (num1 / num2));

            Console.ReadKey();
        }
    }
}
