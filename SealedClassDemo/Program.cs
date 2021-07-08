using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Child child = new Child();
            child.GetGrandParentPro();


            Console.ReadKey();
        }
    }
}
