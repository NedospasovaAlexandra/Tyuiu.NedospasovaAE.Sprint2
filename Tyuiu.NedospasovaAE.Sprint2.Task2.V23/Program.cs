using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NedospasovaAE.Sprint2.Task2.V23.Lib;

namespace Tyuiu.NedospasovaAE.Sprint2.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Недоспасова.А.Э | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Недоспасова Александра Эдуардовна | ИИПб-23-2                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Тема: Написать программу, которая запрашивает целые значения с          *");
            Console.WriteLine("* клавиатуры  и вычисляет находится ли точка с координатами X,Y в         *");
            Console.WriteLine("* заштрихованной области                                                  *");
            Console.WriteLine("* _______________                                                         *");
            Console.WriteLine("* _______________                                                         *");
            Console.WriteLine("* __+++___++++___                                                         *");
            Console.WriteLine("* __+++___++++___                                                         *");
            Console.WriteLine("* __++++++++++___                                                         *");
            Console.WriteLine("* ______+++++++__                                                         *");
            Console.WriteLine("* ______+++++++__                                                         *");
            Console.WriteLine("* ______+++++++__                                                         *");
            Console.WriteLine("* _____+++++++___                                                         *");
            Console.WriteLine("* _____+++++++___                                                         *");
            Console.WriteLine("* __+++++++++++__                                                         *");
            Console.WriteLine("* _______++++_++_                                                         *");
            Console.WriteLine("* _______________                                                         *");
            Console.WriteLine("* _______________                                                         *");
            Console.WriteLine("* _______________                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x, y;
            Console.WriteLine("Введите значение переменной x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.CheckDotInShadedArea(x, y);
            if (res)
                Console.WriteLine("Точка находится в заштрихованной области");
            else
                Console.WriteLine("Точка не находится в заштрихованной области");
            Console.ReadKey();
        }
    }
}
