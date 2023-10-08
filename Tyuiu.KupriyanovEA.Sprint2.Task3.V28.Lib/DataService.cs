using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KupriyanovEA.Sprint2.Task3.V28.Lib
{
    public class DataService : ISprint2Task3V28
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                y = x + Math.Pow(((Math.Cos(Math.Pow(x, 2))) / (x - 1)), x + 3);
            }
            else
            {
                if (x == 0)
                {
                   y = (Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 11) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 2);
                }
                else
                {
                    if ((x > -32) && (x < -1))
                    {
                        y = Math.Pow(((Math.Cos(x)) / (Math.PI - x)), 2);
                    }
                    else
                    {
                        if (x < -32)
                        {
                            y = x + (10 * x) - (7 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
