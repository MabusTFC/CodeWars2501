/*Напишите функцию, которая принимает массив из 10 целых чисел (от 0 до 9), которая возвращает строку этих чисел в виде номера телефона.*/

using Microsoft.VisualBasic;
using System;

namespace word2501
{
    class Program
    {
        public static void Main()
        {
            
            string[] nomer = new string[10];
            Console.WriteLine("Введите цифры подряд:");
            for (int i = 0; i < nomer.Length; i++)
            {
                nomer[i] =Console.ReadLine();
            }
            string str = String.Join("", nomer);

            Console.WriteLine("Ваш номер телефона:",str);

        }

        

    }
}