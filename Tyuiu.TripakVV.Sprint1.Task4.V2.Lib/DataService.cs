using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TripakVV.Sprint1.Task4.V2.Lib
{
    public class DataService : ISprint1Task4V2
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((x + y) / Math.Abs(x - 2), 3);
        }
    }
}
