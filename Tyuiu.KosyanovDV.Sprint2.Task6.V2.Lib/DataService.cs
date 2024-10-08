using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KosyanovDV.Sprint2.Task6.V2.Lib
{
    public class DataService : ISprint2Task6V2
    {
        public string FindMonthSeason(int value)
        {
            return value switch
            {
                12 => "Зима",
                1 => "Зима",
                2 => "Зима",
                3 => "Весна",
                4 => "Весна",
                5 => "Весна",
                6 => "Лето",
                7 => "Лето",
                8 => "Лето",
                9 => "Осень",
                10 => "Осень",
                11 => "Осень",
                _ => throw new ArgumentException("Такого месяца не существет. Пожалуйста, введите целое, положительное число от 1 до 12 включительно")
            };
        } 
    }
}