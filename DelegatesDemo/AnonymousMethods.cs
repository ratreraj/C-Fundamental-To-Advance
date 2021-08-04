using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class AnonymousMethods
    {

        public delegate void Adddel(int num1, int num2);

        public delegate List<string> addlname(List<string> name);

        public void FullName(List<string> name)
        {
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

        }

        //public void Add(int num1, int num2)
        //{
        //    Console.WriteLine($" Sum of Num1= {num1} Numb2 ={num2}  = {num1 + num2} ");

        //}
        static void Main(string[] args)
        {
            AnonymousMethods anonymous = new AnonymousMethods();
            // Adddel adddel = new Adddel(anonymous.Add);
            Adddel adddel = delegate (int num1, int num2)
            {
                Console.WriteLine("Please enter two number for additaions");
                Console.WriteLine($" Sum of Num1= {num1} Numb2 ={num2}  = {num1 + num2} ");
            };
            adddel(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            addlname addlname = delegate (List<string> name)
            {
                List<string> namess = new List<string>();
                foreach (var item in name)
                {
                    namess.Add(item);
                }
                return namess;
            };

            //addlname addlname =  (List<string> name) =>
            //{
            //    List<string> namess = new List<string>();
            //    foreach (var item in name)
            //    {
            //        namess.Add(item);
            //    }
            //    return namess;
            //};

            List<string> names = new List<string>()
            {
                "Raj",
                "Nitin",
                "Atul",
                "Kinjal"
            };

            anonymous.FullName(addlname(names));
            Console.Read();

        }
    }
}
