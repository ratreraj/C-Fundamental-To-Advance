using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersises
{
    class multiplication_table
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please enter a number for mutiplication table");
            int num1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(" {0} X {1} = {2}", num1, i, (num1 * i));
            }

            Console.ReadKey();
        }
    }
}
