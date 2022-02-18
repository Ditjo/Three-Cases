using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_cases_ClassLibrary
{
    public class Case2Logic
    {

        public string Dans(string navn1, string navn2)
            //navnende bliver lagt sammen i en string
        {
            return navn1 + " & " + navn2 + " ";
        }
        public int Dans(int point1, int point2)
            //point bliver lagt sammen.a
        {
            return point1 + point2;
        }


    }
}


