/*Вариант 5
Вводится кириллический символ. Ответ на него даётся лишь в том случае, если ему на 
клавиатуре соответствует операция или знак препинания. Указать название операции или 
знака препинания. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите кириллический символ:");
            string input = Console.ReadLine();

            string output = GetCharacterInfo(input);
            Console.WriteLine(output);

            Console.ReadLine();
        }
        static string GetCharacterInfo(string input)
        {
            switch (input)
            {
                case "А":
                    return "А - Заглавная буква 'A'";
                case "а":
                    return "а - Строчная буква 'a'";
                case "Б":
                    return "Б - Заглавная буква 'B'";
                case "б":
                    return "б - Строчная буква 'b'";
                case "В":
                    return "В - Заглавная буква 'V'";
                case "в":
                    return "в - Строчная буква 'v'";
                case "!":
                    return "! - Восклицательный знак";
                case "?":
                    return "? - Вопросительный знак";
                case ",":
                    return ", - Запятая";
                case ".":
                    return ". - Точка";
                default:
                    return "Символ не соответствует операции или знаку пунктуации.";
            }
        }

    }
}