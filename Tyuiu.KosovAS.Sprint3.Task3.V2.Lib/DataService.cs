using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KosovAS.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            int length, maxLength = 0;
            foreach (char c in value)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == item)
                    {
                        length = 0;
                        for (int j = i; j < value.Length && value[j] == item; j++)
                        {
                            length++;
                        }
                        i += length;
                        if (length > maxLength) maxLength = length;
                    }
                }
            }
            return maxLength;
        }
    }
}
