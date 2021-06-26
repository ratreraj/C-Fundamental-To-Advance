using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Student: IStudentA
    {

        public void GetStudentName(string name)
        {
            Console.WriteLine("My name is - {0}", name);
        }

        public decimal GetStudetMark(decimal mark)
        {
            return mark;

        }
    }
}
