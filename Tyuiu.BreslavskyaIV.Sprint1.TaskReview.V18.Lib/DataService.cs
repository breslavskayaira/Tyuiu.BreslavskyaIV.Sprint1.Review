using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BreslavskyaIV.Sprint1.TaskReview.V18.Lib
{
    public class DataService: ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double n = 1 + Math.Sin(x + y) * Math.Sin(x + y);
            double s = x - (2 * x) / (1 + x * x * y * y);
            var res = Math.Round((n/(2+s)+x), 3);
            return res;
        }
    }
}
