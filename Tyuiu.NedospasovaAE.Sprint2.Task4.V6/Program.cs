using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NedospasovaAE.Sprint2.Task4.V6.Lib;

namespace Tyuiu.NedospasovaAE.Sprint2.Task4.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт # | Выполнила: Недоспасова.А.Э | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Недоспасова Александра Эдуардовна | ИИПб-23-2                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу которая вычисляет значение с использованием          *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значения x,y              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x, y;
            Console.WriteLine("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.Calculate(x, y);
            Console.WriteLine(Math.Round(res, 3));

            Console.ReadKey();
        }
    }
}
