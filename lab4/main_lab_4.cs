/*Вариант №5
Оп еделить количество нулевых элементов в заданном одномерном массиве целых чисел.*/

using System;

class Program {
    static void Main(string[] args) {
        int[] arr = { 1, 0, 5, 0, 0, -2, 0 };
        int count = 0;
        for (int i = 0; i < arr.Length; i++) 
            if (arr[i] == 0) {
                count++;
            }
        }

        Console.WriteLine("Количество нулевых элементов в массиве: " + count);
    }
}
