using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class Program
    {
        // intilization of delegates
        public delegate void delAdd(int x, int y);
        public delegate string delSey(string msg);
        public void Add(int num1, int num2)
        {

            Console.WriteLine(" Sum of Num1 {0} Numb2  {1} = {2}", num1, num2, (num1 + num2));

        }
        public void sub(int num1, int num2)
        {

            Console.WriteLine(" Substraction of Num1 {0} Numb2  {1} = {2}", num1, num2, (num1 - num2));

        }

        public static string SeyHello(string msg)
        {

            return "Welcome and hi " + msg;

        }


        static void Main(string[] args)
        {
            Program program = new Program();
            //program.Add(20, 30);
            // Instantiating of delegates
            delAdd delAdd = new delAdd(program.Add);
            delSey delSey = new delSey(Program.SeyHello);

            delAdd += program.sub;
            // Invokeing a delegates
            delAdd(20, 30);
            //delAdd.Invoke(20, 30);
            string d = delSey("Raj Prakash ");
            Console.WriteLine(d);

            Console.ReadKey();

        }
    }
}
