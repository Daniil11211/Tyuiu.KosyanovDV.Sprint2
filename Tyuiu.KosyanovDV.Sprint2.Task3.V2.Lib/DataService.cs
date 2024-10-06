using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KosyanovDV.Sprint2.Task3.V2.Lib
{
    public class DataService : ISprint2Task3V2
    {
        public double Calculate (double x)
        {

            bool condition1 = x > -6;
            bool condition2 = x < 1;

            if (x > 3)
            {
                return Math.Round((x - 12 * x + Math.Cos(x)),3);
            }
            if (x == 2)
            {
                return Math.Round((x - (1 / x)), 3);
            }
            if (condition1&condition2)
            {
                return Math.Round((Math.Pow(x, 5) + 10 * x - Math.Sqrt(1 / (x + 3))), 3);
            }
            if (x < -6)
            {
                return Math.Round((x + 10 * x - (1 / Math.Pow(x, 4))), 3);
            }

            return 0;
        }
    }
}
