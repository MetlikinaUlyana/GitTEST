using System;

namespace MetanitStrings
{
    class ItProger
    {
        static void Main()
          {
              // Console.Write("Hello, world\n"); // \n создает отступ в одну строку после текста
              // Console.Write("Hello 2\n");
              // Console.Write("Hello 3\n");
              // // Console.ReadKey(); - метод повзоляет пользователю ввести 1 символ
              // Console.ReadLine(); // метод позволяет ввести строку
              
              // //1. Целочисленные типы данных
              // int number = -10; // диапазон от 2 млрд до -2 млрд
              // uint numberPlus = 20; // может хранить только положительные целые числа
              // byte bytes = 255; /* не можем хранить значение больше 255. Потребляем в 4 раза 
              // меньше операционной памяти для хранения числа по сравнению с in*/
              // short numberShort = 32500; // потребляет в 2 раза меньше памяти, чем int
              // long numberLong = 9000000000000; // супер длинные числа (жрет памяти больше чем int)
              //
              // //2. Числа с точкой
              // float digit1 = 12.3423423f;
              // double digit2 = 5.45645d;
              //
              // //3. Строки и символы
              // string name = "Переменная: ";
              // char symbol = 's';
              // Console.WriteLine($"{name}{number}.");
              //
              // //4. Логический тип данных
              // bool isHappy = true; //либо true, либо false - используются обычно в условных предложениях
              //
              //Practice
              int num_1 = 1, num_2 = 2;
              num_1 = Convert.ToInt32(Console.ReadLine());
              num_2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine($"Print {num_1} and {num_2}");
              



          }
        
    }

    public class Experiment
    {
        static void Example1()
        {
               
        }
    }
}