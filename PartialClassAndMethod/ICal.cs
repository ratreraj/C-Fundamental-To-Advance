using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassAndMethod
{
    public partial interface ICal
    {
        void ADD(int num1, int num2);
        void SUB(int num1, int num2);
        void MUL(int num1, int num2);
        void DIV(int num1, int num2);

    }

    public partial interface ICal
    {
        void MOD(int num1, int num2);
      

    }
}
