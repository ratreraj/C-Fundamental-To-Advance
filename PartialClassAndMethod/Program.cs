using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassAndMethod
{
    class Program
    {



        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();
            calculator.ADD(10, 20);
            calculator.SUB(20, 50);
            calculator.MUL(10, 5);
            

            Console.ReadKey();
        }
    }
}
