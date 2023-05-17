/*Вариант №5
1. В текст вставить символ «пробел» после каждого уже имеющегося в нём символа 
«пробел». В качестве текста для тестового примера (тестовых примеров) взять не менее 
двух предложений. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();

            string modifiedText = InsertSpaceAfterSpace(input);
            Console.WriteLine("Результат:");
            Console.WriteLine(modifiedText);

            Console.ReadLine();
        }

        static string InsertSpaceAfterSpace(string text)
        {
            string modifiedText = "";

            for (int i = 0; i < text.Length; i++)
            {
                modifiedText += text[i];

                if (text[i] == ' ')
                    modifiedText += ' ';
            }

            return modifiedText;
        }
    }
}
