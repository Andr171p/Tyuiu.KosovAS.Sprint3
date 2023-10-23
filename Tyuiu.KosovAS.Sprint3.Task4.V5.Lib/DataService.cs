using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KosovAS.Sprint3.Task4.V5.Lib
{
    public class DataService : ISprint3Task4V5
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0) { continue; }
                result += (Math.Cos(i) - Math.Sin(i)) / i;
            }
            return Math.Round(result, 3);
        }
    }
}
