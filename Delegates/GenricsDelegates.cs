using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //public delegate double delAddResult(int num1, float num2, double num3);
    //public delegate void delGetResult(int num1);
    //public delegate bool delResult(bool flag);

    //---------------------------------------

    class GenricsDelegates
    {
        public double AddResult(int num1, float num2, double num3)
        {
            return num1 + num2 + num3;
        }

        public void GetResult(int num1)
        {
            Console.WriteLine("Result - {0}", num1);
        }

        public bool Result(bool flag)
        {
            return flag;
        }

        static void Main(string[] args)
        {
            //GenricsDelegates delegates = new GenricsDelegates();
            //// First Delegates
            //delAddResult delAdd = new delAddResult(delegates.AddResult);
            //double res = delAdd.Invoke(10, 20.25f, 50.52f);
            //Console.WriteLine("Result - {0}", res);
            //// Second Delegates 
            //delGetResult delGet = new delGetResult(delegates.GetResult);
            //delGet.Invoke(10);

            //// Third Delegates
            //delResult del = new delResult(delegates.Result);
            //del.Invoke(true);


            // -------------- Anonymous method 

            //GenricsDelegates delegates = new GenricsDelegates();
            //// Func Delegates is used for only value retuning methods
            //Func<int,float,double,double> delAdd =  (delegates.AddResult);
            //double res = delAdd.Invoke(10, 20.25f, 50.52f);
            //Console.WriteLine("Result - {0}", res);
            //// Action delegates are used for void type method  
            //Action<int> delGet =  (delegates.GetResult);
            //delGet.Invoke(10);

            //// Predicate Delegates is only for bool return method
            //Predicate<bool> del =  (delegates.Result);
            //del.Invoke(true);



            // -------------- lambda expression method 

            //GenricsDelegates delegates = new GenricsDelegates();
            // Func Delegates is used for only value retuning methods
            Func<int, float, double, double> delAdd = (x, y, z) => x + y + z;
            double res = delAdd.Invoke(10, 20.25f, 50.52f);
            Console.WriteLine("Result - {0}", res);
            // Action delegates are used for void type method  
            Action<int> delGet = (x) => Console.WriteLine("Result - {0}", x);
            delGet.Invoke(10);

            // Predicate Delegates is only for bool return method
            Predicate<bool> del = (f) => f;
            del.Invoke(true);

        }
    }


}
