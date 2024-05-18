using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NedospasovaAE.Sprint2.Task5.V12.Lib;

namespace Tyuiu.NedospasovaAE.Sprint2.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Недоспасова.А.Э | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Недоспасова Александра Эдуардовна | ИИПб-23-2                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат. Необходимо определить        *");
            Console.WriteLine("* дату предыдущего дня от дня, заданного пользователем                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = Convert.ToString(ds.FindDateOfPreviousDay(g, m, n));
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
