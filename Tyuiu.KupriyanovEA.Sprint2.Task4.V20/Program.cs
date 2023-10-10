using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KupriyanovEA.Sprint2.Task4.V20.Lib;

namespace Tyuiu.KupriyanovEA.Sprint2.Task4.V20
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Куприянов Евгений Александрович | АСОиУб-23-2                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значения   *");
            Console.WriteLine("* переменных x,y с клавиатуры.                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;
            double y;

            Console.WriteLine("Введите значение переменной X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
