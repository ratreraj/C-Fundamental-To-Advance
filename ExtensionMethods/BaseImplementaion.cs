using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class BaseImplementaion
    {

        public string SayHello(string str)
        {
            return "Hello " + str;

        }


        public string FullName(string fname, string lname)
        {
            return fname + " " + lname;

        }


    }
}
