using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class CallingImplemention
    {
        //private IStudent _student;

        //public CallingImplemention()
        //{ }
        //public CallingImplemention(IStudent student)
        //{
        //    _student = student;
        //}

        //public void caliing()
        //{
        //    _student.GetStudentName("raj");
        //    decimal marks = _student.GetStudetMark(8000);
        //    Console.WriteLine("My Marks is -{0}", marks);

        //}
        static void Main(string[] args)
        {
            IStudent student = new Student();
           // Student student = new Student();
            student.GetStudentName("Raj");
            decimal marks = student.GetStudetMark(8000);
            Console.WriteLine("My Marks is -{0}", marks);
            //CallingImplemention calling = new CallingImplemention();

            //calling.caliing();
        }

    }
}
