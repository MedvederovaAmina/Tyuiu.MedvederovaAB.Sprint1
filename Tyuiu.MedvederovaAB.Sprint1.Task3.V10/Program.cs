using System.Globalization;
using Tyuiu.MedvederovaAB.Sprint1.Task3.V10.Lib;

namespace Tyuiu.MedvederovaAB.Sprint1.Task3.V10;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнила: Медведерова А. Б. | ПКT6-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКTб-24-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
       
        Console.Write(" number = ");
       
        double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
       
        string res =  ds.NumberToMoney(number);
        Console.WriteLine(res);

        Console.ReadKey();
    }
}
