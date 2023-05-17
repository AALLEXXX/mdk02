/* Даны три пары чисел определяющие положения точек на  координатной плоскости. Проверить, лежат ли эти точки на одной прямой? */

using System;


public class Program
{
    public static void Main()
    {
        // Задаем координаты трех точек
        int x1 = 1;
        int y1 = 2;

        int x2 = 3;
        int y2 = 4;

        int x3 = 5;
        int y3 = 6;

        // Вычисляем коэффициенты прямых, проходящих через каждую пару точек
        double k1 = (double)(y2 - y1) / (x2 - x1);
        double b1 = y1 - k1 * x1;

        double k2 = (double)(y3 - y2) / (x3 - x2);
        double b2 = y2 - k2 * x2;

        // Проверяем, лежат ли все три точки на одной прямой
        if (Math.Abs(k1 - k2) < 0.00001 && Math.Abs(b1 - b2) < 0.00001)
        {
            Console.WriteLine("Все три точки лежат на одной прямой.");
        }
        else
        {
            Console.WriteLine("Точки не лежат на одной прямой.");
        }
    }
}

