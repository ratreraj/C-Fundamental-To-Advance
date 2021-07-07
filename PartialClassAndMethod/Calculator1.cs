using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassAndMethod
{
    public partial class Calculator
    {

        public void SUB(int num1, int num2)
        {
            Console.WriteLine(" num1 {0} - num2 {1} = {2}", num1, num2, (num1 - num2));

        }

        public void MOD(int num1, int num2)
        {
            Console.WriteLine(" num1 {0} - num2 {1} = {2}", num1, num2, (num1 - num2));

        }
        partial void PartialMethod()
        {

            Console.WriteLine("I am Partial method ");
        }

    }
}
