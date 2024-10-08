using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KosyanovDV.Sprint2.Task6.V2.Lib
{
    public class DataService : ISprint2Task6V2
    {
        public string FindMonthSeason(int value)
        {
            return value switch
            {
                12 => "зима",
                1 => "зима",
                2 => "зима",
                3 => "весна",
                4 => "весна",
                5 => "весна",
                6 => "лето",
                7 => "лето",
                8 => "лето",
                9 => "осень",
                10 => "осень",
                11 => "осень",
                _ => throw new ArgumentException("такого месяца не существет. Пожалуйста, введите целое, положительное число от 1 до 12 включительно")
            };
        } 
    }
}