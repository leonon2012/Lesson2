using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result of task26 is -> " + Task28(2, 1, 1, 1, 1, 1, 1, 1).ToString());
        }

        private static object Task28(double x, double y, double z, double a, double b, double c, double d, double f)
        {
            double resultSin, resultDrob;

            // Получаем значение синуса
            resultSin = Math.Sin(x);
            // Получаем значение знаменателя дроби
            resultDrob = d * x * x * x - f;

            // Если синус или знаменатель 0 - исключительная ситуация
            if (resultSin == 0.0 || resultDrob == 0.0)
            {
                return "Недопустимые значения параметров - деление на ноль!";
            }
            else
            {
                return (double)((Math.Cos(x) * Math.Cos(x)) / resultSin - x * y * z + (a * x * x + b * x + c) / resultDrob);
            }
        }
    }
}
