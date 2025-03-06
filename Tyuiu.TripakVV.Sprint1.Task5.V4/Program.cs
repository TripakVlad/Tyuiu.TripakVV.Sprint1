using Tyuiu.TripakVV.Sprint1.Task5.V5.Lib;

namespace Tyuiu.TripakVV.Sprint1.Task5.V5
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Трипак Владислав Валентинович | ИСТНб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение X2:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Растояние между точками: " + ds.DistanceBetweenDots(x1, y1, x2, y2));

            Console.ReadLine();

        }
    }
}

