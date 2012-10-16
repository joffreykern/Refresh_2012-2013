using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_Basics_CSharp
{
    class WorkWithArray
    {
        int[] firstarray;
        int[] initarray = new int[3] { 1, 2, 3 };

        void AddValues()
        {
            firstarray = new int[3];
            firstarray[0] = 1;
            firstarray[1] = 2;
            firstarray[2] = 3;
        }
    }
}
