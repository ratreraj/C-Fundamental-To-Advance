using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public interface ITest1
    {
        void Test();
        void Show();
    }

    public interface ITest2
    {
        void Test();
        void Show2();
    }

    public class HybridTest
    {
        public void Show3()
        {

            Console.WriteLine(" Show method is calling from HybridTest class");
        }
    }

    class InterfaceImplemention : HybridTest, ITest1, ITest2
    {
        void ITest1.Show()
        {
            Console.WriteLine(" Show method is calling from Itest1");
        }

        void ITest1.Test()
        {
            Console.WriteLine(" Print method is calling from Itest1");
        }

        public void Show2()
        {
            Console.WriteLine(" Show method is calling from Itest2");
        }

        void ITest2.Test()
        {
            Console.WriteLine(" Print method is calling from Itest2");
        }
    }
    class MultipleInheritance
    {
        static void Main(string[] args)
        {
            InterfaceImplemention @interface = new InterfaceImplemention();

            //@interface.Test();
            //@interface.Show2();
            @interface.Show3();

            ITest1 test1 = @interface;
            test1.Test();
            test1.Show();
           

            ITest2 test2 = @interface;
            test2.Test();
            test2.Show2();

            Console.ReadKey();

        }
    }
}
