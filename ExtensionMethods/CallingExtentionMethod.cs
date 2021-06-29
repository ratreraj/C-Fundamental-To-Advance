using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class CallingExtentionMethod
    {
        static void Main(string[] args)
        {
            BaseImplementaion baseImplementaion = new BaseImplementaion();
            //string fullname = baseImplementaion.fullNameWithMidlleName("Raj", "Prakash", "Ratre");
            //Console.WriteLine("My Name is - {0}", fullname);
            string myword = "Hello how are you";
            int count = myword.GetWordCount();
            Console.WriteLine(" Count -{0} ", count);
            Console.ReadKey();

        }
    }
}
