using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task3.V18.Lib
{
    public class DataService: ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char c in value)
            {
                char[] nums = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
                if (nums.Contains(c)) value = value.Replace(c, 'n');
            }
            return value;
        }
    }
}
