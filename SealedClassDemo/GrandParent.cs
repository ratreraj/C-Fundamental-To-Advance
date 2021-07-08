using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassDemo
{
    public class GrandParent
    {
        public virtual void GetGrandParentPro()
        {
            Console.WriteLine("Hi I am grand parent class");

        }

      
    }

    public class Parent : GrandParent
    {
        public void GetParentPro()
        {
            Console.WriteLine("Hi I am  parent class");
        }

        public sealed override void GetGrandParentPro()
        {
            Console.WriteLine("Hi I am grand parent class");

        }

    }

    public sealed class Child : Parent
    {
        public void GetChildPro()
        {
            Console.WriteLine("Hi I am Child class");

        }
        
        //public  override void GetGrandParentPro()
        //{
        //    Console.WriteLine("Hi I am grand parent class");

        //}

    }

    //public sealed class GrandChild : Child
    //{
    //    public void GetGrandChildPro()
    //    {
    //        Console.WriteLine("Hi I am GrandChil class");

    //    }

    //}
}
