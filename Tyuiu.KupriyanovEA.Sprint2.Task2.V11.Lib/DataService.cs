using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KupriyanovEA.Sprint2.Task2.V11.Lib
{
    public class DataService : ISprint2Task2V11
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            bool v1 = ((((x >= 3) && (x <= 5)) || (x == 9)) && ((y >= 3) && (y <= 4)));
            bool v2 = ((((x >= 6) && (x <= 9)) || ((x >= 11) && (x <= 12))) && ((y >= 5) && (y <= 6)));
            bool v3 = ((((x >= 2) && (x <= 9)) || ((x >= 11) && (x <= 12))) && (y == 7));
            bool v4 = ((x >= 6) && (x <= 13) && (y == 8));
            bool v5 = ((x >= 6) && (x <= 12) && (y >= 9) && (y <= 10));
            bool v6 = ((((x >= 3) && (x <= 7)) || ((x >= 11) && (x <= 12))) && (y == 11));
            bool v7 = ((x == 7) && (y == 12));

            if (v1 || v2 || v3 || v4 || v5 || v6 || v7)
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
