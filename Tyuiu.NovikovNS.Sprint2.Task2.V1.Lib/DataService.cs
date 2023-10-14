using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovNS.Sprint2.Task2.V1.Lib
{
    public class DataService : ISprint2Task2V1
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3 && x <= 5) && (y == 3) || (x == 9 | x == 12) & (y == 3) || (x >= 3 && x <= 5) && (y == 4) || (x == 9 | x == 12) && (y == 4) || (x >= 5 && x <= 12) && (y == 5) || (x >= 5 && x <= 13) && (y == 6) || (x >= 3 && x <= 13) && (y == 7) || (x >= 6 && x <= 8) && (y == 8) || (x >= 12 && x <= 13) && (y == 8) || (x >= 6 && x <= 8) && (y == 9) || (x == 12) && (y == 9) || (x >= 6 && x <= 8) && (y == 10) || (x == 12) && (y == 10) || (x >= 3 && x <= 8) && (y == 11) || (x == 12) && (y == 11) || (x == 4) && (y == 12) || (x >= 7 && x <= 8) && (y == 12) || (x == 4) && (y == 13))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
