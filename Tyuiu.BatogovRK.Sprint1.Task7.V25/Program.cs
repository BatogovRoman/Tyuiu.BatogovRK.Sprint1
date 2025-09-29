using Tyuiu.BatogovRK.Sprint1.Task7.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Батогов Р. К. | АСОиУб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант 25                                                              *");
        Console.WriteLine("* Выполнил: Батогов Роман Константинович | АСОиУб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*             (y^2 + 6 + cos(x^3) + x * y - 2 * x^2)                      *");
        Console.WriteLine("* z = e^x - ------------------------------------------                    *");
        Console.WriteLine("*                   (sin(x^4 + 13) + 9 * y - 2)                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        double x, y;
        Console.WriteLine("Введите значение X:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(x,y));
        Console.ReadKey();

        
    }
}