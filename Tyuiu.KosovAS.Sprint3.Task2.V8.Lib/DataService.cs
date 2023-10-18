using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KosovAS.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            int i = 1;
            double result = 1;
            do
            {
                result *= 1 / (Math.Pow((Math.Cos(5) + 1), 2));
                i++;
            } while ((i < stopValue) && (startValue <= i));
            return Math.Round(result, 3);
        }
    }
}
