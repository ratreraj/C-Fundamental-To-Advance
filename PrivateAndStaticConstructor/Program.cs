using System;

namespace PrivateAndStaticConstructor
{
    class Program
    {
        private static int counter;


        private Program()
        {
            counter = 10;
        }
        static Program()
        {
            counter = 20;
        }

        public Program(int id)
        {
            counter = id + 1;
        }


        public static int GetId(int id)
        {
            return counter = counter + id;

        }

        public class NestedClass
        {
            Program program1 = new Program(10);


        }



    }


    public class newclass
    {
        static void Main(string[] args)
        {
            //Program program = new Program();
            //// Program program1 = new Program(10);
            //Console.WriteLine("Name {0} age {1}", program.name, program.age);
            // Console.WriteLine("Id - {0} Name {1} age {2}", program1.id, program1.name, program1.age);
            Console.WriteLine("Id - {0}", Program.GetId(10));
            Console.ReadKey();
        }

    }
}
