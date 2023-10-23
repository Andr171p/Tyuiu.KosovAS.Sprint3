using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KosovAS.Sprint3.Task6.V13.Lib
{
    public class DataService : ISprint3Task6V13
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int result = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 9; j <= i; j++)
                {
                    if (i % j == 0) { result += j; }
                }
            }
            return result;
        }
    }
}
