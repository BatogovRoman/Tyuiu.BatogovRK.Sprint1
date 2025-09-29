using Tyuiu.BatogovRK.Sprint1.Task6.V15.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Батогов Р. К. | АСОиУб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант 15                                                              *");
        Console.WriteLine("* Выполнил: Батогов Роман Константинович | АСОиУб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
        Console.WriteLine("* Проверить, что в строке больше букв, чем знаков.                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");

        if (ds.CheckLettersCount(str) == true)
        {
            Console.WriteLine("В строке больше букв, чем знаков");
        }
        else
        {
            Console.WriteLine("В строке меньше букв, чем знаков");
        }
        Console.ReadKey();
    }
}