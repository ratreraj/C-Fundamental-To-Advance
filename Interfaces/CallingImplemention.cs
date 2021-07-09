using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class CallingImplemention
    {
        private IStudent _student;

       
        public CallingImplemention(IStudent student)
        {
            _student = student;
        }

        
        static void Main(string[] args)
        {
           // IStudent student = new Student();
            Student student = new Student();
            CallingImplemention calling = new CallingImplemention(student);
            calling._student.GetStudentName("Raj");
            decimal marks = calling._student.GetStudetMark(8000);
            Console.WriteLine("My Marks is -{0}", marks);
            //CallingImplemention calling = new CallingImplemention();

            //calling.caliing();

            Console.ReadKey();
        }

    }
}
