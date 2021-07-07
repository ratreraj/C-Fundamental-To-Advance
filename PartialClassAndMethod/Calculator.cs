using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassAndMethod
{
    public partial class Calculator : ICal
    {

        public void ADD(int num1, int num2)
        {
            Console.WriteLine(" num1 {0} + num2 {1} = {2}", num1, num2, (num1 + num2));

            PartialMethod();

        }

        partial void PartialMethod();



    }
}
