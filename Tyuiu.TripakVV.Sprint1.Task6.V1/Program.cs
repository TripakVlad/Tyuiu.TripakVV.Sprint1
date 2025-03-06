using Tyuiu.TripakVV.Sprint1.Task6.V4.Lib;


namespace Tyuiu.TripakVV.Sprint1.Task6.V4
{
    class Programm
    {
        static void Main(String[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Трипак В. В. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Трипак Владислав Валентинович | ИСТНб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу,которая выводит код введенного пользователем символа *");
            Console.WriteLine("* Программа должна завершать работу в результате ввода, например, точки.  *");
            Console.WriteLine("* Рекомендуемый вид экрана во время выполнения программы приведен ниже.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            while (true)
            {
                Console.WriteLine("Введите символ и нажмите <Enter>. Для завершения введите точку.");
                Console.Write("-> ");
                string input = Console.ReadLine();

                if (input == ".")
                    break;

                if (!string.IsNullOrEmpty(input))
                {
                    char symbol = input[0];
                    string code = ((int)symbol).ToString(); 
                    Console.WriteLine($"Символ: {symbol} Код: {code}");
                }
            }
        }
    }
}
