using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    // define delegates 
    // note retun type and input parameter must match with function of delegate
    public delegate void adddelegate(int num1, int num2);
    public delegate string Sayhello(string name);
    public class Delegates
    {

        public void AddNumber(int num1, int num2)
        {
            Console.WriteLine("num1= {0} + num2 {1} = {2}", num1, num2);

        }

        public static string Sayhello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            Delegates objdata = new Delegates();
            // Instantiation of delegates
            adddelegate ad = new adddelegate(objdata.AddNumber);
            // call a delegates
            ad(10, 50);
            // alternative option for calling
            ad.Invoke(50, 100);

            Sayhello sy = new Sayhello(Sayhello);
            sy("Raj Prakash Ratre");

            Console.ReadKey();


        }
    }
}
