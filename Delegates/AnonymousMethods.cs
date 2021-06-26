using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{


    public delegate void DelSayHello(string msg);
    public class AnonymousMethods
    {

        public void SayHello(string msg)
        {
            Console.WriteLine("Hello - {0}",msg);
        
        }
        static void Main(string[] args)
        {
            AnonymousMethods anonymousMethods = new AnonymousMethods();
            anonymousMethods.SayHello("Raj");
            //DelSayHello delSayHello = anonymousMethods.SayHello;
            //delSayHello.Invoke("Hello");

            DelSayHello delSayHello = delegate (string msg)
            {
                Console.WriteLine("Hello - {0}", msg);
            };
            delSayHello.Invoke("Raj Prakash Ratre");
            Console.ReadKey();



        }

    }
}
