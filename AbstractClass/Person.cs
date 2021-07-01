using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{

    interface demo
    {

        void print();
    }

    public  abstract  class Person :demo
    {

        public string name;
        public static string fullname;
        public  void SayHello(string str)
        {
            Console.WriteLine(" Hello my name is {0}", str);
        }


        public abstract  string FullName(string fname, string mname, string lname);

        public abstract void print();
       
    }
}


