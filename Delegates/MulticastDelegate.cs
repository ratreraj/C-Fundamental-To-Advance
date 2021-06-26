using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // Multicate Delegates 
    public delegate void react(float w, float h);
    public class MulticastDelegate
    {

        public void GetAreaOfReact(float width, float height)
        {
            Console.WriteLine("Area of reactangle - {0}", width * height);
        }

        public void GetPerimeterOfReact(float width, float height)
        {
            Console.WriteLine("Perimeter of reactangle - {0}", width * height);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Caliing by class object");

            MulticastDelegate multicastDelegate = new MulticastDelegate();
            multicastDelegate.GetAreaOfReact(10.25f,70.78f);
            multicastDelegate.GetPerimeterOfReact(10.52f, 45.20f);
            Console.WriteLine("Caliing by delegates");
            // react react = new react(multicastDelegate.GetAreaOfReact);
            // alternative way
            react react = multicastDelegate.GetAreaOfReact;
            react += multicastDelegate.GetPerimeterOfReact;

            react.Invoke(10.25f, 19.25f);

            Console.ReadKey();



        }
    }
}
