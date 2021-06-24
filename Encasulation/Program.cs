using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encasulation
{
    public class Program
    {
        //private double balance;

        //public double GetBalance()
        //{

        //    return balance;
        //}
        //public double SetBalance(double _balnace)
        //{
        //    if (_balnace < 0)
        //    {
        //        Console.WriteLine(" Negative value is not required");

        //    }
        //    else
        //    {
        //         this.balance = _balnace;

        //    }
        //    return this.balance;
        //}

        private double _balance;


        public double balance
        {
            get
            {

                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine(" Negative value is not required");
                    value = 0;
                }
               
                _balance = value;
            }
        }


    }
    public class Banimp
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.balance = -10;
            Console.WriteLine("Balance - {0}", obj.balance);
            Console.ReadKey();
        }
    }

}
