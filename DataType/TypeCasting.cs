using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    public class TypeCasting
    {


        interface data1
        { }

        
        struct data2 : data1
        {

        }
        static void Main(string[] args)
        {
            // Implicit type casting

        
            int num1 = 10;
            double numb2 = num1;
            Console.WriteLine("num1- {0} num2- {1}", num1, numb2);



            // Explicit type casting 
            double dub1 = 200.256f;
            int dub2 = (int)dub1;
            Console.WriteLine("dub1- {0} dub2- {1}", dub1, dub2);

            // Casting uisng helper class

            string str1 = "200";
            int num3 = Convert.ToInt32(str1);
            Console.WriteLine("str1- {0} num3- {1}", str1, num3);

            Console.ReadKey();

        }
    }
}
