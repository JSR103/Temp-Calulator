using System;
using System.Collections.Generic;
using System.Text;

namespace tempCAL
{
    public static class TemCal
    {
        


        public static double ifColdWeather(double T, double V)//V is Wind Speed
        {
            double results = 35.74 + (0.6215 * (T)) - 35.74 * (Math.Pow(V, 0.16)) + (0.4275 * (T) * (Math.Pow(V, 0.16)));
            return results;
        }

        public static double ifHotWeather(double T, double R)//R is Humidity
        {
            double results = -42.379 + (2.04901523 * (T)) +
                (10.14333127 * (R)) - (0.22475541 * (T) * (R)) -
                (6.83783 * (Math.Pow(10, -3)) * (Math.Pow(T, 2))) -
                (5.481717 * (Math.Pow(10, -2)) * (Math.Pow(R, 2))) +
                (1.22874 * (Math.Pow(10, -3)) * (Math.Pow(T, 2)) * (R)) +
                (8.5282 * (Math.Pow(10, -4)) * (T) * (Math.Pow(R, 2))) -
                (1.99 * (Math.Pow(10, -6)) * (Math.Pow(T, 2)) * (Math.Pow(R, 2)));
            return results;
        }
    }
}
