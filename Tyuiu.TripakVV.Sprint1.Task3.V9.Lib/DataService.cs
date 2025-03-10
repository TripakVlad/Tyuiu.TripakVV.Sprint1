﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TripakVV.Sprint1.Task3.V9.Lib
{
    public class DataService : ISprint1Task3V9
    {
        public double TriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return Math.Round((Math.Abs(((x2 - x1) * (y3 - y1)) - ((x3 - x1)* (y2 - y1))) / 2), 3);
        }
    }
}
