using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{

    public class Class1
    {

        public virtual void Print()
        {

            Console.WriteLine("Parrent Virtual Class Method ");
        }

        public void SayHello()
        {

            Console.WriteLine(" Hello Parrent Class Method ");
        }


    }

    class Class2 : Class1
    {
        public override void Print()
        {
            //base.Print();
            Console.WriteLine("Child Class Overriden Method ");
        }

        //public new void Print()
        //{
        //    //base.Print();
        //    Console.WriteLine("Child Class Overriden Method ");
        //}


        public new void SayHello()
        {

            Console.WriteLine(" Hello Child Class New Method ");
        }
        static void Main(string[] args)
        {
            Class1 cl = new Class1();

            Class1 @class = new Class2();
            @class.Print();
            //cl.Print();
            @class.SayHello();

            Console.ReadKey();


        }
    }
}
