using System;

namespace Inheritance
{

    // Single Inheritance  Class Car:Vehicle


    class child : Parrent
    {

        internal int CHid;
        internal string CHname;
        internal string CHaddrsss;
        public child()
        {
            Console.WriteLine("Child class constructor calling");
        }
        static void Main(string[] args)
        {
            child objchild = new child();
            //objchild.
            Parrent objp = new Parrent();
            //objp.
            Parrent pp = new child();
            
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

    class Parrent 
    {
        internal int id;
        internal string name;
        internal string addrsss;

        public Parrent()
        {
            Console.WriteLine("Parent class constructor calling");
        }

    }

    class GrandParent
    {
        internal int id;
        internal string name;
        internal string addrsss;
        public GrandParent()
        {
            Console.WriteLine("GrandParent class constructor calling");
        }

    }
}
