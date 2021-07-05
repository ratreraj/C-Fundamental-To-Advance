using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{

    class Add1
    {
        public void add(int num1, int num2)
        {

            Console.WriteLine(" Num1 -{0} Num2 {1} = {2}", num1, num2, num1 + num2);
        }
    }
    class Program : Add1
    {

        public void add(string str1, string str2)
        {

            Console.WriteLine(" Num1 -{0} Num2 {1} = {2}", str1, str2, str1 + str2);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Add1 add = new Add1();
            program.add(10, 10);
            program.add("Raj", "Prakash");


            Console.ReadKey();
        }
    }
}
