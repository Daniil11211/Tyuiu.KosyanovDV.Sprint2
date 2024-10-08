using Tyuiu.KosyanovDV.Sprint2.Task4.V28.Lib;

namespace Tyuiu.KosyanovDV.Sprint2.Task4.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Косьянов Д. В. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Косьянов Даниил Васильевич | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение при помощи     *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значения переменных X, Y  *");
            Console.WriteLine("* с клавиатуры.                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("* условие: x < y * 2 - 10                                                 *");


            Console.WriteLine("* Введите значение X: ");

            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("* Введите значение Y: ");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (x < y + 2)
            {
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("*            y + 2    x                                                   *");
                Console.WriteLine($"* z = ( 1 + ------- )    = {ds.Calculate(x,y)}                            ");
                Console.WriteLine("*               2                                                         *");
                Console.WriteLine("*              x                                                          *");
                Console.WriteLine("***************************************************************************");
            }

            else
            {
                Console.WriteLine("*         2        2                                                      *");
                Console.WriteLine("*      2*x - cos(y) + 12                                                  *");
                Console.WriteLine($"* z = ------------------ = {ds.Calculate(x, y)}                           ");
                Console.WriteLine("*       2       2                                                         *");
                Console.WriteLine("*      y  - sinx  + 9                                                     *");
                Console.WriteLine("***************************************************************************");
            }
        }
    }
}