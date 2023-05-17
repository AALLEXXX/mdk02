/*Вариант №5
Вывести трёхмерный массив целых чисел (со значениями из диапазона от 1 до 9 включительно) по 
спирали. Последний элемент расположить в центре окна консоли, остальные «раскручивать» 
вокруг него по часовой стрелке. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract4
{
    internal class Program
    {
        static void Main()
        {
            int[,] spiralArray = GenerateSpiralArray(3, 3, 1, 9);
            PrintArrayInSpiral(spiralArray);

            Console.ReadLine();
        }

        // Генерация трехмерного массива в виде спирали
        static int[,] GenerateSpiralArray(int rows, int columns, int minValue, int maxValue)
        {
            int[,] array = new int[rows, columns];
            int value = minValue;
            int rowStart = 0, rowEnd = rows - 1;
            int colStart = 0, colEnd = columns - 1;

            while (value <= maxValue)
            {
                // Верхняя горизонтальная строка
                for (int col = colStart; col <= colEnd; col++)
                    array[rowStart, col] = value++;

                // Правый вертикальный столбец
                for (int row = rowStart + 1; row <= rowEnd; row++)
                    array[row, colEnd] = value++;

                // Проверка, существуют ли нижняя горизонтальная строка и левый вертикальный столбец
                if (rowStart < rowEnd && colStart < colEnd)
                {
                    // Нижняя горизонтальная строка
                    for (int col = colEnd - 1; col > colStart; col--)
                        array[rowEnd, col] = value++;

                    // Левый вертикальный столбец
                    for (int row = rowEnd; row > rowStart; row--)
                        array[row, colStart] = value++;
                }

                rowStart++;
                rowEnd--;
                colStart++;
                colEnd--;
            }

            return array;
        }

        // Вывод трехмерного массива в виде спирали
        static void PrintArrayInSpiral(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write($"{array[row, col],-2} ");
                }
                Console.WriteLine();
            }
        }

    }

}
