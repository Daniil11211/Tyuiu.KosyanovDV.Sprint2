using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KosyanovDV.Sprint2.Task1.V14.Lib
{
    public class DataService : ISprint2Task1V14
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (a + 256 < c);
            res[1] = (d == 701 + b) & (b >= a);
            res[2] = (d != c) || (a + 678 == b);
            res[3] = (b>=a)&&(a<=d);
            res[4] = !res[0];
            res[5] = (a>=d)^(c==d);

            return res;
        }
    }
}
