using Tyuiu.BatogovRK.Sprint1.Task5.V7.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Батогов Р. К. | АСОиУб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант 7                                                               *");
        Console.WriteLine("* Выполнил: Батогов Роман Константинович | АСОиУб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
        Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до     *");
        Console.WriteLine("* того момента (в первой половине дня), когда часовая стрелка повернулась *");
        Console.WriteLine("* на f градусов (0<f<360, f – вещественное число).                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("***************************************************************************");

        double f;
        Console.WriteLine("Введите значение угла наклона стрелки:");
        f = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"При угле {f} градусов прошло " + ds.AngleToHoursMinutes(f));
        Console.ReadKey();
    }
}