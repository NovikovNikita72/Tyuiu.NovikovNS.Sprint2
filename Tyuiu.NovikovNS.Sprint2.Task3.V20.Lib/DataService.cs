using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovNS.Sprint2.Task3.V20.Lib
{
    public class DataService
    {
        public double Calculate(double x)
        {
            double res = 0;
            if (x > 1)
            {
                res = x * Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x==0)
            {
                res = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12));
            }
            else if (x>-24&&x<2)
            {
                res = Math.Pow(1 + (1 / Math.Pow(x, 2)), 2);
            }
            else if (x<-24)
            {
                res = x + (10 * x) - (1 / x);
            }

            return res;
        }
    }
}
