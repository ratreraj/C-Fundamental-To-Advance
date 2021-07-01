using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program : Person
    {
        public override string FullName(string fname, string mname, string lname)
        {
            return fname + " " + mname + " " + lname;
        }

        public override void print()
        {
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            Program person = new Program();
            Person persons = new Program();
           
            string fullname = person.FullName("Raj", "Prakash", "Ratre");
            person.SayHello("Raj Parkash Ratre");
            Console.WriteLine(fullname);
            Console.ReadKey();
        }

      
    }
}
