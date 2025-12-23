using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task1.V4.Lib
{
    public class DataService: ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            int i = startValue;
            double s = 0;
            while (i <= stopValue)
            {
                s += Math.Pow((1.0 / i), 2);
                i++;
            }
            return Math.Round(s, 3);
        }
    }
}