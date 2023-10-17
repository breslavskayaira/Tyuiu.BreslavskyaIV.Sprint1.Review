using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BreslavskyaIV.Sprint1.TaskReview.V18.Lib;

namespace Tyuiu.BreslavskyaIV.Sprint1.TaskReview.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: SprintReview                                                       *");
            Console.WriteLine("* Задание TaskReview                                                       *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране                  *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Double x, y;
            Console.WriteLine("Введите значение Х: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Значение выражения =  " + ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
