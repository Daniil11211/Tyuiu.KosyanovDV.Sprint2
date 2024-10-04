using System.ComponentModel.Design;
using Tyuiu.KosyanovDV.Sprint2.Task0.V3.Lib;

namespace Tyuiu.KosyanovDV.Sprint2.Task0.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Косьянов Д. В. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Косьянов Даниил Васильевич | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)*");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность*");
            Console.WriteLine("* (массив): (False, True, False, True, False, True), при x = 45, y = 127  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 45;
            int y = 127;

            Console.WriteLine($"X = {x}                                                                    *");
            Console.WriteLine($"Y = {y}                                                                   *");

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 5; i++)
            {
                
                if (res[i] == false) 
                {
                    Console.WriteLine($"* {res[i]}                                                                   *");
                }
                        
                else
                {
                    Console.WriteLine($"* {res[i]}                                                                    *");
                }
            }
            Console.WriteLine("***************************************************************************");



            Console.ReadLine();
        }
    }
}