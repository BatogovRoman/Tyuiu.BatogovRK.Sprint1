﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BatogovRK.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            double res = Math.Floor(f / 30);
            return Convert.ToInt32(res);
        }
    }
}
