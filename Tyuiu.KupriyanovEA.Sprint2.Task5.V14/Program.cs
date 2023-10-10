using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KupriyanovEA.Sprint2.Task5.V14.Lib;

namespace Tyuiu.KupriyanovEA.Sprint2.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Куприянов Е. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Куприянов Евгений Александрович | АСОиУб-23-2                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат. Дано целое число k           *");
            Console.WriteLine("* (1 <= k <= 365). Определить, каким днем недели (понедельником,          *");
            Console.WriteLine("* вторником, …, субботой или воскресеньем) является k-й день не           *");
            Console.WriteLine("* високосного года, в котором 1 января d-й день недели (если 1 января     *");
            Console.WriteLine("* — понедельник, то d = 1 , если вторник — d = 2 , …, если воскресенье —  *");
            Console.WriteLine("* d = 7).                                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string res;

            int k;
            int d;

            Console.WriteLine("Введите значение переменной K: ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной D: ");
            d = Convert.ToInt32(Console.ReadLine());

            if (((k < 1) || (k > 365)) || ((d < 1) || (d > 7)))
            {
                res = "Введены неверные значения";
            }
            else
            {
                res = "День недели: " + ds.FindDayName(k, d);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
