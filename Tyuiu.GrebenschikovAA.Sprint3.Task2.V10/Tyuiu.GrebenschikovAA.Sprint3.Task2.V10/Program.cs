using Tyuiu.GrebenschikovAA.Sprint3.Task2.V10.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task2.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x = 0.25;
            int startValue = 1, endValue = 11;
            Console.Title = "Спринт #3 | Выполнил: Гребенщиков А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Гребенщиков Арсений | ИБКСб-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл d0-while                              *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 0,25, 1 <= i <= 11                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Произвездение равно " + ds.GetMultiplySeries(x, startValue, endValue));
            Console.ReadLine();
        }
    }
}
