using Tyuiu.GrebenschikovAA.Sprint3.Task1.V4.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task1.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 5, startValue = 1, endValue = 17;
            Console.Title = "Спринт #3 | Выполнил: Гребенщиков А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Гребенщиков Арсений | ИБКСб-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while                                 *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 5, 1 <= i <= 17                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Сумма ряда равна " + ds.GetSumSeries(x, startValue, endValue));
            Console.ReadLine();
        }
    }
}
