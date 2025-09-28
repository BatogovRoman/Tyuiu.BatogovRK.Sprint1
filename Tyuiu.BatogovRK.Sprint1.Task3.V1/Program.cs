using Tyuiu.BatogovRK.Sprint1.Task3.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Батогов Р. К. | АСОиУб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант 1                                                               *");
        Console.WriteLine("* Выполнил: Батогов Роман Константинович | АСОиУб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("***************************************************************************");

        double r = 5;
        double h = 14;
        Console.WriteLine("Радиус цилиндра равна " + r);
        Console.WriteLine("Высота цилиндра равна " + h);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Объем цилиндра равен " + ds.CylinderVolume(r,h));
        Console.ReadLine();
    }
}