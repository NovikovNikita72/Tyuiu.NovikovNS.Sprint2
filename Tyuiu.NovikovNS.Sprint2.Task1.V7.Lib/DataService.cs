using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovikovNS.Sprint2.Task1.V7.Lib
{
    public class DataService
    {
        public bool[] GetCompareOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = b == c + 2 | a < d;
            res[1] = b != c & a == c;
            res[2] = a < b || c == d;
            res[3] = b > a && c != d;
            res[4] = ! (a == d);
            res[5] = b <= d ^ c < a;
            return res;
        }
    }
}
