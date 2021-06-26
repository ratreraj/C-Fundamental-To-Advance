using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IStudent
    {
        void GetStudentName(string name);
        decimal GetStudetMark(decimal mark);

    }

    public interface IStudentA: IStudent
    {
        void GetStudentName(string name);
        decimal GetStudetMark(decimal mark);

    }
}
