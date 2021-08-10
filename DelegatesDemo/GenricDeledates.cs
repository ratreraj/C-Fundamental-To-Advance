using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{

    public class Emp
    {
        public int EmpID { get; set; }
        public string EmployeeName { get; set; }


        public Emp GetData(Func<string, Emp> func)
        {
            Emp emp = new Emp();

            return emp;
        }

    }
    public class GenricDeledates
    {


        public delegate string delSeyHello(string smg);
        public void Add(int num1, int num2)
        {

            Console.WriteLine(" Sum of Num1 {0} Numb2  {1} = {2}", num1, num2, (num1 + num2));

        }

        public static string SeyHello(string msg)
        {

            return "Welcome and hi " + msg;

        }

        public bool GetGender(string gender)
        {
            if (gender == "M")
                return true;
            else
                return false;

        }



        public static void Main(string[] args)
        {
            GenricDeledates genricDeledates = new GenricDeledates();

            Func<string, string> func = new Func<string, string>(SeyHello);
            string result = func.Invoke("Raj Prakash Ratre");

            delSeyHello delSey = new delSeyHello(SeyHello);
            delSey.Invoke("Raj Prakash Ratre");

            Action<int, int> action = new Action<int, int>(genricDeledates.Add);
            action.Invoke(10, 20);

            Predicate<string> predicate = new Predicate<string>(genricDeledates.GetGender);
            predicate.Invoke("M");


            Func<string, string> funccc = (string m) => "Welcome and hi " + m;
            funccc.Invoke("Ram");


            Func<string, string> funcca = delegate (string m)
                { return "Welcome and hi " + m; };
            Console.WriteLine(result);


        }
    }
}
