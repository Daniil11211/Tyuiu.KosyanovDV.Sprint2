using Tyuiu.KosyanovDV.Sprint2.Task2.V6.Lib;

namespace Tyuiu.KosyanovDV.Sprint2.Task2.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Косьянов Д. В. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if                                                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Косьянов Даниил Васильевич | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами                           *");
            Console.WriteLine("* X,Y в заштрихованной области.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("* Введите значение x: ");

            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("* Введите значение y: ");

            y = Convert.ToInt32(Console.ReadLine());
            
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

                if (res == false)
                {
                    Console.WriteLine($"* {res}                                                                   *");
                }

                else
                {
                    Console.WriteLine($"* {res}                                                                    *");
                }
            
            Console.WriteLine("***************************************************************************");



            Console.ReadLine();
        }
    }
}