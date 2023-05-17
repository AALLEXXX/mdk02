using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;
            string formula;
            double ieeeRemainder, remainder;

            (number1, number2) = (3, 2);
            formula = $"{number1} / {number2} = ";
            ieeeRemainder = Math.IEEERemainder(number1, number2);
            remainder = number1 % number2;
            Console.WriteLine($"{formula,-16} {ieeeRemainder,18} {remainder,20}");

            (number1, number2) = (4, 2);
            formula = $"{number1} / {number2} = ";
            ieeeRemainder = Math.IEEERemainder(number1, number2);
            remainder = number1 % number2;
            Console.WriteLine($"{formula,-16} {ieeeRemainder,18} {remainder,20}");

            (number1, number2) = (10, 3);
            formula = $"{number1} / {number2} = ";
            ieeeRemainder = Math.IEEERemainder(number1, number2);
            remainder = number1 % number2;
            Console.WriteLine($"{formula,-16} {ieeeRemainder,18} {remainder,20}");

            (number1, number2) = (11, 3);
            formula = $"{number1} / {number2} = ";
            ieeeRemainder = Math.IEEERemainder(number1, number2);
            remainder = number1 % number2;
            Console.WriteLine($"{formula,-16} {ieeeRemainder,18} {remainder,20}");

            (number1, number2) = (27, 4);
            formula = $"{number1} / {number2} = ";
            ieeeRemainder = Math.IEEERemainder(number1, number2);
            remainder = number1 % number2;
            Console.WriteLine($"{formula,-16} {ieeeRemainder,18} {remainder,20}");

            (number1, number2) = (28, 5);
            formula = $"{number1} / {number2} = ";
            ieeeRemainder = Math.IEEERemainder(number1, number2);
            remainder = number1 % number2;
            Console.WriteLine($"{formula,-16} {ieeeRemainder,18} {remainder,20}");

            (number1, number2) = (17.8, 4);
            formula = $"{number1} / {number2} = ";
            ieeeRemainder = Math.IEEERemainder(number1, number2);
            remainder = number1 % number2;
            Console.WriteLine($"{formula,-16} {ieeeRemainder,18} {remainder,20}");

            (number1, number2) = (17.8, 4.1);
            formula = $"{number1} / {number2} = ";
            ieeeRemainder = Math.IEEERemainder(number1, number2);
            remainder = number1 % number2;
            Console.WriteLine($"{formula,-16} {ieeeRemainder,18} {remainder,20}");


        }
    }
}
