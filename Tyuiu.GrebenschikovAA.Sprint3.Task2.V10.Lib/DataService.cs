using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task2.V10.Lib
{
    public class DataService: ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            int i = startValue;
            do
            {
                p *= Math.Pow(value, i) + 1 / (i + 1);
                i++;
            } while (i <= stopValue);
            return Math.Round(p, 3);
        }
    }
}
