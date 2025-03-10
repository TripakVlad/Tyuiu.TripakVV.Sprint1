﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TripakVV.Sprint1.Task7.V15.Lib
{
    public class DataService : ISprint1Task7V15
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(((2 + Math.Pow(Math.Cos(x + y), 2)) / (1 + Math.Abs(x - ((3 * x) / (1 + x * x * y * y)))) + x * y), 3);
        }
    }
}