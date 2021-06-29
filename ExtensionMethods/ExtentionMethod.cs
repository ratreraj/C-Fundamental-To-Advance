using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtentionMethod
    {

        //public static string fullNameWithMidlleName(this BaseImplementaion b, string fname, string mname, string lname)
        //{
        //    return fname + " " + mname + "" + lname;
        //}

        public static int GetWordCount(this string s)
        {
            int count = 0;
            if (s.Trim().Length > 0)
            {
                string[] strarray = s.Split(' ');
                count = strarray.Count();
            }

            return count;

        }

    }
}
