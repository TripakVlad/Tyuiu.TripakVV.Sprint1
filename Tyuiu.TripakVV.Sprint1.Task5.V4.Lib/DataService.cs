using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TripakVV.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            return Convert.ToInt32(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }
    }
}
