using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task0.V20.Lib
{
    public class DataService: ISprint3Task0V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                p *= (Math.Cos(value) + Math.Pow(k/8, 3));
            }
            return Math.Round(p, 3);
        }
    }
}