using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MiliukovLO.Sprint0.Task7.V0.Lib;

namespace Tyuiu.MiliukovLO.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Милюков Л. О. | ИИПб 24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                                ");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                              ");
            Console.WriteLine("* Задание #7                                                               ");
            Console.WriteLine("* Вариант #0                                                               ");
            Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух     ");
            Console.WriteLine("* одинаковых массивов по длинне.                                           ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            int[] arrayNumbs1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrayNumbs1.Length; i++)
            {
                Console.WriteLine(arrayNumbs1[i]);
            }
            Console.WriteLine();
            int[] arrayNumbs2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0;i < arrayNumbs2.Length; i++)
            {
                Console.WriteLine(arrayNumbs2[i]);
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            if (arrayNumbs1.Length == arrayNumbs2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNumbs1, arrayNumbs2);
                Console.WriteLine("Сумма элементов массива равна: ");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i]+", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }
            Console.ReadKey();
        }
    }
}