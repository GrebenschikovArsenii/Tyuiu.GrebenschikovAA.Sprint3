using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task7.V27.Lib
{
    public class DataService: ISprint3Task7V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[11];
            int index = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (0 == (i + 1)) result[index] = 0;
                else result[index] = Math.Round((Math.Cos(i) / (1 + i) - Math.Cos(i) * 1.3 + 3 * i), 2);
                index++;
            }
            return result;
        }
    }
}
