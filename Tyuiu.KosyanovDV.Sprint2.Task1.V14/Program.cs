using Tyuiu.KosyanovDV.Sprint2.Task1.V14.Lib;

namespace Tyuiu.KosyanovDV.Sprint2.Task1.V14
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Косьянов Даниил Васильевич | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций можно чередовать,    *");
            Console.WriteLine("* но использовать один раз в выражении) и логических операций             *");
            Console.WriteLine("* (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)  *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую             *");
            Console.WriteLine("* последовательность (массив): (False, True, True, True, True, False)     *");
            Console.WriteLine("* при a = 185, b = 216, c = 174, d = 917                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 185;
            int b = 216;
            int c = 174;
            int d = 917;

            Console.WriteLine($"* a = {a}                                                                 *");
            Console.WriteLine($"* b = {b}                                                                 *");
            Console.WriteLine($"* c = {c}                                                                 *");
            Console.WriteLine($"* d = {d}                                                                 *");



            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
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
