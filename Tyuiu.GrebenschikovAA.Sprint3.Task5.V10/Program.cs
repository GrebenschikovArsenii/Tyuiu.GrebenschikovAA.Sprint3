using Tyuiu.GrebenschikovAA.Sprint3.Task5.V10.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 2, start1 = 1, end1 = 3, start2 = 1, end2 = 10;
            Console.Title = "Спринт #3 | Выполнил: Гребенщиков А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Гребенщиков Арсений | ИБКСб-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 2, 1 <= i <= 3, 1 <= k <= 10                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Сумма сумм ряда равна " + ds.GetSumSumSeries(x, start1, start2, end1, end2));
            Console.ReadLine();
        }
    }
}
