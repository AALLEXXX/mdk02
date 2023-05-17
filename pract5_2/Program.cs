/* Дано предложение. Напечатать все слова, отличные от слова «Привет».*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5_2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            Console.WriteLine("Результат:");

            foreach (string word in words)
            {
                if (word.ToLower() != "hello")
                {
                    Console.WriteLine(word);
                }
            }

            Console.ReadLine();
        }
    }
}
